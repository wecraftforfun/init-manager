using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitManager.Data
{
    public class CampaignService
    {
        private HashSet<Campaign> Campaigns { get; set; }

        public HashSet<Campaign> GetCampaigns()
        {
            if(Campaigns == null)
            {
                Campaigns = new HashSet<Campaign>();
            }
            return Campaigns;
        }

        public void SetCampaigns(HashSet<Campaign> c)
        {
            Campaigns = c;
        }

    }
}
