using System;
using System.Text;
using System.Text.RegularExpressions;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DifChar();
            GetStr();

            void GetStr()
            {
                

                string[] text = { "+375299786692 10:00 40", "+375299782212 01:22 12", "+375299786692 00:01 40", "+375299786692 02:45 40", "+375299786692 22:12 40", "+375299782212 01:22 12", "+375299786692 03:01 40" };
                var sb = new StringBuilder();
                var list = new List<int>();

                foreach (string str in text)
                {
                    var number = Regex.Matches(str, @"(\d{12})");
                    var hour = Regex.Matches(str, @"(\d{2}:)");
                    var minutes = Regex.Matches(str, @"(:\d{2})");

                    int num_hour = int.Parse(hour[0].Value.Remove(2, 1));
                    int num_minutes = int.Parse(minutes[0].Value.Remove(0, 1));


                    if (number[0].Value == "375299786692" & CheckTime(num_hour, num_minutes))
                    {
                        sb.AppendLine(str);
                    }

                    
                            
                }

                Console.WriteLine(sb.ToString());   


            }

            bool CheckTime(int hours, int minutes)
            {
                if(hours > 0 & hours < 3)
                {
                    return true;
                }
                if (hours == 0 & minutes >= 1)
                {
                    return true;
                }
                else return false;
            }







            void DifChar()
            {
                Console.Write("Введите предложение: ");
                string line = Console.ReadLine();
                line = Regex.Replace(line, @"\s+", "");

                var gr = line.GroupBy(e => e);
                Console.WriteLine(gr.GetType().Name);
                foreach (var i in gr)
                {
                    Console.WriteLine($"{i.Key} = {i.Count()}");
                }
            }
        }
    }
}