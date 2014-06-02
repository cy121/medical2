using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace MedicalV2
{
    class PresentHistory
    {
        private string main_report;

        public string Main_report
        {
            get { return main_report; }
            set { main_report = value; }
        }
        private string symptom;

        public string Symptom
        {
            get { return symptom; }
            set { symptom = value; }
        }
        private int stool_times;

        public int Stool_times
        {
            get { return stool_times; }
            set { stool_times = value; }
        }
        private int palsy_times;

        public int Palsy_times
        {
            get { return palsy_times; }
            set { palsy_times = value; }
        }
        private string else_things;

        public string Else_things
        {
            get { return else_things; }
            set { else_things = value; }
        }
        private string treat_process;

        public string Treat_process
        {
            get { return treat_process; }
            set { treat_process = value; }
        }

        public bool readPresentHistory(string lid)
        {
            MySqlConnection con = CommonFunc.getConnection();
            if (con == null)
            {
                return false;
            }
            else
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("select * from present_history where log_id='" + lid + "'", con);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    main_report = reader.GetString(1);
                    symptom = reader.GetString(2);
                    stool_times = reader.GetInt32(3);
                    palsy_times = reader.GetInt32(4);
                    else_things = reader.GetString(5);
                    treat_process = reader.GetString(6);
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

        public bool insertPhysicalInspect(string lid)
        {
            MySqlConnection con = CommonFunc.getConnection();
            if (con == null)
            {
                return false;
            }
            else
            {
                string insert_sql = "insert into present_history(log_id,main_report,symptom,stool_times,palsy_times,else_things,treat_process) value('" + lid + "','" + 
                    main_report + "','" + symptom + "'," + stool_times + "," + palsy_times + ",'" + else_things + "','" + treat_process + "')";
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
                    MessageBox.Show("现病史保存失败！");
                }
                con.Close();
                return true;
            }
        }

        public bool updatePhysicalInspect(string lid)
        {
            MySqlConnection con = CommonFunc.getConnection();
            if (con == null)
            {
                return false;
            }
            else
            {
                string update_sql = "update present_history set main_report='" + main_report + "', symptom='" + symptom + "',stool_times=" + stool_times + ",palsy_times=" + palsy_times +
                    ",else_things='" + else_things + "',treat_process='" + treat_process + "' where log_id='" + lid + "'";
                MySqlCommand command = new MySqlCommand(update_sql, con);
                try
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    //MessageBox.Show("更新成功！");
                }
                catch (MySqlException e)
                {
                    e.Message.ToString();
                    MessageBox.Show("现病史更新失败");
                }
                con.Close();
                return true;
            }
        }
    }
}
