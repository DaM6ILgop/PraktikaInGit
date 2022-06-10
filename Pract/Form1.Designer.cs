
namespace Pract
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
            this.ButAddToList = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CheckGrants = new System.Windows.Forms.CheckBox();
            this.ButtWriteToFile = new System.Windows.Forms.Button();
            this.ButtReadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButAddToList
            // 
            this.ButAddToList.Location = new System.Drawing.Point(1069, 12);
            this.ButAddToList.Name = "ButAddToList";
            this.ButAddToList.Size = new System.Drawing.Size(144, 51);
            this.ButAddToList.TabIndex = 0;
            this.ButAddToList.Text = "AddToList";
            this.ButAddToList.UseVisualStyleBackColor = true;
            this.ButAddToList.Click += new System.EventHandler(this.ButAddToList_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1063, 453);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Фамилия";
            this.columnHeader1.Width = 134;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Отчество";
            this.columnHeader3.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Год рождения";
            this.columnHeader4.Width = 104;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Пол";
            this.columnHeader5.Width = 46;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Математика";
            this.columnHeader6.Width = 96;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Английский";
            this.columnHeader7.Width = 92;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Физика";
            this.columnHeader8.Width = 66;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Дискретка";
            this.columnHeader9.Width = 83;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Мат-логика";
            this.columnHeader10.Width = 96;
            // 
            // CheckGrants
            // 
            this.CheckGrants.AutoSize = true;
            this.CheckGrants.Location = new System.Drawing.Point(1093, 194);
            this.CheckGrants.Name = "CheckGrants";
            this.CheckGrants.Size = new System.Drawing.Size(120, 21);
            this.CheckGrants.TabIndex = 2;
            this.CheckGrants.Text = "Check_Grants";
            this.CheckGrants.UseVisualStyleBackColor = true;
            this.CheckGrants.CheckedChanged += new System.EventHandler(this.CheckGrants_CheckedChanged);
            // 
            // ButtWriteToFile
            // 
            this.ButtWriteToFile.Location = new System.Drawing.Point(1069, 69);
            this.ButtWriteToFile.Name = "ButtWriteToFile";
            this.ButtWriteToFile.Size = new System.Drawing.Size(144, 51);
            this.ButtWriteToFile.TabIndex = 3;
            this.ButtWriteToFile.Text = "WriteToFile";
            this.ButtWriteToFile.UseVisualStyleBackColor = true;
            this.ButtWriteToFile.Click += new System.EventHandler(this.ButtWriteToFile_Click);
            // 
            // ButtReadFile
            // 
            this.ButtReadFile.Location = new System.Drawing.Point(1069, 126);
            this.ButtReadFile.Name = "ButtReadFile";
            this.ButtReadFile.Size = new System.Drawing.Size(144, 51);
            this.ButtReadFile.TabIndex = 4;
            this.ButtReadFile.Text = "ReadFile";
            this.ButtReadFile.UseVisualStyleBackColor = true;
            this.ButtReadFile.Click += new System.EventHandler(this.ButtReadFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 450);
            this.Controls.Add(this.ButtReadFile);
            this.Controls.Add(this.ButtWriteToFile);
            this.Controls.Add(this.CheckGrants);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ButAddToList);
            this.Name = "Form1";
            this.Text = "LoadForm";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButAddToList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox CheckGrants;
        private System.Windows.Forms.Button ButtWriteToFile;
        private System.Windows.Forms.Button ButtReadFile;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}

