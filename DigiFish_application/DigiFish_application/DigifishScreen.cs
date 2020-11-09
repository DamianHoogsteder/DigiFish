using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiFish_application
{
    public partial class DigifishScreen : Form
    {
        public DigifishScreen()
        {
            InitializeComponent();
        }

        private void DigifishScreen_Load(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pctbox_barcode.Image = barcode.Draw("854267", 50, 2);
        }
    }
}
