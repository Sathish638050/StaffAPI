using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffsApi.Model
{
    public interface ITopic<Topic>
    {
        public void AddModule(Topic m);
        public Task<List<Topic>> Topics(int cid);
    }
}
