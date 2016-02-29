namespace SnakeGame
{
    partial class GameWindow
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
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.radioBtnGroupBox = new System.Windows.Forms.GroupBox();
            this.radioBtnHard = new System.Windows.Forms.RadioButton();
            this.radioBtnMedium = new System.Windows.Forms.RadioButton();
            this.radioBtnEasy = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.radioBtnGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.LightBlue;
            this.pbCanvas.Location = new System.Drawing.Point(12, 5);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(793, 407);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(5, 549);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(118, 37);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: ";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(340, 450);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(130, 40);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.TabStop = false;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblGameOver
            // 
            this.lblGameOver.BackColor = System.Drawing.Color.LightBlue;
            this.lblGameOver.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGameOver.Location = new System.Drawing.Point(236, 45);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(372, 202);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGameOver.Visible = false;
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplier.Location = new System.Drawing.Point(5, 512);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(0, 37);
            this.lblMultiplier.TabIndex = 4;
            // 
            // radioBtnGroupBox
            // 
            this.radioBtnGroupBox.Controls.Add(this.radioBtnHard);
            this.radioBtnGroupBox.Controls.Add(this.radioBtnMedium);
            this.radioBtnGroupBox.Controls.Add(this.radioBtnEasy);
            this.radioBtnGroupBox.Enabled = false;
            this.radioBtnGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnGroupBox.Location = new System.Drawing.Point(304, 502);
            this.radioBtnGroupBox.Name = "radioBtnGroupBox";
            this.radioBtnGroupBox.Size = new System.Drawing.Size(200, 100);
            this.radioBtnGroupBox.TabIndex = 5;
            this.radioBtnGroupBox.TabStop = false;
            this.radioBtnGroupBox.Text = "Select difficulty:";
            // 
            // radioBtnHard
            // 
            this.radioBtnHard.AutoSize = true;
            this.radioBtnHard.Location = new System.Drawing.Point(0, 75);
            this.radioBtnHard.Name = "radioBtnHard";
            this.radioBtnHard.Size = new System.Drawing.Size(58, 23);
            this.radioBtnHard.TabIndex = 7;
            this.radioBtnHard.Text = "Hard";
            this.radioBtnHard.UseVisualStyleBackColor = true;
            this.radioBtnHard.CheckedChanged += new System.EventHandler(this.radioBtnHard_CheckedChanged);
            // 
            // radioBtnMedium
            // 
            this.radioBtnMedium.AutoSize = true;
            this.radioBtnMedium.Checked = true;
            this.radioBtnMedium.Location = new System.Drawing.Point(0, 52);
            this.radioBtnMedium.Name = "radioBtnMedium";
            this.radioBtnMedium.Size = new System.Drawing.Size(77, 23);
            this.radioBtnMedium.TabIndex = 6;
            this.radioBtnMedium.TabStop = true;
            this.radioBtnMedium.Text = "Medium";
            this.radioBtnMedium.UseVisualStyleBackColor = true;
            this.radioBtnMedium.CheckedChanged += new System.EventHandler(this.radioBtnMedium_CheckedChanged);
            // 
            // radioBtnEasy
            // 
            this.radioBtnEasy.AutoSize = true;
            this.radioBtnEasy.Location = new System.Drawing.Point(0, 29);
            this.radioBtnEasy.Name = "radioBtnEasy";
            this.radioBtnEasy.Size = new System.Drawing.Size(56, 23);
            this.radioBtnEasy.TabIndex = 0;
            this.radioBtnEasy.Text = "Easy";
            this.radioBtnEasy.UseVisualStyleBackColor = true;
            this.radioBtnEasy.CheckedChanged += new System.EventHandler(this.radioBtnEasy_CheckedChanged);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 614);
            this.Controls.Add(this.radioBtnGroupBox);
            this.Controls.Add(this.lblMultiplier);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbCanvas);
            this.Name = "GameWindow";
            this.Text = "Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpdateScreen);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameWindow_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.radioBtnGroupBox.ResumeLayout(false);
            this.radioBtnGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblMultiplier;
        private System.Windows.Forms.GroupBox radioBtnGroupBox;
        private System.Windows.Forms.RadioButton radioBtnHard;
        private System.Windows.Forms.RadioButton radioBtnMedium;
        private System.Windows.Forms.RadioButton radioBtnEasy;
    }
}

