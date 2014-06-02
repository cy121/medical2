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
    public partial class ConstHistoryControl : UserControl
    {
        public ConstHistoryControl()
        {
            InitializeComponent();
        }

        public ConstHistoryControl(string id)
        {
            InitializeComponent();
            ConstHistory ch = new ConstHistory();
            ch.readConstHistory(id);
            PastrichTextBox.Text = ch.Past_his;
            Char[] personHis = ch.Person_his.ToCharArray();
            if(personHis[0] == 1)
                this.ResidentcheckBox.Checked = true;
            else if (personHis[1] == 1)
                this.EatSeacheckBox.Checked = true;
            else if (personHis[2] == 1)
                this.DrinkcheckBox.Checked = true;

            this.MarriAgetextBox.Text = Convert.ToString(ch.Mari_age);
            this.PregtextBox.Text = Convert.ToString(ch.Preg_times);
            this.BeartextBox.Text = Convert.ToString(ch.Bear_times);

            this.NatBeartextBox.Text = Convert.ToString(ch.Nat_bear);

            this.OpBeartextBox.Text  = Convert.ToString(ch.Op_bear);
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
            if (ch.Meno_pain == 0 )
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
                MenoIrregularHascheckBox.Checked = true ;
            }
        }
    }
}
