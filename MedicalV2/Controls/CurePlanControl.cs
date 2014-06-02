using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicalV2.Controls
{
    public partial class CurePlanControl : UserControl
    {
        private string[] efCheck = {"AgecheckBox",
                                "ZhengcheckBox",
                                "HecheckBox",
                                "BingcheckBox",
                                "shoushucheckBox",
                                "ATDcheckBox",
                                "fufacheckBox",
                                "JiacheckBox",
                                "JiejiecheckBox",
                                "qitacheckBox" };

        public CurePlanControl()
        {
            InitializeComponent();
        }

        public CurePlanControl(string id)
        {
            InitializeComponent();
            CurePlan cp = new CurePlan();
            cp.readCurePlan(id);
            this.twohtextBox.Text = Convert.ToString(cp.Twoh_rate);
            this.TwoFhtextBox.Text = Convert.ToString(cp.Twentyfourh_rate);
            if (cp.Rate_level == 0)
            {
                NormalcheckBox.Checked = true;
            }

            if (cp.Rate_level == 1)
            {
                MorecheckBox.Checked = true;
            }

            if (cp.Rate_level == -1)
            {
                LesscheckBox.Checked = true;
            }
            this.RecomtextBox.Text = Convert.ToString(cp.Recom_dose);
            this.PlantextBox.Text = Convert.ToString(cp.Plan_dose);
            this.CaltextBox.Text = Convert.ToString(cp.Cal_dose);
            this.RealtextBox.Text = Convert.ToString(cp.Real_dose);
            Char[] ef = cp.Ef_factor.ToCharArray();
            for (int i = 0; i < ef.Length; i++)
            {
                if (ef[i] == '1')
                {
                    Control[] ctls = this.Controls.Find(efCheck[i], true);
                    if (ctls.Length > 0)
                    {
                        CheckBox cb = (CheckBox)ctls[0];
                        cb.Checked = true;
                    }

                }
            }
            this.ElsethingtextBox.Text = cp.Ef_else;
            this.elserichTextBox.Text = cp.Else_things;
        }
    }
}
