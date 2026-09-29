namespace NNLTCS.WinForms;

static class Program2
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
            Form form = new Form();
             
            form.Text = "WinForm"; 
            form.BackColor = Color.Green; 
            form.Width = 300; 
            form.Height = 300; 
            form.MaximizeBox = false; 
            form.Cursor = Cursors.Hand; 
            form.StartPosition = FormStartPosition.CenterScreen; 
        
            Application.Run(form);
    }    
}