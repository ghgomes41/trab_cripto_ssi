using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trab_cripto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbCryp.Checked = true;
            rbDecryp.Checked = false;
            panel1.Enabled = true;
            panel2.Enabled = false;

        }

        private void RbDecryp_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            panel1.Enabled = false;
        }

        private void RbCryp_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel2.Enabled = false;
        }

        private void Exec_btn1_Click(object sender, EventArgs e)
        {
            String crypt_src = txt_src1.Text.ToUpper();
           // String crypt_target = crypt_src;
           //.Replace('0','o').Replace('1','p').Replace('2','q').Replace('3','r')
           //.Replace('4', 'ó').Replace('5', 'ú').Replace('6', 'à').Replace('7', 'ô').Replace('8', 'ã').Replace('9', 'õ')
            String crypt_target = crypt_src.Replace('0', 'o').Replace('1', 'p').Replace('2', 'q').Replace('3', 'r')
                                           .Replace('4', 'ó').Replace('5', 'ú').Replace('6', 'à').Replace('7', 'ô').Replace('8', 'ã').Replace('9', 'õ')
                                           .Replace('A','4').Replace('B','5').Replace('C','6').Replace('D','7').Replace('E','8').Replace('F','9')
                                           .Replace('G','s').Replace('H','t').Replace('I','u').Replace('J','v').Replace('K','w').Replace('L','x')
                                           .Replace('M','a').Replace('N','b').Replace('O','c').Replace('P','d').Replace('Q','e').Replace('R','f')
                                           .Replace('S','g').Replace('T','h').Replace('U','i').Replace('V','j').Replace('W','k').Replace('X','l')
                                           .Replace('Y','m').Replace('Z','n')
                                           .Replace('!','%').Replace('@','&').Replace('#','*').Replace('$','(').Replace('_',')').Replace('+','-')
                                           .Replace('%','|').Replace('&','?').Replace('*','=').Replace('(','´').Replace(')','`').Replace('-',':')
                                           .Replace('|','!').Replace('?','@').Replace('=','#').Replace('´','$').Replace('`','_').Replace(':','+')
                                           .Replace('.','Y').Replace(',','Z').Replace(';','0').Replace('Á','1').Replace('É','2').Replace('Í','3')
                                           .Replace('Ó','[').Replace('Ú',']').Replace('À','{').Replace('Ô','}').Replace('Ã','~').Replace('Õ','^')
                                           .Replace('Ê','.').Replace('Â',',').Replace('Ô',';').Replace('Ç','Á').Replace('Û','É').Replace('Ü','Í')
                                           .Replace('[','Ñ').Replace(']','Ö').Replace('{','Ä').Replace('}','£').Replace('~','º').Replace('^','ª')
                                           .Replace('Ñ','Ê').Replace('Ö','Â').Replace('Ä','Ô').Replace('£','Ç').Replace('º','Û').Replace('ª','Ü');
            txt_target1.Text = crypt_target;
        }

        private void Exec_btn2_Click(object sender, EventArgs e)
        {
            String decrypt_src = txt_src2.Text;
            txt_target2.Text = decrypt_src;
        }
    }
}
