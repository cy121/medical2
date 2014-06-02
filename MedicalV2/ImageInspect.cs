using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace MedicalV2
{
    class ImageInspect
    {
        private string ecg;

        public string Ecg
        {
            get { return ecg; }
            set { ecg = value; }
        }

        private string ect_left;

        public string Ect_left
        {
            get { return ect_left; }
            set { ect_left = value; }
        }

        private string ect_right;

        public string Ect_right
        {
            get { return ect_right; }
            set { ect_right = value; }
        }

        private double ect_area;

        public double Ect_area
        {
            get { return ect_area; }
            set { ect_area = value; }
        }

        private double ect_tb;

        public double Ect_tb
        {
            get { return ect_tb; }
            set { ect_tb = value; }
        }

        private double ect_weight;

        public double Ect_weight
        {
            get { return ect_weight; }
            set { ect_weight = value; }
        }

        private string ect_inspect;

        public string Ect_inspect
        {
            get { return ect_inspect; }
            set { ect_inspect = value; }
        }

        private string ect_nodule;

        public string Ect_nodule
        {
            get { return ect_nodule; }
            set { ect_nodule = value; }
        }

        private string b_left;

        public string B_left
        {
            get { return b_left; }
            set { b_left = value; }
        }

        private string b_right;

        public string B_right
        {
            get { return b_right; }
            set { b_right = value; }
        }

        private double b_area;

        public double B_area
        {
            get { return b_area; }
            set { b_area = value; }
        }

        private double b_weight;

        public double B_weight
        {
            get { return b_weight; }
            set { b_weight = value; }
        }

        private string b_inspect;

        public string B_inspect
        {
            get { return b_inspect; }
            set { b_inspect = value; }
        }

        private string b_nodule;

        public string B_nodule
        {
            get { return b_nodule; }
            set { b_nodule = value; }
        }

        private double else_inspect;

        public double Else_inspect
        {
            get { return else_inspect; }
            set { else_inspect = value; }
        }

        private string diagnosis;

        public string Diagnosis
        {
            get { return diagnosis; }
            set { diagnosis = value;}
        }
        public bool readImageInspect(string lid)
        {
             MySqlConnection con = CommonFunc.getConnection();
             if (con == null)
             {
                 return false;
             }
             else
             {
                 con.Open();
                 MySqlCommand command = new MySqlCommand("select * from image_inspect where log_id='" + lid + "'", con);
                 MySqlDataReader reader = command.ExecuteReader();

                 if (reader.Read())
                 {
                     ecg = reader.GetString(1);
                     ect_left = reader.GetString(2);
                     ect_right = reader.GetString(3);
                     ect_area = reader.GetDouble(4);
                     ect_tb = reader.GetDouble(5);
                     ect_weight = reader.GetDouble(6);
                     ect_inspect = reader.GetString(7);
                     ect_nodule = reader.GetString(8);
                     b_left = reader.GetString(9);
                     b_right = reader.GetString(10);
                     b_area = reader.GetDouble(11);
                     b_weight = reader.GetDouble(12);
                     b_inspect = reader.GetString(13);
                     b_nodule = reader.GetString(14);
                     else_inspect = reader.GetDouble(15);
                     diagnosis = reader.GetString(16);
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

        public bool insertImageInspect(string lid)
        {
            MySqlConnection con = CommonFunc.getConnection();
            if (con == null)
            {
                return false;
            }
            else
            {
                string insert_sql = "insert into image_inspect(log_id,ecg,ect_left,ect_right,ect_area,ect_tb,ect_weight,ect_inspect," +
                "ect_nodule,b_left,b_right,b_area,b_weight,b_inspect,b_nodule,else_inspect,diagnosis) value('" + lid + "','" + ecg + "','" + ect_left +
                "','" + ect_right + "'," + ect_area + "," + ect_tb + "," + ect_weight + ",'" + ect_inspect + "','" + ect_nodule + "','" + b_left + "','" +
                b_right + "'," + b_area + "," + b_weight + ",'" + b_inspect + "','" + b_nodule + "'," + else_inspect + ",'" + diagnosis + "')";
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
                    MessageBox.Show("影像检查保存失败！");
                }
                con.Close();
                return true;
            }
        }
    }
}
