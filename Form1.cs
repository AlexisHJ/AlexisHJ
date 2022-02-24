using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckButtonApp
{
    public partial class CheckBoxApp : Form
    {
        public CheckBoxApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox2.Checked == true && checkBox1.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                label2.Text = "RESULTADO: Respuesta existosa!!!";
            }
            else {
                label2.Text = "RESULTADO: Respuesta incorrecta vuelve a intentarlo";

            }
        }
    }
}
