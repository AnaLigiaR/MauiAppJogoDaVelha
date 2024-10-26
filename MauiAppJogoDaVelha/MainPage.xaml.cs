namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        int contadorMovimentos = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";

            }
            else
            {
                btn.Text = "O";
                vez = "X";

            }

            contadorMovimentos++;

            /* Verificando se o X ganhou em linhas */

            
                if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
                {
                    DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                    Zerar();
                }

                else if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
                {
                    DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                    Zerar();
                }

                else if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
                {
                    DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                    Zerar();
                }

                /* Verificando se o O ganhou em linhas */

                else if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
                {
                    DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                    Zerar();
                }

                else if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
                {
                    DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                    Zerar();
                }

                else if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
                {
                    DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                    Zerar();
                }

                /* Verificando se o X ganhou em colunas */

                else if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
                {
                    DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                    Zerar();
                }

                else if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
                {
                    DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                    Zerar();
                }

                else if (btn21.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
                {
                    DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                    Zerar();
                }

                /* Verificando se o O ganhou em colunas */

                else if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
                {
                    DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                    Zerar();
                }

                else if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
                {
                    DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                    Zerar();
                }

                else if (btn21.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
                {
                    DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                    Zerar();
                }

                /* Verificando se o X ganhou em diagonais */

                else if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
                {
                    DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                    Zerar();
                }

                else if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
                {
                    DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                    Zerar();
                }

                /* Verificando se o O ganhou em diagonais */

                else if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
                {
                    DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                    Zerar();
                }

                else if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
                {
                    DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                    Zerar();
                }

                /* Verificando se deu velha*/

                else if (contadorMovimentos == 9)
            {
                DisplayAlert("Empate", "Ninguém ganhou...", "OK");
                Zerar();
            }

       

            void Zerar()
            {
                btn10.Text = ""; btn10.IsEnabled = true;
                btn11.Text = ""; btn10.IsEnabled = true;
                btn12.Text = ""; btn10.IsEnabled = true;

                btn20.Text = ""; btn10.IsEnabled = true;
                btn21.Text = ""; btn10.IsEnabled = true;
                btn22.Text = ""; btn10.IsEnabled = true;

                btn30.Text = ""; btn10.IsEnabled = true;
                btn31.Text = ""; btn10.IsEnabled = true;
                btn32.Text = ""; btn10.IsEnabled = true;
            }
        }

    }
}
