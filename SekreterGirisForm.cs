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
    public partial class SekreterGirisForm : Form
    {
        public SekreterGirisForm()
        {
            InitializeComponent();
        }

        private void sGirisBtn_Click(object sender, EventArgs e)
        {
            if (skullaniciAdTxt.Text == "admin" && sSifreTxt.Text == "1234")
            {
                SekreterSayfaForm frm = new SekreterSayfaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış girilmiştir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
