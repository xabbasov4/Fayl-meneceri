namespace Fayl_meneceri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            toolStripStatusLabel1.Text = "Hazýrdýr | Fayl sayý: 0";
        }
        int n = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Create file *.* | *.*";
            sv.FileName = "document" + n;

            if (sv.ShowDialog() == DialogResult.OK)
            {
                File.Create(sv.FileName).Close();
                n++;

                textBox1.Text = sv.FileName;
                listBox1.Items.Add(Path.GetFileName(sv.FileName));
                toolStripStatusLabel1.Text = "Fayl sayý: " + listBox1.Items.Count;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog sv = new OpenFileDialog();
            sv.Filter = "write file *.txt | *.txt";

            if (sv.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(sv.FileName))
                {
                    MessageBox.Show("sened secilmeyib", "dayan", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    File.AppendAllText(sv.FileName, richTextBox1.Text);

                    FileInfo fi = new FileInfo(sv.FileName);
                    double olcuKB = Math.Round((double)fi.Length / 1024, 1);
                    label1.Text = "Ad: " + fi.Name + " | Ölçü: " + olcuKB + " KB";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog sv = new OpenFileDialog();
            sv.Filter = "write file *.txt | *.txt";

            if (sv.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(sv.FileName))
                {
                    MessageBox.Show("sened secilmeyib", "dayan", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    richTextBox1.Text = File.ReadAllText(sv.FileName);
                    textBox1.Text = sv.FileName;

                    FileInfo fi = new FileInfo(sv.FileName);
                    double olcuKB = Math.Round((double)fi.Length / 1024, 1);
                    label1.Text = "Ad: " + fi.Name + " | Ölçü: " + olcuKB + " KB | Tarix: " + fi.CreationTime.ToString("dd.MM.yyyy");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog sv = new OpenFileDialog();
            sv.Filter = "write file *.txt | *.txt";

            if (sv.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(sv.FileName))
                {
                    MessageBox.Show("sened secilmeyib", "dayan", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    DialogResult d = MessageBox.Show("file silinsin mi?", "sual", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        File.Delete(sv.FileName);
                        richTextBox1.Text = sv.FileName + " - file silindi";
                        label1.Text = "melumat";
                        textBox1.Clear();

                        string faylAdi = Path.GetFileName(sv.FileName);
                        if (listBox1.Items.Contains(faylAdi))
                        {
                            listBox1.Items.Remove(faylAdi);
                        }
                        toolStripStatusLabel1.Text = "Fayl sayý: " + listBox1.Items.Count;
                    }
                }
            }
        }
    }
}