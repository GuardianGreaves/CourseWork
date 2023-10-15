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
    public partial class MainForms : Form
    {
        public MainForms()
        {
            InitializeComponent();
        }

        private void MainForms_Load(object sender, EventArgs e)
        {

            FillListView();
        }

        public void FillListView()
        {
            this.gROUPTableAdapter.Fill(this.baseDataSet.GROUP);
            this.lOGIN_PASSWORDTableAdapter.Fill(this.baseDataSet.LOGIN_PASSWORD);
            this.uSER_ROLETableAdapter.Fill(this.baseDataSet.USER_ROLE);
            this.userTableAdapter1.Fill(this.baseDataSet.USER);

            listView1.Items.Clear();

            foreach (DataRow Row in baseDataSet.USER.Rows)
            {
                string[] item = new string[15]; // Вам, возможно, потребуется больше элементов

                item[1] = Row[2].ToString();
                item[2] = Row[3].ToString();
                item[3] = Row[4].ToString();
                item[4] = ((DateTime)Row[5]).ToString("yyyy-MM-dd"); // Пример формата даты "гггг-ММ-дд"
                item[6] = Row[6].ToString();
                item[7] = Row[7].ToString();
                DataRow TempRow = Row.GetParentRow("GROUPUSER");
                item[8] = TempRow[1].ToString(); // Проверка на null, чтобы избежать ошибок
                item[9] = ((DateTime)Row[9]).ToString("yyyy-MM-dd"); // Пример формата даты "гггг-ММ-дд"
                ListViewItem id = new ListViewItem();
                id.Text = Row[0].ToString();
                id.SubItems.AddRange(item);
                listView1.Items.Add(id);
            }
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsGroup formsGroup = new FormsGroup();
            formsGroup.ShowDialog();
        }
    }
}
