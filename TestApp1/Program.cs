using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Разработать абстрактный класс Animal, который описывает животное. Класс содержит следующие элементы:

            абстрактное свойство - название животного.
            В классе Animal нужно определить следующие методы:

            конструктор, устанавливающий значение по умолчанию для названия;
            абстрактный метод Say(), который выводит звук, который издает животное;
            неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук (вызывая метод Say()).
            Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. В классах реализовать следующие элементы:

            свойство – название животного;
            метод Say (), выводящий на экран «Мяу» либо «Гав» соответственно.
            Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.*/
            
            //Строки для проверки работы классов.
            Cat cat = new Cat();
            cat.Name = "Кнопка";
            cat.ShowInfo();
            
            Dog dog = new Dog();
            dog.Name = "Жучка";
            dog.ShowInfo();

            Console.ReadKey();

        }
    }
    abstract class Animal //абстрактный класс
    {
        public abstract string Name { set; get; }
        public Animal()
        {

        }
        public abstract void Say();
        
        public virtual void ShowInfo()
        {
            Console.Write("{0} ",Name);
            Say();

        }


    }

    class Cat : Animal
    {
        string name;
        public override string Name 
        {
            get 
            {
                return name;
            }
            set 
            {
                name = value;
            } 
        }

        public override void Say()
        {
            Console.WriteLine("умеет говорить \"Мяу !\""); ;
        }

    }
    class Dog : Animal
    {
        string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public override void Say()
        {
            Console.WriteLine("умеет говорить \"ГАВ !\""); ;
        }
    }
}
