using Conference1.Data;
using Conference1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Conference1.Service
{
    public interface IEditionService
    {
        List<Editions> GetAllEditions();
        Editions AddEdition(Editions edition);
        Editions GetEditionById(int id);
        Editions Update(Editions editionToUpdate);
        void Delete(Editions editionToDelete);
    }
    public class EditionService : IEditionService
    {


        private readonly IEditionsRepository editionRepository;

        public EditionService(IEditionsRepository editionRepository)
        {
            this.editionRepository = editionRepository;
        }

        public Editions AddEdition(Editions edition)
        {
            Editions addedEdition = editionRepository.AddEdition(edition);
            return addedEdition;
        }

        public void Delete(Editions editionToDelete)
        {
            editionRepository.Delete(editionToDelete);
        }

        public List<Editions> GetAllEditions()
        {
            return editionRepository.GetAllEditions();
        }

        public Editions GetEditionById(int id)
        {
            return editionRepository.GetEditionById(id);
        }

        public Editions Update(Editions editionToUpdate)
        {
            return editionRepository.Update(editionToUpdate);
        }
    }
}
