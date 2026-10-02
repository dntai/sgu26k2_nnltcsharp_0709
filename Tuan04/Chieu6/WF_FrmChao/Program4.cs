namespace NNLTCSharp.WinForms;

static class Program4
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
            Form form = new Form();
            form.Text = "WinForm";
            
            Button button = new Button();
            button.Text = "OK";
            button.Location = new Point(100, 100);
            form.Controls.Add(button);
 
            button.Click += Button_Click;
            form.Click += Form_Click;
            form.FormClosing += Form_FormClosing;

            Application.Run(form);
    }

    private static void Form_FormClosing(object? sender, FormClosingEventArgs e)
    {
        DialogResult result = MessageBox.Show("Ban muon dong form hay khong?", "Thong bao", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question);
        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

    private static void Form_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Ban da click vao form.");
    }

    static void Button_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Ban da click vao nut OK.");
    }
}