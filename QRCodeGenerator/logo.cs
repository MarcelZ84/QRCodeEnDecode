using System.Drawing;

namespace QRCodeEnDecode
{
    class logo
    {
        //private variablen
        string pfad;
        Bitmap qrBitmap;

        //constructor
        public logo()
        {
        }
        //eigenschaften des constructor
        public string Pfad
        {
            get { return this.pfad; }
            set { this.pfad = value; }
        }

        //eigenschaften des constructor
        public Bitmap QrBitmap
        {
            get { return this.qrBitmap; }
            set { this.qrBitmap = value; }
        }

        public Bitmap rückgabeQRmitLogo()
        {
            return berechneLogo();
        }

        //methode
        private Bitmap berechneLogo()
        {
            Image imageLogo = Image.FromFile(pfad);

            int qrBreite = qrBitmap.Width;
            int qrHoehe = qrBitmap.Height;

            int sybolBreite = (int)(qrBreite * 0.3);
            int symbolHoehe = (int)(qrHoehe * 0.3);

            //plaziert das logo in die mitte dés qrcodes
            int logoPosX = (qrBreite - sybolBreite) / 2;
            int logoPosY = (qrHoehe - symbolHoehe) / 2;
            //skallieren des logos
            Image logo = new Bitmap(imageLogo, sybolBreite, symbolHoehe);
            //zeichnet logo auf qrcode
            using (Graphics graphics = Graphics.FromImage(qrBitmap))
            {
                graphics.DrawImage(logo, logoPosX, logoPosY);
            }
            return qrBitmap;
        }
    }
}
