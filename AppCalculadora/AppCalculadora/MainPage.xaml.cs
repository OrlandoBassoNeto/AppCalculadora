using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCalculadora
{
    public partial class MainPage : ContentPage
    {
        private double valor1;
        private double valor2;
        private string operacao;

        public MainPage()
        {
            

        }

        private void ButtonNumero7_Clicked(object sender, EventArgs e)
        {
            EntryNumeros.Text += "7";
        }

        private void ButtonNumero1_Clicked(object sender, EventArgs e)
        {
            EntryNumeros.Text += "1";
        }

        private void ButtonNumero8_Clicked(object sender, EventArgs e)
        {
            EntryNumeros.Text += "8";
        }

        private void ButtonNumero9_Clicked(object sender, EventArgs e)
        {
            EntryNumeros.Text += "9";
        }

        private void ButtonNumeroSomar_Clicked(object sender, EventArgs e)
        {
            this.valor1 = Convert.ToDouble(EntryNumeros.Text);
            EntryNumeros.Text = "";
            this.operacao = "SOMA";
        }

        private void ButtonNumero6_Clicked(object sender, EventArgs e)
        {
            EntryNumeros.Text += "6";
        }

        private void ButtonNumero5_Clicked(object sender, EventArgs e)
        {
            EntryNumeros.Text += "5";
        }

        private void ButtonNumero4_Clicked(object sender, EventArgs e)
        {
            EntryNumeros.Text += "4";
        }

        private void ButtonNumeroMultiplicar_Clicked(object sender, EventArgs e)
        {
            this.valor1 = Convert.ToDouble(EntryNumeros.Text);
            EntryNumeros.Text = "";
            this.operacao = "MULTIPLICACAO";

        }

        private void ButtonNumero3_Clicked(object sender, EventArgs e)
        {
            EntryNumeros.Text += "3";
        }

        private void ButtonNumero2_Clicked(object sender, EventArgs e)
        {
            EntryNumeros.Text += "2";
        }

        private void ButtonNumeroSubtrair_Clicked(object sender, EventArgs e)
        {
            this.valor1 = Convert.ToDouble(EntryNumeros.Text);
            EntryNumeros.Text = "";
            this.operacao = "SUBTRAIR";
        }

        private void ButtonNumero0_Clicked(object sender, EventArgs e)
        {
            EntryNumeros.Text += "0";

        }

        private void ButtonNumeroCE_Clicked(object sender, EventArgs e)
        {
            Calcular calc = new Calcular();
            this.valor2 = Convert.ToDouble(EntryNumeros.Text);

            switch (this.operacao)
            {
                case "SOMA":
                    EntryNumeros.Text = calc.Somar(this.valor1, this.valor2).ToString();
                    break;
                case "SUBTRACAO":
                    EntryNumeros.Text =calc.Subtrair(this.valor1, this.valor2).ToString();
                    break;
                case "DIVISAO":
                    EntryNumeros.Text = calc.Dividir(this.valor1, this.valor2).ToString();
                    break;
                case "MULTIPLICACAO":
                    EntryNumeros.Text = calc.Multiplicar(this.valor1, this.valor2).ToString();
                    break;
                default:
                    DisplayAlert("Ops...", "HOUVE UM ERRO!\n TENTE NOVAMENTE", "OK");
                        break;

            }
        }

        private void ButtonNumeroResultado_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonNumeroDividir_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonSomar_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonMultiplicar_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonSubtrair_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonCE_Clicked(object sender, EventArgs e)
        {
            EntryNumeros.Text = "";
            this.valor1 = 0;
            this.valor2 = 0;
            this.operacao = "";
        }

        private void ButtonResultado_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonDividir_Clicked(object sender, EventArgs e)
        {

        }
    }
}
