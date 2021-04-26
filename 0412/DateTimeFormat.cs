using System;
using System.Globalization;
namespace A088_DateTimeFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(today.ToString("yyyy년 MM월 dd일"));
            Console.WriteLine(string.Format("{0:yyyy년 MM월 dd일}", today));
            Console.WriteLine(today.ToString("MMMM dd, yyyy ddd", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(today.ToString("MMMM dd, yyyy ddd", new CultureInfo("en-US")));
            // 오전, 오후
            Console.WriteLine(today.ToString("tt"));
            today = today.AddHours(12);
            Console.WriteLine(today.ToString("tt"));
            today = today.AddHours(-12);
            Console.WriteLine("\n표준 포맷 지정자");
            // d : 축약된 날짜 형식
            Console.WriteLine("d : " + today.ToString("d"));
            Console.WriteLine("d : " + today.ToString("d", new CultureInfo("en-US")));
            using System;
namespace A089_MethodArguments
    {
        class Program
        {
            static void Main(string[] args)
            {
                int a = 3;
                Sqr(a);
                Console.WriteLine("Value: {0}", a); // 3이 출력됩니다.
                int b = 3;
                Sqr(ref b);
                Console.WriteLine("ref: {0}", b); // 9가 출력됩니다.
                string name;
                int id;
                GetName(out name, out id);
                Console.WriteLine("out: {0} {1}", name, id);
            }
            static void Sqr(int x)
            {
                x = x * x;
            }
            static void Sqr(ref int x)
            {
                x = x * x;
            }
            static void GetName(out string name, out int id)
            {
                Console.Write("Enter Name: ");
                name = Console.ReadLine();
                Console.Write("Enter Id: ");
                id = int.Parse(Console.ReadLine());
            }
        }
    }
