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
    public partial class SearchResultForm : Form
    {
        private string id;
        private string[] thyroidCheck = {"BigcheckBox",
                                "QuantityLesscheckBox",
                                "QuantityFormalcheckBox",
                                "QuantityMorecheckBox",
                                "DiffusiblecheckBox",
                                "TremblecheckBox",
                                "VesselcheckBox",
                                "NoduleNonecheckBox",
                                "NoduleLesscheckBox",
                                "NoduleMorecheckBox",
                                "PainNonecheckBox",
                                "PainLesscheckBox",
                                "PainMorecheckBox",
                                "LeftcheckBox",
                                "RightcheckBox",
                                "DissymmetrycheckBox"};

        private string[] heartCheck = {"HeartFormalcheckBox",
                                "HeartInformalcheckBox",
                                "HeartEarlycheckBox",
                                "NoiseNonecheckBox",
                                "NoiseHascheckBox",
                                "SystolecheckBox",
                                "DiastolecheckBox",
                                "BorderFormalcheckBox",
                                "BorderMorecheckBox",
                                "BreathClearcheckBox",
                                "BreathGancheckBox",
                                "BreathShicheckBox",
                                "LeftLungcheckBox",
                                "RightLungcheckBox" };

        private string[] eyeCheck = {"EyeTucheckBox",
                                    "FlashcheckBox",
                                    "FaceMorecheckBox",
                                    "EyelidLowcheckBox",
                                    "EyelidMorecheckBox",
                                    "ConjunctivacheckBox",
                                    "FullBloodcheckBox",
                                    "VoncheckBox",
                                    "JofforycheckBox",
                                    "MobiuscheckBox"};


        private string[] otherCheck = {"PachylosischeckBox",
                                "YellowcheckBox",
                                "SweetcheckBox",
                                "PointcheckBox",
                                "WatercheckBox",
                                "FaircheckBox" };

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
                        "AsthenopiacheckBox",
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
        private int b;

        public SearchResultForm(String logId, int n)
        {
            InitializeComponent();
            b = n;
            if (n == 0) this.UpdateBtn.Visible = false;
            else if (n == 1) this.AddFVBtn.Visible = false;
            this.Text = "登记号：" + logId;
            BasicInfo bi = new BasicInfo();
            id = logId;
            bi.readBasicInfoById(logId);
            NametextBox.Text = bi.P_name;
            //SexcomboBox.Text = Convert.ToString(bi.P_sex);
            if (bi.P_sex == '1') SexTextBox.Text = "男";
            else SexTextBox.Text = "女";
            //SexTextBox.Text = Convert.ToString(bi.P_sex);
            AgetextBox.Text = Convert.ToString(bi.P_age);
            TeletextBox.Text = bi.P_tel;
            HosIDtextBox.Text = Convert.ToString(bi.Hos_id);
            Control phc = new PresentHistoryControl(id);
            Control pic = new PhysicalInspectControl(id);
            Control cpc = new CurePlanControl(id);
           
            //this.PresentHistorytabPage.Controls.Add(phc);
            //this.PhysicalInspecttabPage.Controls.Add(pic);
            //this.CurePlantabPage.Controls.Add(cpc);

            PhysicalInspect pi = new PhysicalInspect();
            pi.readPhysicalInspect(id);
            Char[] thyroid = pi.Thyroid_inspect.ToCharArray();
            Char[] heart = pi.Heart_inspect.ToCharArray();
            Char[] eye = pi.Eye_inspect.ToCharArray();
            Char[] other = pi.Else_inspect.ToCharArray();
            for (int i = 0; i < thyroid.Length; i++)
            {
                if (thyroid[i] == '1')
                {
                    Control[] ctls = this.Controls.Find(thyroidCheck[i], true);
                    if (ctls.Length > 0)
                    {
                        CheckBox cb = (CheckBox)ctls[0];
                        cb.Checked = true;
                    }

                }
            }

            for (int i = 0; i < heart.Length; i++)
            {
                if (heart[i] == '1')
                {
                    Control[] ctls = this.Controls.Find(heartCheck[i], true);
                    if (ctls.Length > 0)
                    {
                        CheckBox cb = (CheckBox)ctls[0];
                        cb.Checked = true;
                    }

                }
            }

            for (int i = 0; i < eye.Length; i++)
            {
                if (eye[i] == '1')
                {
                    Control[] ctls = this.Controls.Find(eyeCheck[i], true);
                    if (ctls.Length > 0)
                    {
                        CheckBox cb = (CheckBox)ctls[0];
                        cb.Checked = true;
                    }

                }
            }

            for (int i = 0; i < other.Length; i++)
            {
                if (other[i] == '1')
                {
                    Control[] ctls = this.Controls.Find(otherCheck[i], true);
                    if (ctls.Length > 0)
                    {
                        CheckBox cb = (CheckBox)ctls[0];
                        cb.Checked = true;
                    }

                }
            }

            this.BiggertextBox.Text = Convert.ToString(pi.Thyroid_bigger);
            this.LefttextBox.Text = Convert.ToString(pi.Thyroid_left);
            this.RighttextBox.Text = Convert.ToString(pi.Thyroid_right);
            this.HeartRatetextBox.Text = Convert.ToString(pi.Heart_rate);
            this.NoiseLeveltextBox.Text = Convert.ToString(pi.Noise_level);
            this.BloodLowtextBox.Text = Convert.ToString(pi.Blood_lpressure);
            this.BloodHightextBox.Text = Convert.ToString(pi.Blood_hpressure);
            this.EyeLefttextBox.Text = Convert.ToString(pi.Left_eye_out);
            this.EyeRighttextBox.Text = Convert.ToString(pi.Right_eye_out);
            this.EyeDistancetextBox.Text = Convert.ToString(pi.Eye_distance);


            PresentHistory ph = new PresentHistory();
            ph.readPresentHistory(id);
            this.MainReporttextBox.Text = ph.Main_report;
            Char[] c = ph.Symptom.ToCharArray();
            int a = c.Length;
            for (int i = 0; i < c.Length; i++)
            {
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


            if (cp.Illness_course == 1)
            {
                this.IDosageCoursetextBox.Text = "≤1年";
            }
            else if (cp.Illness_course == 2)
            {
                IDosageCoursetextBox.Text = ">1≤2年";
            }
            else if (cp.Illness_course == 3)
            {
                IDosageCoursetextBox.Text = ">2≤3年";
            }
            else if (cp.Illness_course == 4)
            {
                IDosageCoursetextBox.Text = ">3≤4年";
            }
            else
            {
                IDosageCoursetextBox.Text = ">4年";
            }
            if (cp.Illness_states == 1)
            {
                this.IDosageStatetextBox.Text = "轻";
            }
            else if (cp.Illness_states == 2)
            {
                IDosageStatetextBox.Text = "中";
            }
            else
            {
                IDosageStatetextBox.Text = "重";
            }
            
            this.PlantextBox.Text = Convert.ToString(cp.Plan_dose);

            foreach (Control control in Controls)
            {

                if (control is TextBox)
                {
                    TextBox tb = (TextBox)control;
                    tb.ReadOnly = true;
                }
                if (control is CheckBox)
                {
                    CheckBox cb = (CheckBox)control;
                    cb.Enabled = false;
                }
            }
        }

        private AllTabControl allTabControl;

        

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            
            allTabControl = new AllTabControl(id);
            this.tabControlAll.Visible = false;
            this.ShowPanel.Controls.Add(allTabControl);
            if (b == 0) this.UpdateBtn.Visible = false;
            else if (b == 1) this.AddFVBtn.Visible = false;
            //Control iic = new ImageInspectControl(id);
            //Control lic = new LabInspectControl(id);
            //Control chc = new ConstHistoryControl(id);
           //this.tabPage1.Controls.Add(iic);
           // this.tabPage2.Controls.Add(lic);
            //this.tabPage3.Controls.Add(chc);
            //new ShowAll().Show();
            //this.ShowAllBtn.Visible = false;
            //this.UpdateBtn.Visible = true;
            
        }

        

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            /***********************更新操作************************/
            //allTabControl.Update();
            new UpdateForm(id).Show();
            this.Hide();
        }

        private void AddFVBtn_Click(object sender, EventArgs e)
        {
            new AddFollowVisitForm(id).Show();
            this.Hide();
        }

        private void SearchResultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.CreateMF().Show();
        }

        

        
    }
}
