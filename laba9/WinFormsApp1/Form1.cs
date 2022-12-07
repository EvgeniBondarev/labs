using System.Drawing.Drawing2D;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[,] GetMatrix(string file)
        {
            try
            {
                StreamReader f = new StreamReader(file);
                int[,] C = new int[4, 4];

                int i = 0;
                while (!f.EndOfStream)
                {

                    string s = f.ReadLine();
                    int[] subs = s.Split(',').Select(Int32.Parse).ToArray();

                    for (int j = 0; j < subs.Length; j++)
                    {
                        C[i, j] = subs[j];
                    }
                    i++;
                }
                f.Close();
                return C;
            }
            catch (FileNotFoundException e)
            {
                throw new FileNull($"Такого файла не существует\n{e}");
            }

        }
        public string ShowThisMatrix(int[,] matrix)
        {
            string tmp = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    tmp += $"{matrix[i, j]}  ";
                }
                tmp += "\n";
            }
            return tmp;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] A = GetMatrix("C:\\Users\\Evgeni\\Desktop\\C#\\laba9\\input.txt");
            int[,] B = GetMatrix("C:\\Users\\Evgeni\\Desktop\\C#\\laba9\\input2.txt");

            label5.Text = ShowThisMatrix(A);
            label6.Text = ShowThisMatrix(B);

            MatrixConvert matr1 = new MatrixConvert(A);
            MatrixConvert matr2 = new MatrixConvert(B);
            MatrixConvert matr3 = new MatrixConvert();

            matr3 = matr1 * matr2;

            label2.Text = $"{matr3.ShowMatrix()}";

            matr1 = matr1 * 2;
            label4.Text = $"{matr1.ShowMatrix()}";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}