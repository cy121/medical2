using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MedicalV2
{
    class PhysicalInspect
    {
        private string thyroid_inspect;

        public string  Thyroid_inspect
        {
            get { return thyroid_inspect; }
            set { thyroid_inspect = value; }
        }
        private int thyroid_bigger;

        public int Thyroid_bigger
        {
            get { return thyroid_bigger; }
            set { thyroid_bigger = value; }
        }
        private int thyroid_left;

        public int Thyroid_left
        {
            get { return thyroid_left; }
            set { thyroid_left = value; }
        }
        private int thyroid_right;

        public int Thyroid_right
        {
            get { return thyroid_right; }
            set { thyroid_right = value; }
        }
        private int heart_rate;

        public int Heart_rate
        {
            get { return heart_rate; }
            set { heart_rate = value; }
        }
        private string heart_inspect;

        public string Heart_inspect
        {
            get { return heart_inspect; }
            set { heart_inspect = value; }
        }
        private int noise_level;

        public int Noise_level
        {
            get { return noise_level; }
            set { noise_level = value; }
        }
        private int blood_lpressure;

        public int Blood_lpressure
        {
            get { return blood_lpressure; }
            set { blood_lpressure = value; }
        }
        private int blood_hpressure;

        public int Blood_hpressure
        {
            get { return blood_hpressure; }
            set { blood_hpressure = value; }
        }
        private string eye_inspect;

        public string Eye_inspect
        {
            get { return eye_inspect; }
            set { eye_inspect = value; }
        }
        private double left_eye_out;

        public double Left_eye_out
        {
            get { return left_eye_out; }
            set { left_eye_out = value; }
        }
        private double right_eye_out;

        public double Right_eye_out
        {
            get { return right_eye_out; }
            set { right_eye_out = value; }
        }
        private double eye_distance;

        public double Eye_distance
        {
            get { return eye_distance; }
            set { eye_distance = value; }
        }
        private string else_inspect;

        public string Else_inspect
        {
            get { return else_inspect; }
            set { else_inspect = value; }
        }

        public bool readPhysicalInspect(string lid)
        {
            MySqlConnection con = CommonFunc.getConnection();
            if (con == null)
            {
                return false;
            }
            else
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("select * from physical_inspect where log_id='" + lid + "'", con);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    thyroid_inspect = reader.GetString(1);
                    thyroid_bigger = reader.GetInt32(2);
                    thyroid_left = reader.GetInt32(3);
                    thyroid_right = reader.GetInt32(4);
                    heart_rate = reader.GetInt32(5);
                    heart_inspect = reader.GetString(6);
                    noise_level = reader.GetInt32(7);
                    blood_lpressure = reader.GetInt32(8);
                    blood_hpressure = reader.GetInt32(9);
                    eye_inspect = reader.GetString(10);
                    left_eye_out = reader.GetDouble(11);
                    right_eye_out = reader.GetDouble(12);
                    eye_distance = reader.GetDouble(13);
                    else_inspect = reader.GetString(14);
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
                string insert_sql = "insert into physical_inspect(log_id,thyroid_inspect,thyroid_bigger,thyroid_left,thyroid_right,heart_rate,heart_inspect,noise_level,blood_lpresure," +
                    "blood_hpresure,eye_inspect,left_eye_out,right_eye_out,eye_distance,else_inspect) value('" + lid + "','" + thyroid_inspect + "'," + thyroid_bigger + "," + thyroid_left + "," + thyroid_right + "," + 
                    heart_rate + ",'" + heart_inspect + "'," + noise_level + "," + blood_lpressure + "," + blood_hpressure + ",'" + eye_inspect + "'," + left_eye_out + "," + right_eye_out + "," + eye_distance +
                    ",'" + else_inspect + "')";
                MySqlCommand command = new MySqlCommand(insert_sql, con);;
                try
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    //MessageBox.Show("保存成功！");
                }
                catch (MySqlException e)
                {
                    e.Message.ToString();
                    MessageBox.Show("体格检查保存失败！");
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
                string update_sql = "update physical_inspect set thyroid_inspect='" + thyroid_inspect + "', thyroid_bigger=" + thyroid_bigger + ",thyroid_left=" + thyroid_left + ",thyroid_right=" + thyroid_right + 
                    ",heart_rate=" + heart_rate + ",heart_inspect='" + heart_inspect + "',noise_level=" + noise_level + ",blood_lpresure=" + blood_lpressure + ",blood_hpresure=" + blood_hpressure + ",eye_inspect='" + eye_inspect +
                    "',left_eye_out=" + left_eye_out + ",right_eye_out=" + right_eye_out + ",eye_distance=" + eye_distance + ",else_inspect='" + else_inspect + "' where log_id='" + lid + "'";
                
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
                    MessageBox.Show("体格检查更新失败！");
                }
                con.Close();
                return true;
            }
        }
    }
}
