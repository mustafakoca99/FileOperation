using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dosyaislemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //dosyaları getirir
            string[] dosyalar=Directory.GetFiles(toolStripStatusLabel1.Text,"*.*",SearchOption.TopDirectoryOnly);
            foreach (var item in dosyalar)
            {
                listBox1.Items.Add(item);
            }
            //klasörleri getirir
            string[] dizinler = Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory);
            foreach (var item in dizinler)
            {
                listBox2.Items.Add(item);
            }
            //klasör bilgileri
            FileInfo dosyabilgisi = new FileInfo(dosyalar[0]);
            DirectoryInfo dosyabilgisi2 = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
