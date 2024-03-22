namespace Run_Button;
using System.Drawing;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnRun_Click(object sender, EventArgs e)
    {
        if(checkBox.Checked == true)
            btnRun.Location = new Point(new Random().Next(0, 300), new Random().Next(0, 300));
    }
}
