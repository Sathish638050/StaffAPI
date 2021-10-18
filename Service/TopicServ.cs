using StaffsApi.Model;
using StaffsApi.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffsApi.Service
{
    public class TopicServ : ITopicServ<Topic>
    {
        private readonly ITopicRepo<Topic> repo;
        public TopicServ(ITopicRepo<Topic> _repo)
        {
            repo = _repo;
        }
        public void AddModule(Topic m)
        {
            repo.AddModule(m);
        }

        public Task<List<Topic>> Topics(int cid)
        {
            return repo.Topics(cid);
        }
    }
}
