namespace GunDecorations
{
    public class MachineGun : Gun
    {
        public override int AmmoCapacity { get; }

        public override float NoiseLevel { get; }

        public MachineGun()
        {
            AmmoCapacity =  250;
            NoiseLevel =    20.0f; 
        }
    }
}