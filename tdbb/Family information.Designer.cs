namespace tdbb
{
    partial class Family_information
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentFamilyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ovogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajilSurguuliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.huisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPrimaryFamilyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyRelationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentFamilyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tDB_AnketDataSet = new tdbb.TDB_AnketDataSet();
            this.student_FamilyTableAdapter = new tdbb.TDB_AnketDataSetTableAdapters.Student_FamilyTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentFamilyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDB_AnketDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(44, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Гэр бүлтэй";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(161, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(99, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Гэр бүлгүй";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 48);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ам бүлийн тоо:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(394, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentFamilyIDDataGridViewTextBoxColumn,
            this.ovogDataGridViewTextBoxColumn,
            this.nerDataGridViewTextBoxColumn,
            this.ajilSurguuliDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.huisDataGridViewTextBoxColumn,
            this.isPrimaryFamilyDataGridViewTextBoxColumn,
            this.familyRelationIDDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentFamilyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(450, 348);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentFamilyIDDataGridViewTextBoxColumn
            // 
            this.studentFamilyIDDataGridViewTextBoxColumn.DataPropertyName = "StudentFamilyID";
            this.studentFamilyIDDataGridViewTextBoxColumn.HeaderText = "StudentFamilyID";
            this.studentFamilyIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentFamilyIDDataGridViewTextBoxColumn.Name = "studentFamilyIDDataGridViewTextBoxColumn";
            this.studentFamilyIDDataGridViewTextBoxColumn.Visible = false;
            this.studentFamilyIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ovogDataGridViewTextBoxColumn
            // 
            this.ovogDataGridViewTextBoxColumn.DataPropertyName = "Ovog";
            this.ovogDataGridViewTextBoxColumn.HeaderText = "Ovog";
            this.ovogDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ovogDataGridViewTextBoxColumn.Name = "ovogDataGridViewTextBoxColumn";
            this.ovogDataGridViewTextBoxColumn.Width = 125;
            // 
            // nerDataGridViewTextBoxColumn
            // 
            this.nerDataGridViewTextBoxColumn.DataPropertyName = "Ner";
            this.nerDataGridViewTextBoxColumn.HeaderText = "Ner";
            this.nerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nerDataGridViewTextBoxColumn.Name = "nerDataGridViewTextBoxColumn";
            this.nerDataGridViewTextBoxColumn.Width = 125;
            // 
            // ajilSurguuliDataGridViewTextBoxColumn
            // 
            this.ajilSurguuliDataGridViewTextBoxColumn.DataPropertyName = "AjilSurguuli";
            this.ajilSurguuliDataGridViewTextBoxColumn.HeaderText = "AjilSurguuli";
            this.ajilSurguuliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ajilSurguuliDataGridViewTextBoxColumn.Name = "ajilSurguuliDataGridViewTextBoxColumn";
            this.ajilSurguuliDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // huisDataGridViewTextBoxColumn
            // 
            this.huisDataGridViewTextBoxColumn.DataPropertyName = "Huis";
            this.huisDataGridViewTextBoxColumn.HeaderText = "Huis";
            this.huisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.huisDataGridViewTextBoxColumn.Name = "huisDataGridViewTextBoxColumn";
            this.huisDataGridViewTextBoxColumn.Width = 125;
            // 
            // isPrimaryFamilyDataGridViewTextBoxColumn
            // 
            this.isPrimaryFamilyDataGridViewTextBoxColumn.DataPropertyName = "isPrimaryFamily";
            this.isPrimaryFamilyDataGridViewTextBoxColumn.HeaderText = "isPrimaryFamily";
            this.isPrimaryFamilyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isPrimaryFamilyDataGridViewTextBoxColumn.Name = "isPrimaryFamilyDataGridViewTextBoxColumn";
            this.isPrimaryFamilyDataGridViewTextBoxColumn.Width = 125;
            // 
            // familyRelationIDDataGridViewTextBoxColumn
            // 
            this.familyRelationIDDataGridViewTextBoxColumn.DataPropertyName = "FamilyRelationID";
            this.familyRelationIDDataGridViewTextBoxColumn.HeaderText = "FamilyRelationID";
            this.familyRelationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.familyRelationIDDataGridViewTextBoxColumn.Name = "familyRelationIDDataGridViewTextBoxColumn";
            this.familyRelationIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentFamilyBindingSource
            // 
            this.studentFamilyBindingSource.DataMember = "Student_Family";
            this.studentFamilyBindingSource.DataSource = this.tDB_AnketDataSet;
            // 
            // tDB_AnketDataSet
            // 
            this.tDB_AnketDataSet.DataSetName = "TDB_AnketDataSet";
            this.tDB_AnketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_FamilyTableAdapter
            // 
            this.student_FamilyTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Нэмэх";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Family_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Family_information";
            this.Size = new System.Drawing.Size(538, 597);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentFamilyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDB_AnketDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentFamilyBindingSource;
        private TDB_AnketDataSet tDB_AnketDataSet;
        private TDB_AnketDataSetTableAdapters.Student_FamilyTableAdapter student_FamilyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFamilyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ovogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ajilSurguuliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn huisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isPrimaryFamilyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyRelationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}
