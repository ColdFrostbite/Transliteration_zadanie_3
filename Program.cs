using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transcript
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int iSl;
            string sWord;
            string sFin;
            string[,] sMassive = { { "А","A"},{"Б","B" },{"В","V" },{"Г","G" },{"Д","В"},{"Е","E" },{"Ё","E" },{"Ж","ZH" },{"З","Z" },{"И","I" },{"Й","I" },{"К","K" },{"Л","L" },{"М","M" },{"Н","N" },{"О","O" },{"П","P" },{"Р","R" },{"С","S" },{"Т","T" },{"У","U" },{"Ф","F" },{"Х","KH" },{"Ц","TS" },{"Ч","CH" },{"Ш","SH" },{"Щ","SHCH" },{ "Ы","Y"},{"Ь","" },{"Ъ","IE" },{"Э","E" },{"Ю","IU" },{"Я","IA" } };

            sFin = "";


            Console.Write("Введите любой текст(Большими буквами): ");
            sWord = Console.ReadLine();

            iSl = sWord.Length;

            for (int i = 0; i < iSl; i++)
            {
                for(int k =0; k<33; k++)


                if (string.Equals(sMassive[k,0], sWord.Substring(i, 1)))
                {
                        sFin = sFin + sMassive[k, 1];
                }

            }

            Console.WriteLine(" " + sFin);

            Console.ReadLine();
        }
    }
}
