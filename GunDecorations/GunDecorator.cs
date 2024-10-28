namespace GunDecorations
{
    public abstract class GunDecorator : Gun
    {
        private readonly Gun _gun;

        public GunDecorator(Gun gun)  
        { 
            _gun = gun;
        }

        public override int AmmoCapacity    => _gun.AmmoCapacity;
        public override float NoiseLevel    => _gun.NoiseLevel;
        
    }
}