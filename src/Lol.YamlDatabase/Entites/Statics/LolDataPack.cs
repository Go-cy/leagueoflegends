﻿using Lol.YamlDatabase.Entites.Schema;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Lol.YamlDatabase.Entites.Statics
{
    public class LolDataPack
    {
        internal static LolDataPack Instance;

        static LolDataPack()
        {
            Instance = new LolDataPack();
        }

        private LolDataPack()
        { 
        
        }

        private List<Users>? _users;
        private List<Friends>? _friends;
        internal List<CodeItems>? _codeItems;
        internal List<Spells>? _spells;
        internal List<PlayTypes>? _playTypes;
        internal List<Items>? _items;
        internal List<MapTypes>? _mapTypes;
        internal List<TeamFights>? _teamFights;
        internal List<GameRooms>? _gameRooms;
        internal List<ClashCups>? _clashCups;
        internal List<Histories> _historys;
        internal List<Histories> _activities;
        internal List<Histories> _playChampions;
        internal List<ClashTabs> _clashTabs;
        internal List<ClashTiers> _clashTiers;
        internal List<ClashTierDetails> _clashTierDetails;
        internal List<ClashSchedules> _clashSchedules;
        internal List<StoreChampTypes> _storeChampTypes;
        internal List<StoreChampSortings> _storeChampSortings;
        internal List<SettingMenus> _settingMenus;
        internal List<Champs> _champs;
        internal List<Resolutions> _resolutions;

        private static string GetYamlData(string table)
        {
            string file = $"/datas/{table}.yml";
            string path = Environment.CurrentDirectory + file;
            string text = File.ReadAllText(path);

            return text;
        }

        #region Users

        internal List<Users> Users
        {
            get
            {
                if (_users == null)
                {
                    string readText = GetYamlData("users");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _users = deserializer.Deserialize<List<Users>>(readText);
                }
                return _users;
            }
        }
        #endregion

        #region Friends

        internal List<Friends> Friends
        {
            get
            {
                if (_friends == null)
                {
                    string readText = GetYamlData("friends");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _friends = deserializer.Deserialize<List<Friends>>(readText);
                }
                return _friends;
            }
        }
        #endregion

        #region CodeItems

        internal List<CodeItems> CodeItems
        {
            get
            {
                if (_codeItems == null)
                {
                    string readText = GetYamlData("codeitems");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _codeItems = deserializer.Deserialize<List<CodeItems>>(readText);
                }
                return _codeItems;
            }
        }
        #endregion

        #region Spells

        internal List<Spells> Spells
        {
            get
            {
                if (_spells == null)
                {
                    string readText = GetYamlData("spells");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _spells = deserializer.Deserialize<List<Spells>>(readText);
                }
                return _spells;
            }
        }
        #endregion

        #region Items

        internal List<Items> Items
        {
            get
            {
                if (_items == null)
                {
                    string readText = GetYamlData("items");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _items = deserializer.Deserialize<List<Items>>(readText);
                }
                return _items;
            }
        }
        #endregion

        #region MapTypes

        internal List<MapTypes> MapTypes
        {
            get
            {
                if (_mapTypes == null)
                {
                    string readText = GetYamlData("mapTypes");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _mapTypes = deserializer.Deserialize<List<MapTypes>>(readText);
                }
                return _mapTypes;
            }
        }
        #endregion

        #region PlayTypes

        internal List<PlayTypes> PlayTypes
        {
            get
            {
                if (_playTypes == null)
                {
                    string readText = GetYamlData("playTypes");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _playTypes = deserializer.Deserialize<List<PlayTypes>>(readText);
                }
                return _playTypes;
            }
        }
        #endregion

        #region TeamFights

        internal List<TeamFights> TeamFights
        {
            get
            {
                if (_teamFights == null)
                {
                    string readText = GetYamlData("teamFights");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _teamFights = deserializer.Deserialize<List<TeamFights>>(readText);
                }
                return _teamFights;
            }
        }
        #endregion

        #region GameRooms

        internal List<GameRooms> GameRooms
        {
            get
            {
                if (_gameRooms == null)
                {
                    string readText = GetYamlData("gameRooms");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _gameRooms = deserializer.Deserialize<List<GameRooms>>(readText);
                }
                return _gameRooms;
            }
        }
        #endregion

        #region ClashCups

        internal List<ClashCups> ClashCups
        {
            get
            {
                if (_clashCups == null)
                {
                    string readText = GetYamlData("clashCups");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _clashCups = deserializer.Deserialize<List<ClashCups>>(readText);
                }
                return _clashCups;
            }
        }
        #endregion

        #region ClashTabs

        internal List<ClashTabs> ClashTabs
        {
            get
            {
                if (_clashTabs == null)
                {
                    string readText = GetYamlData("clashTabs");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _clashTabs = deserializer.Deserialize<List<ClashTabs>>(readText);
                }
                return _clashTabs;
            }
        }
        #endregion

        #region ClashTiers

        internal List<ClashTiers> ClashTiers
        {
            get
            {
                if (_clashTiers == null)
                {
                    string readText = GetYamlData("clashTiers");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _clashTiers = deserializer.Deserialize<List<ClashTiers>>(readText);
                }
                return _clashTiers;
            }
        }
        #endregion

        #region ClashTabs

        internal List<ClashTierDetails> ClashTierDetails
        {
            get
            {
                if (_clashTierDetails == null)
                {
                    string readText = GetYamlData("clashTierDetails");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _clashTierDetails = deserializer.Deserialize<List<ClashTierDetails>>(readText);
                }
                return _clashTierDetails;
            }
        }
        #endregion

        #region Historys

        internal List<Histories> Historys
        {
            get
            {
                if (_historys == null)
                {
                    string readText = GetYamlData("histories");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _historys = deserializer.Deserialize<List<Histories>>(readText);
                }

                return _historys;
            }
        }
        #endregion

        #region Activities

        internal List<Histories> Activities
        {
            get
            {
                if (_activities == null)
                {
                    string readText = GetYamlData("activities");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _activities = deserializer.Deserialize<List<Histories>>(readText);
                }

                return _activities;
            }
        }
        #endregion

        #region PlayChampions

        internal List<Histories> PlayChampions
        {
            get
            {
                if (_playChampions == null)
                {
                    string readText = GetYamlData("playChampions");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _playChampions = deserializer.Deserialize<List<Histories>>(readText);
                }

                return _playChampions;
            }
        }
        #endregion

        #region StoreChampTypes

        internal List<StoreChampTypes> StoreChampTypes
        {
            get
            {
                if (_storeChampTypes == null)
                {
                    string readText = GetYamlData("storeChampTypes");
                    var deserializer = new DeserializerBuilder()
                      .WithNamingConvention(CamelCaseNamingConvention.Instance)
                      .Build();
                    _storeChampTypes = deserializer.Deserialize<List<StoreChampTypes>>(readText);
                }

                return _storeChampTypes;
            }
        }
        #endregion

        #region StoreChampTypes

        internal List<StoreChampSortings> StoreChampSortings
        {
            get
            {
                if (_storeChampSortings == null)
                {
                    string readText = GetYamlData("storeChampSortings");
                    var deserializer = new DeserializerBuilder()
                      .WithNamingConvention(CamelCaseNamingConvention.Instance)
                      .Build();
                    _storeChampSortings = deserializer.Deserialize<List<StoreChampSortings>>(readText);
                }

                return _storeChampSortings;
            }
        }
        #endregion

        #region SettingMenus

        internal List<SettingMenus> SettingMenus
        {
            get
            {
                if (_settingMenus == null)
                {
                    string readText = GetYamlData("settingMenus");
                    var deserializer = new DeserializerBuilder()
                      .WithNamingConvention(CamelCaseNamingConvention.Instance)
                      .Build();
                    _settingMenus = deserializer.Deserialize<List<SettingMenus>>(readText);
                }

                return _settingMenus;
            }
        }
        #endregion

        #region SettingMenus

        internal List<Resolutions> Resolutions
        {
            get
            {
                if (_resolutions == null)
                {
                    string readText = GetYamlData("resolutions");
                    var deserializer = new DeserializerBuilder()
                      .WithNamingConvention(CamelCaseNamingConvention.Instance)
                      .Build();
                    _resolutions = deserializer.Deserialize<List<Resolutions>>(readText);
                }

                return _resolutions;
            }
        }
        #endregion

        #region Champs

        internal List<Champs> Champs
        {
            get
            {
                if (_champs == null)
                {
                    string readText = GetYamlData("champs");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _champs = deserializer.Deserialize<List<Champs>>(readText);
                }

                return _champs;
            }
        }
        #endregion

        #region ClashSchedules

        internal List<ClashSchedules> ClashSchedules
        {
            get
            {
                if (_clashSchedules == null)
                {
                    string readText = GetYamlData("clashSchedules");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _clashSchedules = deserializer.Deserialize<List<ClashSchedules>>(readText);
                }

                return _clashSchedules;
            }
        }
        #endregion
    }
}
