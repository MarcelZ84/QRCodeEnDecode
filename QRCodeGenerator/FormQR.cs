using System;
using System.Drawing;
using System.Windows.Forms;

namespace QRCodeEnDecode
{
    public partial class FormQR : Form
    {
        public FormQR()
        {
            InitializeComponent();
        }

        private string logo;
        private Bitmap bild;

        private void qrcodeMitLogo()
        {
            try
            {
                logo symbol = new logo();
                symbol.QrBitmap = bild;
                symbol.Pfad = logo;
                var ImageQRmitLogo = symbol.rückgabeQRmitLogo();
                pictureBoxQR.Image = ImageQRmitLogo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void generiereQRCode()
        {
            pictureBoxQR.Image = null;
            string text = textBoxQR.Text;
            int groesse = Convert.ToInt32(textBoxGroesse.Text);
            string fehlerkorrektur;
            string farbe;
            //auswahl fehlerkorrektur
            switch (comboBoxFehler.SelectedItem)
            {
                case "H (30%)":
                    fehlerkorrektur = "H";
                    break;
                case "Q (25%)":
                    fehlerkorrektur = "Q";
                    break;
                case "M (15%)":
                    fehlerkorrektur = "M";
                    break;
                case "L (7%)":
                    fehlerkorrektur = "L";
                    break;
                default:
                    fehlerkorrektur = "H";
                    break;
            };

            switch (comboBoxFarbe.SelectedItem)
            {
                case "Rot":
                    farbe = "Rot";
                    break;
                case "Grün":
                    farbe = "Grün";
                    break;
                case "Blau":
                    farbe = "Blau";
                    break;
                case "Schwarz":
                    farbe = "Schwarz";
                    break;
                default:
                    farbe = "Rot";
                    break;
            }

            Generieren generieren = new Generieren(text, groesse, fehlerkorrektur, farbe)
            {
                Text = text,
                Groesse = groesse,
                Fehlerkorrektur = fehlerkorrektur,
                Farbe = farbe
            };

            bild = generieren.qrBitmap();
            pictureBoxQR.Image = bild;
        }

        private void buttonGenerieren_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBoxQR.Text) || string.IsNullOrEmpty(textBoxQR.Text)))
            {
                if (!(string.IsNullOrEmpty(textBoxGroesse.Text) || string.IsNullOrWhiteSpace(textBoxGroesse.Text)))
                {
                    if (logo != null)
                    {
                        comboBoxFehler.SelectedIndex = 0;
                        generiereQRCode();
                        qrcodeMitLogo();
                    }
                    else
                    {
                        generiereQRCode();
                    }

                }
            }
        }

        private void buttonLesen_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBoxQR.Image != null)
                {
                    Bitmap qrBitmap = new Bitmap(pictureBoxQR.Image);

                    var decodierterText = Decodieren.leseQRcode(qrBitmap);
                    textBoxQR.Text = decodierterText;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Der QR-Code konnte nicht gelesen werden", "Fehler: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOeffnen_Click(object sender, EventArgs e)
        {
            if (openFileDialogQR.ShowDialog() == DialogResult.OK)
            {
                pictureBoxQR.ImageLocation = openFileDialogQR.FileName;
            }
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            if (saveFileDialogQR.ShowDialog() == DialogResult.OK)
            {
                pictureBoxQR.Image.Save(saveFileDialogQR.FileName);
            }
        }

        private void buttonLogo_Click(object sender, EventArgs e)
        {
            if (openFileDialogLogo.ShowDialog() == DialogResult.OK)
            {
                pictureBoxLogo.ImageLocation = openFileDialogLogo.FileName;
                logo = openFileDialogLogo.FileName;
            }

        }

        private void buttonEinfuegen_Click(object sender, EventArgs e)
        {
            comboBoxFehler.SelectedIndex = 0;
            generiereQRCode();
            qrcodeMitLogo();
        }

        private void FormQR_Load(object sender, EventArgs e)
        {
            textBoxGroesse.Text = "1000";
            comboBoxFehler.SelectedIndex = 0;
            comboBoxFarbe.SelectedIndex = 0;
        }

        private void buttonTextLeeren_Click(object sender, EventArgs e)
        {
            textBoxQR.Clear();
        }

        private void buttonPicLeeren_Click(object sender, EventArgs e)
        {
            pictureBoxQR.Image = null;
            pictureBoxLogo.Image = null;
            logo = string.Empty;
        }

        private void buttonScann_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Die Funktion ist noch in Arbeit.");
        }
    }
}
