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
    public partial class LabInspectControl : UserControl
    {
        public LabInspectControl()
        {
            InitializeComponent();
        }

        public LabInspectControl(string id)
        {
            InitializeComponent();
            LabInspect li = new LabInspect();
            li.readLabInspect(id);
            FT3textBox.Text = Convert.ToString(li.Ft3);
            FT4textBox.Text = Convert.ToString(li.Ft4);
            TSHtextBox.Text = Convert.ToString(li.Tsh);
            TT3textBox.Text = Convert.ToString(li.Tt3);
            TT4textBox.Text = Convert.ToString(li.Tt4);
            TPOAbtextBox.Text = Convert.ToString(li.Tpoab);
            TgAbtextBox.Text = Convert.ToString(li.Tgab) ;
            TRAbtextBox.Text = Convert.ToString(li.Trab) ;
            WBCtextBox.Text = Convert.ToString(li.Wbc) ;
            RBCtextBox.Text =Convert.ToString(li.Rbc);
            HbtextBox.Text = Convert.ToString(li.Hb) ;
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
            PtextBox.Text= Convert.ToString(li.P);
            ElseThingrichTextBox.Text = li.Else_inspect;
        }
    }
}
