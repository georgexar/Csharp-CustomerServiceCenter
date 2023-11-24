namespace KEP_ERG3
{
    partial class DataShow
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clientInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientInfoBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.clientDatabaseDataSet = new KEP_ERG3.ClientDatabaseDataSet();
            this.clientInfoBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.clientInfoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.clientDatabaseDataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.clientInfoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.clientInfoTableAdapter = new KEP_ERG3.ClientDatabaseDataSetTableAdapters.clientInfoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientInfoBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBirthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniqueIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDatabaseDataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoBindingSource7)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1054, 692);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sort per Citizen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1065, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clientInfoBindingSource1
            // 
            this.clientInfoBindingSource1.DataMember = "clientInfo";
            this.clientInfoBindingSource1.DataSource = this.clientDatabaseDataSetBindingSource;
            // 
            // clientInfoBindingSource
            // 
            this.clientInfoBindingSource.DataMember = "clientInfo";
            // 
            // clientInfoBindingSource6
            // 
            this.clientInfoBindingSource6.DataMember = "clientInfo";
            this.clientInfoBindingSource6.DataSource = this.clientDatabaseDataSet;
            // 
            // clientDatabaseDataSet
            // 
            this.clientDatabaseDataSet.DataSetName = "ClientDatabaseDataSet";
            this.clientDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientInfoBindingSource5
            // 
            this.clientInfoBindingSource5.DataMember = "clientInfo";
            this.clientInfoBindingSource5.DataSource = this.clientDatabaseDataSet;
            // 
            // clientInfoBindingSource4
            // 
            this.clientInfoBindingSource4.DataMember = "clientInfo";
            this.clientInfoBindingSource4.DataSource = this.clientDatabaseDataSet11BindingSource;
            // 
            // clientInfoBindingSource2
            // 
            this.clientInfoBindingSource2.DataMember = "clientInfo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1098, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search by name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1065, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1098, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search by phone";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1065, 298);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1098, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Search by email";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1065, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 49);
            this.button2.TabIndex = 9;
            this.button2.Text = "Delete Request";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1098, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter the UniqueID";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1065, 443);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 22);
            this.textBox4.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1065, 526);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 49);
            this.button3.TabIndex = 12;
            this.button3.Text = "Modify Request";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // clientInfoBindingSource3
            // 
            this.clientInfoBindingSource3.DataMember = "clientInfo";
            this.clientInfoBindingSource3.DataSource = this.clientDatabaseDataSetBindingSource;
            // 
            // clientInfoTableAdapter
            // 
            this.clientInfoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientNameDataGridViewTextBoxColumn,
            this.clientEmailDataGridViewTextBoxColumn,
            this.clientPhoneDataGridViewTextBoxColumn,
            this.clientBirthdateDataGridViewTextBoxColumn,
            this.clientDateDataGridViewTextBoxColumn,
            this.clientRequestDataGridViewTextBoxColumn,
            this.clientPostalDataGridViewTextBoxColumn,
            this.uniqueIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientInfoBindingSource7;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 752);
            this.dataGridView1.TabIndex = 13;
            // 
            // clientInfoBindingSource7
            // 
            this.clientInfoBindingSource7.DataMember = "clientInfo";
            this.clientInfoBindingSource7.DataSource = this.clientDatabaseDataSet;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "clientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "clientName";
            this.clientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientEmailDataGridViewTextBoxColumn
            // 
            this.clientEmailDataGridViewTextBoxColumn.DataPropertyName = "clientEmail";
            this.clientEmailDataGridViewTextBoxColumn.HeaderText = "clientEmail";
            this.clientEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientEmailDataGridViewTextBoxColumn.Name = "clientEmailDataGridViewTextBoxColumn";
            this.clientEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientPhoneDataGridViewTextBoxColumn
            // 
            this.clientPhoneDataGridViewTextBoxColumn.DataPropertyName = "clientPhone";
            this.clientPhoneDataGridViewTextBoxColumn.HeaderText = "clientPhone";
            this.clientPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientPhoneDataGridViewTextBoxColumn.Name = "clientPhoneDataGridViewTextBoxColumn";
            this.clientPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientBirthdateDataGridViewTextBoxColumn
            // 
            this.clientBirthdateDataGridViewTextBoxColumn.DataPropertyName = "clientBirthdate";
            this.clientBirthdateDataGridViewTextBoxColumn.HeaderText = "clientBirthdate";
            this.clientBirthdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientBirthdateDataGridViewTextBoxColumn.Name = "clientBirthdateDataGridViewTextBoxColumn";
            this.clientBirthdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientBirthdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientDateDataGridViewTextBoxColumn
            // 
            this.clientDateDataGridViewTextBoxColumn.DataPropertyName = "clientDate";
            this.clientDateDataGridViewTextBoxColumn.HeaderText = "clientDate";
            this.clientDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientDateDataGridViewTextBoxColumn.Name = "clientDateDataGridViewTextBoxColumn";
            this.clientDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientRequestDataGridViewTextBoxColumn
            // 
            this.clientRequestDataGridViewTextBoxColumn.DataPropertyName = "clientRequest";
            this.clientRequestDataGridViewTextBoxColumn.HeaderText = "clientRequest";
            this.clientRequestDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientRequestDataGridViewTextBoxColumn.Name = "clientRequestDataGridViewTextBoxColumn";
            this.clientRequestDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientRequestDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientPostalDataGridViewTextBoxColumn
            // 
            this.clientPostalDataGridViewTextBoxColumn.DataPropertyName = "clientPostal";
            this.clientPostalDataGridViewTextBoxColumn.HeaderText = "clientPostal";
            this.clientPostalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientPostalDataGridViewTextBoxColumn.Name = "clientPostalDataGridViewTextBoxColumn";
            this.clientPostalDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientPostalDataGridViewTextBoxColumn.Width = 125;
            // 
            // uniqueIdDataGridViewTextBoxColumn
            // 
            this.uniqueIdDataGridViewTextBoxColumn.DataPropertyName = "uniqueId";
            this.uniqueIdDataGridViewTextBoxColumn.HeaderText = "uniqueId";
            this.uniqueIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uniqueIdDataGridViewTextBoxColumn.Name = "uniqueIdDataGridViewTextBoxColumn";
            this.uniqueIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.uniqueIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // DataShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 810);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "DataShow";
            this.Text = "dataShow";
            this.Load += new System.EventHandler(this.DataShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoBindingSource7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clientInfoBindingSource;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource clientDatabaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource clientInfoBindingSource1;
        private System.Windows.Forms.BindingSource clientInfoBindingSource2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource clientDatabaseDataSet11BindingSource;
        private System.Windows.Forms.BindingSource clientInfoBindingSource3;
        private System.Windows.Forms.BindingSource clientInfoBindingSource4;
        private ClientDatabaseDataSet clientDatabaseDataSet;
        private System.Windows.Forms.BindingSource clientInfoBindingSource5;
        private ClientDatabaseDataSetTableAdapters.clientInfoTableAdapter clientInfoTableAdapter;
        private System.Windows.Forms.BindingSource clientInfoBindingSource6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientBirthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniqueIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientInfoBindingSource7;
    }
}