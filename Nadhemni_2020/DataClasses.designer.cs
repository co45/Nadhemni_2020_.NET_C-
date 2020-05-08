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

namespace Nadhemni_2020
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="nadhemni")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertadresse(adresse instance);
    partial void Updateadresse(adresse instance);
    partial void Deleteadresse(adresse instance);
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    partial void Insertinfop(infop instance);
    partial void Updateinfop(infop instance);
    partial void Deleteinfop(infop instance);
    partial void Insertplaning(planing instance);
    partial void Updateplaning(planing instance);
    partial void Deleteplaning(planing instance);
    partial void Inserttache(tache instance);
    partial void Updatetache(tache instance);
    partial void Deletetache(tache instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::Nadhemni_2020.Properties.Settings.Default.nadhemniConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<adresse> adresse
		{
			get
			{
				return this.GetTable<adresse>();
			}
		}
		
		public System.Data.Linq.Table<user> user
		{
			get
			{
				return this.GetTable<user>();
			}
		}
		
		public System.Data.Linq.Table<infop> infop
		{
			get
			{
				return this.GetTable<infop>();
			}
		}
		
		public System.Data.Linq.Table<planing> planing
		{
			get
			{
				return this.GetTable<planing>();
			}
		}
		
		public System.Data.Linq.Table<tache> tache
		{
			get
			{
				return this.GetTable<tache>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.adresse")]
	public partial class adresse : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_adresse;
		
		private System.Nullable<int> _numero;
		
		private string _rue;
		
		private string _localisation;
		
		private EntitySet<infop> _infop;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_adresseChanging(int value);
    partial void Onid_adresseChanged();
    partial void OnnumeroChanging(System.Nullable<int> value);
    partial void OnnumeroChanged();
    partial void OnrueChanging(string value);
    partial void OnrueChanged();
    partial void OnlocalisationChanging(string value);
    partial void OnlocalisationChanged();
    #endregion
		
		public adresse()
		{
			this._infop = new EntitySet<infop>(new Action<infop>(this.attach_infop), new Action<infop>(this.detach_infop));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_adresse", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_adresse
		{
			get
			{
				return this._id_adresse;
			}
			set
			{
				if ((this._id_adresse != value))
				{
					this.Onid_adresseChanging(value);
					this.SendPropertyChanging();
					this._id_adresse = value;
					this.SendPropertyChanged("id_adresse");
					this.Onid_adresseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numero", DbType="Int")]
		public System.Nullable<int> numero
		{
			get
			{
				return this._numero;
			}
			set
			{
				if ((this._numero != value))
				{
					this.OnnumeroChanging(value);
					this.SendPropertyChanging();
					this._numero = value;
					this.SendPropertyChanged("numero");
					this.OnnumeroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rue", DbType="VarChar(50)")]
		public string rue
		{
			get
			{
				return this._rue;
			}
			set
			{
				if ((this._rue != value))
				{
					this.OnrueChanging(value);
					this.SendPropertyChanging();
					this._rue = value;
					this.SendPropertyChanged("rue");
					this.OnrueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_localisation", DbType="VarChar(50)")]
		public string localisation
		{
			get
			{
				return this._localisation;
			}
			set
			{
				if ((this._localisation != value))
				{
					this.OnlocalisationChanging(value);
					this.SendPropertyChanging();
					this._localisation = value;
					this.SendPropertyChanged("localisation");
					this.OnlocalisationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="adresse_infop", Storage="_infop", ThisKey="id_adresse", OtherKey="adresse")]
		public EntitySet<infop> infop
		{
			get
			{
				return this._infop;
			}
			set
			{
				this._infop.Assign(value);
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
		
		private void attach_infop(infop entity)
		{
			this.SendPropertyChanging();
			entity.adresse1 = this;
		}
		
		private void detach_infop(infop entity)
		{
			this.SendPropertyChanging();
			entity.adresse1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[user]")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_user;
		
		private string _login;
		
		private string _mdp;
		
		private EntitySet<infop> _infop;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_userChanging(int value);
    partial void Onid_userChanged();
    partial void OnloginChanging(string value);
    partial void OnloginChanged();
    partial void OnmdpChanging(string value);
    partial void OnmdpChanged();
    #endregion
		
		public user()
		{
			this._infop = new EntitySet<infop>(new Action<infop>(this.attach_infop), new Action<infop>(this.detach_infop));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_user", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id_user
		{
			get
			{
				return this._id_user;
			}
			set
			{
				if ((this._id_user != value))
				{
					this.Onid_userChanging(value);
					this.SendPropertyChanging();
					this._id_user = value;
					this.SendPropertyChanged("id_user");
					this.Onid_userChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_login", DbType="VarChar(50)")]
		public string login
		{
			get
			{
				return this._login;
			}
			set
			{
				if ((this._login != value))
				{
					this.OnloginChanging(value);
					this.SendPropertyChanging();
					this._login = value;
					this.SendPropertyChanged("login");
					this.OnloginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mdp", DbType="VarChar(50)")]
		public string mdp
		{
			get
			{
				return this._mdp;
			}
			set
			{
				if ((this._mdp != value))
				{
					this.OnmdpChanging(value);
					this.SendPropertyChanging();
					this._mdp = value;
					this.SendPropertyChanged("mdp");
					this.OnmdpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_infop", Storage="_infop", ThisKey="id_user", OtherKey="Id_personne")]
		public EntitySet<infop> infop
		{
			get
			{
				return this._infop;
			}
			set
			{
				this._infop.Assign(value);
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
		
		private void attach_infop(infop entity)
		{
			this.SendPropertyChanging();
			entity.user = this;
		}
		
		private void detach_infop(infop entity)
		{
			this.SendPropertyChanging();
			entity.user = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.infop")]
	public partial class infop : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_personne;
		
		private string _nom;
		
		private string _prenom;
		
		private System.Nullable<System.DateTime> _date_naissance;
		
		private string _genre;
		
		private string _fonction;
		
		private System.Data.Linq.Binary _photo;
		
		private string _etat_civil;
		
		private System.Nullable<int> _nbre_enfant;
		
		private int _adresse;
		
		private string _etat_sante;
		
		private string _etablissement;
		
		private string _niveau_etude;
		
		private string _distance;
		
		private string _mail;
		
		private int _planing;
		
		private EntityRef<adresse> _adresse1;
		
		private EntityRef<user> _user;
		
		private EntityRef<planing> _planing1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_personneChanging(int value);
    partial void OnId_personneChanged();
    partial void OnnomChanging(string value);
    partial void OnnomChanged();
    partial void OnprenomChanging(string value);
    partial void OnprenomChanged();
    partial void Ondate_naissanceChanging(System.Nullable<System.DateTime> value);
    partial void Ondate_naissanceChanged();
    partial void OngenreChanging(string value);
    partial void OngenreChanged();
    partial void OnfonctionChanging(string value);
    partial void OnfonctionChanged();
    partial void OnphotoChanging(System.Data.Linq.Binary value);
    partial void OnphotoChanged();
    partial void Onetat_civilChanging(string value);
    partial void Onetat_civilChanged();
    partial void Onnbre_enfantChanging(System.Nullable<int> value);
    partial void Onnbre_enfantChanged();
    partial void OnadresseChanging(int value);
    partial void OnadresseChanged();
    partial void Onetat_santeChanging(string value);
    partial void Onetat_santeChanged();
    partial void OnetablissementChanging(string value);
    partial void OnetablissementChanged();
    partial void Onniveau_etudeChanging(string value);
    partial void Onniveau_etudeChanged();
    partial void OndistanceChanging(string value);
    partial void OndistanceChanged();
    partial void OnmailChanging(string value);
    partial void OnmailChanged();
    partial void OnplaningChanging(int value);
    partial void OnplaningChanged();
    #endregion
		
		public infop()
		{
			this._adresse1 = default(EntityRef<adresse>);
			this._user = default(EntityRef<user>);
			this._planing1 = default(EntityRef<planing>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_personne", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_personne
		{
			get
			{
				return this._Id_personne;
			}
			set
			{
				if ((this._Id_personne != value))
				{
					if (this._user.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_personneChanging(value);
					this.SendPropertyChanging();
					this._Id_personne = value;
					this.SendPropertyChanged("Id_personne");
					this.OnId_personneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nom", DbType="VarChar(50)")]
		public string nom
		{
			get
			{
				return this._nom;
			}
			set
			{
				if ((this._nom != value))
				{
					this.OnnomChanging(value);
					this.SendPropertyChanging();
					this._nom = value;
					this.SendPropertyChanged("nom");
					this.OnnomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prenom", DbType="VarChar(50)")]
		public string prenom
		{
			get
			{
				return this._prenom;
			}
			set
			{
				if ((this._prenom != value))
				{
					this.OnprenomChanging(value);
					this.SendPropertyChanging();
					this._prenom = value;
					this.SendPropertyChanged("prenom");
					this.OnprenomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_naissance", DbType="Date")]
		public System.Nullable<System.DateTime> date_naissance
		{
			get
			{
				return this._date_naissance;
			}
			set
			{
				if ((this._date_naissance != value))
				{
					this.Ondate_naissanceChanging(value);
					this.SendPropertyChanging();
					this._date_naissance = value;
					this.SendPropertyChanged("date_naissance");
					this.Ondate_naissanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_genre", DbType="VarChar(50)")]
		public string genre
		{
			get
			{
				return this._genre;
			}
			set
			{
				if ((this._genre != value))
				{
					this.OngenreChanging(value);
					this.SendPropertyChanging();
					this._genre = value;
					this.SendPropertyChanged("genre");
					this.OngenreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fonction", DbType="VarChar(50)")]
		public string fonction
		{
			get
			{
				return this._fonction;
			}
			set
			{
				if ((this._fonction != value))
				{
					this.OnfonctionChanging(value);
					this.SendPropertyChanging();
					this._fonction = value;
					this.SendPropertyChanged("fonction");
					this.OnfonctionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_photo", DbType="Binary(50)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary photo
		{
			get
			{
				return this._photo;
			}
			set
			{
				if ((this._photo != value))
				{
					this.OnphotoChanging(value);
					this.SendPropertyChanging();
					this._photo = value;
					this.SendPropertyChanged("photo");
					this.OnphotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_etat_civil", DbType="VarChar(50)")]
		public string etat_civil
		{
			get
			{
				return this._etat_civil;
			}
			set
			{
				if ((this._etat_civil != value))
				{
					this.Onetat_civilChanging(value);
					this.SendPropertyChanging();
					this._etat_civil = value;
					this.SendPropertyChanged("etat_civil");
					this.Onetat_civilChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nbre_enfant", DbType="Int")]
		public System.Nullable<int> nbre_enfant
		{
			get
			{
				return this._nbre_enfant;
			}
			set
			{
				if ((this._nbre_enfant != value))
				{
					this.Onnbre_enfantChanging(value);
					this.SendPropertyChanging();
					this._nbre_enfant = value;
					this.SendPropertyChanged("nbre_enfant");
					this.Onnbre_enfantChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adresse", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int adresse
		{
			get
			{
				return this._adresse;
			}
			set
			{
				if ((this._adresse != value))
				{
					if (this._adresse1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnadresseChanging(value);
					this.SendPropertyChanging();
					this._adresse = value;
					this.SendPropertyChanged("adresse");
					this.OnadresseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_etat_sante", DbType="VarChar(50)")]
		public string etat_sante
		{
			get
			{
				return this._etat_sante;
			}
			set
			{
				if ((this._etat_sante != value))
				{
					this.Onetat_santeChanging(value);
					this.SendPropertyChanging();
					this._etat_sante = value;
					this.SendPropertyChanged("etat_sante");
					this.Onetat_santeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_etablissement", DbType="VarChar(50)")]
		public string etablissement
		{
			get
			{
				return this._etablissement;
			}
			set
			{
				if ((this._etablissement != value))
				{
					this.OnetablissementChanging(value);
					this.SendPropertyChanging();
					this._etablissement = value;
					this.SendPropertyChanged("etablissement");
					this.OnetablissementChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_niveau_etude", DbType="VarChar(50)")]
		public string niveau_etude
		{
			get
			{
				return this._niveau_etude;
			}
			set
			{
				if ((this._niveau_etude != value))
				{
					this.Onniveau_etudeChanging(value);
					this.SendPropertyChanging();
					this._niveau_etude = value;
					this.SendPropertyChanged("niveau_etude");
					this.Onniveau_etudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_distance", DbType="VarChar(50)")]
		public string distance
		{
			get
			{
				return this._distance;
			}
			set
			{
				if ((this._distance != value))
				{
					this.OndistanceChanging(value);
					this.SendPropertyChanging();
					this._distance = value;
					this.SendPropertyChanged("distance");
					this.OndistanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mail", DbType="VarChar(50)")]
		public string mail
		{
			get
			{
				return this._mail;
			}
			set
			{
				if ((this._mail != value))
				{
					this.OnmailChanging(value);
					this.SendPropertyChanging();
					this._mail = value;
					this.SendPropertyChanged("mail");
					this.OnmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_planing", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int planing
		{
			get
			{
				return this._planing;
			}
			set
			{
				if ((this._planing != value))
				{
					if (this._planing1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnplaningChanging(value);
					this.SendPropertyChanging();
					this._planing = value;
					this.SendPropertyChanged("planing");
					this.OnplaningChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="adresse_infop", Storage="_adresse1", ThisKey="adresse", OtherKey="id_adresse", IsForeignKey=true)]
		public adresse adresse1
		{
			get
			{
				return this._adresse1.Entity;
			}
			set
			{
				adresse previousValue = this._adresse1.Entity;
				if (((previousValue != value) 
							|| (this._adresse1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._adresse1.Entity = null;
						previousValue.infop.Remove(this);
					}
					this._adresse1.Entity = value;
					if ((value != null))
					{
						value.infop.Add(this);
						this._adresse = value.id_adresse;
					}
					else
					{
						this._adresse = default(int);
					}
					this.SendPropertyChanged("adresse1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_infop", Storage="_user", ThisKey="Id_personne", OtherKey="id_user", IsForeignKey=true)]
		public user user
		{
			get
			{
				return this._user.Entity;
			}
			set
			{
				user previousValue = this._user.Entity;
				if (((previousValue != value) 
							|| (this._user.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user.Entity = null;
						previousValue.infop.Remove(this);
					}
					this._user.Entity = value;
					if ((value != null))
					{
						value.infop.Add(this);
						this._Id_personne = value.id_user;
					}
					else
					{
						this._Id_personne = default(int);
					}
					this.SendPropertyChanged("user");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="planing_infop", Storage="_planing1", ThisKey="planing", OtherKey="Id_planing", IsForeignKey=true)]
		public planing planing1
		{
			get
			{
				return this._planing1.Entity;
			}
			set
			{
				planing previousValue = this._planing1.Entity;
				if (((previousValue != value) 
							|| (this._planing1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._planing1.Entity = null;
						previousValue.infop.Remove(this);
					}
					this._planing1.Entity = value;
					if ((value != null))
					{
						value.infop.Add(this);
						this._planing = value.Id_planing;
					}
					else
					{
						this._planing = default(int);
					}
					this.SendPropertyChanged("planing1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.planing")]
	public partial class planing : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_planing;
		
		private System.Nullable<int> _id_taches;
		
		private EntitySet<infop> _infop;
		
		private EntityRef<tache> _tache;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_planingChanging(int value);
    partial void OnId_planingChanged();
    partial void Onid_tachesChanging(System.Nullable<int> value);
    partial void Onid_tachesChanged();
    #endregion
		
		public planing()
		{
			this._infop = new EntitySet<infop>(new Action<infop>(this.attach_infop), new Action<infop>(this.detach_infop));
			this._tache = default(EntityRef<tache>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_planing", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id_planing
		{
			get
			{
				return this._Id_planing;
			}
			set
			{
				if ((this._Id_planing != value))
				{
					this.OnId_planingChanging(value);
					this.SendPropertyChanging();
					this._Id_planing = value;
					this.SendPropertyChanged("Id_planing");
					this.OnId_planingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_taches", DbType="Int")]
		public System.Nullable<int> id_taches
		{
			get
			{
				return this._id_taches;
			}
			set
			{
				if ((this._id_taches != value))
				{
					if (this._tache.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_tachesChanging(value);
					this.SendPropertyChanging();
					this._id_taches = value;
					this.SendPropertyChanged("id_taches");
					this.Onid_tachesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="planing_infop", Storage="_infop", ThisKey="Id_planing", OtherKey="planing")]
		public EntitySet<infop> infop
		{
			get
			{
				return this._infop;
			}
			set
			{
				this._infop.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tache_planing", Storage="_tache", ThisKey="id_taches", OtherKey="id_tache", IsForeignKey=true)]
		public tache tache
		{
			get
			{
				return this._tache.Entity;
			}
			set
			{
				tache previousValue = this._tache.Entity;
				if (((previousValue != value) 
							|| (this._tache.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tache.Entity = null;
						previousValue.planing.Remove(this);
					}
					this._tache.Entity = value;
					if ((value != null))
					{
						value.planing.Add(this);
						this._id_taches = value.id_tache;
					}
					else
					{
						this._id_taches = default(Nullable<int>);
					}
					this.SendPropertyChanged("tache");
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
		
		private void attach_infop(infop entity)
		{
			this.SendPropertyChanging();
			entity.planing1 = this;
		}
		
		private void detach_infop(infop entity)
		{
			this.SendPropertyChanging();
			entity.planing1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tache")]
	public partial class tache : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_tache;
		
		private string _titre;
		
		private System.DateTime _t_debut;
		
		private System.DateTime _t_fin;
		
		private string _description;
		
		private System.Nullable<double> _duree;
		
		private string _emplacement;
		
		private System.Nullable<int> _personne_imp;
		
		private string _type;
		
		private EntitySet<planing> _planing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_tacheChanging(int value);
    partial void Onid_tacheChanged();
    partial void OntitreChanging(string value);
    partial void OntitreChanged();
    partial void Ont_debutChanging(System.DateTime value);
    partial void Ont_debutChanged();
    partial void Ont_finChanging(System.DateTime value);
    partial void Ont_finChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OndureeChanging(System.Nullable<double> value);
    partial void OndureeChanged();
    partial void OnemplacementChanging(string value);
    partial void OnemplacementChanged();
    partial void Onpersonne_impChanging(System.Nullable<int> value);
    partial void Onpersonne_impChanged();
    partial void OntypeChanging(string value);
    partial void OntypeChanged();
    #endregion
		
		public tache()
		{
			this._planing = new EntitySet<planing>(new Action<planing>(this.attach_planing), new Action<planing>(this.detach_planing));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_tache", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id_tache
		{
			get
			{
				return this._id_tache;
			}
			set
			{
				if ((this._id_tache != value))
				{
					this.Onid_tacheChanging(value);
					this.SendPropertyChanging();
					this._id_tache = value;
					this.SendPropertyChanged("id_tache");
					this.Onid_tacheChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_titre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string titre
		{
			get
			{
				return this._titre;
			}
			set
			{
				if ((this._titre != value))
				{
					this.OntitreChanging(value);
					this.SendPropertyChanging();
					this._titre = value;
					this.SendPropertyChanged("titre");
					this.OntitreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_t_debut", DbType="DateTime NOT NULL")]
		public System.DateTime t_debut
		{
			get
			{
				return this._t_debut;
			}
			set
			{
				if ((this._t_debut != value))
				{
					this.Ont_debutChanging(value);
					this.SendPropertyChanging();
					this._t_debut = value;
					this.SendPropertyChanged("t_debut");
					this.Ont_debutChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_t_fin", DbType="DateTime NOT NULL")]
		public System.DateTime t_fin
		{
			get
			{
				return this._t_fin;
			}
			set
			{
				if ((this._t_fin != value))
				{
					this.Ont_finChanging(value);
					this.SendPropertyChanging();
					this._t_fin = value;
					this.SendPropertyChanged("t_fin");
					this.Ont_finChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_duree", DbType="Float")]
		public System.Nullable<double> duree
		{
			get
			{
				return this._duree;
			}
			set
			{
				if ((this._duree != value))
				{
					this.OndureeChanging(value);
					this.SendPropertyChanging();
					this._duree = value;
					this.SendPropertyChanged("duree");
					this.OndureeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emplacement", DbType="VarChar(50)")]
		public string emplacement
		{
			get
			{
				return this._emplacement;
			}
			set
			{
				if ((this._emplacement != value))
				{
					this.OnemplacementChanging(value);
					this.SendPropertyChanging();
					this._emplacement = value;
					this.SendPropertyChanged("emplacement");
					this.OnemplacementChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_personne_imp", DbType="Int")]
		public System.Nullable<int> personne_imp
		{
			get
			{
				return this._personne_imp;
			}
			set
			{
				if ((this._personne_imp != value))
				{
					this.Onpersonne_impChanging(value);
					this.SendPropertyChanging();
					this._personne_imp = value;
					this.SendPropertyChanged("personne_imp");
					this.Onpersonne_impChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((this._type != value))
				{
					this.OntypeChanging(value);
					this.SendPropertyChanging();
					this._type = value;
					this.SendPropertyChanged("type");
					this.OntypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tache_planing", Storage="_planing", ThisKey="id_tache", OtherKey="id_taches")]
		public EntitySet<planing> planing
		{
			get
			{
				return this._planing;
			}
			set
			{
				this._planing.Assign(value);
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
		
		private void attach_planing(planing entity)
		{
			this.SendPropertyChanging();
			entity.tache = this;
		}
		
		private void detach_planing(planing entity)
		{
			this.SendPropertyChanging();
			entity.tache = null;
		}
	}
}
#pragma warning restore 1591
