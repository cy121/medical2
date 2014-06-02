using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MedicalV2
{
    class FollowVisit
    {
        private string fv_id;

        public string Fv_id
        {
            get { return fv_id; }
            set { fv_id = value; }
        }
        private string fv_date;

        public string Fv_date
        {
            get { return fv_date; }
            set { fv_date = value; }
        }
        private string log_id;

        public string Log_id
        {
            get { return log_id; }
            set { log_id = value; }
        }
        private string main_report;

        public string Main_report
        {
            get { return main_report; }
            set { main_report = value; }
        }
        private string heavy_thing;

        public string Heavy_thing
        {
            get { return heavy_thing; }
            set { heavy_thing = value; }
        }
        private string light_thing;

        public string Light_thing
        {
            get { return light_thing; }
            set { light_thing = value; }
        }
        private int heart_rate;

        public int Heart_rate
        {
            get { return heart_rate; }
            set { heart_rate = value; }
        }
        private int heart_rythm;

        public int Heart_rythm
        {
            get { return heart_rythm; }
            set { heart_rythm = value; }
        }
        private double thyroid_size;

        public double Thyroid_size
        {
            get { return thyroid_size; }
            set { thyroid_size = value; }
        }
        private string thyroid_grain;

        public string Thyroid_grain
        {
            get { return thyroid_grain; }
            set { thyroid_grain = value; }
        }
        private string ph_else;

        public string Ph_else
        {
            get { return ph_else; }
            set { ph_else = value; }
        }
        private double ft3;

        public double Ft3
        {
            get { return ft3; }
            set { ft3 = value; }
        }
        private double ft4;

        public double Ft4
        {
            get { return ft4; }
            set { ft4 = value; }
        }
        private double tsh;

        public double Tsh
        {
            get { return tsh; }
            set { tsh = value; }
        }
        private double tt3;

        public double Tt3
        {
            get { return tt3; }
            set { tt3 = value; }
        }
        private double tt4;

        public double Tt4
        {
            get { return tt4; }
            set { tt4 = value; }
        }
        private double tpoab;

        public double Tpoab
        {
            get { return tpoab; }
            set { tpoab = value; }
        }
        private double tgab;

        public double Tgab
        {
            get { return tgab; }
            set { tgab = value; }
        }
        private double trab;

        public double Trab
        {
            get { return trab; }
            set { trab = value; }
        }
        private double wbc;

        public double Wbc
        {
            get { return wbc; }
            set { wbc = value; }
        }
        private double rbc;

        public double Rbc
        {
            get { return rbc; }
            set { rbc = value; }
        }
        private double hb;

        public double Hb
        {
            get { return hb; }
            set { hb = value; }
        }
        private double plt;

        public double Plt
        {
            get { return plt; }
            set { plt = value; }
        }
        private string n;

        public string N
        {
            get { return n; }
            set { n = value; }
        }
        private string l;

        public string L
        {
            get { return l; }
            set { l = value; }
        }
        private double tb;

        public double Tb
        {
            get { return tb; }
            set { tb = value; }
        }
        private double db;

        public double Db
        {
            get { return db; }
            set { db = value; }
        }
        private double alt;

        public double Alt
        {
            get { return alt; }
            set { alt = value; }
        }
        private double ast;

        public double Ast
        {
            get { return ast; }
            set { ast = value; }
        }
        private double alp;

        public double Alp
        {
            get { return alp; }
            set { alp = value; }
        }
        private double ygt;

        public double Ygt
        {
            get { return ygt; }
            set { ygt = value; }
        }
        private double tp;

        public double Tp
        {
            get { return tp; }
            set { tp = value; }
        }
        private double alb;

        public double Alb
        {
            get { return alb; }
            set { alb = value; }
        }
        private double glo;

        public double Glo
        {
            get { return glo; }
            set { glo = value; }
        }
        private double ag;

        public double Ag
        {
            get { return ag; }
            set { ag = value; }
        }
        private double bun;

        public double Bun
        {
            get { return bun; }
            set { bun = value; }
        }
        private double ua;

        public double Ua
        {
            get { return ua; }
            set { ua = value; }
        }
        private double cr;

        public double Cr
        {
            get { return cr; }
            set { cr = value; }
        }
        private double glu;

        public double Glu
        {
            get { return glu; }
            set { glu = value; }
        }
        private string lab_else;

        public string Lab_else
        {
            get { return lab_else; }
            set { lab_else = value; }
        }
        private string handle;

        public string Handle
        {
            get { return handle; }
            set { handle = value; }
        }

        public bool insertFollowVisit(string lid)
        {
            MySqlConnection con = CommonFunc.getConnection();
            if (con == null)
            {
                return false;
            }
            else
            {
                string insert_sql = "insert into follow_visit(fv_id,fv_date,log_id,main_report,heavy_thing,light_thing,heart_rate,heart_rythm,thyroid_size,thyroid_grain,ph_else,ft3,ft4,tsh,tt3,tt4,tpoab,tgab,trab,wbc,rbc,hb,plt,n,l,tb,db,alt,ast,alp," +
                    "ygt,tp,alb,glo,ag,bun,ua,cr,glu,lab_else,handle) value('" + fv_id + "','" + fv_date + "','" + lid + "','" + main_report + "','" + heavy_thing + "','" + light_thing + "'," + heart_rate + "," + heart_rythm + "," +
                    +thyroid_size + ",'" + thyroid_grain + "','" + ph_else + "'," + ft3 + "," + ft4 + "," + tsh + "," + tt3 + "," + tt4 + "," + tpoab + "," + tgab + "," +
                    trab + "," + wbc + "," + rbc + "," + hb + "," + plt + ",'" + n + "','" + l + "'," + tb + "," + db + "," + alt + "," + ast + "," + alp + "," + ygt + "," + tp + "," + alb + "," + glo + "," +
                    ag + "," + bun + "," + ua + "," + cr + "," + glu + ",'" + lab_else + "','" + handle + "')";
                MySqlCommand command = new MySqlCommand(insert_sql, con);
                try
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("保存成功！");
                }
                catch (MySqlException e)
                {
                    e.Message.ToString();
                    MessageBox.Show("无法保存！");
                }
                con.Close();
                return true;
            }
        }
    }
}
