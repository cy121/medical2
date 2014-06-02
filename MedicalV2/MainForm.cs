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
    public partial class MainForm : Form
    {
        private static MainForm mf;

        private MainForm()
        {
            InitializeComponent();
        }

        public static MainForm CreateMF()
        {
            if (mf == null || mf.IsDisposed)
            {
                mf = new MainForm();
            }
            return mf;
        }

        private void CureFirstBtn_Click(object sender, EventArgs e)
        {
            CureFirst cf = new CureFirst();
            cf.Show();
            this.Hide();
            //AddForm af = new AddForm();
            //af.Show();
        }

        private void RandomVisitBtn_Click(object sender, EventArgs e)
        {
            SearchUpdateForm suf = new SearchUpdateForm();
            suf.Show();
            this.Hide();
            
        }

        

        private void SearchFollowVisitBtn_Click(object sender, EventArgs e)
        {
            SearchFollowVisitForm sfvf = new SearchFollowVisitForm();
            sfvf.Show();
            this.Hide();
        }

        
    }
}
