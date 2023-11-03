namespace maytinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.tb_KQ = new System.Windows.Forms.TextBox();
            this.Cộng = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết quả: ";
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(121, 101);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(100, 20);
            this.tb_a.TabIndex = 1;
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(121, 146);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(100, 20);
            this.tb_b.TabIndex = 1;
            // 
            // tb_KQ
            // 
            this.tb_KQ.Location = new System.Drawing.Point(121, 186);
            this.tb_KQ.Name = "tb_KQ";
            this.tb_KQ.Size = new System.Drawing.Size(100, 20);
            this.tb_KQ.TabIndex = 1;
            // 
            // Cộng
            // 
            this.Cộng.Location = new System.Drawing.Point(121, 270);
            this.Cộng.Name = "Cộng";
            this.Cộng.Size = new System.Drawing.Size(75, 23);
            this.Cộng.TabIndex = 2;
            this.Cộng.Text = "button1";
            this.Cộng.UseVisualStyleBackColor = true;
            this.Cộng.Click += new System.EventHandler(this.Cộng_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cộng);
            this.Controls.Add(this.tb_KQ);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.tb_a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.TextBox tb_KQ;
        private System.Windows.Forms.Button Cộng;
        private System.Windows.Forms.Button button1;
    }
}

