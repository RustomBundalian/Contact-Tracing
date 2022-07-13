using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUP___Lost_and_Found
{
    public partial class QRCodeGenerator : Form
    {
        string name;
        string contact;
        public QRCodeGenerator(string s, string c)
        {
            InitializeComponent();
            name = s;
            contact = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(name + ":" + contact, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pbGenerator.Image = code.GetGraphic(50);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void QRCodeGenerator_Load(object sender, EventArgs e)
        {

        }
    }
}
