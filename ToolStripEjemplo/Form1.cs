namespace StripToolEjemp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripButton2.Visible = false;
            toolStripButton3.Visible = false;
            toolStripButton4.Visible = false;
            this.MaximizeBox = false;
            this.Text = "Ejemplo de ToolsTrip";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
         
            if (toolStripButton2.Visible == false)
            {
                toolStripButton2.Visible = true;
            }
            else
            {
                toolStripButton2.Visible = false;
            }

            if (toolStripButton3.Visible == false)
            {
                toolStripButton3.Visible = true;
            }
            else
            {
                toolStripButton3.Visible = false;
            }
            if (toolStripButton4.Visible == false)
            {
                toolStripButton4.Visible = true;
            }
            else
            {
                toolStripButton4.Visible = false;
            }
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == default)
            {
                MessageBox.Show("No se está mostrando ninguna imagen", "Error");
            }
            else
            {
                pictureBox1.Image = default;
            }
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }

        }

 
    }
}