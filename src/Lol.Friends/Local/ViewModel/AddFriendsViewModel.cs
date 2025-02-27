﻿using System;
using System.Windows.Input;
using Lol.Friends.Local.Collection;
using DevNcore.LayoutSupport.Leagueoflegends.Controls;
using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using DevNcore.UI.Foundation.Mvvm;
using DevNcore.LayoutSupport.Leagueoflegends.Controls.Primitives;

namespace Lol.Friends.Local.ViewModel
{
    public class AddFriendsViewModel : ObservableObject
    {
        #region Variables

        private readonly Action<IRiotUI> ViewClosed;
        private string _keyword;
        #endregion

        #region ICommands

        public ICommand CompleteCommand { get; set; }
        public ICommand KeywordCommand { get; private set; }
        public ICommand CloseKeywordCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }
        public ICommand RequestCommand { get; private set; }
        #endregion

        #region Keyword

        public string Keyword
        {
            get { return _keyword; }
            set { _keyword = value; OnPropertyChanged(); }
        }
        #endregion

        #region UserCollection

        public FriendsCollection UserCollection { get; }
        #endregion

        #region Constructor

        public AddFriendsViewModel(Action<IRiotUI> _viewClosed)
        {
            UserCollection = new();

            ViewClosed = _viewClosed;

            Keyword = "";
            KeywordCommand = new RelayCommand<object>(KeywordChanged);
            CloseKeywordCommand = new RelayCommand<object>(CloseKeyword);
            CompleteCommand = new RelayCommand<object>((o) => ViewClosed.Invoke(View as IRiotUI));
            DeleteCommand = new RelayCommand<RequestUsers>(UserCollection.CancelRequest);
            RequestCommand = new RelayCommand<RequestUsers>(UserCollection.SendRequest);

            var data = new FriendsApi().GetFriendRequests(0);
            UserCollection.AddRange(data);
        }
        #endregion

        #region KeywordChanged

        private void KeywordChanged(object obj)
        {
            Keyword = (obj as RiotTextBox).Text;
        }
        #endregion

        #region CloseKeyword

        private void CloseKeyword(object obj)
        {
            Keyword = "";
        }
        #endregion
    }
}
