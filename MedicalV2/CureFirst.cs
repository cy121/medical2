using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using MySql;

namespace MedicalV2
{
    public partial class CureFirst : Form
    {
        private String cfId;

        public CureFirst()
        {
            InitializeComponent();
            DateTime dt = DateTime.Now;
            cfId = string.Format("{0:yyyyMMddHHmm}", dt);
            //string hostId = string.Format("{0:HHmm}", dt);
            this.Text = "初治" + cfId;
            //this.HosIDtextBox.Text = hostId;
            //this.HosIDtextBox.ReadOnly = true;
            this.SexcomboBox.SelectedIndex = 0;
            this.MarriedcomboBox.SelectedIndex = 0;
            this.MarriagegroupBox.Visible = false;
            this.MenophaniagroupBox.Visible = false;
        }

        private void BasicInfogroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void CureFirst_Load(object sender, EventArgs e)
        {

        }

        private void saveAllBtn_Click(object sender, EventArgs e)
        {
            //基本信息
            BasicInfo basicinfo = new BasicInfo();
            basicinfo.Log_id = cfId.Trim();
            basicinfo.P_name = NametextBox.Text.Trim();
            if (SexcomboBox.Text.Trim().Equals("男"))
            {
                basicinfo.P_sex = '1';
            }
            else
            {
                basicinfo.P_sex = '0';
            }
            basicinfo.P_age = Convert.ToInt32(AgetextBox.Text.Trim());
            if (MarriedcomboBox.Text.Trim().Equals("已婚"))
            {
                basicinfo.P_married = '1';
            }
            else
            {
                basicinfo.P_married = '0';
            }
            basicinfo.P_radical = RadicaltextBox.Text.Trim();
            basicinfo.Hos_id = Convert.ToInt32(HosIDtextBox.Text.Trim());
            basicinfo.P_home = HometextBox.Text.Trim();
            basicinfo.P_born = BorntextBox.Text.Trim();
            basicinfo.P_jobaddr = JodaddrtextBox.Text.Trim();
            basicinfo.P_job = JobtextBox.Text.Trim();
            basicinfo.P_addr = HomeaddrtextBox.Text.Trim();
            basicinfo.P_tel = TeletextBox.Text.Trim();
            basicinfo.P_email = EmailtextBox.Text.Trim();
            basicinfo.P_contact = ContacttextBox.Text.Trim();
            basicinfo.P_relation = RelationtextBox.Text.Trim();


            /***********************************************************************************
         * 基本症状保存*
         ***********************************************************************************/
            PresentHistory presenthistory = new PresentHistory();
            presenthistory.Main_report = MainReporttextBox.Text.Trim();                  //主述
            presenthistory.Else_things = OthertextBox.Text.Trim();                       //其他
            char[] symptom = new char[50];
            if (NeckcheckBox.Checked) //颈粗
            {
                symptom[0] = '1';
            }
            else
            {
                symptom[0] = '0';
            }
            if (HeatcheckBox.Checked) //怕热
            {
                symptom[1] = '1';
            }
            else
            {
                symptom[1] = '0';
            }
            if (IdrosischeckBox.Checked) //多汗
            {
                symptom[2] = '1';
            }
            else
            {
                symptom[2] = '0';
            }
            if (FeeblecheckBox.Checked)  //乏力
            {
                symptom[3] = '1';
            }
            else
            {
                symptom[3] = '0';
            }
            if (WeightLcheckBox.Checked)  //体重减轻
            {
                symptom[4] = '1';
            }
            else
            {
                symptom[4] = '0';
            }
            if (WeightHcheckBox.Checked)  //体重增加
            {
                symptom[5] = '1';
            }
            else
            {
                symptom[5] = '0';
            }
            if (ShakecheckBox.Checked)  //手颤
            {
                symptom[6] = '1';
            }
            else
            {
                symptom[6] = '0';
            }
            if (LanguagecheckBox.Checked)  //多言多动
            {
                symptom[7] = '1';
            }
            else
            {
                symptom[7] = '0';
            }
            if (NervouscheckBox.Checked)  //紧张多虑
            {
                symptom[8] = '1';
            }
            else
            {
                symptom[8] = '0';
            }
            if (InsomniacheckBox.Checked)  //失眠
            {
                symptom[9] = '1';
            }
            else
            {
                symptom[9] = '0';
            }
            if (AngrycheckBox.Checked)  //焦躁易怒
            {
                symptom[10] = '1';
            }
            else
            {
                symptom[10] = '0';
            }
            if (MemorycheckBox.Checked)  //记忆力减退
            {
                symptom[11] = '1';
            }
            else
            {
                symptom[11] = '0';
            }
            if (IllusioncheckBox.Checked)  //幻觉
            {
                symptom[12] = '1';
            }
            else
            {
                symptom[12] = '0';
            }
            if (DepressioncheckBox.Checked)  //寡言抑郁
            {
                symptom[13] = '1';
            }
            else
            {
                symptom[13] = '0';
            }
            if (ColdcheckBox.Checked)  //神情冷漠
            {
                symptom[14] = '1';
            }
            else
            {
                symptom[14] = '0';
            }
            if (PalpitationcheckBox.Checked)  //心悸
            {
                symptom[15] = '1';
            }
            else
            {
                symptom[15] = '0';
            }
            if (ChestcheckBox.Checked)  //胸闷
            {
                symptom[16] = '1';
            }
            else
            {
                symptom[16] = '0';
            }
            if (BreathcheckBox.Checked)  //气短
            {
                symptom[17] = '1';
            }
            else
            {
                symptom[17] = '0';
            }
            if (PolyphagiacheckBox.Checked)  //多食
            {
                symptom[18] = '1';
            }
            else
            {
                symptom[18] = '0';
            }
            if (HungercheckBox.Checked)  //易饥
            {
                symptom[19] = '1';
            }
            else
            {
                symptom[19] = '0';
            }
            if (AppetitecheckBox.Checked)  //食欲减退
            {
                symptom[20] = '1';
            }
            else
            {
                symptom[20] = '0';
            }
            if (JaundicecheckBox.Checked)  //黄疸
            {
                symptom[21] = '1';
            }
            else
            {
                symptom[21] = '0';
            }
            if (NauseacheckBox.Checked)  //恶心呕吐
            {
                symptom[22] = '1';
            }
            else
            {
                symptom[22] = '0';
            }
            if (ExophthalmoscheckBox.Checked)  //突眼
            {
                symptom[23] = '1';
            }
            else
            {
                symptom[23] = '0';
            }
            if (EyecheckBox.Checked)  //眼胀
            {
                symptom[24] = '1';
            }
            else
            {
                symptom[24] = '0';
            }
            if (SensationcheckBox.Checked)  //眼异物感
            {
                symptom[25] = '1';
            }
            else
            {
                symptom[25] = '0';
            }
            if (PhotophobiacheckBox.Checked)  //怕光
            {
                symptom[26] = '1';
            }
            else
            {
                symptom[26] = '0';
            }
            if (TearscheckBox.Checked)  //流泪
            {
                symptom[27] = '1';
            }
            else
            {
                symptom[27] = '0';
            }
            if (StackcheckBox.Checked)  //刺痛
            {
                symptom[28] = '1';
            }
            else
            {
                symptom[28] = '0';
            }
            if (AsthenopiacheckBox.Checked)  //视力疲劳
            {
                symptom[29] = '1';
            }
            else
            {
                symptom[29] = '0';
            }
            if (EyesightcheckBox.Checked)  //视力减退
            {
                symptom[30] = '1';
            }
            else
            {
                symptom[30] = '0';
            }
            if (DiplopiacheckBox.Checked)  //复视
            {
                symptom[31] = '1';
            }
            else
            {
                symptom[31] = '0';
            }
            if (StrabismuscheckBox.Checked)  //斜视
            {
                symptom[32] = '1';
            }
            else
            {
                symptom[32] = '0';
            }
            if (IrregularcheckBox.Checked)  //月经不调
            {
                symptom[33] = '1';
            }
            else
            {
                symptom[33] = '0';
            }
            if (AmenorrhoeacheckBox.Checked)  //闭经
            {
                symptom[34] = '1';
            }
            else
            {
                symptom[34] = '0';
            }
            if (MammarycheckBox.Checked)  //乳腺增生
            {
                symptom[35] = '1';
            }
            else
            {
                symptom[35] = '0';
            }
            if (ImpotencecheckBox.Checked)  //阳痿
            {
                symptom[36] = '1';
            }
            else
            {
                symptom[36] = '0';
            }
            if (SexlesscheckBox.Checked)  //性冷淡
            {
                symptom[37] = '1';
            }
            else
            {
                symptom[37] = '0';
            }
            if (ZhoucheckBox.Checked)  //周麻
            {
                symptom[38] = '1';
            }
            else
            {
                symptom[38] = '0';
            }
            if (DiscomfortcheckBox.Checked)  //颈前不适
            {
                symptom[39] = '1';
            }
            else
            {
                symptom[39] = '0';
            }
            if (FlaccidcheckBox.Checked)  //软瘫
            {
                symptom[40] = '1';
                presenthistory.Palsy_times = Convert.ToInt32(FlaccidtextBox.Text.Trim());   //软瘫次数
            }
            else
            {
                symptom[40] = '0';
                presenthistory.Palsy_times = 0;   //软瘫次数
            }


            if (DefecatecheckBox.Checked)  //大便次数增多
            {
                symptom[41] = '1';
                presenthistory.Stool_times = Convert.ToInt32(DefecatetextBox.Text.Trim());   //大便次数
            }
            else
            {
                symptom[41] = '0';
                presenthistory.Stool_times = 0;   //大便次数
            }
            string symptom_string = new string(symptom);
            presenthistory.Symptom = symptom_string.Trim();  //症状
            presenthistory.Treat_process = ProcessrichTextBox.Text.Trim();      //发病及治疗经过

            /***********************************************************************************
            * 既往史保存*
            ***********************************************************************************/
            ConstHistory consthistory = new ConstHistory();
            /*既往史*/
            consthistory.Past_his = PastrichTextBox.Text.Trim();

            /*个人史*/
            char[] personhistory = new char[10];
            if (ResidentcheckBox.Checked)          //沿海地区居住10年以上
            {
                personhistory[0] = '1';
            }
            else
            {
                personhistory[0] = '0';
            }
            if (EatSeacheckBox.Checked)          //有食用海产品
            {
                personhistory[1] = '1';
            }
            else
            {
                personhistory[1] = '0';
            }
            if (DrinkcheckBox.Checked)          //饮凉茶的习惯
            {
                personhistory[2] = '1';
            }
            else
            {
                personhistory[2] = '0';
            }
            string person_his = new string(personhistory);
            consthistory.Person_his = person_his.Trim();


            /*婚育史*/
            if (this.MarriedcomboBox.Text == "已婚" && this.SexcomboBox.Text == "女")
            {
                consthistory.Mari_age = Convert.ToInt32(MenophaniaAgetextBox.Text.Trim());  //结婚年龄
                consthistory.Preg_times = Convert.ToInt32(PregtextBox.Text.Trim());
                consthistory.Bear_times = Convert.ToInt32(BeartextBox.Text.Trim());
                consthistory.Nat_bear = Convert.ToInt32(NatBeartextBox.Text.Trim());
                consthistory.Op_abort = Convert.ToInt32(OpBeartextBox.Text.Trim());
                consthistory.Nat_abort = Convert.ToInt32(NatAborttextBox.Text.Trim());
                consthistory.Op_abort = Convert.ToInt32(OpAborttextBox.Text.Trim());
                consthistory.Early_bear = Convert.ToInt32(EarlyBeartextBox.Text.Trim());
                consthistory.Dead_bear = Convert.ToInt32(DeadBeartextBox.Text.Trim());
            }



            /*月经史*/
            if (this.SexcomboBox.Text == "女")
            {
                consthistory.Menophania_age = Convert.ToInt32(MenophaniaAgetextBox.Text.Trim());
                consthistory.Period = Convert.ToInt32(PeriodtextBox.Text.Trim());
                consthistory.Cycle_day = Convert.ToInt32(CycletextBox.Text.Trim());
                consthistory.Menopause_y = Convert.ToInt32(MenopauseYtextBox.Text.Trim());
                consthistory.Menopause_m = Convert.ToInt32(MenopauseMtextBox.Text.Trim());


                //经量
                if (BleedFormalcheckBox.Checked)
                {
                    consthistory.Bleed_amount = 0;
                }

                else if (BleedMorecheckBox.Checked)
                {
                    consthistory.Bleed_amount = 1;
                }

                else if (BleedLesscheckBox.Checked)
                {
                    consthistory.Bleed_amount = 2;
                }

                //痛经
                if (MenoPainNonecheckBox.Checked)
                {
                    consthistory.Meno_pain = 0;
                }
                else if (MenoPainHascheckBox.Checked)
                {
                    consthistory.Meno_pain = 1;
                }

                //经期不规则
                if (MenoIrregularNonecheckBox.Checked)
                {
                    consthistory.Meno_irregular = 0;
                }

                else if (MenoIrregularHascheckBox.Checked)
                {
                    consthistory.Meno_irregular = 1;
                }
            }



            /*家族史*/
            consthistory.Parent_his = ParentHisrichTextBox.Text.Trim();

            /****************************************************************
            * 体格检查保存*
            ****************************************************************/
            PhysicalInspect physical = new PhysicalInspect();

            /***************************
             * 甲状腺检查
             ***************************/



            char[] thyroid = new char[16];
            if (BigcheckBox.Checked)
            {
                thyroid[0] = '1';
            }
            else
            {
                thyroid[0] = '0';
                physical.Thyroid_bigger = Convert.ToInt32(BiggertextBox.Text.Trim());

            }

            int thyroidstatus = 1;
            if (QuantityLesscheckBox.Checked)
            {
                thyroid[1] = '1';
                thyroidstatus = 1;
            }
            else
                thyroid[1] = '0';

            if (QuantityFormalcheckBox.Checked)
            {
                thyroid[2] = '1';
                thyroidstatus = 2;
            }
            else
                thyroid[2] = '0';

            if (QuantityMorecheckBox.Checked)
            {
                thyroid[3] = '1';
                thyroidstatus = 3;
            }
            else
                thyroid[3] = '0';

            if (DiffusiblecheckBox.Checked)
            {
                thyroid[4] = '1';
            }
            else
                thyroid[4] = '0';

            if (TremblecheckBox.Checked)
            {
                thyroid[5] = '1';
            }
            else
                thyroid[5] = '0';

            if (VesselcheckBox.Checked)
            {
                thyroid[6] = '1';
            }
            else
                thyroid[6] = '0';

            if (NoduleNonecheckBox.Checked)
            {
                thyroid[7] = '1';
            }
            else
                thyroid[7] = '0';

            if (NoduleLesscheckBox.Checked)
            {
                thyroid[8] = '1';
            }
            else
                thyroid[8] = '0';

            if (NoduleMorecheckBox.Checked)
            {
                thyroid[9] = '1';
            }
            else
                thyroid[9] = '0';

            if (PainNonecheckBox.Checked)
            {
                thyroid[10] = '1';
            }
            else
                thyroid[10] = '0';

            if (PainLesscheckBox.Checked)
            {
                thyroid[11] = '1';
            }
            else
                thyroid[11] = '0';

            if (PainMorecheckBox.Checked)
            {
                thyroid[12] = '1';
            }
            else
                thyroid[12] = '0';

            if (LeftcheckBox.Checked)
            {
                thyroid[13] = '1';
            }
            else
                thyroid[13] = '0';

            if (RightcheckBox.Checked)
            {
                thyroid[14] = '1';
            }
            else
                thyroid[14] = '0';

            if (DissymmetrycheckBox.Checked)
            {
                thyroid[15] = '1';
                physical.Thyroid_left = Convert.ToInt32(LefttextBox.Text.Trim());
                physical.Thyroid_right = Convert.ToInt32(RighttextBox.Text.Trim());
            }
            else
                thyroid[15] = '0';

            string thyroidinspect = new string(thyroid);
            physical.Thyroid_inspect = thyroidinspect.Trim();


            /***********************************
             * 心血管肺
             **********************************/
            physical.Heart_rate = Convert.ToInt32(HeartRatetextBox.Text.Trim());

            physical.Blood_hpressure = Convert.ToInt32(BloodHightextBox.Text.Trim());
            physical.Blood_lpressure = Convert.ToInt32(BloodLowtextBox.Text.Trim());

            char[] heart = new char[14];
            if (HeartFormalcheckBox.Checked)
            {
                heart[0] = '1';
            }
            else
                heart[0] = '0';

            if (HeartInformalcheckBox.Checked)
            {
                heart[1] = '1';
            }
            else
                heart[1] = '0';

            if (HeartEarlycheckBox.Checked)
            {
                heart[2] = '1';
            }
            else
                heart[2] = '0';

            if (NoiseNonecheckBox.Checked)
            {
                heart[3] = '1';
            }
            else
                heart[3] = '0';

            if (NoiseHascheckBox.Checked)
            {
                heart[4] = '1';
                physical.Noise_level = Convert.ToInt32(NoiseLeveltextBox.Text.Trim());
            }
            else
                heart[4] = '0';

            if (SystolecheckBox.Checked)
            {
                heart[5] = '1';
            }
            else
                heart[5] = '0';

            if (DiastolecheckBox.Checked)
            {
                heart[6] = '1';
            }
            else
                heart[6] = '0';

            if (BorderFormalcheckBox.Checked)
            {
                heart[7] = '1';
            }
            else
                heart[7] = '0';

            if (BorderMorecheckBox.Checked)
            {
                heart[8] = '1';
            }
            else
                heart[8] = '0';

            if (BreathClearcheckBox.Checked)
            {
                heart[9] = '1';
            }
            else
                heart[9] = '0';

            if (BreathGancheckBox.Checked)
            {
                heart[10] = '1';
            }
            else
                heart[10] = '0';

            if (BreathShicheckBox.Checked)
            {
                heart[11] = '1';
            }
            else
                heart[11] = '0';

            if (LeftLungcheckBox.Checked)
            {
                heart[12] = '1';
            }
            else
                heart[12] = '0';

            if (RightLungcheckBox.Checked)
            {
                heart[13] = '1';
            }
            else
                heart[13] = '0';

            string heartispect = new string(heart);
            physical.Heart_inspect = heartispect.Trim();



            /*******************************
            * 眼征
            *********************************/


            char[] eye = new char[10];
            if (EyeTucheckBox.Checked)
            {
                eye[0] = '1';
                physical.Left_eye_out = Convert.ToDouble(EyeLefttextBox.Text.Trim());
                physical.Right_eye_out = Convert.ToDouble(EyeRighttextBox.Text.Trim());
                physical.Eye_distance = Convert.ToDouble(EyeDistancetextBox.Text.Trim());
            }
            else
                eye[0] = '0';

            if (FlashcheckBox.Checked)
            {
                eye[1] = '1';
            }
            else
                eye[1] = '0';

            if (FaceMorecheckBox.Checked)
            {
                eye[2] = '1';
            }
            else
                eye[2] = '0';

            if (EyelidLowcheckBox.Checked)
            {
                eye[3] = '1';
            }
            else
                eye[3] = '0';

            if (EyelidMorecheckBox.Checked)
            {
                eye[4] = '1';
            }
            else
                eye[4] = '0';

            if (ConjunctivacheckBox.Checked)
            {
                eye[5] = '1';
            }
            else
                eye[5] = '0';

            if (FullBloodcheckBox.Checked)
            {
                eye[6] = '1';
            }
            else
                eye[6] = '0';

            if (VoncheckBox.Checked)
            {
                eye[7] = '1';
            }
            else
                eye[7] = '0';

            if (JofforycheckBox.Checked)
            {
                eye[8] = '1';
            }
            else
                eye[8] = '0';

            if (MobiuscheckBox.Checked)
            {
                eye[9] = '1';
            }
            else
                eye[9] = '0';

            string eyeinspect = new string(eye);
            physical.Eye_inspect = eyeinspect.Trim();


            /**********************************
            * 其他
            ***********************************/
            char[] other = new char[6];
            if (PachylosischeckBox.Checked)
            {
                other[0] = '1';
            }
            else
                other[0] = '0';

            if (YellowcheckBox.Checked)
            {
                other[1] = '1';
            }
            else
                other[1] = '0';

            if (SweetcheckBox.Checked)
            {
                other[2] = '1';
            }
            else
                other[2] = '0';

            if (PointcheckBox.Checked)
            {
                other[3] = '1';
            }
            else
                other[3] = '0';

            if (WatercheckBox.Checked)
            {
                other[4] = '1';
            }
            else
                other[4] = '0';

            if (FaircheckBox.Checked)
            {
                other[5] = '1';
            }
            else
                other[5] = '0';

            string otherthing = new string(other);
            physical.Else_inspect = otherthing.Trim();


            /**********************************
            * 化验检查
            ***********************************/

            LabInspect labinspect = new LabInspect();
            labinspect.Ft3 = Convert.ToDouble(FT3textBox.Text.Trim());
            labinspect.Ft4 = Convert.ToDouble(FT4textBox.Text.Trim());
            labinspect.Tsh = Convert.ToDouble(TSHtextBox.Text.Trim());
            labinspect.Tt3 = Convert.ToDouble(TT3textBox.Text.Trim());
            labinspect.Tt4 = Convert.ToDouble(TT4textBox.Text.Trim());
            labinspect.Tpoab = Convert.ToDouble(TPOAbtextBox.Text.Trim());
            labinspect.Tgab = Convert.ToDouble(TgAbtextBox.Text.Trim());
            labinspect.Trab = Convert.ToDouble(TRAbtextBox.Text.Trim());
            labinspect.Wbc = Convert.ToDouble(WBCtextBox.Text.Trim());
            labinspect.Rbc = Convert.ToDouble(RBCtextBox.Text.Trim());
            labinspect.Hb = Convert.ToDouble(HbtextBox.Text.Trim());
            labinspect.Plt = Convert.ToDouble(PLTtextBox.Text.Trim());
            labinspect.N = NLtextBox.Text.Trim() + "%" + NRtextBox.Text.Trim();
            labinspect.L = LLtextBox.Text.Trim() + "%" + LRtextBox.Text.Trim();
            labinspect.Tb = Convert.ToDouble(TBtextBox.Text.Trim());
            labinspect.Db = Convert.ToDouble(DBtextBox.Text.Trim());
            labinspect.Alt = Convert.ToDouble(ALTtextBox.Text.Trim());
            labinspect.Ast = Convert.ToDouble(ASTtextBox.Text.Trim());
            labinspect.Alp = Convert.ToDouble(ALPtextBox.Text.Trim());
            labinspect.Ygt = Convert.ToDouble(yGTtextBox.Text.Trim());
            labinspect.Tp = Convert.ToDouble(TPtextBox.Text.Trim());
            labinspect.Alb = Convert.ToDouble(ALBtextBox.Text.Trim());
            labinspect.Glo = Convert.ToDouble(GLOtextBox.Text.Trim());
            labinspect.Ag = Convert.ToDouble(AgetextBox.Text.Trim());
            labinspect.Bun = Convert.ToDouble(BUNtextBox.Text.Trim());
            labinspect.Ua = Convert.ToDouble(UatextBox.Text.Trim());
            labinspect.Cr = Convert.ToDouble(CRtextBox.Text.Trim());
            labinspect.Glu = Convert.ToDouble(GLUtextBox.Text.Trim());
            labinspect.Sc = Convert.ToDouble(SCtextBox.Text.Trim());
            labinspect.K = Convert.ToDouble(KtextBox.Text.Trim());
            labinspect.P = Convert.ToDouble(PtextBox.Text.Trim());
            labinspect.Else_inspect = ElseThingrichTextBox.Text.Trim();

            /**********************************
           * 影像学
           ***********************************/

            ImageInspect imageinspect = new ImageInspect();
            imageinspect.Ecg = ECGtextBox.Text.Trim();
            imageinspect.Ect_left = ETCleftLtextBox.Text.Trim() + "×" + ETCleftRtextBox.Text.Trim();
            imageinspect.Ect_right = ETCRightLtextBox.Text.Trim() + "×" + ETCRightRtextBox.Text.Trim();
            imageinspect.Ect_area = Convert.ToDouble(ETCAreatextBox.Text.Trim());
            imageinspect.Ect_tb = Convert.ToDouble(ETCTBtextBox.Text.Trim());
            imageinspect.Ect_weight = Convert.ToDouble(ETCWeighttextBox.Text.Trim());

            char[] etc = new char[10];
            if (ETCNodeNonecheckBox.Checked)
            {
                etc[0] = '1';
            }
            else
                etc[0] = '0';
            imageinspect.Ect_nodule = ETCNoduleLtextBox.Text.Trim() + "×" + ETCNoduleRtextBox.Text.Trim();

            if (ETCNodeLesscheckBox.Checked)
            {
                etc[1] = '1';
            }
            else
                etc[1] = '0';

            if (ETCNodeMorecheckBox.Checked)
            {
                etc[2] = '1';
            }
            else
                etc[2] = '0';

            if (ETCLeftcheckBox.Checked)
            {
                etc[3] = '1';
            }
            else
                etc[3] = '0';

            if (ETCRightcheckBox.Checked)
            {
                etc[4] = '1';
            }
            else
                etc[4] = '0';

            if (HotcheckBox.Checked)
            {
                etc[5] = '1';
            }
            else
                etc[5] = '0';

            if (WarmcheckBox.Checked)
            {
                etc[6] = '1';
            }
            else
                etc[6] = '0';

            if (ETCColdcheckBox.Checked)
            {
                etc[7] = '1';
            }
            else
                etc[7] = '0';

            string etcinspect = new string(etc);
            imageinspect.Ect_inspect = etcinspect;
            imageinspect.B_left = Convert.ToString(BLeftLtextBox.Text.Trim()) + "×" + Convert.ToString(BLeftRtextBox.Text.Trim());
            imageinspect.B_right = Convert.ToString(BRightLtextBox.Text.Trim()) + "×" + Convert.ToString(BRightRtextBox.Text.Trim());
            imageinspect.B_area = Convert.ToDouble(BAreatextBox.Text.Trim());
            imageinspect.B_weight = Convert.ToDouble(BWeighttextBox.Text.Trim());



            char[] b = new char[10];
            if (BNoduleNonecheckBox.Checked)
            {
                b[0] = '1';
            }
            else
                b[0] = '0';
            imageinspect.B_nodule = Convert.ToString(BNoduleLtextBox.Text.Trim()) + "×" + Convert.ToString(BNoduleRighttextBox.Text.Trim());

            if (BNoduleLesscheckBox.Checked)
            {
                b[1] = '1';
            }
            else
                b[1] = '0';

            if (BNoduleMorecheckBox.Checked)
            {
                b[2] = '1';
            }
            else
                b[2] = '0';

            if (BLeftcheckBox.Checked)
            {
                b[3] = '1';
            }
            else
                b[3] = '0';

            if (BRightcheckBox.Checked)
            {
                b[4] = '1';
            }
            else
                b[4] = '0';

            if (BShiYongcheckBox.Checked)
            {
                b[5] = '1';
            }
            else
                b[5] = '0';

            if (BNangcheckBox.Checked)
            {
                b[6] = '1';
            }
            else
                b[6] = '0';

            if (BHuncheckBox.Checked)
            {
                b[7] = '1';
            }
            else
                b[7] = '0';

            string binspect = new string(b);
            imageinspect.B_inspect = binspect;
            imageinspect.Else_inspect = Convert.ToDouble(ElseJtextBox.Text.Trim());
            imageinspect.Diagnosis = DiagnosisrichTextBox.Text.Trim();

            /**********************************
           * 治疗计划
           ***********************************/

            CurePlan cureplan = new CurePlan();
            cureplan.Twoh_rate = Convert.ToDouble(twohtextBox.Text.Trim());
            cureplan.Twentyfourh_rate = Convert.ToDouble(TwoFhtextBox.Text.Trim());
            if (NormalcheckBox.Checked)
            {
                cureplan.Rate_level = 0;
            }

            if (MorecheckBox.Checked)
            {
                cureplan.Rate_level = 1;
            }

            if (LesscheckBox.Checked)
            {
                cureplan.Rate_level = -1;
            }

            cureplan.Recom_dose = Convert.ToDouble(RecomtextBox.Text.Trim());
            //cureplan.Plan_dose = Convert.ToDouble(PlantextBox.Text.Trim());
            cureplan.Cal_dose = Convert.ToDouble(CaltextBox.Text.Trim());
            cureplan.Real_dose = Convert.ToDouble(RealtextBox.Text.Trim());
            cureplan.Else_things = elserichTextBox.Text.Trim();



            char[] ef = new char[10];

            if (AgecheckBox.Checked)
            {
                ef[0] = '1';
            }
            else
            {
                ef[0] = '0';
            }

            if (ZhengcheckBox.Checked)
            {
                ef[1] = '1';
            }
            else
            {
                ef[1] = '0';
            }

            if (HecheckBox.Checked)
            {
                ef[2] = '1';
            }
            else
            {
                ef[2] = '0';
            }

            if (BingcheckBox.Checked)
            {
                ef[3] = '1';
            }
            else
            {
                ef[3] = '0';
            }

            if (shoushucheckBox.Checked)
            {
                ef[4] = '1';
            }
            else
            {
                ef[4] = '0';
            }

            if (ATDcheckBox.Checked)
            {
                ef[5] = '1';
            }
            else
            {
                ef[5] = '0';
            }

            if (fufacheckBox.Checked)
            {
                ef[6] = '1';
            }
            else
            {
                ef[6] = '0';
            }


            if (JiacheckBox.Checked)
            {
                ef[7] = '1';
            }
            else
            {
                ef[7] = '0';
            }

            if (JiejiecheckBox.Checked)
            {
                ef[8] = '1';
            }
            else
            {
                ef[8] = '0';
            }


            if (qitacheckBox.Checked)
            {
                ef[9] = '1';
            }
            else
            {
                ef[9] = '0';
            }

            string effect = new string(ef);

            cureplan.Ef_factor = effect;
            cureplan.Ef_else = ElsethingtextBox.Text.Trim();

            cureplan.Plan_dose = Convert.ToDouble(this.PlantextBox.Text);

            basicinfo.insertBasicInfo();
            presenthistory.insertPhysicalInspect(Convert.ToString(cfId.Trim()));
            consthistory.insertConstHistory(Convert.ToString(cfId.Trim())); //插入logid

            labinspect.insertLabInspect(Convert.ToString(cfId.Trim()));
            imageinspect.insertImageInspect(Convert.ToString(cfId.Trim()));
            cureplan.insertCurePlan(Convert.ToString(cfId.Trim()));
            physical.insertPhysicalInspect(Convert.ToString(cfId.Trim())); //插入logid
            //MessageBox.Show("保存成功！");
            //this.Close();
            new Msg("保存成功！", basicinfo.P_name, cfId, this).Show();
        }





