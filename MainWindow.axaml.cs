using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.Diagnostics;

namespace GameEngine
{
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
        }

        public void OnClick(object sender, RoutedEventArgs e) {
            if (GameTypeBox.SelectedIndex == 0) {
                var shooterEditor = new ShooterEditor(ProjectNameSlot.Text);
                shooterEditor.Show();
                this.Close();
            }
            if (GameTypeBox.SelectedIndex == 1) {
                var shooterEditor = new ShooterEditor(ProjectNameSlot.Text);
                shooterEditor.Show();
                this.Close();
            }
        }
    }
}
