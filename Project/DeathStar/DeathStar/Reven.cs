using System;
using System.Collections.Generic;
using System.Text;

namespace DeathStar
{
    public class Reven:IShip,IBattleship
    {
        public int Shield { get; set; }
        public int Armor { get; set; }

        public List<IWeapon> Weapons { get; set; }

        public int FireWeapon()
        {
            int damageAmount = 0;
            if (Weapons != null)
            {
                foreach (var weapon in Weapons)
                {
                    damageAmount += weapon.Damage;
                }

            }
            return damageAmount;

        }

    }
}
