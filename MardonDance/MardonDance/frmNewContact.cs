using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MardonDance
{
    public partial class frmNewContact : Form
    {
        public frmNewContact()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.cboRelationship.SelectedIndex = 0;
        }
    }
}
