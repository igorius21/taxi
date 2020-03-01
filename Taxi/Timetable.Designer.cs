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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(27, 55);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(570, 197);
            this.dataGridView.TabIndex = 0;
            // 
            // textBoxIdRouter
            // 
            this.textBoxIdRouter.Location = new System.Drawing.Point(125, 306);
            this.textBoxIdRouter.Name = "textBoxIdRouter";
            this.textBoxIdRouter.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdRouter.TabIndex = 1;
            // 
            // textBoxIdTipeRouter
            // 
            this.textBoxIdTipeRouter.Location = new System.Drawing.Point(125, 356);
            this.textBoxIdTipeRouter.Name = "textBoxIdTipeRouter";
            this.textBoxIdTipeRouter.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdTipeRouter.TabIndex = 2;
            // 
            // textBoxIdStop
            // 
            this.textBoxIdStop.Location = new System.Drawing.Point(125, 406);
            this.textBoxIdStop.Name = "textBoxIdStop";
            this.textBoxIdStop.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdStop.TabIndex = 3;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(125, 450);
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
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 494);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxIdStop);
            this.Controls.Add(this.textBoxIdTipeRouter);
            this.Controls.Add(this.textBoxIdRouter);
            this.Controls.Add(this.dataGridView);
            this.Name = "Timetable";
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
    }
}