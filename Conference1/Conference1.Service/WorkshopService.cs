using Conference1.Data;
using Conference1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference1.Service
{
    public interface IWorkshopService
    {
        List<Workshops> GetAllWorkshops();
        Workshops GetWorkshopById(int id);
        Workshops AddWorkshop(Workshops workshopToAdd);
        Workshops UpdateWorkshop(Workshops workshopToUpdate);
        void DeleteWorkshop(Workshops workshopToDelete);
    }
    public class WorkshopsService : IWorkshopService
    {
        private readonly IWorkshopsRepository workshopRepository;

        public WorkshopsService(IWorkshopsRepository workshopRepository)
        {
            this.workshopRepository = workshopRepository;
        }

        public Workshops AddWorkshop(Workshops workshopToAdd)
        {
            return workshopRepository.AddWorkShop(workshopToAdd);
        }

        public void DeleteWorkshop(Workshops workshopToDelete)
        {
            workshopRepository.DeleteWorkshop(workshopToDelete);
        }

        public List<Workshops> GetAllWorkshops()
        {
            return workshopRepository.GetAllWorkshops();
        }

        public Workshops GetWorkshopById(int id)
        {
            return workshopRepository.GetWorkShopById(id);
        }

        public Workshops UpdateWorkshop(Workshops workshopToUpdate)
        {
            return workshopRepository.UpdateWorkshop(workshopToUpdate);
        }
    }
}