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

        private void Wczytaj_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            string file_name = ofd.FileName;
            pictureBox1.Image = Bitmap.FromFile (file_name);
            System.Drawing.Image image = pictureBox1.Image;
            pictureBox1.Image = image.GetThumbnailImage(pictureBox1.Width, pictureBox1.Height, null, IntPtr.Zero);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}