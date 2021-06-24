﻿using Leagueoflegends.Client.Normal.ViewModels;
using Leagueoflegends.Client.Normal.Views;
using Leagueoflegends.Data.Setting;
using Leagueoflegends.ExampleData.Setting;
using Leagueoflegends.LayoutSupport.Controls;
using Leagueoflegends.Settings.Views;
using Leagueoflegends.Foundation.Mvvm;
using Leagueoflegends.Foundation.Riotbase;
using Leagueoflegends.Foundation.Riotcore;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Leagueoflegends.Client.Alarm.UI;
using Leagueoflegends.Client.Alarm.Local.ViewModel;
using Leagueoflegends.Client.Chat.Local.ViewModel;
using Leagueoflegends.Client.Chat.UI;

namespace Leagueoflegends.Settings.ViewModels
{
	public class SettingViewModel : ObservableObject
	{
		#region Variables

		private Action<IRiotUI> ViewClosed;
		private IRiotUI _currentView;
		private List<SettingMenuModel> _settingMenus;
		private SettingMenuModel _currentSettingMenu;

		private ClientNormalViewModel Normal;
		private ClientAlarmViewModel Alarm;
		private ClientChatViewModel Chat;
		private Dictionary<int, IRiotUI> UIs { get; set; }
		#endregion 

		#region Command

		public ICommand CompleteCommand { get; set; }
		#endregion

		#region Menus

		public List<SettingMenuModel> SettingMenus
		{
			get => _settingMenus;
			set { _settingMenus = value; OnPropertyChanged(); }
		}

		public SettingMenuModel CurrentSettingMenu
		{
			get => _currentSettingMenu;
			set { _currentSettingMenu = value; OnPropertyChanged(); SettingMenuChanged(value); }
		}
		#endregion

		#region CurrentView

		public IRiotUI CurrentView
		{
			get => _currentView;
			set { _currentView = value; OnPropertyChanged(); }
		}
		#endregion

		#region Constructor

		public SettingViewModel(Action<IRiotUI> modalClose)
		{
			ViewClosed = modalClose;
			UIs = new();
			Normal = new ClientNormalViewModel();
			Alarm = new ClientAlarmViewModel();
			Chat = new ClientChatViewModel();

			SettingMenus = ExamSettings.GetSettingList();
			CompleteCommand = new RelayCommand<Modal>(CompleteClick);
		}
		#endregion

		#region SettingMenuChanged

		private void SettingMenuChanged(SettingMenuModel value)
		{
			IRiotUI content;
			int key;

			if (value != null)
			{
				key = value.Seq;
				content = value.Seq switch
				{
					1 => new ClientNormalView().SetVM(Normal),
					2 => new ClientAlarmView().SetVM(Alarm),
					3 => new ClientChatView().SetVM(Chat),
					_ => new EmptyView()
				};

				if (!UIs.ContainsKey(key))
				{
					UIs.Add(key, content);
				}

				CurrentView = UIs[key];
			}
		}
		#endregion

		#region CompleteClick

		private void CompleteClick(Modal obj)
		{
			ViewClosed.Invoke(View);

			var setting = RiotConfig.Config.Settings;
			setting.ClientNormal = Normal.Model;
			setting.ClientAlarm = Alarm.Model;
			setting.ClientChat = Chat.Model;

			RiotConfig.SaveSettings(setting);
		}
		#endregion
	}
}
