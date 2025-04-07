using Newtonsoft.Json;
namespace Spiral;

public partial class Form1 : Form
{
    private List<ulong> list;
    double size { get; set; }
    public Form1()
    {
        InitializeComponent();
        size = 1;
        textBox1.Text = size.ToString();
        list = JsonConvert.DeserializeObject<List<ulong>>(File.ReadAllText(Path.GetTempPath() + "Prime_Numbers.json"));
        //You can use List of any integer numbers
    }

    private void PrintSpiral()
    {
        Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
        
        for (int p = 0; p < list.Count; p++)
        {
            int x = (int)Math.Round(Math.Sin(list[p]) * list[p] * size) + pictureBox.Width / 2;
            int y = (int)Math.Round(Math.Cos(list[p]) * list[p] * size) + pictureBox.Height / 2;
            if (y >= size / 2 && y <= pictureBox.Height - size / 2 && x >= size / 2 && x <= pictureBox.Width - size / 2)
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
                if (x < -189 || x > pictureBox.Width + 189)
                {
                    pictureBox.Image = bitmap;
                    return;
                }
            }
        }
        pictureBox.Image = bitmap;
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