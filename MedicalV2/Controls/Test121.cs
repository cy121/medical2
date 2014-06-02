using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicalV2
{
    public partial class Test121 : UserControl
    {
        public Test121()
        {
            InitializeComponent();
        }

        public Test121(String id)
        {
            InitializeComponent();
            BasicInfo bi = new BasicInfo();
            bi.readBasicInfoById(id);
            NametextBox.Text = bi.P_name;
            SexcomboBox.Text = Convert.ToString(bi.P_sex);
            AgetextBox.Text = Convert.ToString(bi.P_age);
            MarriedcomboBox.Text = bi.P_married.ToString();
            RadicaltextBox.Text = bi.P_radical;
            HosIDtextBox.Text = Convert.ToString(bi.Hos_id);
            HomeaddrtextBox.Text = bi.P_home;
            BorntextBox.Text = bi.P_born;
            JodaddrtextBox.Text = bi.P_jobaddr;
            JobtextBox.Text = bi.P_job;
            TeletextBox.Text = bi.P_tel;

        }
    }
}
