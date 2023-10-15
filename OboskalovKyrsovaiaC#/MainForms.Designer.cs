namespace OboskalovKyrsovaiaC_
{
    partial class MainForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForms));
            this.userTableAdapter1 = new OboskalovKyrsovaiaC_.BaseDataSetTableAdapters.USERTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID_USER = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Patronymic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HomeAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hostel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_GROUP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateEnrollment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.baseDataSet = new OboskalovKyrsovaiaC_.BaseDataSet();
            this.uSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new OboskalovKyrsovaiaC_.BaseDataSetTableAdapters.TableAdapterManager();
            this.gROUPTableAdapter = new OboskalovKyrsovaiaC_.BaseDataSetTableAdapters.GROUPTableAdapter();
            this.lOGIN_PASSWORDTableAdapter = new OboskalovKyrsovaiaC_.BaseDataSetTableAdapters.LOGIN_PASSWORDTableAdapter();
            this.uSER_ROLETableAdapter = new OboskalovKyrsovaiaC_.BaseDataSetTableAdapters.USER_ROLETableAdapter();
            this.uSER_ROLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOGIN_PASSWORDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.группыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSER_ROLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGIN_PASSWORDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_USER,
            this.Surname,
            this.Name,
            this.Patronymic,
            this.DateBirth,
            this.HomeAddress,
            this.Hostel,
            this.ID_GROUP,
            this.DateEnrollment});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(796, 358);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID_USER
            // 
            this.ID_USER.Text = "";
            this.ID_USER.Width = 20;
            // 
            // Surname
            // 
            this.Surname.Text = "Фамилия";
            this.Surname.Width = 94;
            // 
            // Name
            // 
            this.Name.Text = "Имя";
            this.Name.Width = 73;
            // 
            // Patronymic
            // 
            this.Patronymic.Text = "Отчество";
            this.Patronymic.Width = 95;
            // 
            // DateBirth
            // 
            this.DateBirth.Text = "Дата рождения";
            this.DateBirth.Width = 127;
            // 
            // HomeAddress
            // 
            this.HomeAddress.Text = "Адрес";
            this.HomeAddress.Width = 75;
            // 
            // Hostel
            // 
            this.Hostel.Text = "Общежитие";
            this.Hostel.Width = 105;
            // 
            // ID_GROUP
            // 
            this.ID_GROUP.Text = "Группа";
            this.ID_GROUP.Width = 68;
            // 
            // DateEnrollment
            // 
            this.DateEnrollment.Text = "Дата зачисления";
            this.DateEnrollment.Width = 135;
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "BaseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERBindingSource
            // 
            this.uSERBindingSource.DataMember = "USER";
            this.uSERBindingSource.DataSource = this.baseDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHECK_VACCINETableAdapter = null;
            this.tableAdapterManager.DATA_MEDICAL_CHECKUPSTableAdapter = null;
            this.tableAdapterManager.GROUPTableAdapter = this.gROUPTableAdapter;
            this.tableAdapterManager.HOSPITAL_TREATMENTTableAdapter = null;
            this.tableAdapterManager.LOGIN_PASSWORDTableAdapter = this.lOGIN_PASSWORDTableAdapter;
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
            this.tableAdapterManager.USER_ROLETableAdapter = this.uSER_ROLETableAdapter;
            this.tableAdapterManager.USERTableAdapter = this.userTableAdapter1;
            // 
            // gROUPTableAdapter
            // 
            this.gROUPTableAdapter.ClearBeforeFill = true;
            // 
            // lOGIN_PASSWORDTableAdapter
            // 
            this.lOGIN_PASSWORDTableAdapter.ClearBeforeFill = true;
            // 
            // uSER_ROLETableAdapter
            // 
            this.uSER_ROLETableAdapter.ClearBeforeFill = true;
            // 
            // uSER_ROLEBindingSource
            // 
            this.uSER_ROLEBindingSource.DataMember = "USER_ROLE";
            this.uSER_ROLEBindingSource.DataSource = this.baseDataSet;
            // 
            // lOGIN_PASSWORDBindingSource
            // 
            this.lOGIN_PASSWORDBindingSource.DataMember = "LOGIN_PASSWORD";
            this.lOGIN_PASSWORDBindingSource.DataSource = this.baseDataSet;
            // 
            // gROUPBindingSource
            // 
            this.gROUPBindingSource.DataMember = "GROUP";
            this.gROUPBindingSource.DataSource = this.baseDataSet;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.группыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // группыToolStripMenuItem
            // 
            this.группыToolStripMenuItem.Name = "группыToolStripMenuItem";
            this.группыToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.группыToolStripMenuItem.Text = "Группы";
            this.группыToolStripMenuItem.Click += new System.EventHandler(this.группыToolStripMenuItem_Click);
            // 
            // MainForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 412);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Text = "Основная страница";
            this.Load += new System.EventHandler(this.MainForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSER_ROLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGIN_PASSWORDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseDataSetTableAdapters.USERTableAdapter userTableAdapter1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID_USER;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Patronymic;
        private System.Windows.Forms.ColumnHeader DateBirth;
        private System.Windows.Forms.ColumnHeader HomeAddress;
        private System.Windows.Forms.ColumnHeader Hostel;
        private System.Windows.Forms.ColumnHeader ID_GROUP;
        private System.Windows.Forms.ColumnHeader DateEnrollment;
        private BaseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource uSERBindingSource;
        private BaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BaseDataSetTableAdapters.USER_ROLETableAdapter uSER_ROLETableAdapter;
        private System.Windows.Forms.BindingSource uSER_ROLEBindingSource;
        private BaseDataSetTableAdapters.LOGIN_PASSWORDTableAdapter lOGIN_PASSWORDTableAdapter;
        private System.Windows.Forms.BindingSource lOGIN_PASSWORDBindingSource;
        private BaseDataSetTableAdapters.GROUPTableAdapter gROUPTableAdapter;
        private System.Windows.Forms.BindingSource gROUPBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem группыToolStripMenuItem;
    }
}