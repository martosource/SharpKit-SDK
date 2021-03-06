//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:39 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.data
{
    #region ResultSet
    /// <inheritdocs />
    /// <summary>
    /// <p>Simple wrapper class that represents a set of records returned by a Proxy.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class ResultSet : Ext.Base
    {
        /// <summary>
        /// The number of records in this ResultSet. Note that total may differ from this number.
        /// Defaults to: <c>0</c>
        /// </summary>
        public JsNumber count;
        /// <summary>
        /// True if the records have already been loaded. This is only meaningful when dealing with
        /// SQL-backed proxies.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool loaded;
        /// <summary>
        /// The array of record instances.
        /// </summary>
        public Ext.data.Model records;
        /// <summary>
        /// True if the ResultSet loaded successfully, false if any errors were encountered.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool success;
        /// <summary>
        /// The total number of records reported by the data source. This ResultSet may form a subset of
        /// those records (see count).
        /// Defaults to: <c>0</c>
        /// </summary>
        public JsNumber total;
        /// <summary>
        /// Copy of this.total.
        /// <p>This property has been <strong>deprecated</strong> </p>
        /// <p>Will be removed in Ext JS 5.0. Use <see cref="Ext.data.ResultSetConfig.total">total</see> instead.</p>
        /// </summary>
        public JsNumber totalRecords{get;set;}
        /// <summary>
        /// Creates the resultSet
        /// </summary>
        /// <param name="config"><p>Config object.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public ResultSet(object config=null){}
        public ResultSet(ResultSetConfig config){}
        public ResultSet(params object[] args){}
    }
    #endregion
    #region ResultSetConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ResultSetConfig : Ext.BaseConfig
    {
        /// <summary>
        /// The number of records in this ResultSet. Note that total may differ from this number.
        /// Defaults to: <c>0</c>
        /// </summary>
        public JsNumber count;
        /// <summary>
        /// True if the records have already been loaded. This is only meaningful when dealing with
        /// SQL-backed proxies.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool loaded;
        /// <summary>
        /// The array of record instances.
        /// </summary>
        public Ext.data.Model records;
        /// <summary>
        /// True if the ResultSet loaded successfully, false if any errors were encountered.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool success;
        /// <summary>
        /// The total number of records reported by the data source. This ResultSet may form a subset of
        /// those records (see count).
        /// Defaults to: <c>0</c>
        /// </summary>
        public JsNumber total;
        public ResultSetConfig(params object[] args){}
    }
    #endregion
    #region ResultSetEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ResultSetEvents : Ext.BaseEvents
    {
        public ResultSetEvents(params object[] args){}
    }
    #endregion
}
