namespace WF_FrmChao;

static class Program1
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Form form = new Form(); 
        form.Text = "First Application";

        Application.Run(form);
    }    
}