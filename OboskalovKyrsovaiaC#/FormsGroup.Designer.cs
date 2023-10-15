namespace OboskalovKyrsovaiaC_
{
    partial class FormsGroup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.baseDataSet = new OboskalovKyrsovaiaC_.BaseDataSet();
            this.gROUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUPTableAdapter = new OboskalovKyrsovaiaC_.BaseDataSetTableAdapters.GROUPTableAdapter();
            this.tableAdapterManager = new OboskalovKyrsovaiaC_.BaseDataSetTableAdapters.TableAdapterManager();
            this.gROUPDataGridView = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "BaseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gROUPBindingSource
            // 
            this.gROUPBindingSource.DataMember = "GROUP";
            this.gROUPBindingSource.DataSource = this.baseDataSet;
            // 
            // gROUPTableAdapter
            // 
            this.gROUPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHECK_VACCINETableAdapter = null;
            this.tableAdapterManager.DATA_MEDICAL_CHECKUPSTableAdapter = null;
            this.tableAdapterManager.GROUPTableAdapter = this.gROUPTableAdapter;
            this.tableAdapterManager.HOSPITAL_TREATMENTTableAdapter = null;
            this.tableAdapterManager.LOGIN_PASSWORDTableAdapter = null;
            this.tableAdapterManager.MEDICAL_ORGANIZATIONTableAdapter = null;
            this.tableAdapterManager.OPERATIONSTableAdapter = null;
            this.tableAdapterManager.PASS_CONROLLERTableAdapter = null;
            this.tableAdapterManager.PASSES_FOR_ILLNESSTableAdapter = null;
            this.tableAdapterManager.PAST_INFECTIOUS_DIASESTableAdapter = null;
            this.tableAdapterManager.PREVENTIVE_VACCINETableAdapter = null;
            this.tableAdapterManager.SANITARY_SPA_TREATMENTTableAdapter = null;
            this.tableAdapterManager.SURVEYSTableAdapter = null;
            this.tableAdapterManager.TRAUMATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OboskalovKyrsovaiaC_.BaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USER_ROLETableAdapter = null;
            this.tableAdapterManager.USERTableAdapter = null;
            // 
            // gROUPDataGridView
            // 
            this.gROUPDataGridView.AutoGenerateColumns = false;
            this.gROUPDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gROUPDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.gROUPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gROUPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.gROUPDataGridView.DataSource = this.gROUPBindingSource;
            this.gROUPDataGridView.Location = new System.Drawing.Point(12, 12);
            this.gROUPDataGridView.Name = "gROUPDataGridView";
            this.gROUPDataGridView.Size = new System.Drawing.Size(327, 186);
            this.gROUPDataGridView.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(345, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(186, 186);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            this.chart1.Titles.Add(title1);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Location = new System.Drawing.Point(12, 204);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(519, 190);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            title2.Name = "Title1";
            this.chart2.Titles.Add(title2);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_GROUP";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_GROUP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GroupName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NumberPeople";
            this.dataGridViewTextBoxColumn3.HeaderText = "Кол-во человек";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormsGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 407);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.gROUPDataGridView);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormsGroup";
            this.Text = "Группы";
            this.Load += new System.EventHandler(this.FormsGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource gROUPBindingSource;
        private BaseDataSetTableAdapters.GROUPTableAdapter gROUPTableAdapter;
        private BaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gROUPDataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}