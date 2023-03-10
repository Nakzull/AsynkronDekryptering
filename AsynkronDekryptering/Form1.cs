using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace AsynkronDekryptering
{
    public partial class Form1 : Form
    {
        Decryption decryption = new Decryption();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDecrypt_Click_1(object sender, EventArgs e)
        {
            byte[] decryptMe = decryption.FromHex(textBoxEncrypted.Text);
            byte[] decrypted = decryption.Decrypt(decryptMe);
            textBoxDecrypted.Text = Encoding.Default.GetString(decrypted);
        }

        private void buttonShowKey_Click(object sender, EventArgs e)
        {
            RSAParameters publicKey = decryption.AssignNewKey();
            textBoxExponent.Text = decryption.HexPrint(publicKey.Exponent);
            textBoxModulus.Text = decryption.HexPrint(publicKey.Modulus);
        }
    }
}
