using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Barcode1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var qrcode = new BarcodeWriter
            {
                // 出力するコードの形式をQRコードに選択
                Format = BarcodeFormat.CODE_39,
                Options = new ZXing.QrCode.QrCodeEncodingOptions
                {
                    // QRコードの信頼性
                    ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.M,
                    // 日本語を表示したい場合シフトJISを指定
                    //CharacterSet = "Shift_JIS",
                    // デフォルト
                    CharacterSet = "ISO-8859-1",
                    // QRコードのサイズ決定
                    Height = 160,
                    Width = 160,
                    // QRコード周囲の余白の大きさ
                    Margin = 4
                }
            };
            // PictureBoxの中心に画像を表示するように設定
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            // QRコードを出力
            pictureBox1.Image = qrcode.Write(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var qrcode = new BarcodeWriter
            {
                // 出力するコードの形式をQRコードに選択
                Format = BarcodeFormat.QR_CODE,
                Options = new ZXing.QrCode.QrCodeEncodingOptions
                {
                    // QRコードの信頼性
                    ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.M,
                    // 日本語を表示したい場合シフトJISを指定
                    //CharacterSet = "Shift_JIS",
                    // デフォルト
                    CharacterSet = "ISO-8859-1",
                    // QRコードのサイズ決定
                    Height = 160,
                    Width = 160,
                    // QRコード周囲の余白の大きさ
                    Margin = 4
                }
            };
            // PictureBoxの中心に画像を表示するように設定
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            // QRコードを出力
            pictureBox1.Image = qrcode.Write(textBox1.Text);
        }
    }
}
