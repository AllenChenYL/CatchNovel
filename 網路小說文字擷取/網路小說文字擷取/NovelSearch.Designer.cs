
namespace 網路小說文字擷取
{
    partial class NovelSearch
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
            this.NovelNameLabel = new System.Windows.Forms.Label();
            this.NovelName = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NovelNameLabel
            // 
            this.NovelNameLabel.AutoSize = true;
            this.NovelNameLabel.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NovelNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(239)))), ((int)(((byte)(253)))));
            this.NovelNameLabel.Location = new System.Drawing.Point(12, 9);
            this.NovelNameLabel.Name = "NovelNameLabel";
            this.NovelNameLabel.Size = new System.Drawing.Size(110, 31);
            this.NovelNameLabel.TabIndex = 0;
            this.NovelNameLabel.Text = "小說名稱";
            // 
            // NovelName
            // 
            this.NovelName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NovelName.Location = new System.Drawing.Point(128, 6);
            this.NovelName.Name = "NovelName";
            this.NovelName.Size = new System.Drawing.Size(384, 34);
            this.NovelName.TabIndex = 1;
            this.NovelName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NovelName_KeyUp);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(204)))), ((int)(((byte)(251)))));
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Search.Location = new System.Drawing.Point(538, 6);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(108, 34);
            this.Search.TabIndex = 2;
            this.Search.Text = "搜尋";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // NovelSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(662, 50);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.NovelName);
            this.Controls.Add(this.NovelNameLabel);
            this.Name = "NovelSearch";
            this.Text = "小說搜尋";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NovelNameLabel;
        private System.Windows.Forms.TextBox NovelName;
        private System.Windows.Forms.Button Search;
    }
}