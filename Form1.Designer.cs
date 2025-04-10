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
        ScaleBox = new TextBox();
        printButton = new Button();
        plusButton = new Button();
        minusButton = new Button();
        sizeBox = new TextBox();
        plusButton2 = new Button();
        minusButton2 = new Button();
        scaleLabel = new Label();
        sizeLabel = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
        SuspendLayout();
        // 
        // pictureBox
        // 
        pictureBox.Location = new Point(-23, -58);
        pictureBox.Name = "pictureBox";
        pictureBox.Size = new Size(2560, 1440);
        pictureBox.TabIndex = 0;
        pictureBox.TabStop = false;
        // 
        // ScaleBox
        // 
        ScaleBox.Location = new Point(2294, 1243);
        ScaleBox.Name = "ScaleBox";
        ScaleBox.ReadOnly = true;
        ScaleBox.Size = new Size(232, 31);
        ScaleBox.TabIndex = 1;
        // 
        // printButton
        // 
        printButton.Location = new Point(2294, 1338);
        printButton.Name = "printButton";
        printButton.Size = new Size(232, 34);
        printButton.TabIndex = 2;
        printButton.Text = "Print";
        printButton.UseVisualStyleBackColor = true;
        printButton.Click += printButton_Click;
        // 
        // plusButton
        // 
        plusButton.Location = new Point(2294, 1280);
        plusButton.Name = "plusButton";
        plusButton.Size = new Size(112, 34);
        plusButton.TabIndex = 3;
        plusButton.Text = "+";
        plusButton.UseVisualStyleBackColor = true;
        plusButton.Click += plusButton_Click;
        // 
        // minusButton
        // 
        minusButton.Location = new Point(2414, 1280);
        minusButton.Name = "minusButton";
        minusButton.Size = new Size(112, 34);
        minusButton.TabIndex = 4;
        minusButton.Text = "-";
        minusButton.UseVisualStyleBackColor = true;
        minusButton.Click += minusButton_Click;
        // 
        // sizeBox
        // 
        sizeBox.Location = new Point(2294, 1130);
        sizeBox.Name = "sizeBox";
        sizeBox.ReadOnly = true;
        sizeBox.Size = new Size(232, 31);
        sizeBox.TabIndex = 5;
        // 
        // plusButton2
        // 
        plusButton2.Location = new Point(2294, 1167);
        plusButton2.Name = "plusButton2";
        plusButton2.Size = new Size(112, 34);
        plusButton2.TabIndex = 6;
        plusButton2.Text = "+";
        plusButton2.UseVisualStyleBackColor = true;
        plusButton2.Click += plusButton2_Click;
        // 
        // minusButton2
        // 
        minusButton2.Location = new Point(2414, 1167);
        minusButton2.Name = "minusButton2";
        minusButton2.Size = new Size(112, 34);
        minusButton2.TabIndex = 7;
        minusButton2.Text = "-";
        minusButton2.UseVisualStyleBackColor = true;
        minusButton2.Click += minusButton2_Click;
        // 
        // scaleLabel
        // 
        scaleLabel.AutoSize = true;
        scaleLabel.Location = new Point(2294, 1215);
        scaleLabel.Name = "scaleLabel";
        scaleLabel.Size = new Size(91, 25);
        scaleLabel.TabIndex = 8;
        scaleLabel.Text = "Map scale";
        // 
        // sizeLabel
        // 
        sizeLabel.AutoSize = true;
        sizeLabel.Location = new Point(2294, 1102);
        sizeLabel.Name = "sizeLabel";
        sizeLabel.Size = new Size(86, 25);
        sizeLabel.TabIndex = 9;
        sizeLabel.Text = "Point size";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(2538, 1384);
        Controls.Add(sizeLabel);
        Controls.Add(scaleLabel);
        Controls.Add(minusButton2);
        Controls.Add(plusButton2);
        Controls.Add(sizeBox);
        Controls.Add(minusButton);
        Controls.Add(plusButton);
        Controls.Add(printButton);
        Controls.Add(ScaleBox);
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
    private TextBox ScaleBox;
    private Button printButton;
    private Button plusButton;
    private Button minusButton;
    private TextBox sizeBox;
    private Button plusButton2;
    private Button minusButton2;
    private Label scaleLabel;
    private Label sizeLabel;
}