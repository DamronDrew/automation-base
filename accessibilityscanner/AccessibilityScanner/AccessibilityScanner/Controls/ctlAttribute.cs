using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessibilityScanner.Controls
{
    public partial class ctlAttribute : UserControl
    {
        public ctlAttribute(string attName, string attValue)
        {
            InitializeComponent();
            this.lblAttName.Text = String.Format("{0}: {1}", attName, attValue);
        }

        private void ctlAttribute_Load(object sender, EventArgs e)
        {

        }
    }
}
