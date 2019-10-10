using Conference1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference1.Data
{
    public interface ITalksRepository
    {
        List<Talks> GetAllTalks();
        Talks GetTalkById(int id);
        Talks AddTalk(Talks talkToAdd);
        Talks UpdateTalk(Talks talkToUpdate);
        void DeleteTalk(Talks talkToDelete);
    }
    public class TalksRepository : ITalksRepository
    {
        private readonly ConferenceContext conferenceContext;

        public TalksRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }

        public Talks AddTalk(Talks talkToAdd)
        {
            var addedTalk = conferenceContext.Add(talkToAdd);
            conferenceContext.SaveChanges();
            return addedTalk.Entity;
        }

        public void DeleteTalk(Talks talkToDelete)
        {
            conferenceContext.Remove(talkToDelete);
            conferenceContext.SaveChanges();
        }

        public List<Talks> GetAllTalks()
        {
            return conferenceContext.Talks.ToList();
        }

        public Talks GetTalkById(int id)
        {
            Talks talk;
            talk = conferenceContext.Talks.Find(id);
            return talk;
        }

        public Talks UpdateTalk(Talks talkToUpdate)
        {
            var updatedTalk = conferenceContext.Update(talkToUpdate);
            conferenceContext.SaveChanges();
            return updatedTalk.Entity;
        }
    }
}

