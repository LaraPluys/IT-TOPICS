using System;
using System.Collections.Generic;
using System.Configuration;
using ITtopicsProject.Models;
using ITtopicsProject.ViewModels;
using ITtopicsProject.Views;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ITtopicsProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindowViewModel mainviewModel = new MainWindowViewModel();
            MainWindow mainwindow = new MainWindow();
            mainwindow.DataContext = mainviewModel;
            mainwindow.Show();
        }
    }
}
