using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_vorm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            Triangle triangle = new Triangle(a, b, c);
            listView1.Items.Add("Сторона а");
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Существует?");
            listView1.Items.Add("Спецификатор");
            listView1.Items[0].SubItems.Add(triangle.outputA());
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC());
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriange) { listView1.Items[5].SubItems.Add("Существует"); }
            else listView1.Items[5].SubItems.Add("Не существует");
            listView1.Items[6].SubItems.Add(triangle.TriangleType);
            if (triangle.TriangleType == "равносторонний")
            {
                pictureBox1.Image = Properties.Resources.ravnostr;

            }
            else if (triangle.TriangleType == "равнобедренный")
            {
                pictureBox1.Image = Properties.Resources.ravnobedr;
            }
            else if (triangle.TriangleType == "разносторонний")
            {
                pictureBox1.Image = Properties.Resources.raznostr;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.lomanaya;
            }

            Myform Myform = new Myform();
            Myform.Show();
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }   
}
