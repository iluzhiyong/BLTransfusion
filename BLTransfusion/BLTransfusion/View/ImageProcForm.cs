using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BLTransfusion
{
    public partial class ImageProcForm : Form
    {
        private ImageProcForm()
        {
            InitializeComponent();
        }

        private static ImageProcForm instance;

        public static ImageProcForm CreateFrom()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ImageProcForm();
            }
            return instance;
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public void DisplayResult(bool result)
        {
            //System.Drawing.SolidBrush myBrush;
            if (true == result)
            {
                //myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                this.BeginInvoke(new Action(() => 
                {
                    lb_Result.Text = "NG";
                    lb_Result.Font = new System.Drawing.Font("YouYuan", 16);
                    lb_Result.BackColor = Color.Red;
                }));
            }
            else
            {
                //myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
                this.BeginInvoke(new Action(() => 
                { 
                    lb_Result.Text = "PASS";
                    //lb_Result.Font = new System.Drawing.Font("YouYuan", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    lb_Result.Font = new System.Drawing.Font("YouYuan", 16);
                    lb_Result.BackColor = Color.Green;
                }));
            }

            //边框颜色表示
            //System.Drawing.Graphics formGraphics = this.CreateGraphics();
            //formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, this.Width, this.Height));
            //myBrush.Dispose();
            //formGraphics.Dispose();
        }
    }
}
