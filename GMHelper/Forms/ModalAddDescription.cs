using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMHelper.Forms
{
    public partial class ModalAddDescription : Form
    {
        public string InputText { get; private set; }
        public ModalAddDescription(string description)
        {
            InitializeComponent();
            rtbDescription.Text = description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InputText = rtbDescription.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
