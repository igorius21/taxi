namespace Taxi
{
    partial class NeedReaquest
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxCars = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRouter = new System.Windows.Forms.Button();
            this.textBoxRouter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Маршрутки, которые необходимо заменить ";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(30, 82);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 46);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxCars
            // 
            this.textBoxCars.Location = new System.Drawing.Point(302, 28);
            this.textBoxCars.Multiline = true;
            this.textBoxCars.Name = "textBoxCars";
            this.textBoxCars.Size = new System.Drawing.Size(132, 100);
            this.textBoxCars.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Самый длинный и самый короткий маршрут";
            // 
            // buttonRouter
            // 
            this.buttonRouter.Location = new System.Drawing.Point(33, 236);
            this.buttonRouter.Name = "buttonRouter";
            this.buttonRouter.Size = new System.Drawing.Size(91, 38);
            this.buttonRouter.TabIndex = 4;
            this.buttonRouter.Text = "Найти";
            this.buttonRouter.UseVisualStyleBackColor = true;
            this.buttonRouter.Click += new System.EventHandler(this.buttonRouter_Click);
            // 
            // textBoxRouter
            // 
            this.textBoxRouter.Location = new System.Drawing.Point(302, 214);
            this.textBoxRouter.Multiline = true;
            this.textBoxRouter.Name = "textBoxRouter";
            this.textBoxRouter.Size = new System.Drawing.Size(132, 70);
            this.textBoxRouter.TabIndex = 5;
            // 
            // NeedReaquest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 477);
            this.Controls.Add(this.textBoxRouter);
            this.Controls.Add(this.buttonRouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCars);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label1);
            this.Name = "NeedReaquest";
            this.Text = "NeedReaquest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxCars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRouter;
        private System.Windows.Forms.TextBox textBoxRouter;
    }
}