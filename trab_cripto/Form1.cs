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
            String crypt_target = crypt_src.Replace('0', 'o').Replace('1', 'p').Replace('2', 'q').Replace('3', 'r')
                                           .Replace('4', 'ó').Replace('5', 'ú').Replace('6', 'à').Replace('7', 'ô').Replace('8', 'ã').Replace('9', 'õ')
                                           .Replace('A', '4').Replace('B', '5').Replace('C', '6').Replace('D', '7').Replace('E', '8').Replace('F', '9')
                                           .Replace('G', 's').Replace('H', 't').Replace('I', 'u').Replace('J', 'v').Replace('K', 'w').Replace('L', 'x')
                                           .Replace('M', 'a').Replace('N', 'b').Replace('O', 'c').Replace('P', 'd').Replace('Q', 'e').Replace('R', 'f')
                                           .Replace('S', 'g').Replace('T', 'h').Replace('U', 'i').Replace('V', 'j').Replace('W', 'k').Replace('X', 'l')
                                           .Replace('Y', 'm').Replace('Z', 'n')
                                           .Replace('%', '|').Replace('&', '?').Replace('*', '=').Replace('(', '´').Replace(')', '`').Replace('-', ':')
                                           .Replace('!', '%').Replace('@', '&').Replace('#', '*').Replace('$', '(').Replace('_', ')').Replace('+', '-')
                                           .Replace('|', '!').Replace('?', '@').Replace('=', '#').Replace('´', '$').Replace('`', '_').Replace(':', '+')
                                           .Replace('.', 'y').Replace(',', 'z').Replace(';', '0').Replace('Á', '1').Replace('É', '2').Replace('Í', '3')
                                           .Replace('Ê', '.').Replace('Â', ',').Replace('¢', ';').Replace('Ç', 'á').Replace('Û', 'é').Replace('Ü', 'í')
                                           .Replace('Ñ', 'ê').Replace('Ö', 'â').Replace('Ä', '¢').Replace('£', 'ç').Replace('º', 'û').Replace('ª', 'ü')
                                           .Replace('[', 'ñ').Replace(']', 'ö').Replace('{', 'ä').Replace('}', '£').Replace('~', 'º').Replace('^', 'ª')
                                           .Replace('Ó', '[').Replace('Ú', ']').Replace('À', '{').Replace('Ô', '}').Replace('Ã', '~').Replace('Õ', '^');
                                           
            txt_target1.Text = crypt_target;
        }

        private void Exec_btn2_Click(object sender, EventArgs e)
        {
            String decrypt_src = txt_src2.Text.ToLower();
            String decrypt_target = decrypt_src.Replace('4', 'A').Replace('5', 'B').Replace('6', 'C').Replace('7', 'D').Replace('8', 'E').Replace('9', 'F')
                                               .Replace('s', 'G').Replace('t', 'H').Replace('u', 'I').Replace('v', 'J').Replace('w', 'K').Replace('x', 'L')
                                               .Replace('a', 'M').Replace('b', 'N').Replace('c', 'O').Replace('d', 'P').Replace('e', 'Q').Replace('f', 'R')
                                               .Replace('g', 'S').Replace('h', 'T').Replace('i', 'U').Replace('j', 'V').Replace('k', 'W').Replace('l', 'X')
                                               .Replace('m', 'Y').Replace('n', 'Z')
                                               .Replace('|', '%').Replace('?', '&').Replace('=', '*').Replace('´', '(').Replace('`', ')').Replace(':', '-')
                                               .Replace('!', '|').Replace('@', '?').Replace('#', '=').Replace('$', '´').Replace('_', '`').Replace('+', ':')
                                               .Replace('%', '!').Replace('&', '@').Replace('*', '#').Replace('(', '$').Replace(')', '_').Replace('-', '+')
                                               .Replace('[', 'Ó').Replace(']', 'Ú').Replace('{', 'À').Replace('}', 'Ô').Replace('~', 'Ã').Replace('^', 'Õ')
                                               .Replace('.', 'Ê').Replace(',', 'Â').Replace(';', '¢').Replace('á', 'Ç').Replace('é', 'Û').Replace('í', 'Ü')
                                               .Replace('y', '.').Replace('z', ',').Replace('0', ';').Replace('1', 'Á').Replace('2', 'É').Replace('3', 'Í')
                                               .Replace('ñ', '[').Replace('ö', ']').Replace('ä', '{').Replace('£', '}').Replace('º', '~').Replace('ª', '^')
                                               .Replace('ê', 'Ñ').Replace('â', 'Ö').Replace('¢', 'Ä').Replace('ç', '£').Replace('û', 'º').Replace('ü', 'ª')
                                               .Replace('o', '0').Replace('p', '1').Replace('q', '2').Replace('r', '3')
                                               .Replace('ó', '4').Replace('ú', '5').Replace('à', '6').Replace('ô', '7').Replace('ã', '8').Replace('õ', '9');
                                               
            txt_target2.Text = decrypt_target;
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            txt_src1.Text = "";
            txt_src2.Text = "";
            txt_target1.Text = "";
            txt_target2.Text = "";
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
