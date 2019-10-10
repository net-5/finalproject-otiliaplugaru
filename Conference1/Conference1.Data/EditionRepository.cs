using Conference1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference1.Data
{
    public interface IEditionsRepository
    {
        List<Editions> GetAllEditions();
        Editions AddEdition(Editions edition);
        Editions GetEditionById(int id);
        Editions Update(Editions editionToUpdate);
        void Delete(Editions editionToDelete);
    }

    public class EditionRepository : IEditionsRepository
    {
        private readonly ConferenceContext conferenceContext;

        public EditionRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }

        public Editions AddEdition(Editions edition)
        {
            var addedEdition = conferenceContext.Editions.Add(edition);
            conferenceContext.SaveChanges();
            return addedEdition.Entity;
        }

        public void Delete(Editions editionToDelete)
        {
            conferenceContext.Editions.Remove(editionToDelete);
            conferenceContext.SaveChanges();
        }

        public List<Editions> GetAllEditions()
        {
            return conferenceContext.Editions.ToList();
        }

        public Editions GetEditionById(int id)
        {
            return conferenceContext.Editions.Find(id);
        }

        public Editions Update(Editions editionToUpdate)
        {
            var updatedEdition = conferenceContext.Update(editionToUpdate);
            conferenceContext.SaveChanges();
            return updatedEdition.Entity;
        }
    }
}

