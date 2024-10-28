using System;


namespace GunDecorations
{
    public class WeirdDecorator : GunDecorator
    {
        public WeirdDecorator(Gun gun) : base(gun)
        {

        }

        public override void Fire()
        {
            Console.WriteLine("HaHaHaHaHa");
            base.Fire();
            Console.WriteLine("HaHaHaHaHa");
        }

    }
}