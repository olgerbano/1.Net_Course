using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator5
{
    class Program
    {
        private static void Sumarize(char[] line, ref int consoane, ref int vocale, ref int spatii, 
            ref int acdr, ref int acst, ref int numbers, ref int newline,ref int liniuta,ref int thonjz,ref int presje,ref int pika)
        {
            for (int i = 0; i < line.Length; i++)
            {
                if (char.IsLetter(line[i]))
                {
                    if ("eyuioaEYUIOA".Contains(line[i]))
                        vocale++;
                    else consoane++;
                }
                if (char.IsDigit(line[i]))
                    numbers++;
                if (" ".Contains(line[i]))
                    spatii++;
                if ("(".Contains(line[i]))
                    acst++;
                if (")".Contains(line[i]))
                    acdr++;
                if ("\n".Contains(line[i]))
                    newline++;
                if ("'".Contains(line[i]))
                    thonjz++;
                if ("-".Contains(line[i]))
                    liniuta++;
                if (",".Contains(line[i]))
                    presje++;
                if (":".Contains(line[i]))
                    pika++;
            }
        }
        static void Main(string[] args)
        {
            int consoane = 0, vocale = 0, spatii = 0, acdr = 0, acst = 0 , numbers = 0, 
                newline = 0,liniuta = 0, thonjz = 0,presje = 0,pika = 0;
            string fileName = args[0];
            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            Console.WriteLine((int)stream.Length);
            char[] line = new char[stream.Length];
            for (int i = 0; i < stream.Length; i++)
                line[i] = (char)reader.Read();
            Sumarize(line, ref consoane, ref vocale, ref spatii, ref acdr, ref acst, 
                ref numbers, ref newline,ref liniuta,ref thonjz,ref presje,ref pika);
            Console.WriteLine("consoane " + consoane);
            Console.WriteLine("vocale " + vocale);
            Console.WriteLine("caractere nl " + newline);
            Console.WriteLine("Spatii " + spatii);
            Console.WriteLine("Paranteze stanga: " + acst);
            Console.WriteLine("Paranteze dreapta: " + acdr);
            Console.WriteLine("Numbers: " + numbers);
            Console.WriteLine("Presje: " + presje);
            Console.WriteLine("Thonjza: " + thonjz);
            Console.WriteLine("liniuta: " + liniuta);
            Console.WriteLine("Pika: " + pika);
            Console.ReadKey();
        }


    }
}
