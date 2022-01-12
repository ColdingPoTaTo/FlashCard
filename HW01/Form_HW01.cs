using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW01
{
    public partial class FormHW01 : Form
    {
        public FormHW01()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            String cnName = textCnName.Text;
            String enName = textEnName.Text;
            String gender = textGender.Text;
            String zodiac = textZodiac.Text;
            MessageBox.Show("Hello, 我是 " + cnName + "\n" 
                + "英文名字是 " + enName + "\n"
                + "性別是 " + gender + "\n"
                + "星座是 " + zodiac + "\n"
                + "很高興認識你。");
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            String cnName = textCnName.Text;
            String enName = textEnName.Text;
            String gender = textGender.Text;
            String zodiac = textZodiac.Text;
            MessageBox.Show("Hi, 我是 " + cnName + "\n"
                + "英文名字是 " + enName + "\n"
                + "性別是 " + gender + "\n"
                + "星座是 " + zodiac + "\n"
                + "很高興認識你。");
        }
    }
}
