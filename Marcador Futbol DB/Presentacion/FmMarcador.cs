using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FmMarcador : Form
    {

        int second = 0;
        int minute = 0;
        Boolean secondTime = false;
        public FmMarcador()
        {
            InitializeComponent();
        }
        

        private void timerChronometer_Tick(object sender, EventArgs e)
        {
            second += 1;
            string seg = second.ToString();
            string min = minute.ToString();
        
            if (second < 10) seg = "0" + second.ToString();
            if (minute < 10) min = "0" + minute.ToString();
       
            lblTime.Text =  min + ":" +seg;

            if (second == 60)
            {
                minute += 1;
                second = 0;
            }

            if ((minute == 90) && (secondTime))
            {
                timerChronometer.Stop();
                lblTime.Text = "90:00";
                timerExtra.Start();
            }


        }

        private void txt_local_TextChanged(object sender, EventArgs e)
        {
            lblLocal.Text = (txt_local.Text).ToUpper();
        }

        private void txt_visitor_TextChanged(object sender, EventArgs e)
        {
            lblVisitor.Text = (txt_visitor.Text).ToUpper();
        }

        private void btnImgLocal_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageLocal = new OpenFileDialog();
            imageLocal.Title = "Equipación Local";
            imageLocal.Filter = "Archivos de imagen (*.jpg, *.png)| *.jpg; *.png";
            if (imageLocal.ShowDialog() == DialogResult.OK)
            {
                imgLocal.Image =Image.FromFile(imageLocal.FileName);
            }
        }

        private void btnImgVisitor_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageVisitor = new OpenFileDialog();
            imageVisitor.Title = "Equipación Local";
            imageVisitor.Filter = "Archivos de imagen (*.jpg, *.png)| *.jpg; *.png";
            if (imageVisitor.ShowDialog() == DialogResult.OK)
                imgVisitor.Image = Image.FromFile(imageVisitor.FileName);
        }

        int countVisitor = 0;
        private void btnRemoveCountVisitor_Click(object sender, EventArgs e)
        {
            if(countVisitor==0) lblCountVisitor.Text = "0";
            else
            {
                countVisitor -= 1;
                lblCountVisitor.Text = (countVisitor).ToString();
            }
        }

        private void btnAddCountVisitor_Click(object sender, EventArgs e)
        {
            countVisitor += 1;
            lblCountVisitor.Text = (countVisitor).ToString();
        }

        int countLocal = 0;
        private void btnRemoveCountLocal_Click(object sender, EventArgs e)
        {
            if (countLocal == 0) lblCountVisitor.Text = "0";
            else
            {
                countLocal -= 1;
                lblCountLocal.Text = (countLocal).ToString();
            }
        }

        private void btnAddCountLocal_Click(object sender, EventArgs e)
        {
            countLocal += 1;
            lblCountLocal.Text = (countLocal).ToString();
        }

        private void btnPrimaryTime_Click(object sender, EventArgs e)
        {
            timerChronometer.Start();
            btnPrimaryTime.Enabled = false;
            btnPrimaryTime.Visible = false;

            btnPrimaryTimePause.Enabled = true;
            btnPrimaryTimePause.Visible = true;

            btnPrimaryTimeRestart.Enabled = true;
            btnPrimaryTimeRestart.Visible = true;
        }


        private void btnSecondTime_Click(object sender, EventArgs e)
        {
            minute = 45;
            second = 0;
            timerChronometer.Start();
            secondTime = true;
            
            btnSecondTime.Enabled = false;
            btnSecondTime.Visible = false;

            btnSecondTimePause.Enabled = true;
            btnSecondTimePause.Visible = true;

            btnSecondTimeRestart.Enabled = true;
            btnSecondTimeRestart.Visible = true;
        }

        private void timerExtra_Tick(object sender, EventArgs e)
        {
            second += 1;
            string seg = second.ToString();
            string min = minute.ToString();

            if (second < 10) seg = "0" + second.ToString();
            if (minute < 10) min = "0" + minute.ToString();

            lblExtra.Text = min + ":" + seg;

            if (second == 60)
            {
                minute += 1;
                second = 0;
            }
        }

        private void btnPrimaryTimePause_Click(object sender, EventArgs e)
        {
            timerChronometer.Stop();
            btnPrimaryTimePause.Enabled = false;
            btnPrimaryTimePause.Visible = false;

            btnPrimaryTimeRestart.Enabled = false;
            btnPrimaryTimeRestart.Visible = false;

            btnPrimaryTime.Enabled = true;
            btnPrimaryTime.Visible = true;

        }

        private void btnPrimaryTimeRestart_Click(object sender, EventArgs e)
        {
            minute = 0;
            second = 0;       
            timerChronometer.Start();

            btnPrimaryTime.Enabled = false;
            btnPrimaryTime.Visible = false;

            btnPrimaryTimePause.Enabled = true;
            btnPrimaryTimePause.Visible = true;

            btnPrimaryTimeRestart.Enabled = true;
            btnPrimaryTimeRestart.Visible = true;
        }

        private void btnSecondTimePause_Click(object sender, EventArgs e)
        {
            timerChronometer.Stop();
            timerExtra.Stop();
            btnSecondTimePause.Enabled = false;
            btnSecondTimePause.Visible = false;

            btnSecondTimeRestart.Enabled = false;
            btnSecondTimeRestart.Visible = false;

            btnSecondTime.Enabled = true;
            btnSecondTime.Visible = true;
        }

        private void btnSecondTimeRestart_Click(object sender, EventArgs e)
        {
            minute = 45;
            second = 0;
            timerChronometer.Start();

            btnSecondTime.Enabled = false;
            btnSecondTime.Visible = false;

            btnSecondTimePause.Enabled = true;
            btnSecondTimePause.Visible = true;

            btnSecondTimeRestart.Enabled = true;
            btnSecondTimeRestart.Visible = true;
        }

        private void txtTorneo_TextChanged(object sender, EventArgs e)
        {
            lblTorneo.Text = (txtTorneo.Text).ToUpper();
        }

        private void TxtFecha_TextChanged(object sender, EventArgs e)
        {
            lblFecha.Text = (TxtFecha.Text).ToUpper();
        }

        private void txtGrup_TextChanged(object sender, EventArgs e)
        {
            lblGroup.Text = (txtGroup.Text).ToUpper();
        }

        private void txtFase_TextChanged(object sender, EventArgs e)
        {
            lblFase.Text = (txtFase.Text).ToUpper();
        }

        private void btnImgTorneo_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageTorneo = new OpenFileDialog();
            imageTorneo.Title = "Torneo";
            imageTorneo.Filter = "Archivos de imagen (*.jpg, *.png)| *.jpg; *.png";
            if (imageTorneo.ShowDialog() == DialogResult.OK)
                imgTorneo.Image = Image.FromFile(imageTorneo.FileName);
        }
    }
}
