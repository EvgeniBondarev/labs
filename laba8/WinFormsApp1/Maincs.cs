using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Maincs : Form
    {
        public Maincs()
        {
            InitializeComponent();
        }

        private void Maincs_Load(object sender, EventArgs e)
        {

        }

        public void GetFile(string filename)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";

            List<Figure> ClassList = new List<Figure>();

            StreamReader f = new StreamReader(filename);
            string[] arr;
            while (!f.EndOfStream)
            {
                
                string s = f.ReadLine();
                arr = s.Split(" ");
                int radius = int.Parse(arr[1]);
                string color = arr[arr.Length - 1];
                

                if (arr[0] == "многоугольник")
                {
                    List<int> sides = new List<int>();
                    int j = 2;

                    while (Regex.IsMatch(arr[j], @"^\d+"))
                    {
                        sides.Add(Convert.ToInt32(arr[j]));
                        j++;
                    }
                    ClassList.Add(new Polygon(arr[0], color, radius, sides.ToArray()));
                    
                }
                if (arr[0] == "окружность")
                {
                    List<int> points = new List<int>();
                    int j = 2;

                    while (Regex.IsMatch(arr[j], @"^\d+"))
                    {
                        points.Add(Convert.ToInt32(arr[j]));
                        j++;
                    }
                    ClassList.Add(new Circle(arr[0], radius, points.ToArray(), color));
                }


            }

            List<Polygon> Polygons = new List<Polygon>(); 

            foreach (var i in ClassList)
            {
                switch (i.Color)
                {
                    case "Green":
                        richTextBox1.AppendText($"{i.ShowInfo()}\n", Color.Green);
                        break;
                    case "Red":
                        richTextBox1.AppendText($"{i.ShowInfo()}\n", Color.Red);
                        break;
                    case "Blue":
                        richTextBox1.AppendText($"{i.ShowInfo()}\n", Color.Blue);
                        break;
                }

                if(i is Circle && i.Color == "Green")
                {
                    Circle k = (Circle)i;
                    if (k.IsI())
                    {
                        richTextBox2.AppendText($"{k.GetFigurePerimetr()}; ", Color.Green);
                    }  
                }

                if (i is Polygon)
                {
                    Polygon k = (Polygon)i;
                    Polygons.Add(k);
                }
            }
            Polygon[] newPolygons = Polygons.ToArray();

            Array.Sort(newPolygons);

            foreach(Polygon p in newPolygons)
            {
                switch (p.Color)
                {
                    case "Green":
                        richTextBox3.AppendText($"{p.ShowInfo()}\n", Color.Green);
                        break;
                    case "Red":
                        richTextBox3.AppendText($"{p.ShowInfo()}\n", Color.Red);
                        break;
                    case "Blue":
                        richTextBox3.AppendText($"{p.ShowInfo()}\n", Color.Blue);
                        break;
                }
            }
            f.Close();


        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            GetFile(filename);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
