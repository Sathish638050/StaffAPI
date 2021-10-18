using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffsApi.Service
{
    public interface ITopicServ<Topic>
    {
        public void AddModule(Topic m);
        public Task<List<Topic>> Topics(int cid);
    }
}
