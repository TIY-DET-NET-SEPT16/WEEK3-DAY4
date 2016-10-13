using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReviewQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write out 5 things then wait for user input before clearing and continuing
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine("The number is {0}", i);

            //    if (i > 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("Press any key to continue");
            //        Console.ReadKey();
            //        Console.Clear();
            //    }
            //}

            //List<string> stuff = new List<string>();

            //using (StreamReader sr = new StreamReader("Review.txt"))
            //{
            //    while(!sr.EndOfStream)
            //    {
            //        stuff.Add(sr.ReadLine());
            //    }
            //    sr.Close();
            //}

            //using (StreamReader sr = new StreamReader("Review.txt"))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        string wholeLine = sr.ReadLine();
            //        string[] temp = wholeLine.Split(',');

            //        Book myBook = new Book();
            //        myBook.MyProperty1 = temp[0];
            //        myBook.MyProperty2 = temp[1];
            //        myBook.MyProperty3 = temp[2];
            //        myBook.MyProperty4 = temp[3];

            //        stuff.Add(myBook);
            //    }
            //    sr.Close();
            //}

            //List<Num> numList = new List<Num>();
            //List<string> numStrings = new List<string>();

            //using (StreamReader sr = new StreamReader("Review.txt"))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        string wholeLine = sr.ReadLine();
            //        string[] temp = wholeLine.Split('\n');

            //        Num num = new Num();
            //        num.Number = temp[0];

            //        numList.Add(num);

            //        //This one line of code could replace the previous 5 lines
            //        numStrings.Add(sr.ReadLine());
            //    }
            //    sr.Close();
            //}


        }
    }
}
