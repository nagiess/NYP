using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UniversityArchive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MemurGirisBtn_Click(object sender, EventArgs e)
        {
            MemurGirisForm memurGirisForm = new MemurGirisForm();
            memurGirisForm.Show();
            this.Hide();
        }

        private void SekreterGirisBtn_Click(object sender, EventArgs e)
        {
            SekreterGirisForm sekreterGirisForm = new SekreterGirisForm();
            sekreterGirisForm.Show();
            this.Hide();
        }
    }
}
