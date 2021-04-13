using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;

namespace CW2
{
    public class PayerOrPayeeModel
    {
        public void AddPayerOrPayee(CW2_SystemDB details)
        {
            PayerOrPayee payerOrPayee = new PayerOrPayee();
            foreach (var x in details.PayerOrPayees)
            {
                payerOrPayee.Name = x.Name;
                payerOrPayee.Mail = x.Mail;
                payerOrPayee.PhoneNumber = x.PhoneNumber;
                payerOrPayee.Address = x.Address;
                payerOrPayee.Type = x.Type;
                payerOrPayee.UserId = x.UserId;

            }
            CW2_SystemDBContainer db = new CW2_SystemDBContainer();
            db.PayerOrPayees.Add(payerOrPayee);
            db.SaveChanges();
        }   
        
        public List<PayerOrPayee> GetDetails(UserDetails info,string type)
        {
            
            List<PayerOrPayee> list = new List<PayerOrPayee>();
                CW2_SystemDBContainer db = new CW2_SystemDBContainer();
                list = db.PayerOrPayees
                 .Where(s => s.UserId == info.Id && s.Type==type).ToList();
    
                return list;
         
        }
        public List<PayerPayeeList> GetDetailsForTransaction(UserDetails info, string type)
        {
            List<PayerPayeeList> list = new List<PayerPayeeList>();
            CW2_SystemDBContainer db = new CW2_SystemDBContainer();
            var values = db.PayerOrPayees
             .Where(s => s.UserId == info.Id && s.Type == type)
             .Select(s=>new {Id=s.Id,
                            Name=s.Name}).ToList();

            foreach (var obj in values)
            {
                list.Add(new PayerPayeeList(){ Id=obj.Id,Name=obj.Name});
            }

            return list;

        }


        public void Update(CW2_SystemDB details)
        {
            CW2_SystemDBContainer db = new CW2_SystemDBContainer();
            foreach (var x in details.PayerOrPayees)
            {
                PayerOrPayee payerOrPayee = db.PayerOrPayees.Single(c => c.Id == x.Id);
                payerOrPayee.Name = x.Name;
                payerOrPayee.Mail = x.Mail;
                payerOrPayee.PhoneNumber = x.PhoneNumber;
                payerOrPayee.Address = x.Address;
                payerOrPayee.Type = x.Type;
                payerOrPayee.UserId = x.UserId;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            CW2_SystemDBContainer db = new CW2_SystemDBContainer();

                PayerOrPayee payerOrPayee = db.PayerOrPayees.Single(c => c.Id == id);
                db.PayerOrPayees.Remove(payerOrPayee);
                db.SaveChanges();

        }
    }
}
