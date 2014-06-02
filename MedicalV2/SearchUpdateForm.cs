using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicalV2
{
    public partial class SearchUpdateForm : Form
    {
        

        public SearchUpdateForm()
        {
            InitializeComponent();
            
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string id = LogIdTextBox.Text;
            BasicInfo bi = new BasicInfo();
            bi.readBasicInfoById(id);
            try {
                string fid = bi.Log_id;
                SearchResultForm fvf = new SearchResultForm(id, 1);
                fvf.Show();
                this.Hide();
            }catch (NullReferenceException ee)
            {
                MessageBox.Show("查询不存在！");
            }

            
               
            
        }

        private void SearchUpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.CreateMF().Show();
        }

        private void SearchBynameBtn_Click(object sender, EventArgs e)
        {
            string id = NameTextBox.Text.Trim();
            BasicInfo bi = new BasicInfo();
            bi.readBasicInfoByName(id);
            try
            {
                string fid = bi.Log_id;
                SearchResultForm fvf = new SearchResultForm(fid, 1);
                fvf.Show();
                this.Hide();
            }
            catch (NullReferenceException ee)
            {
                MessageBox.Show("查询不存在！");
            }
        }
    }
}
