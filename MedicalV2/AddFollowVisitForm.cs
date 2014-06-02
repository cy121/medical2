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
    public partial class AddFollowVisitForm : Form
    {
        private String cfId;
        private DateTime datetime;
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

        public AddFollowVisitForm()
        {
            InitializeComponent();
            DateTime dt = DateTime.Now;
            datetime = dt;
            cfId = string.Format("{0:yyyyMMddHHmm}", dt);
        }

        public AddFollowVisitForm(string id)
        {
            InitializeComponent();
            DateTime dt = DateTime.Now;
            
            datetime = dt;
            //cfId = string.Format("{0:yyyyMMddHHmm}", dt);
            cfId = id;
            BasicInfo bi = new BasicInfo();
           
            this.Text = "登记号" + cfId;
            bi.readBasicInfoById(id);
            this.NametextBox.Text= bi.P_name;
            if (bi.P_sex == '1')
                this.SexTextBox.Text = "男";
            else 
                this.SexTextBox.Text = "女";
            this.AgetextBox.Text = Convert.ToString(bi.P_age);
            this.HosIDtextBox.Text = Convert.ToString(bi.Hos_id);
            this.TeletextBox.Text = bi.P_tel;
            
        }

        

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            FollowVisit fv = new FollowVisit();

            fv.Fv_id = cfId;
            //fv.Log_id = cfId;
            fv.Main_report = this.MainReportTextBox.Text;
            fv.Fv_date = datetime.ToString();
            fv.Heavy_thing = this.HeavyTextBox.Text;
            fv.Light_thing = this.LightTextBox.Text;
            fv.Heart_rate = Convert.ToInt32(this.HeartRatetextBox.Text);
            if (this.HeartRythmCheckBox.Checked)
                fv.Heart_rythm = 1;
            else fv.Heart_rythm = 0;
            fv.Thyroid_size = Convert.ToInt32(this.ThyroidSizeTextBox.Text);
            fv.Thyroid_grain = this.ThyroidGrainTextBox.Text;
            fv.Ph_else = this.phElseTextBox.Text;
            fv.Ft3 = Convert.ToDouble(FT3textBox.Text.Trim());
            fv.Ft4 = Convert.ToDouble(FT4textBox.Text.Trim());
            fv.Tsh = Convert.ToDouble(TSHtextBox.Text.Trim());
            fv.Tt3 = Convert.ToDouble(TT3textBox.Text.Trim());
            fv.Tt4 = Convert.ToDouble(TT4textBox.Text.Trim());
            fv.Tpoab = Convert.ToDouble(TPOAbtextBox.Text.Trim());
            fv.Tgab = Convert.ToDouble(TgAbtextBox.Text.Trim());
            fv.Trab = Convert.ToDouble(TRAbtextBox.Text.Trim());
            fv.Wbc = Convert.ToDouble(WBCtextBox.Text.Trim());
            fv.Rbc = Convert.ToDouble(RBCtextBox.Text.Trim());
            fv.Hb = Convert.ToDouble(HbtextBox.Text.Trim());
            fv.Plt = Convert.ToDouble(PLTtextBox.Text.Trim());
            fv.N = NLtextBox.Text.Trim() + "%" + NRtextBox.Text.Trim();
            fv.L = LLtextBox.Text.Trim() + "%" + LRtextBox.Text.Trim();
            fv.Tb = Convert.ToDouble(TBtextBox.Text.Trim());
            fv.Db = Convert.ToDouble(DBtextBox.Text.Trim());
            fv.Alt = Convert.ToDouble(ALTtextBox.Text.Trim());
            fv.Ast = Convert.ToDouble(ASTtextBox.Text.Trim());
            fv.Alp = Convert.ToDouble(ALPtextBox.Text.Trim());
            fv.Ygt = Convert.ToDouble(yGTtextBox.Text.Trim());
            fv.Tp = Convert.ToDouble(TPtextBox.Text.Trim());
            fv.Alb = Convert.ToDouble(ALBtextBox.Text.Trim());
            fv.Glo = Convert.ToDouble(GLOtextBox.Text.Trim());
            fv.Ag = Convert.ToDouble(AgetextBox.Text.Trim());
            fv.Bun = Convert.ToDouble(BUNtextBox.Text.Trim());
            fv.Ua = Convert.ToDouble(UatextBox.Text.Trim());
            fv.Cr = Convert.ToDouble(CRtextBox.Text.Trim());
            fv.Glu = Convert.ToDouble(GLUtextBox.Text.Trim());
            fv.Lab_else = ElseThingrichTextBox.Text.Trim();
            fv.Handle = this.HandleTextBox.Text;
            fv.insertFollowVisit(cfId);
        }

        private void AddFollowVisitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.CreateMF().Show();
        }
    }
}
