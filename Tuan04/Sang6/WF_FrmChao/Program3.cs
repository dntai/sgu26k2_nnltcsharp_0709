namespace NNLTCS.WinForms;

static class Program3
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
            Form form = new Form();             
            form.Text = "WinForm"; 

        form.Click += Form_Click;

        Application.Run(form);
    }

    static void Form_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Ban da click vao form.");
    }
}