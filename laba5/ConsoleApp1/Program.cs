using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder("190.34.12.999999 123.123.11.22  129.133.1.21  20.123.11.22 232.123.11.22 252.123.11.22 195.123.11.22 255.123.11.22");

            var collection = Regex.Matches(text.ToString(), @"(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)");

            var ClassA = new StringBuilder("Класс А: ");
            var ClassB = new StringBuilder("Класс B: ");
            var ClassC = new StringBuilder("Класс C: ");
            var ClassD = new StringBuilder("Класс D: ");
            var ClassE = new StringBuilder("Класс E: ");

            foreach (Match ip in collection)
            {
                var actet = Regex.Matches(ip.Value, @"\d+[.]");
                int actet_int = int.Parse(actet[0].Value.Replace('.', ' '));
    
                if (actet_int >= 0 && actet_int <= 127 )
                {
                    ClassA.Append(ip.Value + ", ");
                }
                if (actet_int >= 128 && actet_int <= 191)
                {
                    ClassB.Append(ip.Value + ", ");
                }
                if (actet_int >= 192 && actet_int <= 223)
                {
                    ClassC.Append(ip.Value + ", ");
                }
                if (actet_int >= 224 && actet_int <= 239)
                {
                    ClassD.Append(ip.Value + ", ");
                }
                if (actet_int > 239)
                {
                    ClassE.Append(ip.Value + ", ");
                }
            }

            Console.WriteLine(ClassA);
            Console.WriteLine(ClassB);
            Console.WriteLine(ClassC);
            Console.WriteLine(ClassD);
            Console.WriteLine(ClassE);



        }
    }
}