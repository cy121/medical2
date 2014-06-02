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
    public partial class PresentHistoryControl : UserControl
    {
        private string[] controlArr = {"NeckcheckBox",
                        "HeatcheckBox",
                        "IdrosischeckBox",
                        "FeeblecheckBox",
                        "WeightLcheckBox",
                        "WeightHcheckBox",
                        "ShakecheckBox",
                        "LanguagecheckBox",
                        "NervouscheckBox",
                        "InsomniacheckBox",
                        "AngrycheckBox",
                        "MemorycheckBox",
                        "IllusioncheckBox",
                        "DepressioncheckBox",
                        "ColdcheckBox",
                        "PalpitationcheckBox",
                        "ChestcheckBox",
                        "BreathcheckBox",
                        "PolyphagiacheckBox",
                        "HungercheckBox",
                        "AppetitecheckBox",
                        "JaundicecheckBox",
                        "NauseacheckBox",
                        "ExophthalmoscheckBox",
                        "EyecheckBox",
                        "SensationcheckBox",
                        "PhotophobiacheckBox",
                        "TearscheckBox",
                        "StackcheckBox",
                        "StackcheckBox",
                        "EyesightcheckBox",
                        "DiplopiacheckBox",
                        "StrabismuscheckBox",
                        "IrregularcheckBox",
                        "AmenorrhoeacheckBox",
                        "MammarycheckBox",
                        "ImpotencecheckBox",
                        "SexlesscheckBox",
                        "ZhoucheckBox",
                        "DiscomfortcheckBox",
                        "FlaccidcheckBox",
                        "DefecatecheckBox"}; 

        public PresentHistoryControl()
        {
            InitializeComponent();
        }

        public PresentHistoryControl(String id)
        {
            InitializeComponent();
            PresentHistory ph = new PresentHistory();
            ph.readPresentHistory(id);
            this.MainReporttextBox.Text = ph.Main_report;
            Char[] c = ph.Symptom.ToCharArray();
            int a = c.Length;
            for (int i = 0; i < c.Length; i++) {
                if (c[i] == '1')
                {
                    Control[] ctls = this.Controls.Find(controlArr[i], true);
                    if (ctls.Length > 0)
                    {
                        CheckBox cb = (CheckBox)ctls[0];
                        cb.Checked = true;
                    }
                        
                }
            }
            this.FlaccidtextBox.Text = Convert.ToString(ph.Palsy_times);
            this.DefecatetextBox.Text = Convert.ToString(ph.Stool_times);
            this.OthertextBox.Text = ph.Else_things;
            this.ProcessrichTextBox.Text = ph.Treat_process;
        }
    }
}
