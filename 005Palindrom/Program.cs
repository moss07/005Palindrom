using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {

            //Palindrom:
            //Eğer bir kelimenin düz okunuşu ile ters okunuşu birbirinin aynı ise palindromdur, değilse palindrom değildir.
            //Örneğin "ana" kelimesi bir palindrom iken "baba" kelimesi bir palindrom değildir.
            //Basit bir palindrom kontrol konsol uygulaması yazınız:
            //1) Kullanıcı 'q' harfine basana kadar tekrar tekrar giriş yapabilir, 'q' harfine bastığında uygulamadan çıkılır.
            //2) Kullanıcının yaptığı giriş en az iki karakter olmalıdır.
            //3) Kullanıcı sadece harf girecek diye bir zorunluluk yoktur.
            //4) Eğer kullanıcının girdiği kelime palindrom ise ekrana "Girdiğiniz kelime palindromdur.", değilse "Girdiğiniz kelime palindrom değildir." yazılır.

            string input1;
            Console.Write("Lütfen kelime giriniz veya çıkış için 'q' basınız:  ");
            input1 = Console.ReadLine();
            if (input1 != "q" && input1.Length > 2)
            {
                string dondur = "";
                for (int i = input1.Length - 1; i >= 0; i--)
                {
                    dondur = dondur + input1[i];

                }
                if (dondur == input1)
                {
                    Console.WriteLine("Girdiğiniz kelime palindromdur.");

                }
                else
                {
                    Console.WriteLine("Girdiğiniz kelime palindrom değildir.");

                }
            }
            else // q ise
            {
                Console.Write("Uygulamadan çıkın");
            }
            Console.Write("Lütfen kelime giriniz veya çıkış için 'q' basınız:  ");
            input1 = Console.ReadLine();


            Console.ReadLine();
        }


    }
}
