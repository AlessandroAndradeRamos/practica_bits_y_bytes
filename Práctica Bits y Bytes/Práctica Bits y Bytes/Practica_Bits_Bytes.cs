using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_Bits_y_Bytes
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private int getFechaArreglada(string entrada)
        {
            string[] arreglada = entrada.Split('/');
            int fecha = 0;
            int dia = Convert.ToInt32(arreglada[0]);
            int mes = Convert.ToInt32(arreglada[1]) << 5;
            int año = (Convert.ToInt32(arreglada[2]) - 1900) << 9;
            fecha += año + mes + dia;
            return fecha;
        }
        private int getDia(int entrada)
        {
            int dia = (entrada >> 8) & 31;
            return dia;
        }
        private int getMes(int entrada)
        {
            int mes = (entrada >> 13) & 15;
            return mes;
        }
        private int getAño(int entrada)
        {
            int año = (entrada >> 17) & 127;
            return año;
        }
        private void getSensorSwitchCheck(int entrada)
        {
            int control = (entrada >> 7) & 1;
            ptbSensorDos.Image = istSensoresCheck.Images[control];
        }
        private void getSensorSwitchOnOff(int entrada)
        {
            int control = (entrada >> 6) & 1;
            ptbSensorUno.Image = istSensores.Images[control];
            getSensorSwitchCheck(entrada);
        }
        private void getNivelDelTanque(int entrada)
        {
            int control = (entrada >> 4) & 3;
            ptbNivel.Image = istNivel.Images[control];
            getSensorSwitchOnOff(entrada);
        }
        private void getDireccion(int entrada)
        {
            int control = (entrada >>1) & 7;
            ptbRosaDeLosVientos.Image = istRosaDeLosVientos.Images[control];
            getNivelDelTanque(entrada);
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            int control = Convert.ToInt32(txtEntrada.Text);
            getDireccion(control);
            int año = getAño(control), dia = getDia(control), mes = getMes(control);
            if (año == 0)
                lblMostrarFecha.Text = dia.ToString() + "/" + mes.ToString() + "/1900";
            else
                lblMostrarFecha.Text = dia.ToString() + "/" + mes.ToString() + "/" + año.ToString();
        }
        private void btnDateFixer_Click(object sender, EventArgs e)
        {
            lblShowFixedDate.Text = getFechaArreglada(lblMostrarFecha.Text).ToString();
        }
    }
}
