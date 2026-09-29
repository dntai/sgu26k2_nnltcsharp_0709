namespace NNLTCS.WinForms;
class MainForm:Form
{
  	public MainForm()
      	{
      	     this.Text = "MainForm";

            button = new Button(); 
            button.Text = "OK"; 
            button.Location = new Point(100, 100);
            button.Click += new EventHandler(button_Click); 
 
            this.Controls.Add(button);
        }

        void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban da click vao nut OK");
        }

        private Button button;
}
