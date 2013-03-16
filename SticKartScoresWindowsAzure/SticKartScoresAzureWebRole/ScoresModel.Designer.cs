﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("SticKartScores_0Model", "FK_ActivePlayers_Statistics", "Statistic", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(SticKartScoresAzureWebRole.Statistic), "ActivePlayer", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(SticKartScoresAzureWebRole.ActivePlayer), true)]

#endregion

namespace SticKartScoresAzureWebRole
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class SticKartScores_0Entities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new SticKartScores_0Entities object using the connection string found in the 'SticKartScores_0Entities' section of the application configuration file.
        /// </summary>
        public SticKartScores_0Entities() : base("name=SticKartScores_0Entities", "SticKartScores_0Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new SticKartScores_0Entities object.
        /// </summary>
        public SticKartScores_0Entities(string connectionString) : base(connectionString, "SticKartScores_0Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new SticKartScores_0Entities object.
        /// </summary>
        public SticKartScores_0Entities(EntityConnection connection) : base(connection, "SticKartScores_0Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<HighScore> HighScores
        {
            get
            {
                if ((_HighScores == null))
                {
                    _HighScores = base.CreateObjectSet<HighScore>("HighScores");
                }
                return _HighScores;
            }
        }
        private ObjectSet<HighScore> _HighScores;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ActivePlayer> ActivePlayers
        {
            get
            {
                if ((_ActivePlayers == null))
                {
                    _ActivePlayers = base.CreateObjectSet<ActivePlayer>("ActivePlayers");
                }
                return _ActivePlayers;
            }
        }
        private ObjectSet<ActivePlayer> _ActivePlayers;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Statistic> Statistics
        {
            get
            {
                if ((_Statistics == null))
                {
                    _Statistics = base.CreateObjectSet<Statistic>("Statistics");
                }
                return _Statistics;
            }
        }
        private ObjectSet<Statistic> _Statistics;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the HighScores EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToHighScores(HighScore highScore)
        {
            base.AddObject("HighScores", highScore);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ActivePlayers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToActivePlayers(ActivePlayer activePlayer)
        {
            base.AddObject("ActivePlayers", activePlayer);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Statistics EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToStatistics(Statistic statistic)
        {
            base.AddObject("Statistics", statistic);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SticKartScores_0Model", Name="ActivePlayer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ActivePlayer : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ActivePlayer object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="ip">Initial value of the Ip property.</param>
        /// <param name="port">Initial value of the Port property.</param>
        /// <param name="state">Initial value of the State property.</param>
        /// <param name="player">Initial value of the Player property.</param>
        public static ActivePlayer CreateActivePlayer(global::System.Int32 id, global::System.String ip, global::System.String port, global::System.String state, global::System.Int32 player)
        {
            ActivePlayer activePlayer = new ActivePlayer();
            activePlayer.Id = id;
            activePlayer.Ip = ip;
            activePlayer.Port = port;
            activePlayer.State = state;
            activePlayer.Player = player;
            return activePlayer;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Ip
        {
            get
            {
                return _Ip;
            }
            set
            {
                OnIpChanging(value);
                ReportPropertyChanging("Ip");
                _Ip = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Ip");
                OnIpChanged();
            }
        }
        private global::System.String _Ip;
        partial void OnIpChanging(global::System.String value);
        partial void OnIpChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Port
        {
            get
            {
                return _Port;
            }
            set
            {
                OnPortChanging(value);
                ReportPropertyChanging("Port");
                _Port = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Port");
                OnPortChanged();
            }
        }
        private global::System.String _Port;
        partial void OnPortChanging(global::System.String value);
        partial void OnPortChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String State
        {
            get
            {
                return _State;
            }
            set
            {
                OnStateChanging(value);
                ReportPropertyChanging("State");
                _State = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("State");
                OnStateChanged();
            }
        }
        private global::System.String _State;
        partial void OnStateChanging(global::System.String value);
        partial void OnStateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Player
        {
            get
            {
                return _Player;
            }
            set
            {
                OnPlayerChanging(value);
                ReportPropertyChanging("Player");
                _Player = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Player");
                OnPlayerChanged();
            }
        }
        private global::System.Int32 _Player;
        partial void OnPlayerChanging(global::System.Int32 value);
        partial void OnPlayerChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SticKartScores_0Model", "FK_ActivePlayers_Statistics", "Statistic")]
        public Statistic Statistic
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Statistic>("SticKartScores_0Model.FK_ActivePlayers_Statistics", "Statistic").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Statistic>("SticKartScores_0Model.FK_ActivePlayers_Statistics", "Statistic").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Statistic> StatisticReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Statistic>("SticKartScores_0Model.FK_ActivePlayers_Statistics", "Statistic");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Statistic>("SticKartScores_0Model.FK_ActivePlayers_Statistics", "Statistic", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SticKartScores_0Model", Name="HighScore")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class HighScore : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new HighScore object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="level">Initial value of the Level property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="score">Initial value of the Score property.</param>
        public static HighScore CreateHighScore(global::System.Int32 id, global::System.Int32 level, global::System.String name, global::System.Int32 score)
        {
            HighScore highScore = new HighScore();
            highScore.Id = id;
            highScore.Level = level;
            highScore.Name = name;
            highScore.Score = score;
            return highScore;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Level
        {
            get
            {
                return _Level;
            }
            set
            {
                OnLevelChanging(value);
                ReportPropertyChanging("Level");
                _Level = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Level");
                OnLevelChanged();
            }
        }
        private global::System.Int32 _Level;
        partial void OnLevelChanging(global::System.Int32 value);
        partial void OnLevelChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Score
        {
            get
            {
                return _Score;
            }
            set
            {
                OnScoreChanging(value);
                ReportPropertyChanging("Score");
                _Score = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Score");
                OnScoreChanged();
            }
        }
        private global::System.Int32 _Score;
        partial void OnScoreChanging(global::System.Int32 value);
        partial void OnScoreChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SticKartScores_0Model", Name="Statistic")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Statistic : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Statistic object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="password">Initial value of the Password property.</param>
        /// <param name="gamesPlayed">Initial value of the GamesPlayed property.</param>
        /// <param name="gamesWon">Initial value of the GamesWon property.</param>
        /// <param name="gamesLost">Initial value of the GamesLost property.</param>
        public static Statistic CreateStatistic(global::System.Int32 id, global::System.String name, global::System.String password, global::System.Int32 gamesPlayed, global::System.Int32 gamesWon, global::System.Int32 gamesLost)
        {
            Statistic statistic = new Statistic();
            statistic.Id = id;
            statistic.Name = name;
            statistic.Password = password;
            statistic.GamesPlayed = gamesPlayed;
            statistic.GamesWon = gamesWon;
            statistic.GamesLost = gamesLost;
            return statistic;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Password
        {
            get
            {
                return _Password;
            }
            set
            {
                OnPasswordChanging(value);
                ReportPropertyChanging("Password");
                _Password = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Password");
                OnPasswordChanged();
            }
        }
        private global::System.String _Password;
        partial void OnPasswordChanging(global::System.String value);
        partial void OnPasswordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 GamesPlayed
        {
            get
            {
                return _GamesPlayed;
            }
            set
            {
                OnGamesPlayedChanging(value);
                ReportPropertyChanging("GamesPlayed");
                _GamesPlayed = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("GamesPlayed");
                OnGamesPlayedChanged();
            }
        }
        private global::System.Int32 _GamesPlayed;
        partial void OnGamesPlayedChanging(global::System.Int32 value);
        partial void OnGamesPlayedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 GamesWon
        {
            get
            {
                return _GamesWon;
            }
            set
            {
                OnGamesWonChanging(value);
                ReportPropertyChanging("GamesWon");
                _GamesWon = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("GamesWon");
                OnGamesWonChanged();
            }
        }
        private global::System.Int32 _GamesWon;
        partial void OnGamesWonChanging(global::System.Int32 value);
        partial void OnGamesWonChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 GamesLost
        {
            get
            {
                return _GamesLost;
            }
            set
            {
                OnGamesLostChanging(value);
                ReportPropertyChanging("GamesLost");
                _GamesLost = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("GamesLost");
                OnGamesLostChanged();
            }
        }
        private global::System.Int32 _GamesLost;
        partial void OnGamesLostChanging(global::System.Int32 value);
        partial void OnGamesLostChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SticKartScores_0Model", "FK_ActivePlayers_Statistics", "ActivePlayer")]
        public EntityCollection<ActivePlayer> ActivePlayers
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<ActivePlayer>("SticKartScores_0Model.FK_ActivePlayers_Statistics", "ActivePlayer");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<ActivePlayer>("SticKartScores_0Model.FK_ActivePlayers_Statistics", "ActivePlayer", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
