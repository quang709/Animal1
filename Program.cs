using System;

namespace Animal1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfAnimal = 0;
            Animal a = new Animal();
            while (numOfAnimal >= 0)
            {
                
                Console.WriteLine("Nhap ten dong vat: ");
                string name = Console.ReadLine();
                Console.WriteLine("Nhap tieng keu dong vat: ");
                string sound = Console.ReadLine();
                Console.WriteLine(a.idNum);
                Console.WriteLine(name + " keu " + sound);
                numOfAnimal++;
            }
        }
    }
}