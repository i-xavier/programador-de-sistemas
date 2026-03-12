using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sideBar
{
    public partial class frmMenu : Form
    {
        bool sidebarExpand;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;

                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
                else
                {
                    sidebar.Width += 10;
                    if(sidebar.Width == sidebar.MaximumSize.Width)
                    {
                        sidebarExpand = true;
                        sidebarTimer.Stop();
                    }
                }
            }
        }

        private void menuBotao_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
    }
}
