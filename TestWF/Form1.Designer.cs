namespace TestWF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.carsDataGridView1 = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Producer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.carsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.addButton = new System.Windows.Forms.Button();
            this.comboBoxMark = new System.Windows.Forms.ComboBox();
            this.comboBoxProducer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelProducer = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // carsDataGridView1
            // 
            this.carsDataGridView1.AllowUserToAddRows = false;
            this.carsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete,
            this.Producer,
            this.Mark,
            this.Cost,
            this.Color,
            this.Date,
            this.Mileage,
            this.Column8});
            this.carsDataGridView1.Location = new System.Drawing.Point(215, 12);
            this.carsDataGridView1.Name = "carsDataGridView1";
            this.carsDataGridView1.RowTemplate.Height = 24;
            this.carsDataGridView1.Size = new System.Drawing.Size(811, 521);
            this.carsDataGridView1.TabIndex = 3;
            this.carsDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carsDataGridView1_CellClick);
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Width = 38;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Width = 55;
            // 
            // Producer
            // 
            this.Producer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Producer.HeaderText = "Producer";
            this.Producer.Name = "Producer";
            this.Producer.ReadOnly = true;
            this.Producer.Width = 95;
            // 
            // Mark
            // 
            this.Mark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Mark.HeaderText = "Mark";
            this.Mark.Name = "Mark";
            this.Mark.ReadOnly = true;
            this.Mark.Width = 68;
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 65;
            // 
            // Color
            // 
            this.Color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 70;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 67;
            // 
            // Mileage
            // 
            this.Mileage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Mileage.HeaderText = "Mileage";
            this.Mileage.Name = "Mileage";
            this.Mileage.ReadOnly = true;
            this.Mileage.Width = 86;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column8.FillWeight = 500F;
            this.Column8.HeaderText = "Image";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 52;
            // 
            // carsBindingSource2
            // 
            this.carsBindingSource2.DataMember = "Cars";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(42, 404);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 21);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Without Sort";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(42, 431);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(124, 21);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Sort ascending";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(42, 458);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(132, 21);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.Text = "Sotr descending";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(52, 510);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // comboBoxMark
            // 
            this.comboBoxMark.FormattingEnabled = true;
            this.comboBoxMark.Items.AddRange(new object[] {
            "818"});
            this.comboBoxMark.Location = new System.Drawing.Point(42, 227);
            this.comboBoxMark.Name = "comboBoxMark";
            this.comboBoxMark.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMark.TabIndex = 15;
            this.comboBoxMark.Text = "WithoutFilter";
            this.comboBoxMark.SelectedIndexChanged += new System.EventHandler(this.comboBoxMark_SelectedIndexChanged);
            // 
            // comboBoxProducer
            // 
            this.comboBoxProducer.FormattingEnabled = true;
            this.comboBoxProducer.Location = new System.Drawing.Point(42, 151);
            this.comboBoxProducer.Name = "comboBoxProducer";
            this.comboBoxProducer.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProducer.TabIndex = 14;
            this.comboBoxProducer.Text = "Without Filter";
            this.comboBoxProducer.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mark";
            // 
            // labelProducer
            // 
            this.labelProducer.AutoSize = true;
            this.labelProducer.Location = new System.Drawing.Point(39, 120);
            this.labelProducer.Name = "labelProducer";
            this.labelProducer.Size = new System.Drawing.Size(66, 17);
            this.labelProducer.TabIndex = 12;
            this.labelProducer.Text = "Producer";
            // 
            // Filter
            // 
            this.Filter.AutoSize = true;
            this.Filter.Location = new System.Drawing.Point(80, 84);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(39, 17);
            this.Filter.TabIndex = 16;
            this.Filter.Text = "Filter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 540);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.comboBoxMark);
            this.Controls.Add(this.comboBoxProducer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProducer);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.carsDataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView carsDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn markDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mileageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfIssueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource carsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox comboBoxMark;
        private System.Windows.Forms.ComboBox comboBoxProducer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProducer;
        private System.Windows.Forms.Label Filter;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mileage;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
    }
}

