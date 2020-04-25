using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen
{
    class City
    {
        public string Name = "";
        public DateTime Data;
        public int Count = 0;
    }

    static class Cities
    {

        static public int Size;
        static public List<City> Town = new List<City>();
        private static bool hasLetters;

        static public void Cityes()
        {
            Console.Write("Размер массива = ");
            Size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Size; i++)
            {
                City city = new City();
                Console.Write("Название города №" + i + " = ");
                city.Name = Console.ReadLine();
                Console.Write("Дата создания №" + i + " = ");
                city.Data = Convert.ToDateTime(Console.ReadLine());
                do
                {
                    Console.Write("Количество жителей №" + i + " = ");
                    string c = Console.ReadLine();
                    hasLetters = c.AsEnumerable().Any(ch => char.IsLetter(ch));
                    if (!hasLetters)
                        city.Count = Convert.ToInt32(c);
                    else
                    {
                        Console.Write("Количество жителей не должно содержать буквы. Только цифры. Повторите ввод количества жителей №" + i + " = ");
                    }
                }
                while (hasLetters);
                Town.Add(city);
            }
        }
        static public void Sort()
        {
            Town.OrderBy(r => r.Count).ThenBy(r => r.Data).ToArray();
        }
        static public void SaveInFile()
        {
            using (StreamWriter sw = new StreamWriter("Towns.txt"))
            {
                foreach (City C in Town)
                    sw.WriteLine(C.Name + ", " + C.Data + ", " + C.Count.ToString());
            }
        }
    }
}
