using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    internal class MeidcList
    {
        public List<string[]> Medic = new List<string[]>();
        
        public void AddDoctorList(string date, string doctor, Label result)
        {
            Medic.Add(new string[2]{ date, doctor });
        }

  

        public void GetDoctorDate(string time, Label result)
        {
            string tmp = $"Записи на {time}:\n";
            for (int i = 0; i < Medic.Count; i++)
            {
                if (Medic[i][0] == time)
                {
                    tmp += $"{Medic[i][1]}\n";
                }
            }
            result.Text = tmp;
        }

        public void GetDoctorCount(string time, Label result)
        {
            string tmp = $"";
            int[] count = new int[4] {0, 0, 0, 0};
            for (int i = 0; i < Medic.Count; i++)
            {
                if (Medic[i][0] == time)
                {

                    switch (Medic[i][1])
                    {
                        case "Хирург":
                            count[0] += 1;
                            break;
                        case "Стамотолог":
                            count[1] += 1;
                            break;
                        case "Дермотолог":
                            count[2] += 1;
                            break;
                        case "Педиатор":
                            count[3] += 1;
                            break;
                    }
                }
            }
            result.Text = $"Количество пачиентов по врачам:\nХирург - {count[0]}\nСтамотолог - {count[1]}\n" +
                                                           $"Дермотолог - {count[2]}\nПедиатар - {count[3]}";
        }

        public void GeSpecializationCount(string time, Label result)
        {
            string tmp = $"";
            int[] count = new int[4] { 0, 0, 0, 0 };
            for (int i = 0; i < Medic.Count; i++)
            {
                if (Medic[i][0] == time)
                {

                    switch (Medic[i][1])
                    {
                        case "Хирург":
                            count[0] += 1;
                            break;
                        case "Стамотолог":
                            count[1] += 1;
                            break;
                        case "Дермотолог":
                            count[2] += 1;
                            break;
                        case "Педиатар":
                            count[3] += 1;
                            break;
                    }
                }
            }
            int spec1 = (count[0] + count[1]) / 2;
            int spec2 = (count[2] + count[3]) / 2;
            result.Text = $"Среднее количество пачиентов по специальностям:\nТерапия - {spec2}\nХирургия - {spec1}";
                                                           
        }

    }
}
