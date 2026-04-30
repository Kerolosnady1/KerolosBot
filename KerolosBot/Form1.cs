using System.Diagnostics;
using System.IO;
namespace KerolosBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataBtn_Click(object sender, EventArgs e)
        {

            string questionFile = "messages4KerolosBot.txt";
            string responseFile = "response4KerolosBot.txt";
            string pythonScript = "ai_engine.py";

            try
            {
                // Save user message
                File.WriteAllText(questionFile, textBox1.Text);
                textBox1.Clear();
                // Make python script ready
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = "python.exe";
                start.Arguments = $"\"{pythonScript}\""; // ai_engine.py as argument
                start.UseShellExecute = false;
                start.CreateNoWindow = true;

                // Running python script and waiting for response
                using (Process process = Process.Start(start))
                {
                    process.WaitForExit();
                }

                // Read the response file
                if (File.Exists(responseFile))
                {
                    string botResponse = File.ReadAllText(responseFile);

                    textBox2.Text = botResponse;
                }
                else
                {
                    MessageBox.Show("The bot didn't create the response file ;(");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurs: " + ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            radioButton1.ForeColor = Color.White;
            radioButton2.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            groupBox1.ForeColor = Color.White;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            radioButton1.ForeColor = Color.Black;
            radioButton2.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            groupBox1.ForeColor = Color.Black;
        }
    }
}
