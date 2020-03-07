namespace Taxi
{
    partial class Cars
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFamily = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSername = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFamilyDel = new System.Windows.Forms.TextBox();
            this.textBoxNameDel = new System.Windows.Forms.TextBox();
            this.textBoxSernameDel = new System.Windows.Forms.TextBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(37, 47);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(548, 158);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Форма для добавления водителя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "В данной таблице имеется список всех водителей маршрутных такси";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Отчество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Форма для удаления водителя";
            // 
            // textBoxFamily
            // 
            this.textBoxFamily.Location = new System.Drawing.Point(246, 284);
            this.textBoxFamily.Name = "textBoxFamily";
            this.textBoxFamily.Size = new System.Drawing.Size(100, 20);
            this.textBoxFamily.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(246, 326);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxSername
            // 
            this.textBoxSername.Location = new System.Drawing.Point(246, 372);
            this.textBoxSername.Name = "textBoxSername";
            this.textBoxSername.Size = new System.Drawing.Size(100, 20);
            this.textBoxSername.TabIndex = 9;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(246, 428);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 44);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Добавить водителя";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Фамилия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Имя";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Отчество";
            // 
            // textBoxFamilyDel
            // 
            this.textBoxFamilyDel.Location = new System.Drawing.Point(506, 284);
            this.textBoxFamilyDel.Name = "textBoxFamilyDel";
            this.textBoxFamilyDel.Size = new System.Drawing.Size(100, 20);
            this.textBoxFamilyDel.TabIndex = 7;
            // 
            // textBoxNameDel
            // 
            this.textBoxNameDel.Location = new System.Drawing.Point(506, 326);
            this.textBoxNameDel.Name = "textBoxNameDel";
            this.textBoxNameDel.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameDel.TabIndex = 8;
            // 
            // textBoxSernameDel
            // 
            this.textBoxSernameDel.Location = new System.Drawing.Point(506, 372);
            this.textBoxSernameDel.Name = "textBoxSernameDel";
            this.textBoxSernameDel.Size = new System.Drawing.Size(100, 20);
            this.textBoxSernameDel.TabIndex = 9;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(506, 428);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(96, 44);
            this.buttonDel.TabIndex = 10;
            this.buttonDel.Text = "Удалить водителя";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Дата получения прав";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(7, 310);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 14;
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(723, 492);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSernameDel);
            this.Controls.Add(this.textBoxSername);
            this.Controls.Add(this.textBoxNameDel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxFamilyDel);
            this.Controls.Add(this.textBoxFamily);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.MaximizeBox = false;
            this.Name = "Cars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFamily;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSername;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFamilyDel;
        private System.Windows.Forms.TextBox textBoxNameDel;
        private System.Windows.Forms.TextBox textBoxSernameDel;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MonthCalendar monthCalendar;
    }
}