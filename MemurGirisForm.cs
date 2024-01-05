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
    public partial class MemurGirisForm : Form
    {
        public MemurGirisForm()
        {
            InitializeComponent();
        }

        private void mGirisBtn_Click(object sender, EventArgs e)
        {
            if (mkullaniciAdTxt.Text == "admin1" && mSifreTxt.Text == "4567")
            {
                MemurSayfaForm frm = new MemurSayfaForm();
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
