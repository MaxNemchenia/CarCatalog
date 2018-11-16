namespace TestWF
{
    partial class AddForm
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
            this.labelProducer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxProducer = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.comboBoxMark = new System.Windows.Forms.ComboBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.numericUpDownDate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCost = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMileage = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProducer
            // 
            this.labelProducer.AutoSize = true;
            this.labelProducer.Location = new System.Drawing.Point(99, 35);
            this.labelProducer.Name = "labelProducer";
            this.labelProducer.Size = new System.Drawing.Size(66, 17);
            this.labelProducer.TabIndex = 0;
            this.labelProducer.Text = "Producer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mileage";
            // 
            // comboBoxProducer
            // 
            this.comboBoxProducer.FormattingEnabled = true;
            this.comboBoxProducer.Location = new System.Drawing.Point(76, 73);
            this.comboBoxProducer.Name = "comboBoxProducer";
            this.comboBoxProducer.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProducer.TabIndex = 7;
            this.comboBoxProducer.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducer_SelectedIndexChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(76, 580);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(120, 33);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // comboBoxMark
            // 
            this.comboBoxMark.FormattingEnabled = true;
            this.comboBoxMark.Items.AddRange(new object[] {
            "818"});
            this.comboBoxMark.Location = new System.Drawing.Point(76, 149);
            this.comboBoxMark.Name = "comboBoxMark";
            this.comboBoxMark.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMark.TabIndex = 11;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(76, 272);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(120, 22);
            this.textBoxColor.TabIndex = 13;
            this.textBoxColor.Text = "Black";
            // 
            // numericUpDownDate
            // 
            this.numericUpDownDate.Location = new System.Drawing.Point(76, 321);
            this.numericUpDownDate.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.numericUpDownDate.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.numericUpDownDate.Name = "numericUpDownDate";
            this.numericUpDownDate.Size = new System.Drawing.Size(121, 22);
            this.numericUpDownDate.TabIndex = 14;
            this.numericUpDownDate.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // numericUpDownCost
            // 
            this.numericUpDownCost.Location = new System.Drawing.Point(76, 219);
            this.numericUpDownCost.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.numericUpDownCost.Name = "numericUpDownCost";
            this.numericUpDownCost.Size = new System.Drawing.Size(121, 22);
            this.numericUpDownCost.TabIndex = 15;
            // 
            // numericUpDownMileage
            // 
            this.numericUpDownMileage.Location = new System.Drawing.Point(76, 366);
            this.numericUpDownMileage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMileage.Name = "numericUpDownMileage";
            this.numericUpDownMileage.Size = new System.Drawing.Size(121, 22);
            this.numericUpDownMileage.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 459);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 115);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(76, 422);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(120, 31);
            this.openButton.TabIndex = 18;
            this.openButton.Text = "LoadImage";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 615);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericUpDownMileage);
            this.Controls.Add(this.numericUpDownCost);
            this.Controls.Add(this.numericUpDownDate);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.comboBoxMark);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.comboBoxProducer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProducer);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProducer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxProducer;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox comboBoxMark;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.NumericUpDown numericUpDownDate;
        private System.Windows.Forms.NumericUpDown numericUpDownCost;
        private System.Windows.Forms.NumericUpDown numericUpDownMileage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button openButton;
    }
}