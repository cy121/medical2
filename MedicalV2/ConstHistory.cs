using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace MedicalV2
{
    class ConstHistory
    {
        private string past_his;

        public string Past_his
        {
            get { return past_his; }
            set { past_his = value; }
        }

        private string person_his;

        public string Person_his
        {
            get { return person_his; }
            set { person_his = value; }
        }

        private int mari_age;

        public int Mari_age
        {
            get { return mari_age; }
            set { mari_age = value; }
        }

        private int preg_times;

        public int Preg_times
        {
            get { return preg_times; }
            set { preg_times = value; }
        }

        private int bear_times;

        public int Bear_times
        {
            get { return bear_times; }
            set { bear_times = value; }
        }

        private int nat_bear;

        public int Nat_bear
        {
            get { return nat_bear; }
            set { nat_bear = value; }
        }

        private int op_bear;

        public int Op_bear
        {
            get { return op_bear; }
            set { op_bear = value; }
        }

        private int nat_abort;

        public int Nat_abort
        {
            get { return nat_abort; }
            set { nat_abort = value; }
        }

        private int op_abort;

        public int Op_abort
        {
            get { return op_abort; }
            set { op_abort = value; }
        }

        private int early_bear;

        public int Early_bear
        {
            get { return early_bear; }
            set { early_bear = value; }
        }

        private int dead_bear;

        public int Dead_bear
        {
            get { return dead_bear; }
            set { dead_bear = value; }
        }

        private int menophania_age;

        public int Menophania_age
        {
            get { return menophania_age; }
            set { menophania_age = value; }
        }

        private int period;

        public int Period
        {
            get { return period; }
            set { period = value; }
        }

        private int cycle_day;

        public int Cycle_day
        {
            get { return cycle_day; }
            set { cycle_day = value; }
        }

        private int menopause_y;

        public int Menopause_y
        {
            get { return menopause_y; }
            set { menopause_y = value; }
        }

        private int menopause_m;

        public int Menopause_m
        {
            get { return menopause_m; }
            set { menopause_m = value; }
        }

        private int bleed_amount;

        public int Bleed_amount
        {
            get { return bleed_amount; }
            set { bleed_amount = value; }
        }

        private int meno_pain;

        public int Meno_pain
        {
            get { return meno_pain; }
            set { meno_pain = value; }
        }

        private int meno_irregular;

        public int Meno_irregular
        {
            get { return meno_irregular; }
            set { meno_irregular = value; }
        }

        private string parent_his;

        public string Parent_his
        {
            get { return parent_his; }
            set { parent_his = value; }
        }

        public bool readConstHistory(string lid)
        {
            MySqlConnection con = CommonFunc.getConnection();
            if (con == null)
            {
                return false;
            }
            else
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("select * from const_history where log_id='" + lid + "'", con);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    past_his = reader.GetString(1);
                    person_his = reader.GetString(2);
                    mari_age = reader.GetInt32(3);
                    preg_times = reader.GetInt32(4);
                    bear_times = reader.GetInt32(5);
                    nat_bear = reader.GetInt32(6);
                    op_bear = reader.GetInt32(7);
                    nat_abort = reader.GetInt32(8);
                    op_abort = reader.GetInt32(9);
                    early_bear = reader.GetInt32(10);
                    dead_bear = reader.GetInt32(11);
                    menophania_age = reader.GetInt32(12);
                    period = reader.GetInt32(13);
                    cycle_day = reader.GetInt32(14);
                    menopause_y = reader.GetInt32(15);
                    menopause_m = reader.GetInt32(16);
                    bleed_amount = reader.GetInt32(17);
                    meno_pain = reader.GetInt32(18);
                    meno_irregular = reader.GetInt32(19);
                    parent_his = reader.GetString(20);
                    reader.Close();
                    con.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    con.Close();
                    return false;
                }
            }
        }

        public bool insertConstHistory(string lid)
        {
            MySqlConnection con = CommonFunc.getConnection();
            if (con == null)
            {
                return false;
            }
            else
            {
                string insert_sql = "insert into const_history(log_id,past_his,person_his,mari_age,preg_times,bear_times," +
                    "nat_bear,op_bear,nat_abort,op_abort,early_bear,dead_bear,menophania_age,period,cycle_day,menopause_y," +
                    "menopause_m,bleed_amount,meno_pain,meno_irregular,parent_his) values('" + lid + "','" + past_his + "','" +
                    person_his + "'," + mari_age + "," + preg_times + "," + bear_times + "," + nat_bear + "," + op_bear + "," + nat_abort + "," +
                    op_abort + "," + early_bear + "," + dead_bear + "," + menophania_age + "," + period + "," + cycle_day + "," + menopause_y + "," +
                    menopause_m + "," + bleed_amount + "," + meno_pain + "," + meno_irregular + ",'" + parent_his + "')";
                MySqlCommand command = new MySqlCommand(insert_sql, con);
                try
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    //MessageBox.Show("保存成功！");
                }
                catch (MySqlException e)
                {
                    e.Message.ToString();
                    MessageBox.Show("既往史保存失败");
                }
                con.Close();
                return true;
            }
        }
    }
}
