using System;
using System.Collections.Generic;
using System.Text;

namespace DeathStar
{
    public interface IShip
    {
        int Shield { get; set; }
        int Armor { get; set; }
    }
}
