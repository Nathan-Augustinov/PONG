namespace atestatpong
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.gametimer1 = new System.Windows.Forms.Timer(this.components);
            this.scoretwo = new System.Windows.Forms.Label();
            this.scorestanga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Yellow;
            this.player1.Location = new System.Drawing.Point(12, 157);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(27, 110);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Red;
            this.player2.Location = new System.Drawing.Point(695, 157);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(27, 110);
            this.player2.TabIndex = 1;
            this.player2.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Black;
            this.ball.Location = new System.Drawing.Point(354, 199);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(25, 25);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // gametimer1
            // 
            this.gametimer1.Enabled = true;
            this.gametimer1.Interval = 20;
            this.gametimer1.Tick += new System.EventHandler(this.gametimer1_Tick);
            // 
            // scoretwo
            // 
            this.scoretwo.AutoSize = true;
            this.scoretwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretwo.ForeColor = System.Drawing.Color.Red;
            this.scoretwo.Location = new System.Drawing.Point(552, 34);
            this.scoretwo.Name = "scoretwo";
            this.scoretwo.Size = new System.Drawing.Size(32, 24);
            this.scoretwo.TabIndex = 4;
            this.scoretwo.Text = "00";
            // 
            // scorestanga
            // 
            this.scorestanga.AutoSize = true;
            this.scorestanga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorestanga.ForeColor = System.Drawing.Color.Yellow;
            this.scorestanga.Location = new System.Drawing.Point(150, 34);
            this.scorestanga.Name = "scorestanga";
            this.scorestanga.Size = new System.Drawing.Size(32, 24);
            this.scorestanga.TabIndex = 6;
            this.scorestanga.Text = "00";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.scorestanga);
            this.Controls.Add(this.scoretwo);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form6_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label scoretwo;
        private System.Windows.Forms.Label scorestanga;
        public System.Windows.Forms.Timer gametimer1;
    }
}