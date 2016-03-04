namespace SnakeGame
{
    partial class SettingsForm
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
            this.lblSelectBG = new System.Windows.Forms.Label();
            this.btnBlackBG = new System.Windows.Forms.Button();
            this.lblBlackBG = new System.Windows.Forms.Label();
            this.btnLightBlueBG = new System.Windows.Forms.Button();
            this.lblLightBlueBG = new System.Windows.Forms.Label();
            this.btnIndigoBG = new System.Windows.Forms.Button();
            this.lblIndigoBG = new System.Windows.Forms.Label();
            this.btnDarkKhakiBG = new System.Windows.Forms.Button();
            this.lblDarkKhakiBG = new System.Windows.Forms.Label();
            this.checkboxStopSoundtrack = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblSelectBG
            // 
            this.lblSelectBG.AutoSize = true;
            this.lblSelectBG.Location = new System.Drawing.Point(12, 9);
            this.lblSelectBG.Name = "lblSelectBG";
            this.lblSelectBG.Size = new System.Drawing.Size(165, 13);
            this.lblSelectBG.TabIndex = 0;
            this.lblSelectBG.Text = "Select a color for the background";
            // 
            // btnBlackBG
            // 
            this.btnBlackBG.BackColor = System.Drawing.Color.Black;
            this.btnBlackBG.Location = new System.Drawing.Point(15, 35);
            this.btnBlackBG.Name = "btnBlackBG";
            this.btnBlackBG.Size = new System.Drawing.Size(56, 55);
            this.btnBlackBG.TabIndex = 1;
            this.btnBlackBG.TabStop = false;
            this.btnBlackBG.UseVisualStyleBackColor = false;
            this.btnBlackBG.Click += new System.EventHandler(this.btnBlackBG_Click);
            // 
            // lblBlackBG
            // 
            this.lblBlackBG.AutoSize = true;
            this.lblBlackBG.Location = new System.Drawing.Point(24, 93);
            this.lblBlackBG.Name = "lblBlackBG";
            this.lblBlackBG.Size = new System.Drawing.Size(34, 13);
            this.lblBlackBG.TabIndex = 2;
            this.lblBlackBG.Text = "Black";
            // 
            // btnLightBlueBG
            // 
            this.btnLightBlueBG.BackColor = System.Drawing.Color.LightBlue;
            this.btnLightBlueBG.Location = new System.Drawing.Point(93, 35);
            this.btnLightBlueBG.Name = "btnLightBlueBG";
            this.btnLightBlueBG.Size = new System.Drawing.Size(56, 55);
            this.btnLightBlueBG.TabIndex = 3;
            this.btnLightBlueBG.TabStop = false;
            this.btnLightBlueBG.UseVisualStyleBackColor = false;
            this.btnLightBlueBG.Click += new System.EventHandler(this.btnLightBlueBG_Click);
            // 
            // lblLightBlueBG
            // 
            this.lblLightBlueBG.AutoSize = true;
            this.lblLightBlueBG.Location = new System.Drawing.Point(95, 93);
            this.lblLightBlueBG.Name = "lblLightBlueBG";
            this.lblLightBlueBG.Size = new System.Drawing.Size(54, 13);
            this.lblLightBlueBG.TabIndex = 4;
            this.lblLightBlueBG.Text = "Light Blue";
            // 
            // btnIndigoBG
            // 
            this.btnIndigoBG.BackColor = System.Drawing.Color.Indigo;
            this.btnIndigoBG.Location = new System.Drawing.Point(171, 35);
            this.btnIndigoBG.Name = "btnIndigoBG";
            this.btnIndigoBG.Size = new System.Drawing.Size(56, 55);
            this.btnIndigoBG.TabIndex = 5;
            this.btnIndigoBG.TabStop = false;
            this.btnIndigoBG.UseVisualStyleBackColor = false;
            this.btnIndigoBG.Click += new System.EventHandler(this.btnIndigoBG_Click);
            // 
            // lblIndigoBG
            // 
            this.lblIndigoBG.AutoSize = true;
            this.lblIndigoBG.Location = new System.Drawing.Point(181, 93);
            this.lblIndigoBG.Name = "lblIndigoBG";
            this.lblIndigoBG.Size = new System.Drawing.Size(36, 13);
            this.lblIndigoBG.TabIndex = 6;
            this.lblIndigoBG.Text = "Indigo";
            // 
            // btnDarkKhakiBG
            // 
            this.btnDarkKhakiBG.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnDarkKhakiBG.Location = new System.Drawing.Point(249, 35);
            this.btnDarkKhakiBG.Name = "btnDarkKhakiBG";
            this.btnDarkKhakiBG.Size = new System.Drawing.Size(56, 55);
            this.btnDarkKhakiBG.TabIndex = 7;
            this.btnDarkKhakiBG.TabStop = false;
            this.btnDarkKhakiBG.UseVisualStyleBackColor = false;
            this.btnDarkKhakiBG.Click += new System.EventHandler(this.btnDarkKhakiBG_Click);
            // 
            // lblDarkKhakiBG
            // 
            this.lblDarkKhakiBG.AutoSize = true;
            this.lblDarkKhakiBG.Location = new System.Drawing.Point(246, 93);
            this.lblDarkKhakiBG.Name = "lblDarkKhakiBG";
            this.lblDarkKhakiBG.Size = new System.Drawing.Size(60, 13);
            this.lblDarkKhakiBG.TabIndex = 8;
            this.lblDarkKhakiBG.Text = "Dark Khaki";
            // 
            // checkboxStopSoundtrack
            // 
            this.checkboxStopSoundtrack.AutoSize = true;
            this.checkboxStopSoundtrack.Location = new System.Drawing.Point(15, 152);
            this.checkboxStopSoundtrack.Name = "checkboxStopSoundtrack";
            this.checkboxStopSoundtrack.Size = new System.Drawing.Size(119, 17);
            this.checkboxStopSoundtrack.TabIndex = 9;
            this.checkboxStopSoundtrack.Text = "Disable Soundtrack";
            this.checkboxStopSoundtrack.UseVisualStyleBackColor = true;
            this.checkboxStopSoundtrack.CheckedChanged += new System.EventHandler(this.checkboxStopSoundtrack_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 240);
            this.Controls.Add(this.checkboxStopSoundtrack);
            this.Controls.Add(this.lblDarkKhakiBG);
            this.Controls.Add(this.btnDarkKhakiBG);
            this.Controls.Add(this.lblIndigoBG);
            this.Controls.Add(this.btnIndigoBG);
            this.Controls.Add(this.lblLightBlueBG);
            this.Controls.Add(this.btnLightBlueBG);
            this.Controls.Add(this.lblBlackBG);
            this.Controls.Add(this.btnBlackBG);
            this.Controls.Add(this.lblSelectBG);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectBG;
        private System.Windows.Forms.Button btnBlackBG;
        private System.Windows.Forms.Label lblBlackBG;
        private System.Windows.Forms.Button btnLightBlueBG;
        private System.Windows.Forms.Label lblLightBlueBG;
        private System.Windows.Forms.Button btnIndigoBG;
        private System.Windows.Forms.Label lblIndigoBG;
        private System.Windows.Forms.Button btnDarkKhakiBG;
        private System.Windows.Forms.Label lblDarkKhakiBG;
        private System.Windows.Forms.CheckBox checkboxStopSoundtrack;
    }
}