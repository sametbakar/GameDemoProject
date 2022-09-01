using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckIfRealGamer(Gamer gamer);
    }
}
