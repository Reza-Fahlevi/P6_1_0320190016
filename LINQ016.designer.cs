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

namespace P6_1_0320190016
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="P6_0320190016")]
	public partial class LINQ016DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMahasiswa(Mahasiswa instance);
    partial void UpdateMahasiswa(Mahasiswa instance);
    partial void DeleteMahasiswa(Mahasiswa instance);
    #endregion
		
		public LINQ016DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["P6_0320190016ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LINQ016DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQ016DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQ016DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQ016DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Mahasiswa> Mahasiswas
		{
			get
			{
				return this.GetTable<Mahasiswa>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Mahasiswa")]
	public partial class Mahasiswa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _nim;
		
		private string _nama;
		
		private string _alamat;
		
		private string _email;
		
		private System.DateTime _tgl_lahir;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnimChanging(string value);
    partial void OnnimChanged();
    partial void OnnamaChanging(string value);
    partial void OnnamaChanged();
    partial void OnalamatChanging(string value);
    partial void OnalamatChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void Ontgl_lahirChanging(System.DateTime value);
    partial void Ontgl_lahirChanged();
    #endregion
		
		public Mahasiswa()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nim", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string nim
		{
			get
			{
				return this._nim;
			}
			set
			{
				if ((this._nim != value))
				{
					this.OnnimChanging(value);
					this.SendPropertyChanging();
					this._nim = value;
					this.SendPropertyChanged("nim");
					this.OnnimChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nama", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string nama
		{
			get
			{
				return this._nama;
			}
			set
			{
				if ((this._nama != value))
				{
					this.OnnamaChanging(value);
					this.SendPropertyChanging();
					this._nama = value;
					this.SendPropertyChanged("nama");
					this.OnnamaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_alamat", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string alamat
		{
			get
			{
				return this._alamat;
			}
			set
			{
				if ((this._alamat != value))
				{
					this.OnalamatChanging(value);
					this.SendPropertyChanging();
					this._alamat = value;
					this.SendPropertyChanged("alamat");
					this.OnalamatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tgl_lahir", DbType="Date NOT NULL")]
		public System.DateTime tgl_lahir
		{
			get
			{
				return this._tgl_lahir;
			}
			set
			{
				if ((this._tgl_lahir != value))
				{
					this.Ontgl_lahirChanging(value);
					this.SendPropertyChanging();
					this._tgl_lahir = value;
					this.SendPropertyChanged("tgl_lahir");
					this.Ontgl_lahirChanged();
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
}
#pragma warning restore 1591
