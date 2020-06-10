using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverDPApplication
{
    public partial class Form1 : Form
    {
        public static Label flabel;
        public static Label blabel;
        public static Label vlabel;
        public static Label ylabel;
        DataTable tablo = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void kapatPBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void futbolBtn_Click(object sender, EventArgs e)
        {
            futbolPnl.Visible = true;
            voleybolPnl.Visible = false;
            yuzmePnl.Visible = false;
            basketbolPnl.Visible = false;
            anasayfaPnl.Visible = false;
            veriPnl.Visible = false;
        }

        private void basketbolBtn_Click(object sender, EventArgs e)
        {
            futbolPnl.Visible = false;
            voleybolPnl.Visible = false;
            yuzmePnl.Visible = false;
            basketbolPnl.Visible = true;
            anasayfaPnl.Visible = false;
            veriPnl.Visible = false;
        }

        private void voleybolBtn_Click(object sender, EventArgs e)
        {
            futbolPnl.Visible = false;
            voleybolPnl.Visible = true;
            yuzmePnl.Visible = false;
            basketbolPnl.Visible = false;
            anasayfaPnl.Visible = false;
            veriPnl.Visible = false;
        }

        private void yuzmeBtn_Click(object sender, EventArgs e)
        {
            futbolPnl.Visible = false;
            voleybolPnl.Visible = false;
            yuzmePnl.Visible = true;
            basketbolPnl.Visible = false;
            anasayfaPnl.Visible = false;
            veriPnl.Visible = false;
        }

        private void veriBtn_Click(object sender, EventArgs e)
        {
            futbolPnl.Visible = false;
            voleybolPnl.Visible = false;
            yuzmePnl.Visible = false;
            basketbolPnl.Visible = false;
            anasayfaPnl.Visible = false;
            veriPnl.Visible = true;
        }

        private void futbol_Click(object sender, EventArgs e)
        {
            sporcular.Enabled = true;
            sporcular.Items.Clear();
            dataGridView1.DataSource = null;
            for (int i=0; i<fSporcu.Items.Count; i++)
            {
                sporcular.Items.Add(fSporcu.Items[i].ToString());
            }
        }

        private void basketbol_Click(object sender, EventArgs e)
        {
            sporcular.Enabled = true;
            sporcular.Items.Clear();
            dataGridView1.DataSource = null;
            for (int i = 0; i < bSporcu.Items.Count; i++)
            {
                sporcular.Items.Add(bSporcu.Items[i].ToString());
            }
        }

        private void voleybol_Click(object sender, EventArgs e)
        {
            sporcular.Enabled = true;
            sporcular.Items.Clear();
            dataGridView1.DataSource = null;
            for (int i = 0; i < vSporcu.Items.Count; i++)
            {
                sporcular.Items.Add(vSporcu.Items[i].ToString());
            }
        }

        private void yuzme_Click(object sender, EventArgs e)
        {
            sporcular.Enabled = true;
            sporcular.Items.Clear();
            dataGridView1.DataSource = null;
            for (int i = 0; i < ySporcu.Items.Count; i++)
            {
                sporcular.Items.Add(ySporcu.Items[i].ToString());
            }
        }

        private void fkaydetBtn_Click(object sender, EventArgs e)
        {
            if (fsure.Text == "" || fgol.Text == "" || fasist.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
            }
            else
            {
                veriBtn.Enabled = true;
                Futbolcu f = new Futbolcu { Name = fSporcu.SelectedItem.ToString(), Sure = Convert.ToInt32(fsure.Text), Gol = Convert.ToInt32(fgol.Text), Asist = Convert.ToInt32(fasist.Text) };
                FAntrenor a = new FAntrenor();

                f.UyeEkle(a);
                f.Sure = Convert.ToInt32(fsure.Text);
                f.Gol = Convert.ToInt32(fgol.Text);
                f.Asist = Convert.ToInt32(fasist.Text);
                fguncellendiLbl.Visible = true;
            }
        }
        
        private void sporcular_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (futbol.selected)
            {
                if (fsure.Text == "" || fgol.Text == "" || fasist.Text == "")
                {
                    MessageBox.Show("Veriler Güncel Değil !!!");
                }
                else
                {
                    sporcular.Enabled = true;
                    tablo.Clear();
                    tablo.Columns.Add("AD SOYAD", typeof(string));
                    tablo.Columns.Add("SÜRE", typeof(int));
                    tablo.Columns.Add("GOL", typeof(int));
                    tablo.Columns.Add("ASİST", typeof(int));
                    

                    Futbolcu f = new Futbolcu { Name = fSporcu.SelectedItem.ToString(), Sure = Convert.ToInt32(fsure.Text), Gol = Convert.ToInt32(fgol.Text), Asist = Convert.ToInt32(fasist.Text) };

                    tablo.Rows.Add(f.Name.ToString(), f.Sure.ToString(), f.Gol.ToString(), f.Asist.ToString());
                    dataGridView1.DataSource = tablo;
                    sporcular.Enabled = false;
                }
            }
            if (basketbol.selected)
            {
                if (bsure.Text == "" || bsayi.Text == "" || bribaund.Text == "")
                {
                    MessageBox.Show("Veriler Güncel Değil !!!");
                }
                else
                {
                    tablo.Clear();
                    tablo.Columns.Add("AD SOYAD", typeof(string));
                    tablo.Columns.Add("SÜRE", typeof(int));
                    tablo.Columns.Add("SAYI", typeof(int));
                    tablo.Columns.Add("RİBAUND", typeof(int));
                    

                    Basketbolcu b = new Basketbolcu { Name = bSporcu.SelectedItem.ToString(), Sure = Convert.ToInt32(bsure.Text), Sayi = Convert.ToInt32(bsayi.Text), Ribaund = Convert.ToInt32(bribaund.Text) };

                    tablo.Rows.Add(b.Name.ToString(), b.Sure.ToString(), b.Sayi.ToString(), b.Ribaund.ToString());
                    dataGridView1.DataSource = tablo;
                    sporcular.Enabled = false;
                }
            }
            if (voleybol.selected)
            {
                if (vsure.Text == "" || vpas.Text == "" || vsmac.Text == "")
                {
                    MessageBox.Show("Veriler Güncel Değil !!!");
                }
                else
                {
                    tablo.Clear();
                    tablo.Columns.Add("AD SOYAD", typeof(string));
                    tablo.Columns.Add("SÜRE", typeof(int));
                    tablo.Columns.Add("PAS", typeof(int));
                    tablo.Columns.Add("SMAÇ", typeof(int));
                    dataGridView1.DataSource = tablo;

                    Voleybolcu v = new Voleybolcu { Name = vSporcu.SelectedItem.ToString(), Sure = Convert.ToInt32(vsure.Text), Pas = Convert.ToInt32(vpas.Text), Smac = Convert.ToInt32(vsmac.Text) };

                    tablo.Rows.Add(v.Name.ToString(), v.Sure.ToString(), v.Pas.ToString(), v.Smac.ToString());
                    dataGridView1.DataSource = tablo;
                    sporcular.Enabled = false;
                }
            }
            if (yuzme.selected)
            {
                if (ysırtsure.Text == "" || ysırtmesafe.Text == "" || ysırtteknik.Text == "" || ykelebeksure.Text == "" || ykelebekmesafe.Text == "" || ykelebekteknik.Text == "" || ykurbagasure.Text == "" || ykurbagamesafe.Text == "" || ykurbagateknik.Text == "" || yserbestsure.Text == "" || yserbestmesafe.Text == "" || yserbestteknik.Text == "")
                {
                    MessageBox.Show("Veriler Güncel Değil !!!");
                }
                else
                {
                    tablo.Clear();
                    tablo.Columns.Add("AD SOYAD", typeof(string));
                    tablo.Columns.Add("SIRT SÜRE", typeof(int));
                    tablo.Columns.Add("SIRT MESAFE", typeof(int));
                    tablo.Columns.Add("SIRT TEKNİK", typeof(string));
                    tablo.Columns.Add("KELEBEK SÜRE", typeof(int));
                    tablo.Columns.Add("KELEBEK MESAFE", typeof(int));
                    tablo.Columns.Add("KELEBEK TEKNİK", typeof(string));
                    tablo.Columns.Add("KURBAĞA SÜRE", typeof(int));
                    tablo.Columns.Add("KURBAĞA MESAFE", typeof(int));
                    tablo.Columns.Add("KURBAĞA TEKNİK", typeof(string));
                    tablo.Columns.Add("SERBEST SÜRE", typeof(int));
                    tablo.Columns.Add("SERBEST MESAFE", typeof(int));
                    tablo.Columns.Add("SERBEST TEKNİK", typeof(string));
                    dataGridView1.DataSource = tablo;

                    Yuzucu y = new Yuzucu { Name = ySporcu.SelectedItem.ToString(), SırtSure = Convert.ToInt32(ysırtsure.Text), SırtMesafe = Convert.ToInt32(ysırtmesafe.Text), SırtTeknik = ysırtteknik.Text.ToString(), KelebekSure = Convert.ToInt32(ykelebeksure.Text), KelebekMesafe = Convert.ToInt32(ykelebekmesafe.Text), KelebekTeknik = ykelebekteknik.Text, KurbagaSure = Convert.ToInt32(ykurbagasure.Text), KurbagaMesafe = Convert.ToInt32(ykurbagamesafe.Text), KurbagaTeknik = ykurbagateknik.Text, SerbestSure = Convert.ToInt32(yserbestsure.Text), SerbestMesafe = Convert.ToInt32(yserbestmesafe.Text), SerbestTeknik = yserbestteknik.Text.ToString() };

                    tablo.Rows.Add(y.Name.ToString(), y.SırtSure.ToString(), y.SırtMesafe.ToString(), y.SırtTeknik.ToString(), y.KelebekSure.ToString(), y.KelebekMesafe.ToString(), y.KelebekTeknik.ToString(), y.KurbagaSure.ToString(), y.KurbagaMesafe.ToString(), y.KurbagaTeknik.ToString(), y.SerbestSure.ToString(), y.SerbestMesafe.ToString(), y.SerbestTeknik.ToString());
                    dataGridView1.DataSource = tablo;
                    sporcular.Enabled = false;
                }
            }
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            if (futbol.selected)
            {
                Futbolcu f = new Futbolcu { Name = fSporcu.SelectedItem.ToString(), Sure = Convert.ToInt32(fsure.Text), Gol = Convert.ToInt32(fgol.Text), Asist = Convert.ToInt32(fasist.Text) };

                tablo.Rows.Add(f.Name.ToString(), f.Sure.ToString(), f.Gol.ToString(), f.Asist.ToString());
                dataGridView1.DataSource = tablo;
            }
            if (basketbol.selected)
            {
                Basketbolcu b = new Basketbolcu { Name = bSporcu.SelectedItem.ToString(), Sure = Convert.ToInt32(bsure.Text), Sayi = Convert.ToInt32(bsayi.Text), Ribaund = Convert.ToInt32(bribaund.Text) };

                tablo.Rows.Add(b.Name.ToString(), b.Sure.ToString(), b.Sayi.ToString(), b.Ribaund.ToString());
                dataGridView1.DataSource = tablo;
            }
            if (voleybol.selected)
            {
                Voleybolcu v = new Voleybolcu { Name = vSporcu.SelectedItem.ToString(), Sure = Convert.ToInt32(vsure.Text), Pas = Convert.ToInt32(vpas.Text), Smac = Convert.ToInt32(vsmac.Text) };

                tablo.Rows.Add(v.Name.ToString(), v.Sure.ToString(), v.Pas.ToString(), v.Smac.ToString());
                dataGridView1.DataSource = tablo;
            }
            if (yuzme.selected)
            {
                Yuzucu y = new Yuzucu { Name = ySporcu.SelectedItem.ToString(), SırtSure = Convert.ToInt32(ysırtsure.Text), SırtMesafe = Convert.ToInt32(ysırtmesafe.Text), SırtTeknik = ysırtteknik.Text.ToString(), KelebekSure = Convert.ToInt32(ykelebeksure.Text), KelebekMesafe = Convert.ToInt32(ykelebekmesafe.Text), KelebekTeknik = ykelebekteknik.Text, KurbagaSure = Convert.ToInt32(ykurbagasure.Text), KurbagaMesafe = Convert.ToInt32(ykurbagamesafe.Text), KurbagaTeknik = ykurbagateknik.Text, SerbestSure = Convert.ToInt32(yserbestsure.Text), SerbestMesafe = Convert.ToInt32(yserbestmesafe.Text), SerbestTeknik = yserbestteknik.Text.ToString() };

                tablo.Rows.Add(y.Name.ToString(), y.SırtSure.ToString(), y.SırtMesafe.ToString(), y.SırtTeknik.ToString(), y.KelebekSure.ToString(), y.KelebekMesafe.ToString(), y.KelebekTeknik.ToString(), y.KurbagaSure.ToString(), y.KurbagaMesafe.ToString(), y.KurbagaTeknik.ToString(), y.SerbestSure.ToString(), y.SerbestMesafe.ToString(), y.SerbestTeknik.ToString());
                dataGridView1.DataSource = tablo;
            }
        }

        private void fSporcu_SelectedIndexChanged(object sender, EventArgs e)
        {
            fsure.Text = "90";
            fgol.Text = "1";
            fasist.Text = "2";
            fkaydetBtn.Enabled = true;
        }

        private void bSporcu_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsure.Text = "35";
            bsayi.Text = "16";
            bribaund.Text = "10";
            bkaydetBtn.Enabled = true;
        }

        private void bkaydetBtn_Click(object sender, EventArgs e)
        {
            if (bsure.Text == "" || bsayi.Text == "" || bribaund.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
            }
            else
            {
                veriBtn.Enabled = true;
                Basketbolcu b = new Basketbolcu { Name = bSporcu.SelectedItem.ToString(), Sure = Convert.ToInt32(bsure.Text), Sayi = Convert.ToInt32(bsayi.Text), Ribaund = Convert.ToInt32(bribaund.Text) };
                BAntrenor a = new BAntrenor();

                b.UyeEkle(a);
                b.Sure = Convert.ToInt32(bsure.Text);
                b.Sayi = Convert.ToInt32(bsayi.Text);
                b.Ribaund = Convert.ToInt32(bribaund.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flabel = fguncellendiLbl;
            blabel = bguncellendiLbl;
            vlabel = vguncellendiLbl;
            ylabel = yguncellendiLbl;
        }

        private void vSporcu_SelectedIndexChanged(object sender, EventArgs e)
        {
            vsure.Text = "30";
            vpas.Text = "120";
            vsmac.Text = "20";
            vkaydetBtn.Enabled = true;
        }

        private void vkaydetBtn_Click(object sender, EventArgs e)
        {
            if (vsure.Text == "" || vpas.Text == "" || vsmac.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
            }
            else
            {
                veriBtn.Enabled = true;
                Voleybolcu v = new Voleybolcu { Name = vSporcu.SelectedItem.ToString(), Sure = Convert.ToInt32(vsure.Text), Pas = Convert.ToInt32(vpas.Text), Smac = Convert.ToInt32(vsmac.Text) };
                VAntrenor a = new VAntrenor();

                v.UyeEkle(a);
                v.Sure = Convert.ToInt32(vsure.Text);
                v.Pas = Convert.ToInt32(vpas.Text);
                v.Smac = Convert.ToInt32(vsmac.Text);
            }
        }

        private void ySporcu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ysırtsure.Text = "30";
            ysırtmesafe.Text = "100";
            ysırtteknik.Text = "iyi";
            ykelebeksure.Text = "25";
            ykelebekmesafe.Text = "25";
            ykelebekteknik.Text = "kötü";
            ykurbagasure.Text = "32";
            ykurbagamesafe.Text = "25";
            ykurbagateknik.Text = "kötü";
            yserbestsure.Text = "23";
            yserbestmesafe.Text = "50";
            yserbestteknik.Text = "iyi";
            ykaydetBtn.Enabled = true;
        }
        private void ykaydetBtn_Click(object sender, EventArgs e)
        {
            if (ysırtsure.Text == "" || ysırtmesafe.Text == ""|| ysırtteknik.Text == ""|| ykelebeksure.Text == "" || ykelebekmesafe.Text == "" || ykelebekteknik.Text == "" || ykurbagasure.Text == "" || ykurbagamesafe.Text == "" || ykurbagateknik.Text == "" || yserbestsure.Text == "" || yserbestmesafe.Text == "" || yserbestteknik.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
            }
            else
            {
                veriBtn.Enabled = true;
                Yuzucu y = new Yuzucu { Name = ySporcu.SelectedItem.ToString(), SırtSure = Convert.ToInt32(ysırtsure.Text), SırtMesafe = Convert.ToInt32(ysırtmesafe.Text), SırtTeknik = ysırtteknik.Text.ToString(), KelebekSure = Convert.ToInt32(ykelebeksure.Text), KelebekMesafe = Convert.ToInt32(ykelebekmesafe.Text), KelebekTeknik = ykelebekteknik.Text, KurbagaSure = Convert.ToInt32(ykurbagasure.Text), KurbagaMesafe = Convert.ToInt32(ykurbagamesafe.Text), KurbagaTeknik = ykurbagateknik.Text, SerbestSure = Convert.ToInt32(yserbestsure.Text), SerbestMesafe = Convert.ToInt32(yserbestmesafe.Text), SerbestTeknik = yserbestteknik.Text.ToString() };
                YAntrenor a = new YAntrenor();

                y.UyeEkle(a);
                y.SırtSure = Convert.ToInt32(ysırtsure.Text);
                y.SırtMesafe = Convert.ToInt32(ysırtmesafe.Text);
                y.SırtTeknik = ysırtteknik.Text;
                y.KelebekSure = Convert.ToInt32(ykelebeksure.Text);
                y.KelebekMesafe = Convert.ToInt32(ykelebekmesafe.Text);
                y.KelebekTeknik = ykelebekteknik.Text;
                y.KurbagaSure = Convert.ToInt32(ykurbagasure.Text);
                y.KurbagaMesafe = Convert.ToInt32(ykurbagamesafe.Text);
                y.KurbagaTeknik = ykurbagateknik.Text;
                y.SerbestSure = Convert.ToInt32(yserbestsure.Text);
                y.SerbestMesafe = Convert.ToInt32(yserbestmesafe.Text);
                y.SerbestTeknik = yserbestteknik.Text;
            }
            

        }
    }
}
