
namespace 網路小說文字擷取
{
    partial class Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.URL = new System.Windows.Forms.TextBox();
            this.TwentyChapter = new System.Windows.Forms.CheckBox();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.Search = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.Voice = new System.Windows.Forms.Button();
            this.Prev = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小說搜尋ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(239)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "小說章節網址";
            // 
            // URL
            // 
            this.URL.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.URL.Location = new System.Drawing.Point(183, 42);
            this.URL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(353, 34);
            this.URL.TabIndex = 1;
            // 
            // TwentyChapter
            // 
            this.TwentyChapter.AutoSize = true;
            this.TwentyChapter.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TwentyChapter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(239)))), ((int)(((byte)(253)))));
            this.TwentyChapter.Location = new System.Drawing.Point(546, 43);
            this.TwentyChapter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TwentyChapter.Name = "TwentyChapter";
            this.TwentyChapter.Size = new System.Drawing.Size(183, 34);
            this.TwentyChapter.TabIndex = 2;
            this.TwentyChapter.Tag = "";
            this.TwentyChapter.Text = "一次擷取20回";
            this.TwentyChapter.UseVisualStyleBackColor = true;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("微軟正黑體", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabel.LinkColor = System.Drawing.Color.Cornsilk;
            this.linkLabel.Location = new System.Drawing.Point(105, 75);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(64, 18);
            this.linkLabel.TabIndex = 3;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "參考網址";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(204)))), ((int)(((byte)(251)))));
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Search.Location = new System.Drawing.Point(746, 41);
            this.Search.Margin = new System.Windows.Forms.Padding(0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(117, 38);
            this.Search.TabIndex = 4;
            this.Search.Text = "搜尋";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Export
            // 
            this.Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(204)))), ((int)(((byte)(251)))));
            this.Export.FlatAppearance.BorderSize = 0;
            this.Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Export.Location = new System.Drawing.Point(868, 41);
            this.Export.Margin = new System.Windows.Forms.Padding(0);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(117, 38);
            this.Export.TabIndex = 4;
            this.Export.Text = "匯出";
            this.Export.UseVisualStyleBackColor = false;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.Bisque;
            this.Result.Font = new System.Drawing.Font("宋体", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(19, 99);
            this.Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(1192, 695);
            this.Result.TabIndex = 5;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // Voice
            // 
            this.Voice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(204)))), ((int)(((byte)(251)))));
            this.Voice.Cursor = System.Windows.Forms.Cursors.Default;
            this.Voice.FlatAppearance.BorderSize = 0;
            this.Voice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Voice.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Voice.Location = new System.Drawing.Point(991, 41);
            this.Voice.Margin = new System.Windows.Forms.Padding(0);
            this.Voice.Name = "Voice";
            this.Voice.Size = new System.Drawing.Size(117, 38);
            this.Voice.TabIndex = 4;
            this.Voice.Text = "語音";
            this.Voice.UseVisualStyleBackColor = false;
            this.Voice.Click += new System.EventHandler(this.Voice_Click);
            // 
            // Prev
            // 
            this.Prev.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Prev.Location = new System.Drawing.Point(1126, 41);
            this.Prev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(40, 38);
            this.Prev.TabIndex = 6;
            this.Prev.Text = "◀";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Next.Location = new System.Drawing.Point(1171, 41);
            this.Next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(40, 38);
            this.Next.TabIndex = 6;
            this.Next.Text = "▶";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.功能ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1231, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 功能ToolStripMenuItem
            // 
            this.功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.小說搜尋ToolStripMenuItem});
            this.功能ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            this.功能ToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.功能ToolStripMenuItem.Text = "功能";
            // 
            // 小說搜尋ToolStripMenuItem
            // 
            this.小說搜尋ToolStripMenuItem.Name = "小說搜尋ToolStripMenuItem";
            this.小說搜尋ToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.小說搜尋ToolStripMenuItem.Text = "小說搜尋";
            this.小說搜尋ToolStripMenuItem.Click += new System.EventHandler(this.小說搜尋ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1231, 845);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Voice);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.TwentyChapter);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "小說";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.CheckBox TwentyChapter;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Voice;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小說搜尋ToolStripMenuItem;
    }
}

