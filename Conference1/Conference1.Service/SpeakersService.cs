using Conference1.Data;
using Conference1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference1.Service
{

    public interface ISpeakerService
    {
        List<Speakers> GetAllSpeakers();
        Speakers GetSpeakerById(int id);
        Speakers AddSpeaker(Speakers speakerToAdd);
        Speakers UpdateSpeaker(Speakers speakerToUpdate);
        void DeleteSpeaker(Speakers speakerToDelete);
    }
    public class SpeakersService : ISpeakerService
    {
        private readonly ISpeakersRepository speakerRepository;

        public SpeakersService(ISpeakersRepository speakerRepository)
        {
            this.speakerRepository = speakerRepository;
        }

        public Speakers AddSpeaker(Speakers speakerToAdd)
        {
            Speakers addedSpeaker = speakerRepository.AddSpeaker(speakerToAdd);
            return addedSpeaker;
        }

        public void DeleteSpeaker(Speakers speakerToDelete)
        {
            speakerRepository.DeleteSpeaker(speakerToDelete);
        }

        public List<Speakers> GetAllSpeakers()
        {
            return speakerRepository.GetAllSpeakers();
        }

        public Speakers GetSpeakerById(int id)
        {
            return speakerRepository.GetSpeakerById(id);
        }

        public Speakers UpdateSpeaker(Speakers speakerToUpdate)
        {
            Speakers updatedSpeaker;
            updatedSpeaker = speakerRepository.UpdateSpeaker(speakerToUpdate);
            return updatedSpeaker;
        }
    }
}
