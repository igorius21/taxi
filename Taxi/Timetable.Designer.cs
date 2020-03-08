namespace Taxi
{
    partial class Timetable
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
            this.textBoxIdRouter = new System.Windows.Forms.TextBox();
            this.textBoxIdTipeRouter = new System.Windows.Forms.TextBox();
            this.textBoxIdStop = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Router = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Router,
            this.Type,
            this.Stop,
            this.Time});
            this.dataGridView.Location = new System.Drawing.Point(27, 55);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(438, 153);
            this.dataGridView.TabIndex = 0;
            // 
            // textBoxIdRouter
            // 
            this.textBoxIdRouter.Location = new System.Drawing.Point(172, 305);
            this.textBoxIdRouter.Name = "textBoxIdRouter";
            this.textBoxIdRouter.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdRouter.TabIndex = 1;
            // 
            // textBoxIdTipeRouter
            // 
            this.textBoxIdTipeRouter.Location = new System.Drawing.Point(172, 355);
            this.textBoxIdTipeRouter.Name = "textBoxIdTipeRouter";
            this.textBoxIdTipeRouter.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdTipeRouter.TabIndex = 2;
            // 
            // textBoxIdStop
            // 
            this.textBoxIdStop.Location = new System.Drawing.Point(172, 405);
            this.textBoxIdStop.Name = "textBoxIdStop";
            this.textBoxIdStop.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdStop.TabIndex = 3;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(172, 449);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxTime.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(299, 433);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(99, 40);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить запись";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Номер маршрута";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тип маршрута (1/2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "id остановки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Плановое время прибытия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Введите данные расписания для маршруток";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "(1 - прямой/ 2 - обратный)";
            // 
            // Router
            // 
            this.Router.HeaderText = "Router";
            this.Router.Name = "Router";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Stop
            // 
            this.Stop.HeaderText = "Stop";
            this.Stop.Name = "Stop";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 494);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxIdStop);
            this.Controls.Add(this.textBoxIdTipeRouter);
            this.Controls.Add(this.textBoxIdRouter);
            this.Controls.Add(this.dataGridView);
            this.MaximizeBox = false;
            this.Name = "Timetable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Timetable";
            this.Load += new System.EventHandler(this.Timetable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxIdRouter;
        private System.Windows.Forms.TextBox textBoxIdTipeRouter;
        private System.Windows.Forms.TextBox textBoxIdStop;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Router;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
    }
}