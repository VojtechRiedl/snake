namespace snake
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hrac1_timer = new System.Windows.Forms.Timer(this.components);
            this.hrac2_timer = new System.Windows.Forms.Timer(this.components);
            this.GameName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.single = new System.Windows.Forms.Timer(this.components);
            this.hra = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hrac1_timer
            // 
            this.hrac1_timer.Interval = 500;
            this.hrac1_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hrac2_timer
            // 
            this.hrac2_timer.Interval = 500;
            this.hrac2_timer.Tick += new System.EventHandler(this.hrac2_timer_Tick);
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameName.Location = new System.Drawing.Point(277, 9);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(214, 72);
            this.GameName.TabIndex = 0;
            this.GameName.Text = "Snake";
            this.GameName.Click += new System.EventHandler(this.GameName_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(486, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "2 players";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(164, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "1 player";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // single
            // 
            this.single.Interval = 500;
            this.single.Tick += new System.EventHandler(this.single_Tick);
            // 
            // hra
            // 
            this.hra.Interval = 10;
            this.hra.Tick += new System.EventHandler(this.hra_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(229, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 86);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GameName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer hrac1_timer;
        private System.Windows.Forms.Timer hrac2_timer;
        private Label GameName;
        private Button button2;
        private Button button1;
        private System.Windows.Forms.Timer single;
        private System.Windows.Forms.Timer hra;
        private Label label1;
    }
}