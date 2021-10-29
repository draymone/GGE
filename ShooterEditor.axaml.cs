using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GameEngine
{
    public partial class ShooterEditor : Window
    {
        public ShooterEditor(string projectName)
        {
            InitializeComponent();
            this.Title = projectName;
        }
        
        public ShooterEditor()
        {
            throw new ArgumentException();
        }
    }
}
