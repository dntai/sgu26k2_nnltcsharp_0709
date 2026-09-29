namespace NNLTCS.WinForms;

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

            Application.Run(form);
    }

    static void Button_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Ban da click vao nut OK.");
    }
}