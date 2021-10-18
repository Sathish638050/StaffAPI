using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

#nullable disable

namespace StaffsApi.Model
{
    public partial class Topic:ITopic<Topic>
    {
        public int TopicId { get; set; }
        public string TopicName { get; set; }
        public string TopicDesc { get; set; }
        public string MaterialPath { get; set; }
        public string VideoPath { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public ELearnApplicationContext db = new ELearnApplicationContext();

        public async void AddModule(Topic m)
        {
            db.Topics.Add(m);
            await db.SaveChangesAsync();
        }

        public async Task<List<Topic>> Topics(int cid)
        {
            List<Topic> modDetail = new List<Topic>();

            modDetail = (from i in db.Topics
                         where i.CourseId == cid
                         select i).ToList();
            return modDetail;
        }
    }
}
