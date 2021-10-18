using StaffsApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffsApi.Repositary
{
    public class TopicRepo : ITopicRepo<Topic>
    {
        private readonly ITopic<Topic> obj;
        public TopicRepo(ITopic<Topic> _obj)
        {
            obj = _obj;
        }
        public void AddModule(Topic m)
        {
            obj.AddModule(m);
        }

        public Task<List<Topic>> Topics(int cid)
        {
            return obj.Topics(cid);
        }
    }
}
