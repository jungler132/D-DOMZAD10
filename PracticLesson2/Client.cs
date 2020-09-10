using System;
using System.Collections.Generic;
using System.Text;

namespace PracticLesson2
{
    public class Client
    {
        public int summ;
        public int amount_num;
        public string open_date;
        public Client()
        {
            Console.WriteLine("Summa");
            int Summ = tryparse();
            Console.WriteLine("Nomer sseta");
            int Amount_num = tryparse();
            Console.WriteLine("VVedite datu");
            string Open_date = Console.ReadLine();
            this.summ = Summ;
            this.amount_num = Amount_num;
            this.open_date = Open_date;
        }
        public int Summ
        {
            get
            {
                return summ;
            }
            set
            {
                summ = value;
            }
        }
        public int Amount_num
        {
            get
            {
                return amount_num;
            }
            set
            {
                amount_num = value;
            }
        }
        public string Open_date
        {
            get
            {
                return open_date;
            }
            set
            {
                open_date = value;
            }
        }
        public static int tryparse()
        {
            int num1;
            bool triger = false;
            do
            {
                Console.WriteLine("Enter number");
                if (int.TryParse(Console.ReadLine(), out num1) && num1 > 0)
                {
                    triger = true;
                }
                else
                {
                    Console.WriteLine("wrong number try again");
                    continue;
                }
            }
            while (triger == false);
            return num1;
    }
        public  void Vidacha_Summ()
        {
            Console.WriteLine($"Vidacha = {summ}");
        }
        public void Open_date_time()
        {
            Console.WriteLine(open_date);
        }
        public void Procent_nacis()
        {
            int num;
            Console.WriteLine("Vvedite summu kredita");
            int dolg = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite srok kredita");
            int years = int.Parse(Console.ReadLine());
            for(int i = 0; i <= years; i++)
            {
                dolg += dolg / 10;
                i++;
            }
            Console.WriteLine($"Konecniy dolg =  {dolg}");
            Console.WriteLine($"Srok oplati =  {years}");

        }

    }
    public class Fiz_Lico : Client
    {
        public Fiz_Lico()
            : base()
        {
            Console.WriteLine($"Vidacha = {this.summ} Nomer sheta = {this.amount_num} Data otkritiya {this.open_date}");
        }
    }
    public class Yuri_lico : Client
    {
        public Yuri_lico()
            : base()
        {
            
        }
    }
}
