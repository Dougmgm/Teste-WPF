﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Teste
{
    /// <summary>
    /// Lógica interna para CadastrarPedido.xaml
    /// </summary>
    public partial class CadastrarPedido : Window
    {
        public CadastrarPedido()
        {
            InitializeComponent();
        }

        private void SalvarPedido_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelarPedido_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }
    }
}