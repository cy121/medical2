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
    


    public partial class PhysicalInspectControl : UserControl
    {

        


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


        public PhysicalInspectControl()
        {
            InitializeComponent();
        }

        public PhysicalInspectControl(string id)
        {
            InitializeComponent();
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
        }

      
    }
}
