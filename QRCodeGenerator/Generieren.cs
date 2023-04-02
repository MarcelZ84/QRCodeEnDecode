using System.Drawing;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace QRCodeEnDecode
{
    class Generieren
    {
        private string text;
        private int groesse = 0;
        private string fehlerkorrektur = string.Empty;
        private string farbe;
        //constructor
        public Generieren(string text, int groesse, string fehlerkorrektur, string farbe)
        {
            this.text = text;
            this.groesse = groesse;
            this.fehlerkorrektur = fehlerkorrektur;
            this.farbe = farbe;
        }
        //eigenschafte für text des qrcodes
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        //eigenschafte größe des qrcodes
        public int Groesse
        {
            get { return groesse; }
            set { groesse = value; }
        }
        //eingenschaft für die fehlerkorrektur
        public string Fehlerkorrektur
        {
            get { return fehlerkorrektur; }
            set { fehlerkorrektur = value; }
        }
        //eigenschaft für farbe des qrcodes
        public string Farbe
        {
            get { return farbe; }
            set { farbe = value; }
        }
        //methode für den aufruf qrCodeErstellen
        public Bitmap qrBitmap()
        {
            return qrCodeErstellen();
        }
        //methode mit rückgabewert errorcorectionlevel
        private ErrorCorrectionLevel Korrektur()
        {
            switch (fehlerkorrektur)            //auswahl fehlerkorrektur
            {
                case "H":
                    return ErrorCorrectionLevel.H;
                case "Q":
                    return ErrorCorrectionLevel.Q;
                case "M":
                    return ErrorCorrectionLevel.M;
                case "L":
                    return ErrorCorrectionLevel.L;
                default:
                    return ErrorCorrectionLevel.H;
            };
        }

        //methode zum erstellen des qrcodes
        private Bitmap qrCodeErstellen()
        {
            var optionen = new QrCodeEncodingOptions    //encodingOptionen
            {
                DisableECI = false,
                Width = groesse,        //breite
                Height = groesse,       //höhe
                Margin = 0,             //rand
                PureBarcode = true,    //nur qrcode oder gemischt mit text
                ErrorCorrection = Korrektur()       //fehlerkorrektur
            };

            ZXing.BarcodeWriter barcodeWriter = new ZXing.BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = optionen      //übergabe der encodingOptionen
            };

            BitMatrix matrix = barcodeWriter.Encode(text);
            BitmapRenderer bitmapRenderer = new BitmapRenderer();
            bitmapRenderer.Foreground = farbeQR();       //farbe

            Bitmap ergebnis = bitmapRenderer.Render(matrix, BarcodeFormat.QR_CODE, text);

            return ergebnis;    //rückgabe ergebnis
        }
        //methode zur auswahl der farbe, rückgabe color
        private Color farbeQR()
        {
            switch (farbe)                  //auswahl der farbe
            {
                case "Rot":
                    return Color.Red;
                case "Grün":
                    return Color.Green;
                case "Blau":
                    return Color.Blue;
                case "Schwarz":
                    return Color.Black;
                default:
                    return Color.Red;
            }
        }
    }
}
