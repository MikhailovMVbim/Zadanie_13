using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Задан класс Building, который описывает здание. Класс содержит следующие элементы:

адрес здания;
длина здания;
ширина здания;
высота здания.
В классе Building нужно реализовать следующие методы:

конструктор с 4 параметрами;
свойства get/set для доступа к полям класса;
метод Print(), который выводит информацию о здании.
Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. В классе MultiBuilding реализовать следующие элементы:

конструктор с 5 параметрами – реализует вызов конструктора базового класса;
свойство get/set доступа к внутреннему полю класса;
метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
Класс MultiBuilding сделать таким, что не может быть унаследован.
 */

namespace Zadanie_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Классы Building и MultiBuilding");
            Console.WriteLine("-------------------------------");
            Building building = new Building("Московский 143", 200, 200, 32);
            MultiBuilding multiBuilding = new MultiBuilding("Московский 143", 200, 200, 32, 8);
            Console.WriteLine("\nКласс Building:");
            building.Print();
            Console.WriteLine("\nКласс MultiBuilding:");
            multiBuilding.Print();
            Console.ReadKey();
        }
    }

    class Building
    {
        public string BuildingAdress { get; set; }
        public double BuildingLenght { get; set; }
        public double BuildingWidth { get; set; }
        public double BuildingHight{ get; set; }

        public Building(string adr, double l, double w, double h)
        {
            BuildingAdress = adr;
            BuildingLenght = l;
            BuildingWidth = w;
            BuildingHight = h;
        }

        public virtual void Print ()
        {
            Console.WriteLine("Адрес: {0}", BuildingAdress);
            Console.WriteLine("Длина: {0}", BuildingLenght);
            Console.WriteLine("Ширина: {0}", BuildingWidth);
            Console.WriteLine("Высота: {0}", BuildingHight);
        }

    }

    sealed class MultiBuilding: Building
    {
        public int BuildingFloors { get; set; }

        public MultiBuilding(string adr, double l, double w, double h, int e)
            :base (adr,l,w,h)
        {
            BuildingFloors = e;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Этажность: {0}", BuildingFloors);
        }

    }
}
