using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
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

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (var item in this.Controls)
            {
                if (item is CheckBox)
                    ((CheckBox)item).Checked = true;
                if (item is TextBox)
                {
                    TextBox t = (TextBox)item;
                    i++;
                    t.Text = i.ToString();
                }
                    
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dortgen d = new Dortgen(3, 5);
            MessageBox.Show(d.bilgiver());

            Prizma p = new Prizma(10, 20, 30);

            //  d = p;

            //  p = d;   hatalı;


            Dortgen x = new Prizma(3, 5, 8);


            Prizma y =(Prizma) x;

            Object o = p;

            List<Dortgen> kutular = new List<Dortgen>();

            kutular.Add(new Dortgen(1, 1));
            kutular.Add(d);
            kutular.Add(new Prizma(80, 90, 100));

            Dortgen yeni = new Dortgen(1, 1);

            MessageBox.Show( kutular.IndexOf(yeni ).ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {

           


        }
    }
}
