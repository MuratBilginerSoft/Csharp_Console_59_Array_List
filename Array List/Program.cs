using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir sınıftan nesne türetmek için kullanılan yöntem sınıfın_ismi Nesneİsmi =new sınıfın_ismi();

            ArrayList İsimler = new ArrayList();

            string[] İsimler2 = new string[10]; // İçindeki elemanların hepsi aynı olan verilerdir.
            int[] sayı = new int[10];
            sayı[0] = 4;
            İsimler2[0] = "Murat";
            
            // Arraylist dizine girilen tüm değerler object veri tipinden tutulurlar var olan değer kullanılacağı zaman uygun dönüşüm yapılır ve öyle kullanılır.

            İsimler.Add("Murat");
            İsimler.Add("Bilginer");
            İsimler.Add(554);
            İsimler.Add("Büşra");
            İsimler.Add("Kara");
            İsimler.Add(456);

            int a = İsimler2.Length;
            int b = İsimler.Capacity;

            Console.WriteLine(a);
            Console.WriteLine(b);

            foreach (string item in İsimler2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (int item in sayı)
            {
                Console.WriteLine(item);
            }
           
            foreach (var item in İsimler)
            {
                Console.WriteLine(item);
            }

            ArrayList List = new ArrayList();

            foreach (var x in İsimler)
            {
                Console.WriteLine(x+""+x);
            }

            int x1 = Array.IndexOf(İsimler2, "Murat");

            Console.WriteLine(x1);

           
            bool durum=İsimler.Contains("Murat");

            Console.WriteLine(durum);

            int x2 = İsimler.Count;

            Console.WriteLine(x2);


            for (int i = 0; i < İsimler.Count; i++)
            {
                Console.WriteLine(İsimler[i]);
            }

            int x3 = İsimler.IndexOf("Bilginer");

            Console.WriteLine(x3);

            //İsimler.Clear();

            foreach (var x in İsimler)
            {
                Console.WriteLine(x + "" + x);
            }

            İsimler.Insert(2, "556");

            foreach (var x in İsimler)
            {
                Console.WriteLine(x);
            }

            İsimler.Remove("Murat");

            foreach (var x in İsimler)
            {
                Console.WriteLine(x);
            }

            İsimler.Reverse();

            İsimler.Reverse(2, 3);

            foreach (var x in İsimler)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
            
        }
    }
}
