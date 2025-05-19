using OscilloGen.UserControls;

namespace OscilloGen;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void FuncGenButton_Click(object sender, EventArgs e)
    {
        LoadPage(new UC_FunctionGenerator());
    }

    private void OscillButton_Click(object sender, EventArgs e)
    {
        LoadPage(new UC_Oscilloscope());
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        LoadPage(new UC_Update());
    }

    private void AboutButton_Click(object sender, EventArgs e)
    {
        LoadPage(new UC_About());
    }

    private void LoadPage(UserControl page)
    {
        MainPanel.Controls.Clear();
        MainPanel.Controls.Add(page);
        page.Dock = DockStyle.Fill;
    }
}
