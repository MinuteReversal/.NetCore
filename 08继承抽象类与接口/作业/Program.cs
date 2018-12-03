using System;

namespace 作业
{
    interface IWeapon
    {
        void Fire(string target);
    }

    abstract class AGun : IWeapon
    {
        public abstract void Fire(string target);
    }

    class Kar98K : AGun
    {
        public override void Fire(string target)
        {
            Console.WriteLine($"使用Kar98K向{target}开枪");
        }
    }

    class AK47 : AGun
    {
        public override void Fire(string target)
        {
            Console.WriteLine($"使用AK47向{target}开枪");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IWeapon gun;
            gun = new Kar98K();
            gun.Fire("目标A");
            gun = new AK47();
            gun.Fire("目标B");
        }
    }
}
