using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cutch_your_touch
{
    public partial class glowna : Form
    {
        public glowna()
        {
            InitializeComponent();
        }

        public void podazscreen(Bitmap screenoty)
        {
            podglad.Image = screenoty;
        }
      



        private void przyciskScreen_MouseDown(object sender, MouseEventArgs e)
        {
            tlo tło=new tlo();
            tło.Show();
            tło.WindowState= FormWindowState.Maximized;
            tło.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Hide();
        }
    }
}
