using GameDemoProject.Abstract;
using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Concrate
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+ " adlı kampanya eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanya silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "adlı kampanya güncellendi");
        }
    }
}
