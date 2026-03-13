using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade05_sidebar_menu
{
    public partial class lblMenu : Form
    {
        bool menuExpand = false;
        public lblMenu()
        {
            InitializeComponent();
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                sidebar.Width -= 10;

                if (sidebar.Width == sidebar.MinimumSize.Width)
                {

                    menuExpand = false;
                    menuTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;

                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    menuExpand = true;
                    menuTransition.Stop();
                }
                
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
    }
}
