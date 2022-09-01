
using GameDemoProject.Abstract;
using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Concrate
{
    class GamerManager :BaseGamerManager
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                throw new Exception("Hatalı Giriş");
            }
        }
    }
}