        private void OpenFilebutton_Click(object sender, EventArgs e)
        {

        }

        private void FlaccidtextBox_Leave(object sender, EventArgs e)
        {
            if (FlaccidtextBox.Text == string.Empty)
            {
                errorProvider1.SetError(FlaccidcheckBox, "不能为空");
            }
            else
                errorProvider1.Clear();

        }

        private void DefecatetextBox_Leave(object sender, EventArgs e)
        {
            if (DefecatetextBox.Text == string.Empty)
            {
                errorProvider1.SetError(DefecatetextBox, "不能为空");
            }
            else
                errorProvider1.Clear();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void OpenFilebutton_Click_1(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                ECGtextBox.Text = openFileDialog.FileName;
            }
        }

        private void SexcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.SexcomboBox.Text == "男")
            {
                this.MenophaniagroupBox.Visible = false;
                this.MarriagegroupBox.Visible = false;
            }

            else
            {
                this.MenophaniagroupBox.Visible = true;
                if (this.MarriedcomboBox.Text == "已婚")
                {
                    this.MarriagegroupBox.Visible = true;
                }
            }
        }

        private void MarriedcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.MarriedcomboBox.Text == "未婚" || this.SexcomboBox.Text == "男")
                this.MarriagegroupBox.Visible = false;
            else
                this.MarriagegroupBox.Visible = true;
        }

        private void BigcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.BigcheckBox.Checked)
                this.BiggerPanel.Visible = false;
            else this.BiggerPanel.Visible = true;
        }

        private void DissymmetrycheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DissymmetrycheckBox.Checked)
                this.DissPanel.Visible = true;
            else this.DissPanel.Visible = false;
        }

        private void NoiseHascheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.NoiseHascheckBox.Checked)
            {
                this.NoiseNonecheckBox.Visible = false;
                this.NoiseLeveltextBox.Visible = true;
                this.label4.Visible = true;
            }
            else
            {
                this.NoiseNonecheckBox.Visible = true;
                this.NoiseLeveltextBox.Visible = false;
                this.label4.Visible = false;
            }
        }

        private void NoiseNonecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.NoiseNonecheckBox.Checked)

                this.NoisePanel.Visible = false;


            else this.NoisePanel.Visible = true;
        }

        private void EyeTucheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EyeTucheckBox.Checked)
                this.EyePanel.Visible = true;
            else this.EyePanel.Visible = false;
        }

        private void ETCNodeNonecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ETCNodeNonecheckBox.Checked)
                this.ECTPanel.Visible = false;
            else this.ECTPanel.Visible = true;
        }

        private void BNoduleNonecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.BNoduleNonecheckBox.Checked)
                this.BPanel.Visible = false;
            else this.BPanel.Visible = true;
        }

        private void readLabel(string s)
        {
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("请输入" + s);
        }



        private void NametextBox_Click(object sender, EventArgs e)
        {
            readLabel("姓名");
        }

        private void AgetextBox_Click(object sender, EventArgs e)
        {
            readLabel("年龄");
        }

        private void RadicaltextBox_Click(object sender, EventArgs e)
        {
            readLabel("民族");
        }

        private void HometextBox_Click(object sender, EventArgs e)
        {
            readLabel("籍贯");
        }

        private void BorntextBox_Click(object sender, EventArgs e)
        {
            readLabel("出身地");
        }

        private void JobtextBox_Click(object sender, EventArgs e)
        {
            readLabel("职业");
        }

        private void JodaddrtextBox_Click(object sender, EventArgs e)
        {
            readLabel("工作单位及邮编");
        }

        private void HomeaddrtextBox_Click(object sender, EventArgs e)
        {
            readLabel("家庭地址及邮编");
        }

        private void EmailtextBox_Click(object sender, EventArgs e)
        {
            readLabel("电子邮件");
        }

        private void TeletextBox_Click(object sender, EventArgs e)
        {
            readLabel("联系电话");
        }

        private void ContacttextBox_Click(object sender, EventArgs e)
        {

        }

        private void RelationtextBox_Click(object sender, EventArgs e)
        {
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("请输入与患者的关系");
        }




        private void count()
        {
            if ((this.QuantityLesscheckBox.Checked || this.QuantityFormalcheckBox.Checked || this.QuantityMorecheckBox.Checked)
                && (this.ETCWeighttextBox.Text != null && this.ETCWeighttextBox.Text.Length != 0)
                && (this.twohtextBox.Text != null && this.twohtextBox.Text.Length != 0)
                && (this.TwoFhtextBox.Text != null && this.TwoFhtextBox.Text.Length != 0)
                && (this.IDosageCourseComboBox.Text != null && this.IDosageCourseComboBox.Text.Length != 0)
                && (this.IDosageStateComboBox.Text != null && this.IDosageStateComboBox.Text.Length != 0)
                )
            {
                int thyroidstatus = 1;
                if (QuantityLesscheckBox.Checked)
                {

                    thyroidstatus = 1;
                }



                else if (QuantityFormalcheckBox.Checked)
                {

                    thyroidstatus = 2;
                }


                else
                {

                    thyroidstatus = 3;
                }



                //病程
                int illnesscourse;
                if (IDosageCourseComboBox.Text == "≤1年")
                {
                    illnesscourse = 1;
                }
                else if (IDosageCourseComboBox.Text == ">1≤2年")
                {
                    illnesscourse = 2;
                }
                else if (IDosageCourseComboBox.Text == ">2≤3年")
                {
                    illnesscourse = 3;
                }
                else if (IDosageCourseComboBox.Text == ">3≤4年")
                {
                    illnesscourse = 4;
                }
                else
                {
                    illnesscourse = 5;
                }


                int illnessstates;
                if (IDosageStateComboBox.Text == "轻")
                {
                    illnessstates = 1;
                }
                else if (IDosageStateComboBox.Text == "中")
                {
                    illnessstates = 2;
                }
                else
                {
                    illnessstates = 3;
                }

                //计算
                double thyroidweight = Math.Round(Convert.ToDouble(ETCWeighttextBox.Text), 1);
                double ariu6h = Math.Round(Convert.ToDouble(this.twohtextBox.Text), 1);
                double raiu24h = Math.Round(Convert.ToDouble(this.TwoFhtextBox.Text), 1);
                double raiuratio = Math.Round(ariu6h / raiu24h, 2);
                double temp1 = (-0.267 + 0.047 * illnesscourse + 0.159 * thyroidstatus + 0.132 * thyroidweight * 10 + 0.059 * raiuratio * 10 + 0.287 * illnessstates) * 75;
                double idosageplan = Math.Round(temp1, 1);
                double temp2;
                if ((raiuratio - 1) > 0)
                {
                    temp2 = idosageplan * thyroidweight / (10 * ariu6h);
                }
                else
                {
                    temp2 = idosageplan * thyroidweight / (10 * raiu24h);
                }
                double idosagetake = Math.Round(temp2, 1);
                this.PlantextBox.Text = Convert.ToString(idosageplan);
                this.RecomtextBox.Text = Convert.ToString(idosagetake);
            }
        }

        private void QuantityLesscheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.QuantityLesscheckBox.Checked)
            {
                this.QuantityFormalcheckBox.Checked = false;
                this.QuantityMorecheckBox.Checked = false;
                this.QuantityFormalcheckBox.Visible = false;
                this.QuantityMorecheckBox.Visible = false;
                count();
            }
            else
            {
                this.QuantityFormalcheckBox.Visible = true;
                this.QuantityMorecheckBox.Visible = true;
            }
        }

        private void QuantityFormalcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.QuantityFormalcheckBox.Checked)
            {
                this.QuantityLesscheckBox.Checked = false;
                this.QuantityMorecheckBox.Checked = false;
                this.QuantityLesscheckBox.Visible = false;
                this.QuantityMorecheckBox.Visible = false;
                count();
            }
            else
            {
                this.QuantityLesscheckBox.Visible = true;
                this.QuantityMorecheckBox.Visible = true;
            }
        }

        private void QuantityMorecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.QuantityMorecheckBox.Checked)
            {
                this.QuantityLesscheckBox.Checked = false;
                this.QuantityFormalcheckBox.Checked = false;
                this.QuantityLesscheckBox.Visible = false;
                this.QuantityFormalcheckBox.Visible = false;
                count();
            }
            else
            {
                this.QuantityLesscheckBox.Visible = true;
                this.QuantityFormalcheckBox.Visible = true;
            }
        }

        private void ETCWeighttextBox_TextChanged(object sender, EventArgs e)
        {
            count();
        }

        private void twohtextBox_TextChanged(object sender, EventArgs e)
        {
            count();
        }

        private void TwoFhtextBox_TextChanged(object sender, EventArgs e)
        {
            count();
        }

        private void IDosageCourseComboBox_TextChanged(object sender, EventArgs e)
        {
            count();
        }

        private void IDosageStateComboBox_TextChanged(object sender, EventArgs e)
        {
            count();
        }



        private void CureFirst_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.CreateMF().Show();
        }

        private void FlaccidcheckboxChanged(object sender, EventArgs e)
        {
            if (FlaccidcheckBox.Checked)
            {
                Flaccidlabel.Visible = true;
                FlaccidtextBox.Visible = true;
            }
            else
            {
                Flaccidlabel.Visible = false;
                FlaccidtextBox.Visible = false;
            }
        }

        private void DefecatecheckboxChanged(object sender, EventArgs e)
        {
            if (DefecatecheckBox.Checked)
            {
                Defecatelabel.Visible = true;
                DefecatetextBox.Visible = true;
            }
            else
            {
                Defecatelabel.Visible = false;
                DefecatetextBox.Visible = false;
            }
        }

        private void NoduleNonecheckboxChanged(object sender, EventArgs e)
        {
            if (NoduleNonecheckBox.Checked)
            {
                NoduleLesscheckBox.Visible = false;
                NoduleMorecheckBox.Visible = false;
                LeftcheckBox.Visible = false;
                RightcheckBox.Visible = false;
            }
            else
            {
                NoduleLesscheckBox.Visible = true;
                NoduleMorecheckBox.Visible = true;
                LeftcheckBox.Visible = true;
                RightcheckBox.Visible = true;
            }
        }

        private void BleedFormalcheckboxChanged(object sender, EventArgs e)
        {
            if (BleedFormalcheckBox.Checked)
            {
                BleedMorecheckBox.Visible = false;
                BleedLesscheckBox.Visible = false;
            }
            else
            {
                BleedMorecheckBox.Visible = true;
                BleedLesscheckBox.Visible = true;
            }
        }

        private void BleedMorecheckboxChanged(object sender, EventArgs e)
        {
            if (BleedMorecheckBox.Checked)
            {
                BleedFormalcheckBox.Visible = false;
                BleedLesscheckBox.Visible = false;
            }
            else
            {
                BleedFormalcheckBox.Visible = true;
                BleedLesscheckBox.Visible = true;
            }
        }

        private void BleedLesscheckboxChanged(object sender, EventArgs e)
        {
            if (BleedLesscheckBox.Checked)
            {
                BleedFormalcheckBox.Visible = false;
                BleedMorecheckBox.Visible = false;
            }
            else
            {
                BleedFormalcheckBox.Visible = true;
                BleedMorecheckBox.Visible = true;
            }
        }

        private void MenoPainNonecheckboxChanged(object sender, EventArgs e)
        {
            if (MenoPainNonecheckBox.Checked)
            {
                MenoPainHascheckBox.Visible = false;
            }
            else
            {
                MenoPainHascheckBox.Visible = true;
            }
        }

        private void MenoPainHascheckboxChanged(object sender, EventArgs e)
        {
            if (MenoPainHascheckBox.Checked)
            {
                MenoPainNonecheckBox.Visible = false;
            }
            else
            {
                MenoPainNonecheckBox.Visible = true;
            }
        }

        private void MenoIrregularNonecheckboxChanged(object sender, EventArgs e)
        {
            if (MenoIrregularNonecheckBox.Checked)
            {
                MenoIrregularHascheckBox.Visible = false;
            }
            else
            {
                MenoIrregularHascheckBox.Visible = true;
            }
        }

        private void MenoIrregularHascheckboxChanged(object sender, EventArgs e)
        {
            if (MenoIrregularHascheckBox.Checked)
            {
                MenoIrregularNonecheckBox.Visible = false;
            }
            else
            {
                MenoIrregularNonecheckBox.Visible = true;
            }
        }

        private void PainNonecheckboxChanged(object sender, EventArgs e)
        {
            if (PainNonecheckBox.Checked)
            {
                PainLesscheckBox.Visible = false;
                PainMorecheckBox.Visible = false;
            }
            else
            {
                PainLesscheckBox.Visible = true;
                PainMorecheckBox.Visible = true;
            }
        }

        private void PainLesscheckboxChanged(object sender, EventArgs e)
        {
            if (PainLesscheckBox.Checked)
            {
                PainNonecheckBox.Visible = false;
                PainMorecheckBox.Visible = false;
            }
            else
            {
                PainNonecheckBox.Visible = true;
                PainMorecheckBox.Visible = true;
            }
        }

        private void PainMorecheckboxChanged(object sender, EventArgs e)
        {
            if (PainMorecheckBox.Checked)
            {
                PainLesscheckBox.Visible = false;
                PainNonecheckBox.Visible = false;
            }
            else
            {
                PainLesscheckBox.Visible = true;
                PainNonecheckBox.Visible = true;
            }
        }

        private void NoduleLesscheckboxChanged(object sender, EventArgs e)
        {
            if (NoduleLesscheckBox.Checked)
            {
                NoduleMorecheckBox.Visible = false;
            }
            else
            {
                NoduleMorecheckBox.Visible = true;
            }
        }

        private void NoduleMorecheckboxChanged(object sender, EventArgs e)
        {
            if (NoduleMorecheckBox.Checked)
            {
                NoduleLesscheckBox.Visible = false;
            }
            else
            {
                NoduleLesscheckBox.Visible = true;
            }
        }

        private void HeartFormalcheckboxChanged(object sender, EventArgs e)
        {
            if (HeartFormalcheckBox.Checked)
            {
                HeartInformalcheckBox.Visible = false;
            }
            else
            {
                HeartInformalcheckBox.Visible = true;
            }
        }

        private void HeartInformalcheckboxChanged(object sender, EventArgs e)
        {
            if (HeartInformalcheckBox.Checked)
            {
                HeartFormalcheckBox.Visible = false;
            }
            else
            {
                HeartFormalcheckBox.Visible = true;
            }
        }

        private void SystolecheckboxChanged(object sender, EventArgs e)
        {
            if (SystolecheckBox.Checked)
            {
                DiastolecheckBox.Visible = false;
            }
            else
            {
                DiastolecheckBox.Visible = true;
            }
        }

        private void DiastolecheckboxChanged(object sender, EventArgs e)
        {
            if (DiastolecheckBox.Checked)
            {
                SystolecheckBox.Visible = false;
            }
            else
            {
                SystolecheckBox.Visible = true;
            }
        }

        private void BorderFormalcheckboxChanged(object sender, EventArgs e)
        {
            if (BorderFormalcheckBox.Checked)
            {
                BorderMorecheckBox.Visible = false;
            }
            else
            {
                BorderMorecheckBox.Visible = true;
            }
        }

        private void BorderMorecheckboxChanged(object sender, EventArgs e)
        {
            if (BorderMorecheckBox.Checked)
            {
                BorderFormalcheckBox.Visible = false;
            }
            else
            {
                BorderFormalcheckBox.Visible = true;
            }
        }

        private void BreathClearcheckboxChanged(object sender, EventArgs e)
        {
            if (BreathClearcheckBox.Checked)
            {
                BreathGancheckBox.Visible = false;
                BreathShicheckBox.Visible = false;
                LeftLungcheckBox.Visible = false;
                RightLungcheckBox.Visible = false;
            }
            else
            {
                BreathGancheckBox.Visible = true;
                BreathShicheckBox.Visible = true;
                LeftLungcheckBox.Visible = true;
                RightLungcheckBox.Visible = true;
            }
        }

        private void NormalcheckboxChanged(object sender, EventArgs e)
        {
            if (NormalcheckBox.Checked)
            {
                MorecheckBox.Visible = false;
                LesscheckBox.Visible = false;
            }
            else
            {
                MorecheckBox.Visible = true;
                LesscheckBox.Visible = true;
            }
        }

        private void MorecheckboxChanged(object sender, EventArgs e)
        {
            if (MorecheckBox.Checked)
            {
                NormalcheckBox.Visible = false;
                LesscheckBox.Visible = false;
            }
            else
            {
                NormalcheckBox.Visible = true;
                LesscheckBox.Visible = true;
            }
        }

        private void LesscheckboxChanged(object sender, EventArgs e)
        {
            if (LesscheckBox.Checked)
            {
                NormalcheckBox.Visible = false;
                MorecheckBox.Visible = false;
            }
            else
            {
                NormalcheckBox.Visible = true;
                MorecheckBox.Visible = true;
            }
        }

        private void qitacheckboxChanged(object sender, EventArgs e)
        {
            if (qitacheckBox.Checked)
            {
                ElsethingtextBox.Visible = true;
            }
            else
            {
                ElsethingtextBox.Visible = false;
            }
        }

    }
}
