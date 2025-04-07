using Newtonsoft.Json;
namespace Spiral;

public partial class Form1 : Form
{
    private List<int> primes;
    double size { get; set; }
    public Form1()
    {
        InitializeComponent();
        size = 10;
        textBox1.Text = size.ToString();
        primes = JsonConvert.DeserializeObject<List<int>>(File.ReadAllText(
            "C:\\Users\\1092023\\AppData\\Local\\Temp\\\\Prime_Numbers.json"));
    }

    private void PrintSpiral()
    {
        Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
        int p = 0;
        while (true)
        {
            int x = (int)Math.Round(Math.Sin(primes[p]) * primes[p] * size) + pictureBox.Width / 2;
            int y = (int)Math.Round(Math.Cos(primes[p]) * primes[p] * size) + pictureBox.Height / 2;
            if (x >= size / 2 && y >= size / 2 && x <= pictureBox.Width - size / 2 && y <= pictureBox.Height - size / 2)
            {
                for (int i = (int)Math.Ceiling(size / -2); i <= size / 2; i++)
                {
                    for (int j = (int)Math.Ceiling(size / -2); j <= size / 2; j++)
                    {
                        bitmap.SetPixel(x + i, y + j, Color.Black);
                    }
                }
            }
            else
            {
                pictureBox.Image = bitmap;
                return;
            }
            p++;
        }
    }

    private void printButton_Click(object sender, EventArgs e)
    {
        PrintSpiral();
    }

    private void plusButton_Click(object sender, EventArgs e)
    {
        size *= 2;
        textBox1.Text = size.ToString();
    }

    private void minusButton_Click(object sender, EventArgs e)
    {
        size /= 2;
        textBox1.Text = size.ToString();
    }
}