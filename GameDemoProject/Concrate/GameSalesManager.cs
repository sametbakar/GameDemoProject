using GameDemoProject.Abstract;
using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Concrate
{
    internal class GameSalesManager : IGameSalesService
    {
        public void Sales(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName+" "+gamer.LastName+" adlı oyuncu "+game.GameName+" adlı oyunu "+game.GamePrice+"Tl karşılığında satın aldı.");
        }

        public void Sales(Gamer gamer, Game game, Campaign campaign)
        {
            double campaignPrice = Math.Round(game.GamePrice-(game.GamePrice * campaign.DiscountRate / 100),2);
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı oyuncu " + game.GameName + " adlı oyunu "+campaign.CampaignName+" kupon koduyla " + campaignPrice + "Tl karşılığında satın aldı.");
        }
    }
}
