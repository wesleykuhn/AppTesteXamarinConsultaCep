using System;
using AppConsultaCep.Library;
using AppConsultaCep.Library.Models;
using Xamarin.Forms;
using System.Linq;
using System.Net;

namespace AppConsultaCep
{
    public partial class MainPage : ContentPage
    {
        private char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        private Endereco lastSeekEndereco;

        public MainPage()
        {
            InitializeComponent();

            btn_Search.Clicked += new EventHandler(Btn_Search_ClickedAsync);

            ent_TypedCep.TextChanged += new EventHandler<TextChangedEventArgs>(Ent_TypedCep_TextChanged);
        }

        private void Ent_TypedCep_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(ent_TypedCep.Text.Length > 0 && !numbers.Contains(ent_TypedCep.Text[ent_TypedCep.Text.Length - 1]))
            {
                this.DisplayAlert("Aviso!", "O caractere digitado é invalido.", "OK");

                if (ent_TypedCep.Text.Length == 1) ent_TypedCep.Text = String.Empty;
                else ent_TypedCep.Text = ent_TypedCep.Text.Substring(0, ent_TypedCep.Text.Length - 1);
            }
        }

        private async void Btn_Search_ClickedAsync(object sender, EventArgs e)
        {
            if(ent_TypedCep.Text.Length != 8)
            {
                await this.DisplayAlert("Atenção!", "O CEP não está correto. Verifique e tente novamente.", "OK");
                
                return;
            }

            try
            {
                this.lastSeekEndereco = await HttpRequest.SeekEnderecoUsingCEPAsync(ent_TypedCep.Text);

                if(this.lastSeekEndereco == default(Endereco))
                {
                    await this.DisplayAlert("Erro!", "O CEP digitado não foi encontrado!", "OK");

                    return;
                }
            }
            catch (WebException)
            {
                await DisplayAlert("Erro!", "Houve um erro ao realizar a conexão com o servidor. Verifique sua conexão com a internet.", "OK");
            }
            catch (Exception)
            {
                await DisplayAlert("Erro!", "Houve um erro fatal ao tentar realizar a busca!", "OK");
            }

            this.lbl_Result.Text = this.lastSeekEndereco.ToString();
        }
    }
}
