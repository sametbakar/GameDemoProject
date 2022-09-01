using GameDemoProject.Adapters;
using GameDemoProject.Concrate;
using GameDemoProject.Entities;
using System;

namespace GameDemoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer()
            {
                Id = 1,
                FirstName = "Samet",
                LastName="Bakar",
                DateOfBirth=new DateTime(2000,3,5),
                NationalityId="12345678910"
            };

            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(gamer);

            Game game= new Game()
            {
                Id=1,
                GameName="Counter-Strike",
                GamePrice=249.95
            };
            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            Campaign campaign = new Campaign() { Id = 1,CampaignName="OYUN15",DiscountRate=15};
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            GameSalesManager gameSalesManager = new GameSalesManager();
            gameSalesManager.Sales(gamer, game);
            gameSalesManager.Sales(gamer, game,campaign);

        }
    }
}
