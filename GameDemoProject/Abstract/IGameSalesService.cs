using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Abstract
{
    public interface IGameSalesService
    {
        public void Sales(Gamer gamer, Game game);
        public void Sales(Gamer gamer, Game game, Campaign campaign);
    }
}
