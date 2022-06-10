
namespace Pract
{
    partial class Form2
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
            this.BoxLastName = new System.Windows.Forms.TextBox();
            this.BoxDateOfRelease = new System.Windows.Forms.TextBox();
            this.BoxFatherName = new System.Windows.Forms.TextBox();
            this.BoxName = new System.Windows.Forms.TextBox();
            this.OpenLoadForm = new System.Windows.Forms.Button();
            this.BoxSexMarker = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BoxLastName
            // 
            this.BoxLastName.Location = new System.Drawing.Point(657, 26);
            this.BoxLastName.Multiline = true;
            this.BoxLastName.Name = "BoxLastName";
            this.BoxLastName.Size = new System.Drawing.Size(171, 25);
            this.BoxLastName.TabIndex = 0;
            // 
            // BoxDateOfRelease
            // 
            this.BoxDateOfRelease.Location = new System.Drawing.Point(84, 25);
            this.BoxDateOfRelease.Multiline = true;
            this.BoxDateOfRelease.Name = "BoxDateOfRelease";
            this.BoxDateOfRelease.Size = new System.Drawing.Size(171, 25);
            this.BoxDateOfRelease.TabIndex = 3;
            // 
            // BoxFatherName
            // 
            this.BoxFatherName.Location = new System.Drawing.Point(275, 25);
            this.BoxFatherName.Multiline = true;
            this.BoxFatherName.Name = "BoxFatherName";
            this.BoxFatherName.Size = new System.Drawing.Size(171, 25);
            this.BoxFatherName.TabIndex = 4;
            // 
            // BoxName
            // 
            this.BoxName.Location = new System.Drawing.Point(467, 26);
            this.BoxName.Multiline = true;
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(171, 25);
            this.BoxName.TabIndex = 5;
            // 
            // OpenLoadForm
            // 
            this.OpenLoadForm.Location = new System.Drawing.Point(381, 353);
            this.OpenLoadForm.Name = "OpenLoadForm";
            this.OpenLoadForm.Size = new System.Drawing.Size(217, 46);
            this.OpenLoadForm.TabIndex = 6;
            this.OpenLoadForm.Text = "LoadForm";
            this.OpenLoadForm.UseVisualStyleBackColor = true;
            this.OpenLoadForm.Click += new System.EventHandler(this.OpenLoadForm_Click);
            // 
            // BoxSexMarker
            // 
            this.BoxSexMarker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxSexMarker.FormattingEnabled = true;
            this.BoxSexMarker.Items.AddRange(new object[] {
            "Муж",
            "Жен"});
            this.BoxSexMarker.Location = new System.Drawing.Point(853, 26);
            this.BoxSexMarker.Name = "BoxSexMarker";
            this.BoxSexMarker.Size = new System.Drawing.Size(76, 24);
            this.BoxSexMarker.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(836, 205);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox2.Location = new System.Drawing.Point(647, 205);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(171, 24);
            this.comboBox2.TabIndex = 9;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox3.Location = new System.Drawing.Point(467, 205);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(159, 24);
            this.comboBox3.TabIndex = 10;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox4.Location = new System.Drawing.Point(287, 205);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(159, 24);
            this.comboBox4.TabIndex = 11;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox5.Location = new System.Drawing.Point(109, 205);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(159, 24);
            this.comboBox5.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Оценки";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BoxSexMarker);
            this.Controls.Add(this.OpenLoadForm);
            this.Controls.Add(this.BoxName);
            this.Controls.Add(this.BoxFatherName);
            this.Controls.Add(this.BoxDateOfRelease);
            this.Controls.Add(this.BoxLastName);
            this.Name = "Form2";
            this.Text = "Form2";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxLastName;
        private System.Windows.Forms.TextBox BoxDateOfRelease;
        private System.Windows.Forms.TextBox BoxFatherName;
        private System.Windows.Forms.TextBox BoxName;
        private System.Windows.Forms.Button OpenLoadForm;
        private System.Windows.Forms.ComboBox BoxSexMarker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label1;
    }
}