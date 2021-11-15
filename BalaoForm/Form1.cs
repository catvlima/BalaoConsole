using BalaoConsole_3._0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalaoForm
{
    public partial class Form1 : Form
    {
        int alt = 0;
         
        public Balao Balaozito { get; set; }

        

        public Form1()
        {
            InitializeComponent();

            Balaozito = new Balao();

            lbl_InfoCor.Text = $"Cor do balão: Rosa";
            lbl_InfoDirecao.Text = "";
            Balaozito.DirecaoAtual = lbl_InfoDirecao.Text;
            lbl_InfoAltura.Text = $"Altura do balão: {alt.ToString()}";
            
            Balaozito.Altura = 0;
        }

        private void bt_up_Click(object sender, EventArgs e)
        {
            pb_balao.Location = new Point(pb_balao.Location.X, pb_balao.Location.Y - 5);
            Balaozito.DirecaoAtual = "Norte";
            alt++;
            Balaozito.Altura = alt;
            lbl_InfoAltura.Text = $"Altura do balão: {Balaozito.Altura} metros";
            lbl_InfoDirecao.Text = $"Direção atual do balão: {Balaozito.DirecaoAtual}";


        }

        private void bt_left_Click(object sender, EventArgs e)
        {
           
            Balaozito.DirecaoAtual = "Esquerda";
            lbl_InfoDirecao.Text = $"Direção atual do balão: {Balaozito.DirecaoAtual}";

            if (pb_balao.Location.X >= 96)
            {
                pb_balao.Location = new Point(pb_balao.Location.X - 5, pb_balao.Location.Y);
            }
            else if (pb_balao.Location.X <= 96)
            {
                
                MessageBox.Show("Não pode ir mais para a esquerda!");
            }

        }

        private void bt_down_Click(object sender, EventArgs e)
        {
            if (Balaozito.Altura > 0)
            {
                pb_balao.Location = new Point(pb_balao.Location.X, pb_balao.Location.Y + 5);
                Balaozito.DirecaoAtual = "Sul";
                alt--;
                Balaozito.Altura = alt;
                lbl_InfoAltura.Text = $"Altura do balão: {Balaozito.Altura} metros";
                lbl_InfoDirecao.Text = $"Direção atual do balão: {Balaozito.DirecaoAtual}";
            }
            else
            {
                MessageBox.Show($"Não pode descer mais!");
            }
            

        }

        private void bt_right_Click(object sender, EventArgs e)
        {

           

            Balaozito.DirecaoAtual = "Direita";
            lbl_InfoDirecao.Text = $"Direção atual do balão: {Balaozito.DirecaoAtual}";

            if (pb_balao.Location.X <= 342)
            {
                pb_balao.Location = new Point(pb_balao.Location.X + 5, pb_balao.Location.Y);
            }
            else if (pb_balao.Location.X >= 342)
            {
                MessageBox.Show("Não pode ir mais para a direita!");
            }

           

        }

        private void bt_MudarCor_Click(object sender, EventArgs e)
        {
            

            if (cb_cor.Visible)
            {
                cb_cor.Visible = false;
            }
            else
            {
                cb_cor.Visible = true;
            }
        }

        private void cb_cor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_cor.SelectedItem.ToString() == "Amarelo")
            {
                pb_balao.Image = BalaoForm.Properties.Resources.balao_amarelo;
                Balaozito.Cor = "Amarelo";
                lbl_InfoCor.Text = $"Cor do balão: {Balaozito.Cor}";
            }
            else if (cb_cor.SelectedItem.ToString() == "Azul")
            {
                pb_balao.Image = BalaoForm.Properties.Resources.balao_azul;
                Balaozito.Cor = "Azul";
                lbl_InfoCor.Text = $"Cor do balão: {Balaozito.Cor}";
            }
            else if (cb_cor.SelectedItem.ToString() == "Rosa")
            {
                pb_balao.Image = BalaoForm.Properties.Resources._6694799891583ec4d30a721cba05cbd9;
                Balaozito.Cor = "Rosa";
                lbl_InfoCor.Text = $"Cor do balão: {Balaozito.Cor}";
            }
            else
            {
                pb_balao.Image = BalaoForm.Properties.Resources.balao_lilas;
                Balaozito.Cor = "Lilás";
                lbl_InfoCor.Text = $"Cor do balão: {Balaozito.Cor}";
            }
        }
    }
}
