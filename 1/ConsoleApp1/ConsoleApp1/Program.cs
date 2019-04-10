using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("input.txt");
            string line;
            int waycount = 0;
            var size = System.IO.File.ReadAllLines("input.txt").Length;
            int[,] arr = new int[size, size];
            int n=0, m = 0, way;
            while ((line = reader.ReadLine()) != null) //Заполнение массива из файла
            {
                foreach(string element in line.Split())
                {
                    way = int.Parse(element);
                    arr[n, m] = way;
                    m++;
                }
                m = 0;
                n++;
            }
            int flag = 0;
            for(int i = 0; i < arr.GetLength(0); i++) //Подсчет количества путей
            {
                for(int j = 0 + flag; j < arr.GetLength(1); j++)
                {
                    if(arr[i,j] == 1 && arr[j,i] == 1)
                    {
                        waycount++;
                    }
                }
                flag++;
            }
            StreamWriter sw = new StreamWriter("output.txt");
            sw.WriteLine(waycount);
            sw.Close();
        }
    }
}
