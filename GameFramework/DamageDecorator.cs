using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using GameFramework.Charactor;
using GameFramework.Items;

namespace GameFramework
{
    class DamageDecorator : IWeapon
    {
        private IWeapon _weapon;
        protected double _decor;

        public DamageDecorator(IWeapon weapon)
        {
            _weapon = weapon;
            _decor = 1.3;
        }

        public int GetDamage()
        {
            return (int) Math.Round(_weapon.GetDamage() * _decor);
        }
    }
}
