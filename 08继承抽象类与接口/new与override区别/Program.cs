using System;

namespace new与override区别
{
    class BaseClass
    {
        public void Method1()
        {
            Console.WriteLine("Base - Method1");
        }
        public void Method2()
        {
            Console.WriteLine("Base - Method2");
        }

        public virtual void Method3()
        {
            Console.WriteLine("Base - Method3");
        }
    }

    class DerivedClass : BaseClass
    {
        public new void Method2()
        {
            Console.WriteLine("Derived - Method2");
        }

        public override void Method3()
        {
            Console.WriteLine("Derived - Method3");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();

            bc.Method2();
            dc.Method2();
            bcdc.Method2();
            Console.WriteLine("-----------------------");
            bc.Method3();
            dc.Method3();
            bcdc.Method3();
        }
    }
}
