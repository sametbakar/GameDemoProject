﻿using GameDemoProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
    }
}
