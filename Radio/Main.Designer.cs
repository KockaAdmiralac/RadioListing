namespace Radio
{
    partial class Main
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
            this.fetch = new System.Windows.Forms.Button();
            this.filterOption = new System.Windows.Forms.ComboBox();
            this.text = new System.Windows.Forms.TextBox();
            this.genreSelect = new System.Windows.Forms.ComboBox();
            this.stationList = new System.Windows.Forms.ListBox();
            this.additionalEnable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // fetch
            // 
            this.fetch.Location = new System.Drawing.Point(12, 68);
            this.fetch.Name = "fetch";
            this.fetch.Size = new System.Drawing.Size(114, 20);
            this.fetch.TabIndex = 0;
            this.fetch.Text = "Fetch";
            this.fetch.UseVisualStyleBackColor = true;
            this.fetch.Click += new System.EventHandler(this.fetch_Click);
            // 
            // filterOption
            // 
            this.filterOption.FormattingEnabled = true;
            this.filterOption.Items.AddRange(new object[] {
            "Top 500",
            "Random",
            "Genre",
            "Keyword",
            "Now Playing"});
            this.filterOption.Location = new System.Drawing.Point(12, 12);
            this.filterOption.Name = "filterOption";
            this.filterOption.Size = new System.Drawing.Size(114, 21);
            this.filterOption.TabIndex = 1;
            this.filterOption.SelectedIndexChanged += new System.EventHandler(this.filterOption_SelectedIndexChanged);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(34, 42);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(92, 20);
            this.text.TabIndex = 2;
            // 
            // genreSelect
            // 
            this.genreSelect.FormattingEnabled = true;
            this.genreSelect.Location = new System.Drawing.Point(33, 41);
            this.genreSelect.Name = "genreSelect";
            this.genreSelect.Size = new System.Drawing.Size(93, 21);
            this.genreSelect.TabIndex = 3;
            // 
            // stationList
            // 
            this.stationList.FormattingEnabled = true;
            this.stationList.Location = new System.Drawing.Point(132, 6);
            this.stationList.Name = "stationList";
            this.stationList.Size = new System.Drawing.Size(202, 82);
            this.stationList.TabIndex = 4;
            this.stationList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.select);
            // 
            // additionalEnable
            // 
            this.additionalEnable.AutoSize = true;
            this.additionalEnable.Location = new System.Drawing.Point(12, 44);
            this.additionalEnable.Name = "additionalEnable";
            this.additionalEnable.Size = new System.Drawing.Size(15, 14);
            this.additionalEnable.TabIndex = 5;
            this.additionalEnable.UseVisualStyleBackColor = true;
            this.additionalEnable.CheckedChanged += new System.EventHandler(this.additionalEnable_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 95);
            this.Controls.Add(this.additionalEnable);
            this.Controls.Add(this.stationList);
            this.Controls.Add(this.genreSelect);
            this.Controls.Add(this.text);
            this.Controls.Add(this.filterOption);
            this.Controls.Add(this.fetch);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Radio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fetch;
        private System.Windows.Forms.ComboBox filterOption;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.ComboBox genreSelect;
        private System.Windows.Forms.ListBox stationList;
        private System.Windows.Forms.CheckBox additionalEnable;
    }
}

