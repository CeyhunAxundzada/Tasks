using System;

namespace TASK1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ad ve soyad daxil et");
            string ad_soyad = Console.ReadLine();

            Console.WriteLine("Group n daxil et");
            string qrup = Console.ReadLine();

            Console.WriteLine("Yas daxil et");
            string yas = Console.ReadLine();
            int yas1 = int.Parse(yas);
            Students student = new Students(ad_soyad, qrup, yas1);
        }
    }
}
