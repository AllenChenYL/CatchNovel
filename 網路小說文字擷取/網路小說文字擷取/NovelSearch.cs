using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 網路小說文字擷取
{
    public partial class NovelSearch : Form
    {
        public NovelSearch()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string novelName = "https://www.novel543.com/search/" + NovelName.Text;
            System.Diagnostics.Process.Start(novelName);

            this.Close();
        }


        private void NovelName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search_Click(this, null);
            }
        }
    }
}
