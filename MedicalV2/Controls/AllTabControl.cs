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
    public partial class AllTabControl : UserControl
    {
        private string logId;

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


        private string[] etcCheck = { "ETCNodeNonecheckBox", "ETCNodeLesscheckBox", "ETCNodeMorecheckBox", "ETCLeftcheckBox", 
                                        "ETCRightcheckBox", "HotcheckBox", "WarmcheckBox", "ETCColdcheckBox"};

        private string[] bCheck = {"BNoduleNonecheckBox","BNoduleLesscheckBox","BNoduleMorecheckBox","BLeftcheckBox",
                                   "BRightcheckBox","BShiYongcheckBox","BNangcheckBox","BHuncheckBox"};

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

        public AllTabControl()
        {
            InitializeComponent();
        }

        public AllTabControl(string id)
        {
            InitializeComponent();
            logId = id;
            /**************现病史***********/
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



            /**************既往史***********/
            ConstHistory ch = new ConstHistory();
            ch.readConstHistory(id);
            PastrichTextBox.Text = ch.Past_his;
            ParentHisrichTextBox.Text = ch.Parent_his;
            Char[] personHis = ch.Person_his.ToCharArray();
            if (personHis[0] == '1')
                this.ResidentcheckBox.Checked = true;
            if (personHis[1] == '1')
                this.EatSeacheckBox.Checked = true;
            if (personHis[2] == '1')
                this.DrinkcheckBox.Checked = true;

            this.MarriAgetextBox.Text = Convert.ToString(ch.Mari_age);
            this.PregtextBox.Text = Convert.ToString(ch.Preg_times);
            this.BeartextBox.Text = Convert.ToString(ch.Bear_times);

            this.NatBeartextBox.Text = Convert.ToString(ch.Nat_bear);

            this.OpBeartextBox.Text = Convert.ToString(ch.Op_bear);
            this.NatAborttextBox.Text = Convert.ToString(ch.Nat_abort);
            this.OpAborttextBox.Text = Convert.ToString(ch.Op_abort);
            this.EarlyBeartextBox.Text = Convert.ToString(ch.Early_bear);
            this.DeadBeartextBox.Text = Convert.ToString(ch.Dead_bear);
            this.MenophaniaAgetextBox.Text = Convert.ToString(ch.Menophania_age);
            this.PeriodtextBox.Text = Convert.ToString(ch.Period);
            this.CycletextBox.Text = Convert.ToString(ch.Cycle_day);
            this.MenopauseYtextBox.Text = Convert.ToString(ch.Menopause_y);
            this.MenopauseMtextBox.Text = Convert.ToString(ch.Menopause_m);

            //经量
            if (ch.Bleed_amount == 0)
            {
                BleedFormalcheckBox.Checked = true;
            }

            else if (ch.Bleed_amount == 1)
            {
                BleedMorecheckBox.Checked = true; ;
            }

            else if (ch.Bleed_amount == 2)
            {
                BleedLesscheckBox.Checked = true;
            }

            //痛经
            if (ch.Meno_pain == 0)
            {
                MenoPainNonecheckBox.Checked = true;
            }
            else if (ch.Meno_pain == 1)
            {
                MenoPainHascheckBox.Checked = true;
            }

            //经期不规则
            if (ch.Meno_irregular == 0)
            {
                MenoIrregularNonecheckBox.Checked = true;
            }

            else if (ch.Meno_irregular == 1)
            {
                MenoIrregularHascheckBox.Checked = true;
            }

            BasicInfo bi = new BasicInfo();
            bi.readBasicInfoById(id);
            if(bi.P_sex == '1')
            {
                this.MarriagegroupBox.Visible = false;
                this.MenophaniagroupBox.Visible = false;
            }
               



            /**************体格检查***********/
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

            /**************实验室检查***********/
            LabInspect li = new LabInspect();
            li.readLabInspect(id);
            FT3textBox.Text = Convert.ToString(li.Ft3);
            FT4textBox.Text = Convert.ToString(li.Ft4);
            TSHtextBox.Text = Convert.ToString(li.Tsh);
            TT3textBox.Text = Convert.ToString(li.Tt3);
            TT4textBox.Text = Convert.ToString(li.Tt4);
            TPOAbtextBox.Text = Convert.ToString(li.Tpoab);
            TgAbtextBox.Text = Convert.ToString(li.Tgab);
            TRAbtextBox.Text = Convert.ToString(li.Trab);
            WBCtextBox.Text = Convert.ToString(li.Wbc);
            RBCtextBox.Text = Convert.ToString(li.Rbc);
            HbtextBox.Text = Convert.ToString(li.Hb);
            PLTtextBox.Text = Convert.ToString(li.Plt);
            NLtextBox.Text = (li.N.Split('%'))[0];
            NRtextBox.Text = (li.N.Split('%'))[1];
            LLtextBox.Text = (li.L.Split('%'))[0];
            LRtextBox.Text = (li.L.Split('%'))[0];
            TBtextBox.Text = Convert.ToString(li.Tb);
            DBtextBox.Text = Convert.ToString(li.Db);
            ALTtextBox.Text = Convert.ToString(li.Alt);
            ASTtextBox.Text = Convert.ToString(li.Ast);
            ALPtextBox.Text = Convert.ToString(li.Alp);
            yGTtextBox.Text = Convert.ToString(li.Ygt);
            TPtextBox.Text = Convert.ToString(li.Tp);
            ALBtextBox.Text = Convert.ToString(li.Alb);
            GLOtextBox.Text = Convert.ToString(li.Glo);
            AGtextBox.Text = Convert.ToString(li.Ag);
            BUNtextBox.Text = Convert.ToString(li.Bun);
            UatextBox.Text = Convert.ToString(li.Ua);
            CRtextBox.Text = Convert.ToString(li.Cr);
            GLUtextBox.Text = Convert.ToString(li.Glu);
            SCtextBox.Text = Convert.ToString(li.Sc);
            KtextBox.Text = Convert.ToString(li.K);
            PtextBox.Text = Convert.ToString(li.P);
            ElseThingrichTextBox.Text = li.Else_inspect;

            /**************影像学检查***********/
            ImageInspect ii = new ImageInspect();
            ii.readImageInspect(id);
            this.ECGtextBox.Text = ii.Ecg;
            this.ETCleftLtextBox.Text = (ii.Ect_left.Split('×'))[0];
            this.ETCleftRtextBox.Text = (ii.Ect_left.Split('×'))[1];
            this.ETCRightLtextBox.Text = (ii.Ect_right.Split('×'))[0];
            this.ETCRightRtextBox.Text = (ii.Ect_right.Split('×'))[1];
            this.ETCAreatextBox.Text = Convert.ToString(ii.Ect_area);
            this.ETCTBtextBox.Text = Convert.ToString(ii.Ect_tb);
            this.ETCWeighttextBox.Text = Convert.ToString(ii.Ect_weight);
            char[] etc = ii.Ect_inspect.ToCharArray();
            for (int i = 0; i < etc.Length; i++)
            {
                if (etc[i] == '1')
                {
                    Control[] ctls = this.Controls.Find(etcCheck[i], true);
                    if (ctls.Length > 0)
                    {
                        CheckBox cb = (CheckBox)ctls[0];
                        cb.Checked = true;
                    }

                }
            }
            this.ETCNoduleLtextBox.Text = (ii.Ect_nodule.Split('×'))[0];
            this.ETCNoduleRtextBox.Text = (ii.Ect_nodule.Split('×'))[1];
            this.BLeftLtextBox.Text = (ii.B_left.Split('×'))[0];
            this.BLeftRtextBox.Text = (ii.B_left.Split('×'))[1];
            this.BRightLtextBox.Text = (ii.B_right.Split('×'))[0];
            this.BRightRtextBox.Text = (ii.B_right.Split('×'))[1];
            this.BAreatextBox.Text = Convert.ToString(ii.B_area);
            this.BWeighttextBox.Text = Convert.ToString(ii.B_weight);

            char[] b = ii.B_inspect.ToCharArray();
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == '1')
                {
                    Control[] ctls = this.Controls.Find(bCheck[i], true);
                    if (ctls.Length > 0)
                    {
                        CheckBox cb = (CheckBox)ctls[0];
                        cb.Checked = true;
                    }

                }
            }

            this.BNoduleLtextBox.Text = (ii.B_nodule.Split('×'))[0];
            this.BNoduleRighttextBox.Text = (ii.B_nodule.Split('×'))[1];
            this.ElseJtextBox.Text = Convert.ToString(ii.Else_inspect);
            this.DiagnosisrichTextBox.Text = ii.Diagnosis;

            /**************治疗计划***********/

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
            
        }

        private void MenophaniagroupBox_Enter(object sender, EventArgs e)
        {

        }

        

       

        
    }
}
