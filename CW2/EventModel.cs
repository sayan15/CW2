using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2
{
    public class EventModel
    { 
        public void StoreEvent(CW2_SystemDB dataset)
        {
            Event eventDetails = new Event();
            foreach(var x in dataset.Events)
            {
                eventDetails.EventType = x.EventType;
                eventDetails.OccurenceType = x.OccurenceType;
                eventDetails.Date = x.Date;
                eventDetails.Description = x.Description;
                eventDetails.UserId = x.UserId;
            }
            CW2_SystemDBContainer db = new CW2_SystemDBContainer();
            db.Events.Add(eventDetails);
            db.SaveChanges();
        }
        public List<Event> GetDetails(UserDetails info, string type)
        {
            
            List<Event> list = new List<Event>();
            CW2_SystemDBContainer db = new CW2_SystemDBContainer();
            list = db.Events
             .Where(s => s.UserId == info.Id && s.EventType == type).ToList();

            return list;

        }

        public void UpdateEvent(CW2_SystemDB details)
        {
            CW2_SystemDBContainer db = new CW2_SystemDBContainer();
            foreach (var x in details.Events)
            {
                
                Event eve = db.Events.Single(c => c.Id == x.Id);
                eve.EventType = x.EventType;
                eve.OccurenceType = x.OccurenceType;
                eve.Date = x.Date;
                eve.Description = x.Description;
                db.SaveChanges();
            }
        }
        public void DeleteEVent(CW2_SystemDB details)
        {
            CW2_SystemDBContainer db = new CW2_SystemDBContainer();
            foreach (var x in details.Events)
            { 
                Event eve = db.Events.Single(c => c.Id == x.Id);
                db.Events.Remove(eve);
                db.SaveChanges();
            }
        }

        public List<Event> GetWeekDetails(UserDetails info, DateTime date)
        {
            DateTime addedDate = date.AddDays(7);
            List<Event> list = new List<Event>();
            CW2_SystemDBContainer db = new CW2_SystemDBContainer();
            list = db.Events
             .Where(s => s.UserId == info.Id 
             &&((s.OccurenceType=="Repeat" && (s.Date.Day>=date.Day && s.Date.Day<= addedDate.Day))
             || (s.Date.Day >= date.Day && s.Date.Day <= addedDate.Day))
             )
             .ToList();

            return list;

        }
    }

   
}
