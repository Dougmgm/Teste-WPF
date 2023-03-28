using System.Windows;

namespace Teste
{
    /// <summary>
    /// Lógica interna para CadastroPessoa.xaml
    /// </summary>
    public partial class CadastroPessoa : Window
    {
        public CadastroPessoa()
        {
            InitializeComponent();
        }

        private void CancelarPessoa_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }
    }
}
