using Conference1.Data;
using Conference1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference1.Service
{

    public interface ITalksService
    {
        List<Talks> GetAllTalks();
        Talks AddTalk(Talks talkToAdd);
        Talks UpdateTalk(Talks talkToUpdate);
        void DeleteTalk(Talks talkToDelete);
        Talks GetTalkById(int id);
    }
    public class TalksService : ITalksService
    {
        private readonly ITalksRepository talkRepository;

        public TalksService(ITalksRepository talkRepository)
        {
            this.talkRepository = talkRepository;
        }

        public Talks AddTalk(Talks talkToAdd)
        {
            return talkRepository.AddTalk(talkToAdd);
        }

        public void DeleteTalk(Talks talkToDelete)
        {
            talkRepository.DeleteTalk(talkToDelete);
        }

        public List<Talks> GetAllTalks()
        {
            return talkRepository.GetAllTalks();
        }

        public Talks GetTalkById(int id)
        {
            return talkRepository.GetTalkById(id);
        }

        public Talks UpdateTalk(Talks talkToUpdate)
        {
            return talkRepository.UpdateTalk(talkToUpdate);
        }
    }
}
