using Conference1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference1.Data
{
    public interface IWorkshopsRepository
    {
        List<Workshops> GetAllWorkshops();
        Workshops GetWorkShopById(int id);
        Workshops AddWorkShop(Workshops workshopToAdd);
        Workshops UpdateWorkshop(Workshops workshopToUpdate);
        void DeleteWorkshop(Workshops workshopToDelete);
    }
    public class WorkshopsRepository : IWorkshopsRepository
    {
        private readonly ConferenceContext conferenceContext;

        public WorkshopsRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }

        public Workshops AddWorkShop(Workshops workshopToAdd)
        {
            var addedWorkshop = conferenceContext.Add(workshopToAdd);
            conferenceContext.SaveChanges();
            return addedWorkshop.Entity;
        }

        public void DeleteWorkshop(Workshops workshopToDelete)
        {
            conferenceContext.Remove(workshopToDelete);
            conferenceContext.SaveChanges();
        }

        public List<Workshops> GetAllWorkshops()
        {
            return conferenceContext.Workshops.ToList();
        }

        public Workshops GetWorkShopById(int id)
        {
            Workshops workshop;
            workshop = conferenceContext.Workshops.Find(id);
            return workshop;
        }

        public Workshops UpdateWorkshop(Workshops workshopToUpdate)
        {
            var updatedWorkshop = conferenceContext.Update(workshopToUpdate);
            conferenceContext.SaveChanges();
            return updatedWorkshop.Entity;
        }
    }
}