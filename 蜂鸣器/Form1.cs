using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;//命名空间导入
using Microsoft.VisualBasic;

namespace 蜂鸣器
{
    public partial class 失去焦点发声 : Form
    {
        [DllImport("kernel32.dll", EntryPoint = "Beep")]
        // 第一个参数是指频率的高低，越大越高，第二个参数是指响的时间多长  
        public static extern int Beep(int dwFreq, int dwDuration);  

        public 失去焦点发声()
        {
            InitializeComponent();
            频率textbox.Text = "500";
            时间textbox.Text = "100";
        }

        private void 开始_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(频率textbox.Text);
            int num2 = Convert.ToInt32(时间textbox.Text);
            Beep(num1, num2); 
        }

        private void 失去焦点发声_Deactivate(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(频率textbox.Text);
            int num2 = Convert.ToInt32(时间textbox.Text);
            Beep(num1, num2); 
        }
    }
}
