using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Thread thread;
        SiteParser siteParser;
        Banck banck;

        public Form1()
        {
            InitializeComponent();
            siteParser = new SiteParser();
            thread = new Thread(getSite);
            thread.Start();
            thread.Join();
            JosnToBank josnToBank = new JosnToBank();
            banck = josnToBank.GetBanck(siteParser.Page);
            List<string> valuteName = (from q in banck.Valute select q.Value.Name).ToList();
            comboBox1.DataSource = valuteName;
        }

        void getSite()
        {
            siteParser.HtmlToSite("https://www.cbr-xml-daily.ru/daily_json.js");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Valute val = (from q in banck.Valute where q.Value.Name == comboBox1.Text select q.Value).FirstOrDefault();
            richTextBox1.Text = "Стоимость в рублях: " + val.Value;
            richTextBox1.Text += "\nноминал: " + val.Nominal.ToString();
        }
    }
}
