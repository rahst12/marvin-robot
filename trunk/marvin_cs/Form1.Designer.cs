namespace Marvin_cs
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
            this.btTurn = new System.Windows.Forms.Button();
            this.btForward = new System.Windows.Forms.Button();
            this.txtSensor = new System.Windows.Forms.TextBox();
            this.lbFrontSide = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btTurn
            // 
            this.btTurn.Location = new System.Drawing.Point(320, 58);
            this.btTurn.Name = "btTurn";
            this.btTurn.Size = new System.Drawing.Size(75, 23);
            this.btTurn.TabIndex = 0;
            this.btTurn.Text = "Turn Left";
            this.btTurn.UseVisualStyleBackColor = true;
            this.btTurn.Click += new System.EventHandler(this.btTurn_Click);
            // 
            // btForward
            // 
            this.btForward.Location = new System.Drawing.Point(135, 47);
            this.btForward.Name = "btForward";
            this.btForward.Size = new System.Drawing.Size(75, 23);
            this.btForward.TabIndex = 1;
            this.btForward.Text = "Forward";
            this.btForward.UseVisualStyleBackColor = true;
            this.btForward.Click += new System.EventHandler(this.btForward_Click);
            // 
            // txtSensor
            // 
            this.txtSensor.Location = new System.Drawing.Point(12, 389);
            this.txtSensor.Multiline = true;
            this.txtSensor.Name = "txtSensor";
            this.txtSensor.Size = new System.Drawing.Size(129, 103);
            this.txtSensor.TabIndex = 2;
            // 
            // lbFrontSide
            // 
            this.lbFrontSide.AutoSize = true;
            this.lbFrontSide.Location = new System.Drawing.Point(9, 373);
            this.lbFrontSide.Name = "lbFrontSide";
            this.lbFrontSide.Size = new System.Drawing.Size(92, 13);
            this.lbFrontSide.TabIndex = 3;
            this.lbFrontSide.Text = "Parallel Front Side";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Parallel Back Side";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 389);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 103);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parallel Front Side";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(302, 389);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 103);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Parallel Front Side";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(447, 389);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 103);
            this.textBox3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Parallel Front Side";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(591, 389);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 103);
            this.textBox4.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 631);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbFrontSide);
            this.Controls.Add(this.txtSensor);
            this.Controls.Add(this.btForward);
            this.Controls.Add(this.btTurn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTurn;
        private System.Windows.Forms.Button btForward;
        private System.Windows.Forms.TextBox txtSensor;
        private System.Windows.Forms.Label lbFrontSide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
    }
}

