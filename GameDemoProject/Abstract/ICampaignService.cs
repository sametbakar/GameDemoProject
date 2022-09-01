using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Abstract
{
     public interface ICampaignService
    {
        public void Add(Campaign campaign);
        public void Update(Campaign campaign);
        public void Delete(Campaign campaign);
    }
}
