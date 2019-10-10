using Conference1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference1.Data
{
    public interface ISponsorTypesRepository
    {
        List<SponsorTypes> GetAllSponsorTypes();
        SponsorTypes GetSponsorTypeById(int id);
        SponsorTypes AddSponsorTypes(SponsorTypes sponsorTypeToAdd);
        void DeleteSponsorTypes(SponsorTypes sponsorTypeToDelete);
        SponsorTypes UpdateSponsorTypes(SponsorTypes sponsorTypesToUpdate);
    }
    public class SponsorTypesRepository : ISponsorTypesRepository
    {
        private readonly ConferenceContext conferenceContext;

        public SponsorTypesRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }

        public SponsorTypes AddSponsorTypes(SponsorTypes sponsorTypeToAdd)
        {
            var addedSponsorTypes = conferenceContext.Add(sponsorTypeToAdd);
            conferenceContext.SaveChanges();
            return addedSponsorTypes.Entity;
        }

        public void DeleteSponsorTypes(SponsorTypes sponsorTypeToDelete)
        {
            conferenceContext.Remove(sponsorTypeToDelete);
            conferenceContext.SaveChanges();
        }

        public List<SponsorTypes> GetAllSponsorTypes()
        {
            List<SponsorTypes> listOfAllSponsorTypes;
            listOfAllSponsorTypes = conferenceContext.SponsorTypes.ToList();
            return listOfAllSponsorTypes;
        }

        public SponsorTypes GetSponsorTypeById(int id)
        {
            SponsorTypes sponsorType = conferenceContext.SponsorTypes.Find(id);
            return sponsorType;
        }

        public SponsorTypes UpdateSponsorTypes(SponsorTypes sponsorTypesToUpdate)
        {
            var updatedSponsorTypes = conferenceContext.Update(sponsorTypesToUpdate);
            conferenceContext.SaveChanges();
            return updatedSponsorTypes.Entity;
        }
    }
}