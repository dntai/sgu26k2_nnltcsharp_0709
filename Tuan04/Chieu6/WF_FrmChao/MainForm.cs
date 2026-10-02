namespace NNLTCSharp.WinForms;
class MainForm:Form
{
  	public MainForm()
      	{
      	    this.Text = "MainForm";

            this.BackColor = Color.Green; 
            this.Width = 300; 
            this.Height = 300; 
            this.MaximizeBox = false; 
            this.Cursor = Cursors.Hand; 
            this.StartPosition = FormStartPosition.CenterScreen; 

            button = new Button(); 
            button.Text = "OK"; 
            button.Location = new Point(100, 100);
 
            this.Controls.Add(button);

            button.Click += new EventHandler(button_Click);
        }

    protected override void OnClick(EventArgs e)
    {
        MessageBox.Show("Ban da click vao form.");
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        DialogResult result = MessageBox.Show("Ban muon dong form hay khong?", "Thong bao", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question);
        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

    private void button_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Ban da click vao nut OK.");
    }

    private Button button;
}
