using System;

namespace GunDecorations
{
    public abstract class Gun
    {   
        /// <summary>
        /// abstract ammo capacity
        /// </summary>
        /// <value></value>
        public abstract int AmmoCapacity { get;}


        /// <summary>
        /// Virtual noise
        /// </summary>
        /// <value></value>
        public abstract float NoiseLevel { get;}


        /// <summary>
        /// Gun Constructor
        /// </summary>
        /// <param name="ammo"></param>
        /// <param name="noise"></param>
        public Gun()
        {
        }


        public virtual void Fire()
        {

            Console.Write($"Gun Ammo: {AmmoCapacity} Noise: {NoiseLevel}");
        }
    }
}