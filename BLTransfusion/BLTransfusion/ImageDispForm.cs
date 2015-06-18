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
    public partial class ImageDispForm : Form
    {
        private ImageDispForm()
        {
            InitializeComponent();
        }

        private static ImageDispForm instance;

        public static ImageDispForm CreateFrom()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ImageDispForm();
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
    }
}
