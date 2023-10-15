using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OboskalovKyrsovaiaC_
{
    public partial class FormsGroup : Form
    {
        public FormsGroup()
        {
            InitializeComponent();
        }

        private void gROUPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gROUPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDataSet);

        }
        public class GroupData
        {
            public string GroupName { get; set; }
            public int MemberCount { get; set; }
        }

        public void Diagram()
        {
            List<GroupData> groupDataList = new List<GroupData>();

            foreach (DataRow row in this.baseDataSet.GROUP.Rows)
            {
                string groupName = row["GroupName"].ToString();
                int memberCount = Convert.ToInt32(row["NumberPeople"]);

                GroupData groupData = new GroupData
                {
                    GroupName = groupName,
                    MemberCount = memberCount
                };

                groupDataList.Add(groupData);
            }

            Series series = new Series("GroupMembers");
            series.ChartType = SeriesChartType.Pie;

            foreach (var groupData in groupDataList)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.SetValueY(groupData.MemberCount);
                dataPoint.AxisLabel = $"{groupData.GroupName} ({groupData.MemberCount} человек)";
                series.Points.Add(dataPoint);
            }

            chart1.Series.Add(series);
            chart1.Update();

        }

        public void Diagram2()
        {
            List<GroupData> groupDataList = new List<GroupData>();

            foreach (DataRow row in this.baseDataSet.GROUP.Rows)
            {
                string groupName = row["GroupName"].ToString();
                int memberCount = Convert.ToInt32(row["NumberPeople"]);

                GroupData groupData = new GroupData
                {
                    GroupName = groupName,
                    MemberCount = memberCount
                };
                groupDataList.Add(groupData);
            }

            Series series = new Series("GroupMembers");
            series.ChartType = SeriesChartType.Column; // Измените на SeriesChartType.Column или SeriesChartType.Bar

            foreach (var groupData in groupDataList)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.SetValueY(groupData.MemberCount);
                dataPoint.AxisLabel = $"{groupData.GroupName} ({groupData.MemberCount} человек)";
                series.Points.Add(dataPoint);
            }

            chart2.Series.Add(series);
            chart2.Update();
        }


        private void FormsGroup_Load(object sender, EventArgs e)
        {
            this.gROUPTableAdapter.Fill(this.baseDataSet.GROUP);

            Diagram();
            Diagram2();
        }
    }
}
