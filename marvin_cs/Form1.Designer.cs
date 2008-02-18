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
            this.txtSensor.Location = new System.Drawing.Point(12, 290);
            this.txtSensor.Multiline = true;
            this.txtSensor.Name = "txtSensor";
            this.txtSensor.Size = new System.Drawing.Size(463, 92);
            this.txtSensor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 394);
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
    }
}

