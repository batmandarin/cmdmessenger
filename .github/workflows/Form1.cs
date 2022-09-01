using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FocusApp
{
    public partial class FocusForm : Form
    {
        public FocusForm()
        {
            InitializeComponent();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //엔터키(\r\n)를 누르면 다음 입력 컨트롤로 포커스 이동
            if (e.KeyChar == '\r') txtWeight.Focus();
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnlnput_Click(object sender, EventArgs e)
        {
            //엔터키(\r\n)를 누르면 입력 내용을 출력 레이블에 표시
            lblResult.Text = "학번:" + txtNum.Text + ", 체중:" + txtWeight.Text;
        }
    }
}
