using System;

namespace GunDecorations
{
    public class Program
    {
        private static void Main(string[] args)
        {

            Gun gun = new MachineGun();
            
            gun.Fire();

            // Decorating
            gun = new GunClip(gun, 50);
            gun = new GunSilencer(gun, 0.3f);

            // using gun
            gun.Fire();

        }
    }
}
