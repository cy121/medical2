using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MedicalV2
{
    class LabInspect
    {
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
        private string else_inspect;

        public string Else_inspect
        {
            get { return else_inspect; }
            set { else_inspect = value; }
        }
        private double sc;

        public double Sc
        {
            get { return sc; }
            set { sc = value; }
        }

        private double k;
        public double K
        {
            get { return k; }
            set { k = value; }
        }

        private double p;
        public double P
        {
            get { return p; }
            set { p = value; }
        }

        public bool readLabInspect(string lid)
        {
            MySqlConnection con = CommonFunc.getConnection();
            if (con == null)
            {
                return false;
            }
            else
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("select * from lab_inspect where log_id='" + lid + "'", con);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ft3 = reader.GetDouble(1);
                    ft4 = reader.GetDouble(2);
                    tsh = reader.GetDouble(3);
                    tt3 = reader.GetDouble(4);
                    tt4 = reader.GetDouble(5);
                    tpoab = reader.GetDouble(6);
                    tgab = reader.GetDouble(7);
                    trab = reader.GetDouble(8);
                    wbc = reader.GetDouble(9);
                    rbc = reader.GetDouble(10);
                    hb = reader.GetDouble(11);
                    plt = reader.GetDouble(12);
                    n = reader.GetString(13);
                    l = reader.GetString(14);
                    tb = reader.GetDouble(15);
                    db = reader.GetDouble(16);
                    alt = reader.GetDouble(17);
                    ast = reader.GetDouble(18);
                    alp = reader.GetDouble(19);
                    ygt = reader.GetDouble(20);
                    tp = reader.GetDouble(21);
                    alb = reader.GetDouble(22);
                    glo = reader.GetDouble(23);
                    ag = reader.GetDouble(24);
                    bun = reader.GetDouble(25);
                    ua = reader.GetDouble(26);
                    cr = reader.GetDouble(27);
                    glu = reader.GetDouble(28);
                    else_inspect = reader.GetString(29);
                    sc = reader.GetDouble(30);
                    k = reader.GetDouble(31);
                    p = reader.GetDouble(32);
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

        public bool insertLabInspect(string lid)
        {
            MySqlConnection con = CommonFunc.getConnection();
            if (con == null)
            {
                return false;
            }
            else
            {
                string insert_sql = "insert into lab_inspect(log_id,ft3,ft4,tsh,tt3,tt4,tpoab,tgab,trab,wbc,rbc,hb,plt,n,l,tb,db,alt,ast,alp," +
                    "ygt,tp,alb,glo,ag,bun,ua,cr,glu,else_inspect,sc,k,p) value('" + lid + "'," + ft3 + "," + ft4 + "," + tsh + "," + tt3 + "," + tt4 + "," + tpoab + "," + tgab + "," +
                    trab + "," + wbc + "," + rbc + "," + hb + "," + plt + ",'" + n + "','" + l + "'," + tb + "," + db + "," + alt + "," + ast + "," + alp + "," + ygt + "," + tp + "," + alb + "," + glo + "," +
                    ag + "," + bun + "," + ua + "," + cr + "," + glu + ",'" + else_inspect + "',"+ sc +","+ k +","+ p +")";
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
                    MessageBox.Show("化验检查保存失败！");
                }
                con.Close();
                return true;
            }
        }

        public bool updateLabInspect(string lid)
        {
            MySqlConnection con = CommonFunc.getConnection();
            if (con == null)
            {
                return false;
            }
            else
            {
                string update_sql = "update lab_inspect set ft3=" + ft3 + ", ft4=" + ft4 + ",tsh=" + tsh + ",tt3=" + tt3 + ",tt4=" + tt4 + ",tpoab=" + tpoab +
                    ",tgab=" + tgab + ",trab=" + trab + ",wbc=" + wbc + ",rbc=" + rbc + ",hb=" + hb + ",plt=" + plt + ",n='" + n + "',l='" + l + "',tb=" + tb +
                    ",db=" + db + ",alt=" + alt + ",ast=" + ast + ",alp=" + alp + ",ygt=" + ygt + ",tp=" + tp + ",alb=" + alb + ",glo=" + glo + ",ag=" + ag + ",bun=" + bun + ",ua=" + ua +
                    ",cr=" + cr + ",glu=" + glu + ",else_inspect='" + else_inspect + "',sc="+ sc +",k="+ k +",p="+ p +" where log_id='" + lid + "'";
                
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
                    MessageBox.Show("化验检查更新失败！");
                }
                con.Close();
                return true;
            }
        }
    }
}
