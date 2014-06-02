using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MedicalV2.Controls;

namespace MedicalV2
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            this.Controls.Add(new AllControl());
        }
    }
}
