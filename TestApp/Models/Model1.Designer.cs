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
namespace $safeprojectname$.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MoviesEntities1 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MoviesEntities1 object using the connection string found in the 'MoviesEntities1' section of the application configuration file.
        /// </summary>
        public MoviesEntities1() : base("name=MoviesEntities1", "MoviesEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MoviesEntities1 object.
        /// </summary>
        public MoviesEntities1(string connectionString) : base(connectionString, "MoviesEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MoviesEntities1 object.
        /// </summary>
        public MoviesEntities1(EntityConnection connection) : base(connection, "MoviesEntities1")
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
        public ObjectSet<MovieDB> MovieDBs
        {
            get
            {
                if ((_MovieDBs == null))
                {
                    _MovieDBs = base.CreateObjectSet<MovieDB>("MovieDBs");
                }
                return _MovieDBs;
            }
        }
        private ObjectSet<MovieDB> _MovieDBs;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the MovieDBs EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMovieDBs(MovieDB movieDB)
        {
            base.AddObject("MovieDBs", movieDB);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MoviesModel", Name="MovieDB")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class MovieDB : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new MovieDB object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="director">Initial value of the Director property.</param>
        /// <param name="date">Initial value of the Date property.</param>
        public static MovieDB CreateMovieDB(global::System.Int32 id, global::System.String title, global::System.String director, global::System.DateTime date)
        {
            MovieDB movieDB = new MovieDB();
            movieDB.ID = id;
            movieDB.Title = title;
            movieDB.Director = director;
            movieDB.Date = date;
            return movieDB;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Director
        {
            get
            {
                return _Director;
            }
            set
            {
                OnDirectorChanging(value);
                ReportPropertyChanging("Director");
                _Director = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Director");
                OnDirectorChanged();
            }
        }
        private global::System.String _Director;
        partial void OnDirectorChanging(global::System.String value);
        partial void OnDirectorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                OnDateChanging(value);
                ReportPropertyChanging("Date");
                _Date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Date");
                OnDateChanged();
            }
        }
        private global::System.DateTime _Date;
        partial void OnDateChanging(global::System.DateTime value);
        partial void OnDateChanged();

        #endregion

    
    }

    #endregion

    
}
