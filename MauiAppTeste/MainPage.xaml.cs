

namespace MauiAppTeste
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void CounterBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            double A = double.Parse(txt_coefA.Text);
            if (A == 0)
            {
                string msg = $"O valor do Coeficiente A tem que ser diferente de 0!";

                DisplayAlert("Está errado!", msg, "fechar");
                return;
            }
            double B = double.Parse(txt_coefB.Text);
            double C = double.Parse(txt_coefC.Text);

            double delta = (B * B) - 4 * A * C;
            double raiz = Math.Sqrt(delta);

            double resx1 = (-B + raiz) / (2*A);
            double resx2 = (-B - raiz) / (2 * A);

            string mensg =  $" O resultado do X' é " + resx1 + "\n O resultado do X2 é: " + resx2;
            DisplayAlert("Resultado", mensg, "fechar");

            if (delta < 0)
            {
                string msg3 = $" O delta é igual {delta}, Não há raiz.";
                DisplayAlert("Não há raiz", msg3, "Fechar");
            }
            else
            {
                DisplayAlert("Resposta:",mensg, "Fechar");
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            txt_coefC.Text = string.Empty;
            txt_coefA.Text = string.Empty;
            txt_coefB.Text = string.Empty;
        }
    }

}
