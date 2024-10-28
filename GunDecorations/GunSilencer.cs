using System;

namespace GunDecorations
{
    public class GunSilencer : GunDecorator
    {
        public override float NoiseLevel => (1 - _supression) * base.NoiseLevel;

        private readonly float _supression; 
 
        public GunSilencer(Gun gun, float noiseReduction) : base(gun)
        {
            if (noiseReduction >= 1 && noiseReduction < 0)
                throw new ArgumentException("Invalid values");


            _supression = noiseReduction;
        }
        
    }
}