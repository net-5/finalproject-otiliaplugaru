using Conference1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference1.Data
{
    public interface ISponsorsRepository
    {
        List<Sponsors> GetAllSponsors();
        Sponsors GetSponsorsById(int id);
        Sponsors AddSponsor(Sponsors sponsorToAdd);
        Sponsors UpdateSponsor(Sponsors sponsorToUpdate);
        void DeleteSponsor(Sponsors sponsorToDelete);
    }
    public class SponsorsRepository : ISponsorsRepository
    {
        private readonly ConferenceContext conferenceContext;

        public SponsorsRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }

        public Sponsors AddSponsor(Sponsors sponsorToAdd)
        {
            var addedSponsor = conferenceContext.Add(sponsorToAdd);
            conferenceContext.SaveChanges();
            return addedSponsor.Entity;
        }

        public void DeleteSponsor(Sponsors sponsorToDelete)
        {
            conferenceContext.Remove(sponsorToDelete);
            conferenceContext.SaveChanges();
        }

        public List<Sponsors> GetAllSponsors()
        {
            return conferenceContext.Sponsors.ToList();
        }

        public Sponsors GetSponsorsById(int id)
        {
            return conferenceContext.Sponsors.Find(id);
        }

        public Sponsors UpdateSponsor(Sponsors sponsorToUpdate)
        {
            var updatedSponsor = conferenceContext.Update(sponsorToUpdate);
            conferenceContext.SaveChanges();
            return updatedSponsor.Entity;
        }
    }
}