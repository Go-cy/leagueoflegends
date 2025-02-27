﻿using System;
using System.Windows;
using Lol.Main.UI.Views;
using Lol.Main.Local.ViewModel;
using DevNcore.LayoutSupport.Leagueoflegends.Controls.Primitives;

namespace Leagueoflegends
{
    public class App : RiotApp
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            bool dialogResult = true;

            while (dialogResult)
            {
                ShutdownMode = ShutdownMode.OnExplicitShutdown;
                MainView main = new();
                main.DataContext = new MainViewModel();

                dialogResult = (bool)main.ShowDialog();
            }
            Environment.Exit(0);
        }
    }
}
