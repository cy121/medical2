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
    public partial class Msg : Form
    {
        public Msg()
        {
            InitializeComponent();
        }

        private Form form;

        public Msg(string txt, string name, string id, Form form)
        {
            InitializeComponent();
            
            this.form = form;
            this.OkLabel.Text = txt;
            this.NameTextBox.Text = name;
            this.IdTextBox.Text = id;

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }
    }
}
