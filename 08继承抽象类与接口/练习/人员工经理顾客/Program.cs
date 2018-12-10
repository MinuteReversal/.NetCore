using System;

namespace 人员工经理顾客
{
    //人类
    public class Person
    {
        // 无参数构造器
        public Person()
        {
            Name = "unknown";
        }

        // 有参数构造器
        public Person(string name)
        {
            Name = name;
        }

        //只读属性
        public string Name { get; }
    }

    //顾客类
    public class Customer : Person
    {
        public Customer(string name) : base(name)
        {
        }

        public void Buy(Perfume good)
        {
            Console.WriteLine($"{this.Name}购买了{good.Name}");
        }
    }

    //雇员类
    public class Employee : Person
    {
        public Employee(string name) : base(name)
        {
        }

        //推荐
        public void Recommend(Perfume good, Customer person)
        {
            Console.WriteLine($"雇员{this.Name}给{person.Name}好好推荐了一下{good.Name}");
        }
    }

    //经理类
    public class Manager : Employee
    {
        public Manager(string name) : base(name)
        {
        }

        public void IntroduceTo(Employee employee, Customer customer)
        {
            Console.WriteLine($"经理让{employee.Name}去接待{customer.Name}");
        }
    }

    //商店类
    public class Shop
    {

        public string Name { get; }//只读属性        

        //有参数构造器，商店在建好的时候就已经有名字了
        public Shop(string name)
        {
            this.Name = name;
        }
        //上班
        public void Duty(Employee person)
        {
            Console.WriteLine($"{person.Name}来到了{this.Name}上班");
        }

        //进入
        public void Enter(Customer person)
        {
            Console.WriteLine($"{person.Name}来到了{this.Name}进行购物");
        }
    }

    //香水
    public class Perfume
    {
        public string Name { get; }
        //香水在出产的时候就已经定好名字了
        public Perfume(string name)
        {
            this.Name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Perfume No5=new Perfume("五号香水");
            Shop shop = new Shop("香水店");      //一个叫香水店的商店进入了场景
            Customer lily = new Customer("lily");//一个叫lily的顾客进入了场景
            Manager lilei = new Manager("lilei");//一个叫lilei的经理进入了场景
            Employee lucy = new Employee("lucy");//一个叫lucy的雇员进入了场景

            shop.Duty(lilei);                   //上班
            shop.Duty(lucy);                    //上班
            shop.Enter(lily);                   //逛街

            lilei.IntroduceTo(lucy, lily);      //指定人介绍
            lucy.Recommend(No5, lily);   //介绍了商品
            lily.Buy(No5);

        }
    }
}
