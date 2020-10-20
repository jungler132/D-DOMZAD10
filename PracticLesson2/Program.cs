using System;

namespace PracticLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Vidacha_Summ();
            client.Open_date_time();
            Fiz_Lico client_2 = new Fiz_Lico();
            client_2.Vidacha_Summ();
            client_2.Procent_nacis();
            Yuri_lico client_3 = new Yuri_lico();
            client_3.Procent_nacis();
            Console.ReadKey();
        }
    }
}
