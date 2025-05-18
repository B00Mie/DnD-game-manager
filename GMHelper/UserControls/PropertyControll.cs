using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterManager.UserControls
{
    public partial class PropertyControll : UserControl
    {
        public event EventHandler IncreaseClicked;
        public event EventHandler DecreaseClicked;

        public Button IncreaseButton => btnIncrease;
        public Button DecreaseButton => btnDecrease;

        private string _groupName;

        public string GroupName
        {
            get => _groupName;
            set => _groupName = value;
        } 

        public string PropertyName
        {
            get => lblPropertyName.Text;
            set => lblPropertyName.Text = value;
        }

        public string PropertyValue
        {
            get => lblPropertyVal.Text;
            set => lblPropertyVal.Text = value;
        }
        public PropertyControll()
        {
            InitializeComponent();
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            IncreaseClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            DecreaseClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
