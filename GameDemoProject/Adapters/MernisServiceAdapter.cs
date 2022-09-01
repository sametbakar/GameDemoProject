using GameDemoProject.Abstract;
using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            if (gamer.FirstName=="Samet" && gamer.LastName=="Bakar" && gamer.DateOfBirth.Year==2000 && Convert.ToInt64(gamer.NationalityId)==12345678910)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
