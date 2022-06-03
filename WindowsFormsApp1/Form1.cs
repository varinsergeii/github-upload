using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
       private void Form1_Load(object sender, EventArgs e)
       {

       }

        private void opers_button_Click(object sender, EventArgs e) // обработка события при нажатии кнопки для поиска + или -
        {
            Vector A, B;
            A = new Vector(Convert.ToDouble(x1A.Text), Convert.ToDouble(y1A.Text), Convert.ToDouble(z1A.Text));
            B = new Vector(Convert.ToDouble(x1B.Text), Convert.ToDouble(y1B.Text), Convert.ToDouble(z1B.Text));
            switch (opers.SelectedItem)
            {
                case "+":
                    Vector C = A + B;
                    opers_result.Text = Vector.Show(C);
                    break;
                case "-":
                    Vector D = A - B;
                    opers_result.Text = Vector.Show(D);
                    break;
            }
        }
        private void scal_button_Click(object sender, EventArgs e) // обработка события нажатия кнопки для поиска скалярного произведения
        {
            Vector A, B;
            A = new Vector(Convert.ToDouble(x2A.Text), Convert.ToDouble(y2A.Text), Convert.ToDouble(z2A.Text));
            B = new Vector(Convert.ToDouble(x2B.Text), Convert.ToDouble(y2B.Text), Convert.ToDouble(z2B.Text));
            proz_result.Text = Convert.ToString(A * B);

        }

        private void length_button_Click(object sender, EventArgs e) // обработка события нажатия кнопки для поиска длины вектора
        {
            Vector A;
            A = new Vector(Convert.ToDouble(x3A.Text), Convert.ToDouble(y3A.Text), Convert.ToDouble(z3A.Text));
            length_result.Text = Convert.ToString(Vector.Length(A));
        }
        private void cos_button_Click(object sender, EventArgs e) // обработка события нажатия кнопки для поиска косинуса между двумя векторами
        { 
            Vector A, B;
            A = new Vector(Convert.ToDouble(x4A.Text), Convert.ToDouble(y4A.Text), Convert.ToDouble(z4A.Text));
            B = new Vector(Convert.ToDouble(x4B.Text), Convert.ToDouble(y4B.Text), Convert.ToDouble(z4B.Text));
            cos_result.Text = Convert.ToString(Vector.Cos(A, B));
        }
       
    }

    class Vector
    {
        public double X;
        public double Y;
        public double Z;
        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public static Vector operator +(Vector A, Vector B)
        {
            return new Vector(A.X + B.X, A.Y + B.Y, A.Z + B.Z);
        }
        public static Vector operator -(Vector A, Vector B)
        {
            return new Vector(A.X - B.X, A.Y - B.Y, A.Z - B.Z);
        }
        public static double operator *(Vector A, Vector B)
        {
            return (A.X * B.X + A.Y * B.Y + A.Z * B.Z);
        }
        public static double Length(Vector r) // вычисляем длину по формуле sqrt(x^2+y^2+z^2)
        {
            return Math.Sqrt(r.X * r.X + r.Y * r.Y + r.Z * r.Z);
        }
        public static double Cos(Vector A, Vector B) // вычисляем косинус по формуле
        {
            return (A * B) / (Vector.Length(A) * Vector.Length(B)); // немного сократил формулу
        }
        public static string Show(Vector A) // вывод вектора
        {
           string res;
           return res = ("(" + A.X + ';' + A.Y + ';' + A.Z + ')');
        }
    }

}
