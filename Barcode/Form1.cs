using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Данные для штрих-кода
            string barcodeData = "12563716235293";

            // Ширина и высота полосок штрих-кода
            int barWidth = 110;
            int barHeight = 150;

            // Цвета
            Color backgroundColor = Color.White;
            Color barColor = Color.Black;
            Color textColor = Color.Black;

            // Генерируем штрих-код с помощью вашей библиотеки
            Bitmap barcodeBitmap = ClassLibraryBar.Barcode.GenerateBarcode(barcodeData, barHeight, backgroundColor, barColor, textColor);

            // Отображаем сгенерированный штрих-код на форме
            pictureBox1.Image = barcodeBitmap;
        }
    }
}
