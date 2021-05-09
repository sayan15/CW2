using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2
{
    public class TransactionModel
    {
        public void StoreTransaction(CW2_SystemDB dataset)
        {
            Transaction transaction = new Transaction();
            foreach (var x in dataset.Transactions)
            {
                transaction.TransactionType = x.TransactionType;
                transaction.OccurenceType = x.OccurenceType;
                transaction.Date = x.Date;
                transaction.Description = x.Description;
                transaction.Amount = x.Amount;
                transaction.PayerOrPayeeId = x.PayerOrPayeeId;
                transaction.UserId =x.UserId;
            }
            CW2_SystemDBContainer db = new CW2_SystemDBContainer();
            db.Transactions.Add(transaction);
            db.SaveChanges();
        }

        public List<Transaction> GetDetails(UserDetails info, DateTime from, DateTime to)
        {

            List<Transaction> list = new List<Transaction>();
            CW2_SystemDBContainer db = new CW2_SystemDBContainer();
            list = db.Transactions
             .Where(s => s.UserId == info.Id 
                    && ((((s.Date.Day >= from.Day && s.Date.Day <= to.Day)) && s.OccurenceType=="Repeat")
                    ||(s.Date>=from && s.Date<=to)))
                    .ToList();

            return list;

        }
        public List<Transaction> GetDailyTransaction(UserDetails info, DateTime date)
        {

            List<Transaction> list = new List<Transaction>();
            CW2_SystemDBContainer db = new CW2_SystemDBContainer();
            list = db.Transactions
             .Where(s => s.UserId == info.Id
                    &&(s.Date == date ))
                    .ToList();

            return list;

        }
        public double GetTotalIncome(UserDetails info, DateTime from, DateTime to)
        {
            CW2_SystemDBContainer db = new CW2_SystemDBContainer();
            double income=0;
            double repetetiveIncome;
            try
            {
                income = db.Transactions
                 .Where(s => s.UserId == info.Id && 
                             ((s.OccurenceType=="Repeat" && ((s.Date.Day >= from.Day && s.Date.Day <= to.Day)) && s.TransactionType == "Income")
                             || (s.Date >= from && s.Date <= to && s.TransactionType == "Income")))
                 .Select(s => s.Amount).Sum();

                //caluculate Repetetive expense
                int monthDiff = to.Month - from.Month;
                repetetiveIncome = db.Transactions
                         .Where(s => s.UserId == info.Id &&
                                     (s.OccurenceType == "Repeat" && ((s.Date.Day >= from.Day && s.Date.Day <= to.Day)) && s.TransactionType == "Income")
                                     )
                         .Select(s => s.Amount).Sum();
                if(monthDiff!=0)
                {
                    income = income + (repetetiveIncome * (monthDiff));
                }
                
            }
            catch
            {
                return income ;
            }
            
            return income;

        }
        public double GetTotalExpense(UserDetails info, DateTime from, DateTime to)
        {
            CW2_SystemDBContainer db = new CW2_SystemDBContainer();
            double expense=0;
            double repetetiveExpense;
            try
            {
                expense = db.Transactions
                 .Where(s => s.UserId == info.Id &&
                             ((s.OccurenceType == "Repeat" && ((s.Date.Day >= from.Day && s.Date.Day <= to.Day) ) && s.TransactionType == "Expense")
                             || (s.Date >= from && s.Date <= to && s.TransactionType == "Expense")))
                 .Select(s => s.Amount).Sum();
                //caluculate Repetetive expense
                int monthDiff = to.Month - from.Month;
                repetetiveExpense = db.Transactions
                         .Where(s => s.UserId == info.Id &&
                                     (s.OccurenceType == "Repeat" && ((s.Date.Day >= from.Day && s.Date.Day <= to.Day) ) && s.TransactionType == "Expense")
                                     )
                         .Select(s => s.Amount).Sum();
                if(monthDiff!=0)
                {
                    expense = expense + (repetetiveExpense * (monthDiff));
                }
                

            }
            catch
            {
                return expense;
            }

            return expense;

        }

        public void Update(CW2_SystemDB dataset)
        {
            
            CW2_SystemDBContainer db = new CW2_SystemDBContainer();
            foreach (var x in dataset.Transactions)
            {
                Transaction transaction = db.Transactions.Single(c => c.Id == x.Id);
                transaction.TransactionType = x.TransactionType;
                transaction.OccurenceType = x.OccurenceType;
                transaction.Date = x.Date;
                transaction.Description = x.Description;
                transaction.Amount = x.Amount;
                transaction.PayerOrPayeeId = x.PayerOrPayeeId;
                transaction.UserId = x.UserId;
                db.SaveChanges();
            }
            
            
        }
        public void Delete(int id)
        {
            CW2_SystemDBContainer db = new CW2_SystemDBContainer();
            Transaction transaction = db.Transactions.Single(c => c.Id == id);
            db.Transactions.Remove(transaction);
            db.SaveChanges();
         
        }

        public double GetDetailsForPrediction(UserDetails info, DateTime date)
        {

            List<Transaction> list = new List<Transaction>();
            CW2_SystemDBContainer db = new CW2_SystemDBContainer();
            list = db.Transactions
             .Where(s => s.UserId == info.Id
                    && (s.Date <= date))
                    .OrderBy(x=>x.Date)
                    .ToList();
            List<double> xValues = new List<double>();
            List<double> yValues = new List<double>();
            int count = 0;
            DateTime previousDate=date;
            double previousAmount=0;
            foreach (var rows in list)
            {   
                if(count==0)
                {
                    previousDate = rows.Date;
                    previousAmount = 0;
                }
                xValues.Add((rows.Date - previousDate).TotalDays);
                if(rows.TransactionType=="Income")
                {
                    yValues.Add(rows.Amount + previousAmount);
                    previousAmount = rows.Amount + previousAmount;
                }
                else
                {
                    yValues.Add(previousAmount- rows.Amount);
                    previousAmount = previousAmount - rows.Amount;
                }
                
                previousDate = rows.Date;
                
                count = +1;
                
            }
            double rSquared, intercept, slope;
            LinearRegression(xValues, yValues, out rSquared, out intercept, out slope);

            return (previousAmount-((slope * 20) + intercept));
        }

        /// <summary>
        /// Fits a line to a collection of (x,y) points.
        /// </summary>
        /// <param name="xVals">The x-axis values.</param>
        /// <param name="yVals">The y-axis values.</param>
        /// <param name="rSquared">The r^2 value of the line.</param>
        /// <param name="yIntercept">The y-intercept value of the line (i.e. y = ax + b, yIntercept is b).</param>
        /// <param name="slope">The slop of the line (i.e. y = ax + b, slope is a).</param>
        public static void LinearRegression(
            List<double> xVals,
            List<double> yVals,
            out double rSquared,
            out double yIntercept,
            out double slope)
        {
            if (xVals.Count != yVals.Count)
            {
                throw new Exception("Input values should be with the same length.");
            }

            double sumOfX = 0;
            double sumOfY = 0;
            double sumOfXSq = 0;
            double sumOfYSq = 0;
            double sumCodeviates = 0;

            for (var i = 0; i < xVals.Count; i++)
            {
                var x = xVals[i];
                var y = yVals[i];
                sumCodeviates += x * y;
                sumOfX += x;
                sumOfY += y;
                sumOfXSq += x * x;
                sumOfYSq += y * y;
            }

            var count = xVals.Count;
            var ssX = sumOfXSq - ((sumOfX * sumOfX) / count);
            var ssY = sumOfYSq - ((sumOfY * sumOfY) / count);

            var rNumerator = (count * sumCodeviates) - (sumOfX * sumOfY);
            var rDenom = (count * sumOfXSq - (sumOfX * sumOfX)) * (count * sumOfYSq - (sumOfY * sumOfY));
            var sCo = sumCodeviates - ((sumOfX * sumOfY) / count);

            var meanX = sumOfX / count;
            var meanY = sumOfY / count;
            var dblR = rNumerator / Math.Sqrt(rDenom);

            rSquared = dblR * dblR;
            yIntercept = meanY - ((sCo / ssX) * meanX);
            slope = sCo / ssX;
        }

    }
}
