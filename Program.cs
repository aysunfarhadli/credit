using System;

class Program
{
    static void Main()
    {
        // İstifadəçidən maaş və kredit məbləğini daxil etməsini istəyirik
        Console.Write("İllik maaşınızı daxil edin: ");
        double maas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kredit məbləğini daxil edin: ");
        double kredit = Convert.ToDouble(Console.ReadLine());

        // Şərti yoxlayırıq
        if (kredit > (maas * 0.6))
        {
            Console.WriteLine("Kredit götürə bilərsiniz!");
        }
        else
        {
            Console.WriteLine("Kredit götürə bilməzsiniz!");
        }
    }
}