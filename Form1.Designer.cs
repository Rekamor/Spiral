namespace Spiral;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pictureBox = new PictureBox();
        textBox1 = new TextBox();
        printButton = new Button();
        plusButton = new Button();
        minusButton = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
        SuspendLayout();
        // 
        // pictureBox
        // 
        pictureBox.Location = new Point(0, 0);
        pictureBox.Name = "pictureBox";
        pictureBox.Size = new Size(2560, 1440);
        pictureBox.TabIndex = 0;
        pictureBox.TabStop = false;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(2294, 1261);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(232, 31);
        textBox1.TabIndex = 1;
        // 
        // printButton
        // 
        printButton.Location = new Point(2294, 1298);
        printButton.Name = "printButton";
        printButton.Size = new Size(232, 34);
        printButton.TabIndex = 2;
        printButton.Text = "Print";
        printButton.UseVisualStyleBackColor = true;
        printButton.Click += printButton_Click;
        // 
        // plusButton
        // 
        plusButton.Location = new Point(2294, 1338);
        plusButton.Name = "plusButton";
        plusButton.Size = new Size(112, 34);
        plusButton.TabIndex = 3;
        plusButton.Text = "+";
        plusButton.UseVisualStyleBackColor = true;
        plusButton.Click += plusButton_Click;
        // 
        // minusButton
        // 
        minusButton.Location = new Point(2414, 1338);
        minusButton.Name = "minusButton";
        minusButton.Size = new Size(112, 34);
        minusButton.TabIndex = 4;
        minusButton.Text = "-";
        minusButton.UseVisualStyleBackColor = true;
        minusButton.Click += minusButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(2538, 1384);
        Controls.Add(minusButton);
        Controls.Add(plusButton);
        Controls.Add(printButton);
        Controls.Add(textBox1);
        Controls.Add(pictureBox);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBox;
    private TextBox textBox1;
    private Button printButton;
    private Button plusButton;
    private Button minusButton;
}