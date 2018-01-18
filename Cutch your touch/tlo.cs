using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cutch_your_touch
{
    public partial class tlo : Form
    {
        public tlo()
        {
            InitializeComponent();
            this.Opacity = 0.1;

        }

        private int x;
        private int y;


        private void tlo_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            
        }

        private void tlo_MouseUp(object sender, MouseEventArgs e)
        {
            Hide();
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
            Screen.PrimaryScreen.Bounds.Height);
            Bitmap bitmap2 = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height,
            PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bitmap2 as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, bitmap2.Size);
            bitmap2.Save(@"C:\screen\screen" + Guid.NewGuid() + ".jpg", ImageFormat.Jpeg);
            glowna nowaGlowna=new glowna();
            nowaGlowna.podazscreen(bitmap);
            nowaGlowna.Show();
            Close();
        }

        private void tlo_MouseMove(object sender, MouseEventArgs e)
        {
            
        }


    }
}
