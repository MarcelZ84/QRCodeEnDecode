using System.Collections.Generic;
using System.Drawing;
using ZXing;
using ZXing.Common;

namespace QRCodeEnDecode
{
    class Decodieren
    {
        public static string leseQRcode(Bitmap qrBild)
        {
            var decodingOptionen = new DecodingOptions
            {
                TryHarder = true,
                PureBarcode = false,
                PossibleFormats = new List<BarcodeFormat> { BarcodeFormat.QR_CODE },
                CharacterSet = "UTF-8",
                TryInverted = true
            };

            var barcodeReader = new BarcodeReader
            {
                AutoRotate = true,
                Options = decodingOptionen
            };

            var ergebnis = barcodeReader.Decode(qrBild);
            return ergebnis.Text;
        }
    }
}