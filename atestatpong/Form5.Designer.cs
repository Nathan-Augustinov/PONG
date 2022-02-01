namespace atestatpong
{
    partial class Form5
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
            this.player = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.cpu = new System.Windows.Forms.PictureBox();
            this.pscore = new System.Windows.Forms.Label();
            this.cpuscore = new System.Windows.Forms.Label();
            this.gametimer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Yellow;
            this.player.Location = new System.Drawing.Point(12, 167);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(27, 110);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Black;
            this.ball.Location = new System.Drawing.Point(343, 206);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(25, 25);
            this.ball.TabIndex = 3;
            this.ball.TabStop = false;
            // 
            // cpu
            // 
            this.cpu.BackColor = System.Drawing.Color.Red;
            this.cpu.Location = new System.Drawing.Point(695, 167);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(27, 110);
            this.cpu.TabIndex = 4;
            this.cpu.TabStop = false;
            // 
            // pscore
            // 
            this.pscore.AutoSize = true;
            this.pscore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pscore.ForeColor = System.Drawing.Color.Yellow;
            this.pscore.Location = new System.Drawing.Point(150, 24);
            this.pscore.Name = "pscore";
            this.pscore.Size = new System.Drawing.Size(32, 24);
            this.pscore.TabIndex = 5;
            this.pscore.Text = "00";
            // 
            // cpuscore
            // 
            this.cpuscore.AutoSize = true;
            this.cpuscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuscore.ForeColor = System.Drawing.Color.Red;
            this.cpuscore.Location = new System.Drawing.Point(525, 24);
            this.cpuscore.Name = "cpuscore";
            this.cpuscore.Size = new System.Drawing.Size(32, 24);
            this.cpuscore.TabIndex = 6;
            this.cpuscore.Text = "00";
            // 
            // gametimer1
            // 
            this.gametimer1.Enabled = true;
            this.gametimer1.Interval = 20;
            this.gametimer1.Tick += new System.EventHandler(this.gametimer1_Tick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.cpuscore);
            this.Controls.Add(this.pscore);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form5_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox cpu;
        private System.Windows.Forms.Label pscore;
        private System.Windows.Forms.Label cpuscore;
        public System.Windows.Forms.Timer gametimer1;
    }
}