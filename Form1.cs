using Newtonsoft.Json;
namespace Spiral;

public partial class Form1 : Form
{
    private List<ulong> list;
    double scale { get; set; }
    int size { get; set; }
    public Form1()
    {
        InitializeComponent();
        scale = 1;
        size = 1;
        ScaleBox.Text = scale.ToString();
        list = JsonConvert.DeserializeObject<List<ulong>>(File.ReadAllText(Path.GetTempPath() + "Prime_Numbers.json"));
        //You can use List of any integer numbers
    }

    private void PrintSpiral()
    {
        Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);

        for (int p = 0; p < list.Count; p++)
        {
            int x = (int)Math.Round(Math.Sin(list[p]) * list[p] * scale) + pictureBox.Width / 2;
            int y = (int)Math.Round(Math.Cos(list[p]) * list[p] * scale) + pictureBox.Height / 2;
            if (y >= 0 && y <= pictureBox.Height - size && x >= 0 / 2 && x <= pictureBox.Width - size)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
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
        scale *= 2;
        ScaleBox.Text = scale.ToString();
    }

    private void minusButton_Click(object sender, EventArgs e)
    {
        scale /= 2;
        ScaleBox.Text = scale.ToString();
    }

    private void plusButton2_Click(object sender, EventArgs e)
    {
        size++;
        sizeBox.Text = size.ToString();
    }

    private void minusButton2_Click(object sender, EventArgs e)
    {
        size = Math.Max(1, size - 1);
        sizeBox.Text = size.ToString();
    }
}