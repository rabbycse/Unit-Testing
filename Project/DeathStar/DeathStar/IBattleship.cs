using System;
using System.Collections.Generic;
using System.Text;

namespace DeathStar
{
    public interface IBattleship
    {
        List<IWeapon> Weapons { get; set; }

        int FireWeapon();
    }
}
