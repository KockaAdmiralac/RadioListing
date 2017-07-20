namespace Radio
{
    partial class Player
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
            this.playButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.playText = new System.Windows.Forms.Label();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.moveUpperLeft = new System.Windows.Forms.Button();
            this.moveLowerRight = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.currentlyPlaying = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(12, 12);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(77, 27);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(12, 46);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(77, 27);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // playText
            // 
            this.playText.AutoSize = true;
            this.playText.Location = new System.Drawing.Point(174, 6);
            this.playText.Name = "playText";
            this.playText.Size = new System.Drawing.Size(84, 13);
            this.playText.TabIndex = 3;
            this.playText.Text = "Currently playing";
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(98, 46);
            this.volumeBar.Maximum = 25;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(240, 45);
            this.volumeBar.TabIndex = 5;
            this.volumeBar.Value = 12;
            this.volumeBar.Scroll += new System.EventHandler(this.volumeBar_Scroll);
            // 
            // moveUpperLeft
            // 
            this.moveUpperLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moveUpperLeft.Location = new System.Drawing.Point(344, 36);
            this.moveUpperLeft.Name = "moveUpperLeft";
            this.moveUpperLeft.Size = new System.Drawing.Size(18, 21);
            this.moveUpperLeft.TabIndex = 6;
            this.moveUpperLeft.Text = "⟔";
            this.moveUpperLeft.UseVisualStyleBackColor = true;
            this.moveUpperLeft.Click += new System.EventHandler(this.moveUpperLeft_Click);
            // 
            // moveLowerRight
            // 
            this.moveLowerRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moveLowerRight.Location = new System.Drawing.Point(344, 63);
            this.moveLowerRight.Name = "moveLowerRight";
            this.moveLowerRight.Size = new System.Drawing.Size(18, 21);
            this.moveLowerRight.TabIndex = 7;
            this.moveLowerRight.Text = "⟓";
            this.moveLowerRight.UseVisualStyleBackColor = true;
            this.moveLowerRight.Click += new System.EventHandler(this.moveLowerRight_Click);
            // 
            // exit
            // 
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Location = new System.Drawing.Point(344, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(18, 21);
            this.exit.TabIndex = 8;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // currentlyPlaying
            // 
            this.currentlyPlaying.Enabled = false;
            this.currentlyPlaying.Location = new System.Drawing.Point(98, 22);
            this.currentlyPlaying.Name = "currentlyPlaying";
            this.currentlyPlaying.ReadOnly = true;
            this.currentlyPlaying.Size = new System.Drawing.Size(240, 20);
            this.currentlyPlaying.TabIndex = 9;
            this.currentlyPlaying.WordWrap = false;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 93);
            this.ControlBox = false;
            this.Controls.Add(this.currentlyPlaying);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.moveLowerRight);
            this.Controls.Add(this.moveUpperLeft);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.playText);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.playButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Player";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Player";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Label playText;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Button moveUpperLeft;
        private System.Windows.Forms.Button moveLowerRight;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox currentlyPlaying;
    }
}