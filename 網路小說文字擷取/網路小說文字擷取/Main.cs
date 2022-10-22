using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 網路小說文字擷取
{
    public partial class Main : Form
    {
        private List<string> chapterList = new List<string>();
        private int index = 0;
        public Main()
        {
            InitializeComponent();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel.LinkVisited = true;
            // 導向該網址
            System.Diagnostics.Process.Start("https://www.novel543.com/");
        }
        private void Search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(URL.Text))
            {
                chapterList.Clear();
                if (TwentyChapter.Checked)
                {
                    #region 網址分割
                    int sUrlPos = URL.Text.LastIndexOf("/");
                    int eUrlPos = URL.Text.LastIndexOf(".");
                    string preUrl = URL.Text.Substring(0, sUrlPos + 1);
                    string extension = URL.Text.Substring(eUrlPos, (URL.Text.Length - eUrlPos));
                    string postUrl = URL.Text.Replace(preUrl, "").Replace(extension, "");
                    string temp = string.Empty;
                    int No = 0;
                    //處理23213_1234 與 12394238 字串
                    for (var i = postUrl.Length - 1; i >= 0; i--)
                    {
                        if (Char.IsDigit(postUrl[i]))
                        {
                            temp += postUrl[i];
                        }
                        else
                        {
                            preUrl += postUrl.Substring(0, i + 1);
                            No = Convert.ToInt32(new string(temp.Reverse().ToArray()));
                            break;
                        }
                        if (i == 0) 
                        {
                            No = Convert.ToInt32(postUrl);
                        }
                    }
                    #endregion
                    for (var i = 0; i < 20; i++)
                    {
                        string chapter = GetOneNovelChapter(preUrl + (No + i) + extension);
                        if (chapter != string.Empty) 
                        {
                            chapterList.Add(chapter);
                        }
                        Thread.Sleep(100);
                    }
                }
                else
                {
                    chapterList.Add(GetOneNovelChapter(URL.Text));
                }
                Result.Text = chapterList[0];
                index = 0;
            }
        }

        private string GetOneNovelChapter(string url)
        {
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(url);

            var getContent = htmlDoc.GetElementbyId("text-content");
            if (getContent == null)
            {
                return string.Empty;
            }
            var title = htmlDoc.DocumentNode.Descendants("h1").First().InnerText;
            var node = getContent.OuterHtml;

            #region Regular Expression
            var reg = "[\u4e00-\u9fa5\u3002\uff1f\uff01\uff0c\u3001\uff1b\uff1a\u201c\u201d\u2018\u2019\uff08\uff09\u300a\u300b\u3008\u3009\u3010\u3011\u300e\u300f\u300c\u300d\u3014\u3015\u2026\u2014\uff5e]";
            var matches = Regex.Matches(node, reg, RegexOptions.IgnoreCase);
            string result = title + "。" + Environment.NewLine;
            foreach (Match match in matches)
            {
                result += match.Value;
                if (match.Value == "。")
                    result += Environment.NewLine;
            }
            #endregion 
            return result;
        }

        private void Export_Click(object sender, EventArgs e)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StreamWriter sw = new StreamWriter(desktop + "/Novel.html");
            foreach (var ch in chapterList) 
            {
                var oneChapterLines = ch.Split('。');
                var title = oneChapterLines[0];
                sw.WriteLine("<h1 style=\"text-align:center\">" + title + "</h1>");
                var chs = string.Join("。<br>", oneChapterLines.Where(c => c != title));
                sw.WriteLine(chs);
            }
            sw.Close();
            MessageBox.Show("文章內容已匯出至桌面Html格式檔案");
        }

        private void Voice_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Result.Text)) 
            {
                string ex = Result.Text;
                var synthesizer = new SpeechSynthesizer();
                //synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, new CultureInfo("zh-TW"));
                synthesizer.SetOutputToDefaultAudioDevice();
                synthesizer.SpeakAsync(ex);
            }
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (chapterList.Count > 0 && index > 0) 
            {
                index--;
                Result.Text = chapterList[index];
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (chapterList.Count > 0 && index < chapterList.Count-1)
            {
                index++;
                Result.Text = chapterList[index];
            }
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Result.Text)) 
            {
                chapterList.Clear();
            }else if (chapterList.Count == 0) 
            {
                chapterList.Add(Result.Text);
            }
        }

        private void 小說搜尋ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovelSearch ns = new NovelSearch();
            ns.Show();
        }
    }
}
