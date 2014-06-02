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
    public partial class ImageInspectControl : UserControl
    {
        private string[] etcCheck = { "ETCNodeNonecheckBox", "ETCNodeLesscheckBox", "ETCNodeMorecheckBox", "ETCLeftcheckBox", 
                                        "ETCRightcheckBox", "HotcheckBox", "WarmcheckBox", "ETCColdcheckBox"};

        private string[] bCheck = {"BNoduleNonecheckBox","BNoduleLesscheckBox","BNoduleMorecheckBox","BLeftcheckBox",
                                   "BRightcheckBox","BShiYongcheckBox","BNangcheckBox","BHuncheckBox"};

        public ImageInspectControl()
        {
            InitializeComponent();
        }

        public ImageInspectControl(string id)
        {
            InitializeComponent();
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
            Char[] etc = ii.Ect_inspect.ToCharArray();
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
            this.BLeftLtextBox.Text = (ii.B_left.Split('×'))[1];
            this.BRightLtextBox.Text = (ii.B_right.Split('×'))[0];
            this.BRightRtextBox.Text = (ii.B_right.Split('×'))[1];
            this.BAreatextBox.Text = Convert.ToString(ii.B_area);
            this.BWeighttextBox.Text = Convert.ToString(ii.B_weight);

            Char[] b = ii.B_inspect.ToCharArray();
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
        }
    }
}
