using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnlyPrograme
{
    public partial class FormChild : Form
    {
        #region 声明两delegate的实例
        private SetTextBoxValue SetMainText = null;
        private GetTextBoxValue GetMainText = null;
        #endregion        

        public FormChild( SetTextBoxValue set, GetTextBoxValue get)
        {
            InitializeComponent();
            SetMainText = set;
            GetMainText = get;
        }

        #region 调用两个delegate的实例
        private void btnGetMainText_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetMainText());
        }

        private void btnSetMainText_Click(object sender, EventArgs e)
        {
            SetMainText("Hello World");
        }
        #endregion
    }
}
