namespace my2048
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.pictureBox_Board = new System.Windows.Forms.PictureBox();
            this.label_best = new System.Windows.Forms.Label();
            this.label_bestScore = new System.Windows.Forms.Label();
            this.label_current = new System.Windows.Forms.Label();
            this.label_currentScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Board)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Board
            // 
            this.pictureBox_Board.Location = new System.Drawing.Point(24, 122);
            this.pictureBox_Board.Name = "pictureBox_Board";
            this.pictureBox_Board.Size = new System.Drawing.Size(400, 400);
            this.pictureBox_Board.TabIndex = 0;
            this.pictureBox_Board.TabStop = false;
            this.pictureBox_Board.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Board_Paint);
            // 
            // label_best
            // 
            this.label_best.BackColor = System.Drawing.Color.Gray;
            this.label_best.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_best.ForeColor = System.Drawing.Color.White;
            this.label_best.Location = new System.Drawing.Point(324, 16);
            this.label_best.Name = "label_best";
            this.label_best.Size = new System.Drawing.Size(123, 30);
            this.label_best.TabIndex = 1;
            this.label_best.Text = "BEST";
            this.label_best.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_bestScore
            // 
            this.label_bestScore.BackColor = System.Drawing.Color.Gray;
            this.label_bestScore.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_bestScore.ForeColor = System.Drawing.Color.White;
            this.label_bestScore.Location = new System.Drawing.Point(324, 46);
            this.label_bestScore.Name = "label_bestScore";
            this.label_bestScore.Size = new System.Drawing.Size(123, 38);
            this.label_bestScore.TabIndex = 2;
            this.label_bestScore.Text = "0";
            this.label_bestScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_current
            // 
            this.label_current.BackColor = System.Drawing.Color.Gray;
            this.label_current.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_current.ForeColor = System.Drawing.Color.White;
            this.label_current.Location = new System.Drawing.Point(185, 16);
            this.label_current.Name = "label_current";
            this.label_current.Size = new System.Drawing.Size(139, 30);
            this.label_current.TabIndex = 3;
            this.label_current.Text = "SCORE";
            this.label_current.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_currentScore
            // 
            this.label_currentScore.BackColor = System.Drawing.Color.Gray;
            this.label_currentScore.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_currentScore.ForeColor = System.Drawing.Color.White;
            this.label_currentScore.Location = new System.Drawing.Point(185, 46);
            this.label_currentScore.Name = "label_currentScore";
            this.label_currentScore.Size = new System.Drawing.Size(141, 38);
            this.label_currentScore.TabIndex = 4;
            this.label_currentScore.Text = "0";
            this.label_currentScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(13, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 64);
            this.label3.TabIndex = 7;
            this.label3.Text = "2048";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(316, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "按F1打开帮助";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 545);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_currentScore);
            this.Controls.Add(this.label_current);
            this.Controls.Add(this.label_bestScore);
            this.Controls.Add(this.label_best);
            this.Controls.Add(this.pictureBox_Board);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(446, 545);
            this.MinimumSize = new System.Drawing.Size(446, 545);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Board;
        private System.Windows.Forms.Label label_best;
        private System.Windows.Forms.Label label_bestScore;
        private System.Windows.Forms.Label label_current;
        private System.Windows.Forms.Label label_currentScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}

