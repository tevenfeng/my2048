namespace my2048
{
    partial class my2048MessageBox
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
            this.panel_boarder = new System.Windows.Forms.Panel();
            this.textBox_messageInformation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_messageA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel_boarder
            // 
            this.panel_boarder.BackColor = System.Drawing.Color.SpringGreen;
            this.panel_boarder.Location = new System.Drawing.Point(0, 73);
            this.panel_boarder.Name = "panel_boarder";
            this.panel_boarder.Size = new System.Drawing.Size(340, 12);
            this.panel_boarder.TabIndex = 0;
            // 
            // textBox_messageInformation
            // 
            this.textBox_messageInformation.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_messageInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_messageInformation.Enabled = false;
            this.textBox_messageInformation.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_messageInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_messageInformation.Location = new System.Drawing.Point(48, 108);
            this.textBox_messageInformation.Multiline = true;
            this.textBox_messageInformation.Name = "textBox_messageInformation";
            this.textBox_messageInformation.ReadOnly = true;
            this.textBox_messageInformation.Size = new System.Drawing.Size(245, 226);
            this.textBox_messageInformation.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(95, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "按回车键退出本界面";
            // 
            // label_messageA
            // 
            this.label_messageA.AutoSize = true;
            this.label_messageA.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_messageA.ForeColor = System.Drawing.Color.SkyBlue;
            this.label_messageA.Location = new System.Drawing.Point(41, 28);
            this.label_messageA.Name = "label_messageA";
            this.label_messageA.Size = new System.Drawing.Size(114, 42);
            this.label_messageA.TabIndex = 8;
            this.label_messageA.Text = "label1";
            // 
            // my2048MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(340, 360);
            this.Controls.Add(this.label_messageA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_messageInformation);
            this.Controls.Add(this.panel_boarder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(340, 360);
            this.MinimumSize = new System.Drawing.Size(340, 360);
            this.Name = "my2048MessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "my2048MessageBox";
            this.Load += new System.EventHandler(this.my2048MessageBox_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.my204MessageBox_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_boarder;
        private System.Windows.Forms.TextBox textBox_messageInformation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_messageA;
    }
}