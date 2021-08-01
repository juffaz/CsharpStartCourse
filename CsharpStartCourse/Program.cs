using System;
using System.Text;
using System.Linq;



namespace CsharpStartCourse
//#pragma warning restore CS1633 // Нераспознанная директива #pragma
{
    class Program
    { 
        static void Main(string[] args)
            
        {

            //Ex2();
            Ex2();


            //double d = 131231223.111233223121;
            //Console.WriteLine(d);
            //Console.WriteLine("{0:F7}",d);
            //Console.WriteLine(String.Format("{0:F7}",d));
            //Console.WriteLine(d.ToString("### ### ### ###.### ### ### ### ###"));

            //Console.WriteLine(@"вахвахва");

            //int a = 2147000000; //12
            //double d = Convert.ToDouble(a) + 1_000_000; //12.0
            //Console.WriteLine(d);
            ////a = Convert.ToInt32(d);
            //a = (int)d;
            //Console.WriteLine(a);
            //bool e = 10 > 2;
            //Console.WriteLine(e);
            //char c = '1';
            //string s = "cs";

            //double d = -123456789.0987654321;
            //Console.WriteLine($"{d}");
            //d = Convert.ToDouble(1234567890987643211);
            //Console.WriteLine($"{d}");
            //var a = 1223423423423423422;
            //double numb1 = Convert.ToDouble(Console.ReadLine());

            ////var d = 123; Console.WriteLine(d.GetType().Name);
            ////var i = 123.34; Console.WriteLine(i.GetType().Name);
            ////var s = "ку-ку"; Console.WriteLine(s.GetType().Name);
            //var res = new int[1].Select(e => new { q = e, w = 2020 });
            //Console.WriteLine(res.GetType());

            //// Ex3

            //Console.Write("Введите первое число: ");
            //double numb1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Введите второе число: ");
            //double numb2 = double.Parse(Console.ReadLine());

            //Console.WriteLine(numb1 + numb2);


            // Ex2

            //Console.Write("Введите первое число: ");
            //Int32 numb1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Введите второе число: ");
            //int numb2 = int.Parse(Console.ReadLine());
            //var sum = numb1 + numb2;
            //Console.WriteLine(sum);
            //Console.WriteLine(numb1 + " + " + numb2 + " = " + sum);
            //Console.WriteLine(Convert.ToString(numb1) + " + " + Convert.ToString(numb2) + " = " + Convert.ToString(sum));
            //Console.WriteLine(numb1.ToString() + " + " + numb2.ToString() + " = " + sum.ToString()) ;
            //Console.WriteLine(String.Format("{0} + {1} = {2}", numb1, numb2, sum));

            //Console.WriteLine($"{numb1} + {numb2}  = {sum}"); //++

        }


     
        private static void Ex1()
        {
 
            Console.WriteLine("Введите свое имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите свой возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите свой вес");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Вас зовут {name}");
            Console.WriteLine($"Ваш возраст {age}");
            Console.WriteLine($"Ваш вес {height}");
        }

        private static void Ex2()
        {

            Console.WriteLine("Введите свой рост");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите свой вес");
            double height = Convert.ToDouble(Console.ReadLine());
            double indexBody = (double)(height / (weight * weight));
            Console.WriteLine($"Ваш  индекс массы тела (ИМТ) {indexBody}");
        }

    }
}
