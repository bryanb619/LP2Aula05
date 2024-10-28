using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public class GunClip : GunDecorator
    {
        public override int AmmoCapacity => _extraAmmo * base.AmmoCapacity;

        private readonly int _extraAmmo; 

        public GunClip(Gun gun, int extraAmmo) : base(gun)
        {
            _extraAmmo = extraAmmo;
        }
    }
}