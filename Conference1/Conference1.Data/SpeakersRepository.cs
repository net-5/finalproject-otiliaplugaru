using Conference1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference1.Data
{
    public interface ISpeakersRepository
    {
        List<Speakers> GetAllSpeakers();
        Speakers GetSpeakerById(int id);
        Speakers AddSpeaker(Speakers speakerToAdd);
        Speakers UpdateSpeaker(Speakers speakerToUpdate);
        void DeleteSpeaker(Speakers speakerToDelete);
    }

    public class SpeakersRepository : ISpeakersRepository
    {
        private readonly ConferenceContext conferenceContext;

        public SpeakersRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }

        public Speakers AddSpeaker(Speakers speakerToAdd)
        {
            var addedSpeaker = conferenceContext.Add(speakerToAdd);
            conferenceContext.SaveChanges();
            return addedSpeaker.Entity;
        }

        public void DeleteSpeaker(Speakers speakerToDelete)
        {
            conferenceContext.Remove(speakerToDelete);
            conferenceContext.SaveChanges();
        }

        public List<Speakers> GetAllSpeakers()
        {
            return conferenceContext.Speakers.ToList();
        }

        public Speakers GetSpeakerById(int id)
        {
            Speakers speaker = conferenceContext.Speakers.Find(id);
            return speaker;
        }

        public Speakers UpdateSpeaker(Speakers speakerToUpdate)
        {
            var updatedSpeaker = conferenceContext.Update(speakerToUpdate);
            conferenceContext.SaveChanges();
            return updatedSpeaker.Entity;
        }

    }
}

