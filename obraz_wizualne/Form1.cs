using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using static System.Net.Mime.MediaTypeNames;
namespace obraz_wizualne
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        public string file_name = "";

        public Form1()
        {
            InitializeComponent();
        }

        public void Wczytaj_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            string file_name = ofd.FileName;
            pictureBox1.Image = Bitmap.FromFile(file_name);
            System.Drawing.Image image = pictureBox1.Image;
            pictureBox1.Image = image.GetThumbnailImage(pictureBox1.Width, pictureBox1.Height, null, IntPtr.Zero);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void green_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);

                    // Sprawdzenie czy piksel ma zielony kolor lub jego odcienie
                    if (pixelColor.G >= pixelColor.R && pixelColor.G >= pixelColor.B)
                    {
                        // Pozostawienie piksela bez zmian
                    }
                    else
                    {
                        // Zmiana koloru piksela na bia³y, aby zachowaæ odcienie zielonego
                        image.SetPixel(x, y, Color.White);
                    }
                }
            }

            // Aktualizacja PictureBox z zielonymi pikselami
            pictureBox1.Image = image;
        }

        private void negatyw_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int akt_R= pixelColor.R;
                    int akt_G = pixelColor.G;
                    int akt_B = pixelColor.B;
                    akt_R = 255 - akt_R;
                    akt_G = 255 - akt_G;
                    akt_B = 255 - akt_B;
                    Color color = Color.FromArgb(akt_R, akt_G, akt_B);
                    image.SetPixel(x, y, color);

        }

        private void obrot_90_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);

            // Obrót obrazka o 90 stopni w prawo
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            // Aktualizacja PictureBox z obróconym obrazkiem
            pictureBox1.Image = image;
        }

        private void pion_Click(object sender, EventArgs e)
        {

            // Wczytanie obrazka z pliku
            Bitmap image = new Bitmap(pictureBox1.Image);

            // Odbicie lustrzane obrazka w pionie
            image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            // Aktualizacja PictureBox z odwróconym obrazkiem w pionie
            pictureBox1.Image = image;

        }

        private void poziom_Click(object sender, EventArgs e)
        { 

            // Wczytanie obrazka z pliku
            Bitmap image = new Bitmap(pictureBox1.Image);

            // Odbicie lustrzane obrazka w poziomie
            image.RotateFlip(RotateFlipType.RotateNoneFlipY);

            // Aktualizacja PictureBox z odwróconym obrazkiem w poziomie
            pictureBox1.Image = image;

        }
    }
                }
            }
            pictureBox1.Image = image;
        }
    }
}