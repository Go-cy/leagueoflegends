﻿using DevNcore.UI.Foundation.Mvvm;
using Lol.Data.Config;
using Lol.Data.Setting.Clients;
using Lol.Foundation.Riotbase;

namespace Lol.Settings.Client.Local.ViewModels
{
    public class AlarmViewModel : ObservableObject
    {
        #region Model

        public AlarmModel Model { get; set; }
        #endregion

        #region Constructor

        public AlarmViewModel()
        {
            ConfigModel config = RiotConfig.LoadConfig();
            Model = config.Settings.Alarm;
        }
        #endregion
    }
}
