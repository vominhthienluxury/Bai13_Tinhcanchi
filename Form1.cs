using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai13_tinhcanchi_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            string[] canArr = { "canh ", "tân ", "Nhâm ", "quý ", "giáp ", "ất ", "bính ", "đinh ", "mậu ", "kỷ " };
            string[] chiArr = { "thân ", "dậu ", "tuất ", "hợi ", "tý ", "sửu ", "dần ", "mão ", "thìn ", "tị ", "ngọ ", "mùi " };
            string giatritrave = canArr[Convert.ToInt32(txtnhap.Text) % 10] + "" + chiArr[Convert.ToInt32(txtnhap.Text) % 12];
            txtkq.Text = giatritrave;
            int startyear = 2000;
            int endyear = 2050;
            for (int i = startyear; i <= endyear; i++)
            {
                lstkq.Items.Add(i + " - " + canArr[i % 10] + " " +chiArr[i % 12]);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
