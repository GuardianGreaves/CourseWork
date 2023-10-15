using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OboskalovKyrsovaiaC_
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lOGIN_PASSWORDTableAdapter.Fill(this.baseDataSet.LOGIN_PASSWORD);
            this.uSERTableAdapter.Fill(this.baseDataSet.USER);


            if (textBox1.Text.Length == 0 || textBox1.Text.Length == 0)
                MessageBox.Show("Поле логин или пароль не заполнено !");
            foreach (DataRow Row in baseDataSet.LOGIN_PASSWORD.Rows)
            {
                if (textBox1.Text == Row["Login"].ToString() || textBox2.Text == Row["Password"].ToString())
                {
                    MainForms mainForms = new MainForms();
                    mainForms.Show();
                }
            }
        }


        private void Authorization_Load(object sender, EventArgs e)
        {

        }
    }
}
