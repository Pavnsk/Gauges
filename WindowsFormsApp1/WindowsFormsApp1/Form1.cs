using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public class quad
        {
            public string id;
            public decimal mi_d1, ma_d1, vo_d1, no_d1;
            public override string ToString()
            {
                return String.Format("[mi:{0} ma:{1} vo:{2} no:{3}]", mi_d1, ma_d1, vo_d1, no_d1);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public string ToTrimmedString(decimal num)
        {
            string str = num.ToString();
            string decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            if (str.Contains(decimalSeparator))
            {
                str = str.TrimEnd('0');
                if (str.EndsWith(decimalSeparator))
                {
                    str = RemoveFromEnd(str, 1);
                }
            }
            return str;
        }

        public string RemoveFromEnd(string str, int characterCount)
        {
            return str.Remove(str.Length - characterCount, characterCount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"ST SEV 144.txt");

            using (StreamWriter fs = File.CreateText("out.txt"))
            {
                // Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                // Add some information to the file.
                //  fs.Write(info, 0, info.Length);
                // }


                // File.Create();

                Hashtable tbl = new Hashtable();

                for (int i = 5; i < lines.Length; i++)
                {
                    string line = lines[i];

                    string id = line.Substring(0, 6).Trim();
                    string mi = line.Substring(6, 5);

                    string ma;
                    string vo;
                    string no;

                    if (line.Length < 16)
                    {
                        ma = line.Substring(11);
                        vo = "0";
                        no = "0";
                    }
                    else
                    {
                        ma = line.Substring(11, 5);

                        if (line.Length < 24)
                        {
                            vo = line.Substring(16);
                            no = "0";
                        }
                        else
                        {
                            vo = line.Substring(16, 8);
                            no = line.Substring(24);
                        }
                    }

                    decimal mi_d = Decimal.Parse(mi);
                    decimal ma_d = Decimal.Parse(ma);
                    decimal vo_d = 0;
                    if (vo.Trim().Length != 0)
                    {
                        vo_d = Decimal.Parse(vo);
                    }
                    decimal no_d = Decimal.Parse(no);

                    if (!tbl.ContainsKey(id))
                    {
                        tbl[id] = new ArrayList();
                    }

                    (tbl[id] as ArrayList).Add(new quad() { mi_d1 = mi_d, ma_d1 = ma_d, no_d1 = no_d, vo_d1 = vo_d });

                }

                /*
                string s1 = "";
                foreach (var item in tbl.Keys)
                {
                    s1 += item.ToString()+" ";
                }

                string s2 = "";
                foreach (var de in (tbl["H4"] as ArrayList))
                {
                    var x = (de as quad);
                    s2 += x.ToString() + " ";
                }*/

                foreach (var item in tbl.Keys)
                {
                    ArrayList mi_list = new ArrayList(),
                        ma_list = new ArrayList(),
                        vo_list = new ArrayList(),
                        no_list = new ArrayList();

                    foreach (var de in (tbl[item] as ArrayList))
                    {
                        var x = (de as quad);
                        mi_list.Add(x.mi_d1);
                        ma_list.Add(x.ma_d1);
                        vo_list.Add(x.vo_d1);
                        no_list.Add(x.no_d1);
                    }

                    //              public static ПолеДопуска H4 = new ПолеДопуска(ОсновноеОтклонение.H, 4,
                    //new decimal[] { 3m, 6m, 10m, 18m, 30m, 50m, 80m, 120m, 180m, 250m, 315m, 400m, 500m },
                    //new decimal[] { 3m, 4m, 4m, 5m, 6m, 7m, 8m, 10m, 12m, 14m, 16m, 18m, 20m },
                    //new decimal[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
                    StringBuilder sb = new StringBuilder();

                    string ll = item.ToString();
                    int ee = 0;
                    for(int ci = 0; ci <ll.Length; ci++)
                    {
                        if(Char.IsDigit(ll[ci]))
                        {
                            ee = ci;
                            break;
                        }
                    }

                    string ss1 = ll.Substring(0, ee);
                    string ss2 = ll.Substring(ee);

                    //Regex rg = new Regex(@"^([^\d]+)(\d+)$");

                    //var match = rg.Matches(item.ToString());

                    sb.AppendLine("public static ПолеДопуска " + item + " = new ПолеДопуска(ОсновноеОтклонение."+ss1+", "+ ss2 + ",");
                    sb.Append("new decimal[] { ");
                    foreach (var z in ma_list)
                    {
                        sb.Append(" " + z + "m,");
                    }
                    sb.AppendLine(" },");
                    sb.Append("new decimal[] { ");
                    foreach (var z in vo_list)
                    {
                        sb.Append(" " + ToTrimmedString((decimal)z * 1000) + "m,");
                    }
                    sb.AppendLine(" },");

                    sb.Append("new decimal[] { ");
                    foreach (var z in no_list)
                    {
                        sb.Append(" " + ToTrimmedString((decimal)z * 1000) + "m,");
                    }
                    sb.AppendLine(" }");
                    sb.AppendLine(");");
                    string txt = sb.ToString();
                    
                    fs.WriteLine(txt.Replace(", },", " },").Replace(", }", " }"));
                }
            }
        }
    }
}
