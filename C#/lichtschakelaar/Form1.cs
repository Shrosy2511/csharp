namespace lichtschakelaar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            changeColor();
        }

        void changeColor()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Aqua)
            {
                this.BackColor = Color.LightGoldenrodYellow;
            }
            else {
                this.BackColor = Color.Aqua;
            }
        }
    }
}