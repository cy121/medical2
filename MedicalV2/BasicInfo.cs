using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql;

namespace MedicalV2
{
    class BasicInfo
    {
        //基本信息
        private string log_id;//病人ID

        public string Log_id
        {
            get { return log_id; }
            set { log_id = value; }
        }
        private string p_name;

        public string P_name
        {
            get { return p_name; }
            set { p_name = value; }
        }
        private char p_sex;

        public char P_sex
        {
            get { return p_sex; }
            set { p_sex = value; }
        }
        private int p_age;

        public int P_age
        {
            get { return p_age; }
            set { p_age = value; }
        }
        private char p_married;

        public char P_married
        {
            get { return p_married; }
            set { p_married = value; }
        }
        private string p_radical;

        public string P_radical
        {
            get { return p_radical; }
            set { p_radical = value; }
        }
        private int hos_id;

        public int Hos_id
        {
            get { return hos_id; }
            set { hos_id = value; }
        }
        private string p_home;

        public string P_home
        {
            get { return p_home; }
            set { p_home = value; }
        }
        private string p_born;

        public string P_born
        {
            get { return p_born; }
            set { p_born = value; }
        }
        private string p_job;

        public string P_job
        {
            get { return p_job; }
            set { p_job = value; }
        }
        private string p_jobaddr;

        public string P_jobaddr
        {
            get { return p_jobaddr; }
            set { p_jobaddr = value; }
        }
        private string p_addr;

        public string P_addr
        {
            get { return p_addr; }
            set { p_addr = value; }
        }
        private string p_tel;

        public string P_tel
        {
            get { return p_tel; }
            set { p_tel = value; }
        }
        private string p_email;

        public string P_email
        {
            get { return p_email; }
            set { p_email = value; }
        }
        private string p_contact;

        public string P_contact
        {
            get { return p_contact; }
            set { p_contact = value; }
        }
        private string p_relation;

        public string P_relation
        {
            get { return p_relation; }
            set { p_relation = value; }
        }

        private bool flag = false;

        public bool Flag
        {
            get { return flag; }
            set { flag = value; }
        }

        public void readBasicInfoById(string lid)
        {
            MySqlConnection con = CommonFunc.getConnection();
            if (con == null)
            {
                flag = false;
                return;
            }
            else
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("select * from basic_info where log_id='" + lid + "'", con);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    log_id = reader.GetString(0);
                    p_name = reader.GetString(1);
                    p_sex = reader.GetChar(2);
                    p_age = reader.GetInt32(3);
                    p_married = reader.GetChar(4);
                    p_radical = reader.GetString(5);
                    hos_id = reader.GetInt32(6);
                    p_home = reader.GetString(7);
                    p_born = reader.GetString(8);
                    p_jobaddr = reader.GetString(9);
                    p_job = reader.GetString(10);
                    p_addr = reader.GetString(11);
                    p_tel = reader.GetString(12);
                    p_email = reader.GetString(13);
                    p_contact = reader.GetString(14);
                    p_relation = reader.GetString(15);
                }
                else
                {
                    flag = false;
                }
                reader.Close();
                con.Close();
                return;
            }
        }

        public void readBasicInfoByName(string lid)
        {
            MySqlConnection con = CommonFunc.getConnection();
            if (con == null)
            {
                flag = false;
                return;
            }
            else
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("select * from basic_info where p_name='" + lid + "'", con);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    log_id = reader.GetString(0);
                    p_name = reader.GetString(1);
                    p_sex = reader.GetChar(2);
                    p_age = reader.GetInt32(3);
                    p_married = reader.GetChar(4);
                    p_radical = reader.GetString(5);
                    hos_id = reader.GetInt32(6);
                    p_home = reader.GetString(7);
                    p_born = reader.GetString(8);
                    p_jobaddr = reader.GetString(9);
                    p_job = reader.GetString(10);
                    p_addr = reader.GetString(11);
                    p_tel = reader.GetString(12);
                    p_email = reader.GetString(13);
                    p_contact = reader.GetString(14);
                    p_relation = reader.GetString(15);
                }
                else
                {
                    flag = false;
                }
                reader.Close();
                con.Close();
                return;
            }
        }

        public bool insertBasicInfo()
        {
            MySqlConnection con = CommonFunc.getConnection();
            if (con == null)
            {
                return false;
            }
            else
            {
                string insert_sql = "insert into basic_info(log_id,p_name,p_sex,p_age,p_married,p_radical,hos_id,p_home,p_born,p_jobaddr,p_job,p_addr,p_tel,p_email,p_contact,p_relation) values('" + log_id + "','" +
                    p_name + "','" + p_sex + "'," + p_age + ",'" + p_married + "','" + p_radical + "'," + hos_id + ",'" + p_home + "','" + p_born + "','" + p_jobaddr + "','" + p_job + "','" + p_addr + "','" + p_tel + "','" + p_email + "','" + p_contact + "','" + p_relation + "')";
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
                    MessageBox.Show("基本信息保存失败！");
                }
                con.Close();
                return true;
            }
        }
    }
}
