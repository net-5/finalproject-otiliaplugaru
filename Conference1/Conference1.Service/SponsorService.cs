using Conference1.Data;
using Conference1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference1.Service
{
    public interface ISponsorsService
    {
        List<Sponsors> GetAllSponsors();
        Sponsors GetSponsorById(int id);
        Sponsors AddSponsors(Sponsors sponsorToAdd);
        Sponsors UpdateSponsors(Sponsors sponsorToUpdate);
        void DeleteSponsor(Sponsors sponsorToDelete);
        void Save();
    }
    public class SponsorsService : ISponsorsService
    {
        private readonly ISponsorsRepository sponsorsRepository;

        public SponsorsService(ISponsorsRepository sponsorsRepository)
        {
            this.sponsorsRepository = sponsorsRepository;
        }

        public Sponsors AddSponsors(Sponsors sponsorToAdd)
        {
            return sponsorsRepository.AddSponsor(sponsorToAdd);
        }

        public void DeleteSponsor(Sponsors sponsorToDelete)
        {
            sponsorsRepository.DeleteSponsor(sponsorToDelete);
        }

        public List<Sponsors> GetAllSponsors()
        {
            return sponsorsRepository.GetAllSponsors();
        }

        public Sponsors GetSponsorById(int id)
        {
            return sponsorsRepository.GetSponsorsById(id);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Sponsors UpdateSponsors(Sponsors sponsorToUpdate)
        {
            return sponsorsRepository.UpdateSponsor(sponsorToUpdate);
        }
    }
}