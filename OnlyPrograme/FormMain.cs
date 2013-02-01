using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnlyPrograme
{
    /// <summary>
    /// 在这里实现了用delegate在父窗体和子窗体间传递数据
    /// </summary>

    #region 声明delegate
    public delegate void SetTextBoxValue(string value);
    public delegate string GetTextBoxValue();
    #endregion

    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        #region delegate的实现
        private void SetValue(string value)
        {
            textBox1.Text = value;
        }
        private string GetValue()
        {
            return this.textBox1.Text;
        }
        #endregion        

        #region 声明两个delegate的实例
        private void btnShowChildForm_Click(object sender, EventArgs e)
        {
            FormChild child = new FormChild(
                new SetTextBoxValue(SetValue),
                new GetTextBoxValue(GetValue)
                );
            child.ShowDialog();
            child.Dispose();
        }
        #endregion        
    }
}
