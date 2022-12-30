namespace Adam_Asmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int hak = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string kelime = "TÝMSAH";
            textBox1.Text = textBox1.Text.ToUpper();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Bir Harf Girin");
            }
            else
            {
                if (textBox1.Text == kelime[0].ToString())
                {
                    label1.Text = "T";
                }
                else
                {
                    if (textBox1.Text == kelime[1].ToString())
                    {
                        label2.Text = "Ý";
                    }
                    else
                    {
                        if (textBox1.Text == kelime[2].ToString())
                        {
                            label3.Text = "M";
                        }
                        else
                        {
                            if (textBox1.Text == kelime[3].ToString())
                            {
                                label4.Text = "S";
                            }
                            else
                            {
                                if (textBox1.Text == kelime[4].ToString())
                                {
                                    label5.Text = "A";
                                }
                                else
                                {
                                    if (textBox1.Text == kelime[5].ToString())
                                    {
                                        label6.Text = "H";
                                    }
                                    else
                                    {
                                        hak++;
                                        if (hak == 1)
                                        {
                                            pictureBox1.ImageLocation = "images\\1.png";
                                        }
                                        else if (hak == 2)
                                        {
                                            pictureBox1.ImageLocation = "images\\2.png";
                                        }
                                        else if (hak == 3)
                                        {
                                            pictureBox1.ImageLocation = "images\\3.png";
                                        }
                                        else if (hak == 4)
                                        {
                                            pictureBox1.ImageLocation = "images\\4.png";
                                        }
                                        else if (hak == 5)
                                        {
                                            pictureBox1.ImageLocation = "images\\5.png";
                                        }
                                        else if (hak == 6)
                                        {
                                            pictureBox1.ImageLocation = "images\\6.png";
                                            button1.Enabled = false;
                                            textBox1.Enabled = false;
                                           
                                            MessageBox.Show("TÝMSAH", "Cevap");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (label1.Text == "T")
            {
                if (label2.Text == "Ý")
                {
                    if (label3.Text == "M")
                    {
                        if (label4.Text == "S")
                        {
                            if (label5.Text == "A")
                            {
                                if (label6.Text == "H")
                                {
                                    button1.Enabled = false;
                                    textBox1.Enabled = false;
                                    MessageBox.Show("Kazandýnýz :)");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}