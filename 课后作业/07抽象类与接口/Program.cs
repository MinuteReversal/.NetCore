using System;

namespace 作业
{
    //武器接口
    interface IWeapon
    {
        void Fire(object target);//将目标装箱为object
    }

    //枪类实现了武器的开火功能
    abstract class AGun : IWeapon
    {
        public abstract void Fire(object target);
    }

    //Kar98k实现了枪
    class Kar98K : AGun
    {
        public override void Fire(object target)
        {
            Console.WriteLine($"使用Kar98K向{target}开枪");//隐式调用对象的ToString()的方法
        }
    }
    //AK47实现了枪
    class AK47 : AGun
    {
        public override void Fire(object target)
        {
            Console.WriteLine($"使用AK47向{target.ToString()}开枪");//显示调用对象的ToString()方法
        }
    }

    /*英雄 */
    class Hero
    {

        protected IWeapon Weapon { get; set; }

        protected string Name { get; set; }

        public Hero(string name)//构造器
        {
            this.Name = name;
        }
        public void PicupkWeapon(IWeapon weapon)//捡起武器
        {
            this.Weapon = weapon;
        }

        public void Fire(object target)//向目标开火
        {
            Console.Write(this.Name);
            this.Weapon.Fire(target);//英雄使用捡到的武器
        }
    }

    /*敌人 */

    class Enermy
    {
        protected string Name { get; set; }//名字
        public Enermy(string name)//构造器
        {
            this.Name = name;
        }
        public override string ToString()//重写object的方法ToString，可以把光标点到object上按下F12键查看object的定义
        {
            return this.Name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("白衬衫");//把英雄请进场
            Enermy enermy1 = new Enermy("敌人1");//敌人进场
            Enermy enermy2 = new Enermy("敌人2");//敌人进场
            Kar98K kar98k = new Kar98K();//地图上刷出了Kar98k
            AK47 aK47 = new AK47();//地图上刷出了AK47

            hero.PicupkWeapon(kar98k);//英雄捡起了kar98k
            hero.Fire(enermy1);//向第一个敌人开火

            hero.PicupkWeapon(aK47);//英雄捡起了aK47
            hero.Fire(enermy2);//向第二个敌人开火

        }
    }
}
