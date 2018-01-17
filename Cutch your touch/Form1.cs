using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cutch_your_touch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
      

        private void przyciskScreen_MouseDown(object sender, MouseEventArgs e)
        {
            //Form.ActiveForm.Hide();
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                Screen.PrimaryScreen.Bounds.Height);
            Bitmap bitmap2=new Bitmap(Screen.AllScreens[0].Bounds.Width,Screen.AllScreens[0].Bounds.Height,PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bitmap2 as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, bitmap2.Size);
            podglad.Image = bitmap2;
            bitmap2.Save(@"C:\screen\screen" + Guid.NewGuid() + ".jpg", ImageFormat.Jpeg);
            
        }

        private void przyciskScreen_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
