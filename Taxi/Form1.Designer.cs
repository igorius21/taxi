namespace Taxi
{
    partial class Form1
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
            this.buttonOwners = new System.Windows.Forms.Button();
            this.buttonCar = new System.Windows.Forms.Button();
            this.CarMashine = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timetable = new System.Windows.Forms.Button();
            this.buttonFixMashine = new System.Windows.Forms.Button();
            this.buttonReaquest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOwners
            // 
            this.buttonOwners.Location = new System.Drawing.Point(43, 48);
            this.buttonOwners.Name = "buttonOwners";
            this.buttonOwners.Size = new System.Drawing.Size(105, 56);
            this.buttonOwners.TabIndex = 0;
            this.buttonOwners.Text = "Владельцы";
            this.buttonOwners.UseVisualStyleBackColor = true;
            this.buttonOwners.Click += new System.EventHandler(this.buttonOwners_Click);
            // 
            // buttonCar
            // 
            this.buttonCar.Location = new System.Drawing.Point(226, 48);
            this.buttonCar.Name = "buttonCar";
            this.buttonCar.Size = new System.Drawing.Size(101, 56);
            this.buttonCar.TabIndex = 1;
            this.buttonCar.Text = "Водителя";
            this.buttonCar.UseVisualStyleBackColor = true;
            this.buttonCar.Click += new System.EventHandler(this.buttonCar_Click);
            // 
            // CarMashine
            // 
            this.CarMashine.Location = new System.Drawing.Point(401, 48);
            this.CarMashine.Name = "CarMashine";
            this.CarMashine.Size = new System.Drawing.Size(91, 56);
            this.CarMashine.TabIndex = 2;
            this.CarMashine.Text = "Маршрутные такси";
            this.CarMashine.UseVisualStyleBackColor = true;
            this.CarMashine.Click += new System.EventHandler(this.CarMashine_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(43, 167);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(105, 53);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Маршруты, остановки";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timetable
            // 
            this.timetable.Location = new System.Drawing.Point(226, 167);
            this.timetable.Name = "timetable";
            this.timetable.Size = new System.Drawing.Size(101, 53);
            this.timetable.TabIndex = 4;
            this.timetable.Text = "Расписание";
            this.timetable.UseVisualStyleBackColor = true;
            this.timetable.Click += new System.EventHandler(this.timetable_Click);
            // 
            // buttonFixMashine
            // 
            this.buttonFixMashine.Location = new System.Drawing.Point(401, 167);
            this.buttonFixMashine.Name = "buttonFixMashine";
            this.buttonFixMashine.Size = new System.Drawing.Size(91, 53);
            this.buttonFixMashine.TabIndex = 5;
            this.buttonFixMashine.Text = "Фиксация маршруток";
            this.buttonFixMashine.UseVisualStyleBackColor = true;
            this.buttonFixMashine.Click += new System.EventHandler(this.buttonFixMashine_Click);
            // 
            // buttonReaquest
            // 
            this.buttonReaquest.Location = new System.Drawing.Point(226, 279);
            this.buttonReaquest.Name = "buttonReaquest";
            this.buttonReaquest.Size = new System.Drawing.Size(101, 50);
            this.buttonReaquest.TabIndex = 6;
            this.buttonReaquest.Text = "Необходимые запросы";
            this.buttonReaquest.UseVisualStyleBackColor = true;
            this.buttonReaquest.Click += new System.EventHandler(this.buttonReaquest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(537, 394);
            this.Controls.Add(this.buttonReaquest);
            this.Controls.Add(this.buttonFixMashine);
            this.Controls.Add(this.timetable);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.CarMashine);
            this.Controls.Add(this.buttonCar);
            this.Controls.Add(this.buttonOwners);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOwners;
        private System.Windows.Forms.Button buttonCar;
        private System.Windows.Forms.Button CarMashine;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button timetable;
        private System.Windows.Forms.Button buttonFixMashine;
        private System.Windows.Forms.Button buttonReaquest;
    }
}

