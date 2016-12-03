﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OSTracker.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Runescape")]
	public partial class RunescapeDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPlayer(Player instance);
    partial void UpdatePlayer(Player instance);
    partial void DeletePlayer(Player instance);
    partial void InsertPlayerQuest(PlayerQuest instance);
    partial void UpdatePlayerQuest(PlayerQuest instance);
    partial void DeletePlayerQuest(PlayerQuest instance);
    partial void InsertPlayerSkill(PlayerSkill instance);
    partial void UpdatePlayerSkill(PlayerSkill instance);
    partial void DeletePlayerSkill(PlayerSkill instance);
    partial void InsertSkill(Skill instance);
    partial void UpdateSkill(Skill instance);
    partial void DeleteSkill(Skill instance);
    partial void InsertQuest(Quest instance);
    partial void UpdateQuest(Quest instance);
    partial void DeleteQuest(Quest instance);
    #endregion
		
		public RunescapeDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["RunescapeConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public RunescapeDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RunescapeDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RunescapeDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RunescapeDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Player> Players
		{
			get
			{
				return this.GetTable<Player>();
			}
		}
		
		public System.Data.Linq.Table<PlayerQuest> PlayerQuests
		{
			get
			{
				return this.GetTable<PlayerQuest>();
			}
		}
		
		public System.Data.Linq.Table<PlayerSkill> PlayerSkills
		{
			get
			{
				return this.GetTable<PlayerSkill>();
			}
		}
		
		public System.Data.Linq.Table<Skill> Skills
		{
			get
			{
				return this.GetTable<Skill>();
			}
		}
		
		public System.Data.Linq.Table<Quest> Quests
		{
			get
			{
				return this.GetTable<Quest>();
			}
		}
		
		public System.Data.Linq.Table<Level> Levels
		{
			get
			{
				return this.GetTable<Level>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Players")]
	public partial class Player : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PlayerID;
		
		private string _RS_Username;
		
		private System.Nullable<int> _QuestsID;
		
		private System.Nullable<int> _SkillsID;
		
		private string _Email;
		
		private bool _Admin;
		
		private EntityRef<PlayerQuest> _PlayerQuest;
		
		private EntityRef<PlayerSkill> _PlayerSkill;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPlayerIDChanging(int value);
    partial void OnPlayerIDChanged();
    partial void OnRS_UsernameChanging(string value);
    partial void OnRS_UsernameChanged();
    partial void OnQuestsIDChanging(System.Nullable<int> value);
    partial void OnQuestsIDChanged();
    partial void OnSkillsIDChanging(System.Nullable<int> value);
    partial void OnSkillsIDChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnAdminChanging(bool value);
    partial void OnAdminChanged();
    #endregion
		
		public Player()
		{
			this._PlayerQuest = default(EntityRef<PlayerQuest>);
			this._PlayerSkill = default(EntityRef<PlayerSkill>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PlayerID
		{
			get
			{
				return this._PlayerID;
			}
			set
			{
				if ((this._PlayerID != value))
				{
					if ((this._PlayerQuest.HasLoadedOrAssignedValue || this._PlayerSkill.HasLoadedOrAssignedValue))
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPlayerIDChanging(value);
					this.SendPropertyChanging();
					this._PlayerID = value;
					this.SendPropertyChanged("PlayerID");
					this.OnPlayerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RS_Username", DbType="NVarChar(12) NOT NULL", CanBeNull=false)]
		public string RS_Username
		{
			get
			{
				return this._RS_Username;
			}
			set
			{
				if ((this._RS_Username != value))
				{
					this.OnRS_UsernameChanging(value);
					this.SendPropertyChanging();
					this._RS_Username = value;
					this.SendPropertyChanged("RS_Username");
					this.OnRS_UsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestsID", DbType="Int")]
		public System.Nullable<int> QuestsID
		{
			get
			{
				return this._QuestsID;
			}
			set
			{
				if ((this._QuestsID != value))
				{
					this.OnQuestsIDChanging(value);
					this.SendPropertyChanging();
					this._QuestsID = value;
					this.SendPropertyChanged("QuestsID");
					this.OnQuestsIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SkillsID", DbType="Int")]
		public System.Nullable<int> SkillsID
		{
			get
			{
				return this._SkillsID;
			}
			set
			{
				if ((this._SkillsID != value))
				{
					this.OnSkillsIDChanging(value);
					this.SendPropertyChanging();
					this._SkillsID = value;
					this.SendPropertyChanged("SkillsID");
					this.OnSkillsIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(MAX)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Admin", DbType="Bit NOT NULL")]
		public bool Admin
		{
			get
			{
				return this._Admin;
			}
			set
			{
				if ((this._Admin != value))
				{
					this.OnAdminChanging(value);
					this.SendPropertyChanging();
					this._Admin = value;
					this.SendPropertyChanged("Admin");
					this.OnAdminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PlayerQuest_Player", Storage="_PlayerQuest", ThisKey="PlayerID", OtherKey="PlayerID", IsForeignKey=true)]
		public PlayerQuest PlayerQuest
		{
			get
			{
				return this._PlayerQuest.Entity;
			}
			set
			{
				PlayerQuest previousValue = this._PlayerQuest.Entity;
				if (((previousValue != value) 
							|| (this._PlayerQuest.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PlayerQuest.Entity = null;
						previousValue.Players.Remove(this);
					}
					this._PlayerQuest.Entity = value;
					if ((value != null))
					{
						value.Players.Add(this);
						this._PlayerID = value.PlayerID;
					}
					else
					{
						this._PlayerID = default(int);
					}
					this.SendPropertyChanged("PlayerQuest");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PlayerSkill_Player", Storage="_PlayerSkill", ThisKey="PlayerID", OtherKey="PlayerID", IsForeignKey=true)]
		public PlayerSkill PlayerSkill
		{
			get
			{
				return this._PlayerSkill.Entity;
			}
			set
			{
				PlayerSkill previousValue = this._PlayerSkill.Entity;
				if (((previousValue != value) 
							|| (this._PlayerSkill.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PlayerSkill.Entity = null;
						previousValue.Players.Remove(this);
					}
					this._PlayerSkill.Entity = value;
					if ((value != null))
					{
						value.Players.Add(this);
						this._PlayerID = value.PlayerID;
					}
					else
					{
						this._PlayerID = default(int);
					}
					this.SendPropertyChanged("PlayerSkill");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PlayerQuest")]
	public partial class PlayerQuest : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PlayerQuestID;
		
		private int _PlayerID;
		
		private int _QuestID;
		
		private bool _Status;
		
		private EntitySet<Player> _Players;
		
		private EntitySet<Quest> _Quests;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPlayerQuestIDChanging(int value);
    partial void OnPlayerQuestIDChanged();
    partial void OnPlayerIDChanging(int value);
    partial void OnPlayerIDChanged();
    partial void OnQuestIDChanging(int value);
    partial void OnQuestIDChanged();
    partial void OnStatusChanging(bool value);
    partial void OnStatusChanged();
    #endregion
		
		public PlayerQuest()
		{
			this._Players = new EntitySet<Player>(new Action<Player>(this.attach_Players), new Action<Player>(this.detach_Players));
			this._Quests = new EntitySet<Quest>(new Action<Quest>(this.attach_Quests), new Action<Quest>(this.detach_Quests));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerQuestID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PlayerQuestID
		{
			get
			{
				return this._PlayerQuestID;
			}
			set
			{
				if ((this._PlayerQuestID != value))
				{
					this.OnPlayerQuestIDChanging(value);
					this.SendPropertyChanging();
					this._PlayerQuestID = value;
					this.SendPropertyChanged("PlayerQuestID");
					this.OnPlayerQuestIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerID", DbType="Int NOT NULL")]
		public int PlayerID
		{
			get
			{
				return this._PlayerID;
			}
			set
			{
				if ((this._PlayerID != value))
				{
					this.OnPlayerIDChanging(value);
					this.SendPropertyChanging();
					this._PlayerID = value;
					this.SendPropertyChanged("PlayerID");
					this.OnPlayerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestID", DbType="Int NOT NULL")]
		public int QuestID
		{
			get
			{
				return this._QuestID;
			}
			set
			{
				if ((this._QuestID != value))
				{
					this.OnQuestIDChanging(value);
					this.SendPropertyChanging();
					this._QuestID = value;
					this.SendPropertyChanged("QuestID");
					this.OnQuestIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Bit NOT NULL")]
		public bool Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PlayerQuest_Player", Storage="_Players", ThisKey="PlayerID", OtherKey="PlayerID")]
		public EntitySet<Player> Players
		{
			get
			{
				return this._Players;
			}
			set
			{
				this._Players.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PlayerQuest_Quest", Storage="_Quests", ThisKey="QuestID", OtherKey="QuestID")]
		public EntitySet<Quest> Quests
		{
			get
			{
				return this._Quests;
			}
			set
			{
				this._Quests.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Players(Player entity)
		{
			this.SendPropertyChanging();
			entity.PlayerQuest = this;
		}
		
		private void detach_Players(Player entity)
		{
			this.SendPropertyChanging();
			entity.PlayerQuest = null;
		}
		
		private void attach_Quests(Quest entity)
		{
			this.SendPropertyChanging();
			entity.PlayerQuest = this;
		}
		
		private void detach_Quests(Quest entity)
		{
			this.SendPropertyChanging();
			entity.PlayerQuest = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PlayerSkills")]
	public partial class PlayerSkill : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PlayerSkillID;
		
		private int _PlayerID;
		
		private int _SkillID;
		
		private System.Nullable<int> _Level;
		
		private System.Nullable<int> _Rank;
		
		private System.Nullable<int> _Exp;
		
		private EntitySet<Player> _Players;
		
		private EntitySet<Skill> _Skills;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPlayerSkillIDChanging(int value);
    partial void OnPlayerSkillIDChanged();
    partial void OnPlayerIDChanging(int value);
    partial void OnPlayerIDChanged();
    partial void OnSkillIDChanging(int value);
    partial void OnSkillIDChanged();
    partial void OnLevelChanging(System.Nullable<int> value);
    partial void OnLevelChanged();
    partial void OnRankChanging(System.Nullable<int> value);
    partial void OnRankChanged();
    partial void OnExpChanging(System.Nullable<int> value);
    partial void OnExpChanged();
    #endregion
		
		public PlayerSkill()
		{
			this._Players = new EntitySet<Player>(new Action<Player>(this.attach_Players), new Action<Player>(this.detach_Players));
			this._Skills = new EntitySet<Skill>(new Action<Skill>(this.attach_Skills), new Action<Skill>(this.detach_Skills));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerSkillID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PlayerSkillID
		{
			get
			{
				return this._PlayerSkillID;
			}
			set
			{
				if ((this._PlayerSkillID != value))
				{
					this.OnPlayerSkillIDChanging(value);
					this.SendPropertyChanging();
					this._PlayerSkillID = value;
					this.SendPropertyChanged("PlayerSkillID");
					this.OnPlayerSkillIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerID", DbType="Int NOT NULL")]
		public int PlayerID
		{
			get
			{
				return this._PlayerID;
			}
			set
			{
				if ((this._PlayerID != value))
				{
					this.OnPlayerIDChanging(value);
					this.SendPropertyChanging();
					this._PlayerID = value;
					this.SendPropertyChanged("PlayerID");
					this.OnPlayerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SkillID", DbType="Int NOT NULL")]
		public int SkillID
		{
			get
			{
				return this._SkillID;
			}
			set
			{
				if ((this._SkillID != value))
				{
					this.OnSkillIDChanging(value);
					this.SendPropertyChanging();
					this._SkillID = value;
					this.SendPropertyChanged("SkillID");
					this.OnSkillIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Level]", Storage="_Level", DbType="Int")]
		public System.Nullable<int> Level
		{
			get
			{
				return this._Level;
			}
			set
			{
				if ((this._Level != value))
				{
					this.OnLevelChanging(value);
					this.SendPropertyChanging();
					this._Level = value;
					this.SendPropertyChanged("Level");
					this.OnLevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rank", DbType="Int")]
		public System.Nullable<int> Rank
		{
			get
			{
				return this._Rank;
			}
			set
			{
				if ((this._Rank != value))
				{
					this.OnRankChanging(value);
					this.SendPropertyChanging();
					this._Rank = value;
					this.SendPropertyChanged("Rank");
					this.OnRankChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Exp", DbType="Int")]
		public System.Nullable<int> Exp
		{
			get
			{
				return this._Exp;
			}
			set
			{
				if ((this._Exp != value))
				{
					this.OnExpChanging(value);
					this.SendPropertyChanging();
					this._Exp = value;
					this.SendPropertyChanged("Exp");
					this.OnExpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PlayerSkill_Player", Storage="_Players", ThisKey="PlayerID", OtherKey="PlayerID")]
		public EntitySet<Player> Players
		{
			get
			{
				return this._Players;
			}
			set
			{
				this._Players.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PlayerSkill_Skill", Storage="_Skills", ThisKey="SkillID", OtherKey="SkillID")]
		public EntitySet<Skill> Skills
		{
			get
			{
				return this._Skills;
			}
			set
			{
				this._Skills.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Players(Player entity)
		{
			this.SendPropertyChanging();
			entity.PlayerSkill = this;
		}
		
		private void detach_Players(Player entity)
		{
			this.SendPropertyChanging();
			entity.PlayerSkill = null;
		}
		
		private void attach_Skills(Skill entity)
		{
			this.SendPropertyChanging();
			entity.PlayerSkill = this;
		}
		
		private void detach_Skills(Skill entity)
		{
			this.SendPropertyChanging();
			entity.PlayerSkill = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Skills")]
	public partial class Skill : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SkillID;
		
		private string _Name;
		
		private System.Nullable<int> _MinimumQuestRequirement;
		
		private string _MinimumQuestName;
		
		private System.Nullable<int> _MinimumDiaryRequirement;
		
		private string _MinimumDiaryName;
		
		private EntityRef<PlayerSkill> _PlayerSkill;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSkillIDChanging(int value);
    partial void OnSkillIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnMinimumQuestRequirementChanging(System.Nullable<int> value);
    partial void OnMinimumQuestRequirementChanged();
    partial void OnMinimumQuestNameChanging(string value);
    partial void OnMinimumQuestNameChanged();
    partial void OnMinimumDiaryRequirementChanging(System.Nullable<int> value);
    partial void OnMinimumDiaryRequirementChanged();
    partial void OnMinimumDiaryNameChanging(string value);
    partial void OnMinimumDiaryNameChanged();
    #endregion
		
		public Skill()
		{
			this._PlayerSkill = default(EntityRef<PlayerSkill>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SkillID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SkillID
		{
			get
			{
				return this._SkillID;
			}
			set
			{
				if ((this._SkillID != value))
				{
					if (this._PlayerSkill.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSkillIDChanging(value);
					this.SendPropertyChanging();
					this._SkillID = value;
					this.SendPropertyChanged("SkillID");
					this.OnSkillIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinimumQuestRequirement", DbType="Int")]
		public System.Nullable<int> MinimumQuestRequirement
		{
			get
			{
				return this._MinimumQuestRequirement;
			}
			set
			{
				if ((this._MinimumQuestRequirement != value))
				{
					this.OnMinimumQuestRequirementChanging(value);
					this.SendPropertyChanging();
					this._MinimumQuestRequirement = value;
					this.SendPropertyChanged("MinimumQuestRequirement");
					this.OnMinimumQuestRequirementChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinimumQuestName", DbType="NVarChar(50)")]
		public string MinimumQuestName
		{
			get
			{
				return this._MinimumQuestName;
			}
			set
			{
				if ((this._MinimumQuestName != value))
				{
					this.OnMinimumQuestNameChanging(value);
					this.SendPropertyChanging();
					this._MinimumQuestName = value;
					this.SendPropertyChanged("MinimumQuestName");
					this.OnMinimumQuestNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinimumDiaryRequirement", DbType="Int")]
		public System.Nullable<int> MinimumDiaryRequirement
		{
			get
			{
				return this._MinimumDiaryRequirement;
			}
			set
			{
				if ((this._MinimumDiaryRequirement != value))
				{
					this.OnMinimumDiaryRequirementChanging(value);
					this.SendPropertyChanging();
					this._MinimumDiaryRequirement = value;
					this.SendPropertyChanged("MinimumDiaryRequirement");
					this.OnMinimumDiaryRequirementChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinimumDiaryName", DbType="NVarChar(50)")]
		public string MinimumDiaryName
		{
			get
			{
				return this._MinimumDiaryName;
			}
			set
			{
				if ((this._MinimumDiaryName != value))
				{
					this.OnMinimumDiaryNameChanging(value);
					this.SendPropertyChanging();
					this._MinimumDiaryName = value;
					this.SendPropertyChanged("MinimumDiaryName");
					this.OnMinimumDiaryNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PlayerSkill_Skill", Storage="_PlayerSkill", ThisKey="SkillID", OtherKey="SkillID", IsForeignKey=true)]
		public PlayerSkill PlayerSkill
		{
			get
			{
				return this._PlayerSkill.Entity;
			}
			set
			{
				PlayerSkill previousValue = this._PlayerSkill.Entity;
				if (((previousValue != value) 
							|| (this._PlayerSkill.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PlayerSkill.Entity = null;
						previousValue.Skills.Remove(this);
					}
					this._PlayerSkill.Entity = value;
					if ((value != null))
					{
						value.Skills.Add(this);
						this._SkillID = value.SkillID;
					}
					else
					{
						this._SkillID = default(int);
					}
					this.SendPropertyChanged("PlayerSkill");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Quests")]
	public partial class Quest : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _QuestID;
		
		private string _Name;
		
		private int _Reward;
		
		private string _Url;
		
		private EntityRef<PlayerQuest> _PlayerQuest;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnQuestIDChanging(int value);
    partial void OnQuestIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnRewardChanging(int value);
    partial void OnRewardChanged();
    partial void OnUrlChanging(string value);
    partial void OnUrlChanged();
    #endregion
		
		public Quest()
		{
			this._PlayerQuest = default(EntityRef<PlayerQuest>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int QuestID
		{
			get
			{
				return this._QuestID;
			}
			set
			{
				if ((this._QuestID != value))
				{
					if (this._PlayerQuest.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnQuestIDChanging(value);
					this.SendPropertyChanging();
					this._QuestID = value;
					this.SendPropertyChanged("QuestID");
					this.OnQuestIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Reward", DbType="Int NOT NULL")]
		public int Reward
		{
			get
			{
				return this._Reward;
			}
			set
			{
				if ((this._Reward != value))
				{
					this.OnRewardChanging(value);
					this.SendPropertyChanging();
					this._Reward = value;
					this.SendPropertyChanged("Reward");
					this.OnRewardChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Url", DbType="NVarChar(MAX)")]
		public string Url
		{
			get
			{
				return this._Url;
			}
			set
			{
				if ((this._Url != value))
				{
					this.OnUrlChanging(value);
					this.SendPropertyChanging();
					this._Url = value;
					this.SendPropertyChanged("Url");
					this.OnUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PlayerQuest_Quest", Storage="_PlayerQuest", ThisKey="QuestID", OtherKey="QuestID", IsForeignKey=true)]
		public PlayerQuest PlayerQuest
		{
			get
			{
				return this._PlayerQuest.Entity;
			}
			set
			{
				PlayerQuest previousValue = this._PlayerQuest.Entity;
				if (((previousValue != value) 
							|| (this._PlayerQuest.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PlayerQuest.Entity = null;
						previousValue.Quests.Remove(this);
					}
					this._PlayerQuest.Entity = value;
					if ((value != null))
					{
						value.Quests.Add(this);
						this._QuestID = value.QuestID;
					}
					else
					{
						this._QuestID = default(int);
					}
					this.SendPropertyChanged("PlayerQuest");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Levels")]
	public partial class Level
	{
		
		private int _LevelID;
		
		private int _Value;
		
		private int _Experience;
		
		public Level()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LevelID", DbType="Int NOT NULL")]
		public int LevelID
		{
			get
			{
				return this._LevelID;
			}
			set
			{
				if ((this._LevelID != value))
				{
					this._LevelID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Level]", Storage="_Value", DbType="Int NOT NULL")]
		public int Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this._Value = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Experience", DbType="Int NOT NULL")]
		public int Experience
		{
			get
			{
				return this._Experience;
			}
			set
			{
				if ((this._Experience != value))
				{
					this._Experience = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
