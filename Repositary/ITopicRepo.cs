using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffsApi.Repositary
{
    public interface ITopicRepo<Topic>
    {
        public void AddModule(Topic m);
        public Task<List<Topic>> Topics(int cid);
    }
}
