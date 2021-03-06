// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.util
{
    /// <summary>
	/// <para>This is an util class responsible for serializing qooxdoo objects.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.util.Serializer", OmitOptionalParameters = true, Export = false)]
    public partial class Serializer 
    {
		#region Methods

		public Serializer() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Serializes the properties of the given qooxdoo object into a json object.</para>
		/// </summary>
		/// <param name="objectx">Any qooxdoo object</param>
		/// <param name="qxSerializer">Function used for serializing qooxdoo objects stored in the propertys of the object. Check for the type of classes </param>
		/// <param name="dateFormat">If a date formater is given, the format method of this given formater is used to convert date objects into strings.</param>
		/// <returns>The serialized object.</returns>
		[JsMethod(Name = "toJson")]
		public static string ToJson(qx.core.Object objectx, Action<object> qxSerializer, qx.util.format.DateFormat dateFormat) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Serializes the properties of the given qooxdoo object into a native
		/// object.</para>
		/// </summary>
		/// <param name="objectx">Any qooxdoo object</param>
		/// <param name="qxSerializer">Function used for serializing qooxdoo objects stored in the propertys of the object. Check for the type of classes you want to serialize and return the serialized value. In all other cases, just return nothing.</param>
		/// <param name="dateFormat">If a date formater is given, the format method of this given formater is used to convert date objects into strings.</param>
		/// <returns>The serialized object.</returns>
		[JsMethod(Name = "toNativeObject")]
		public static string ToNativeObject(qx.core.Object objectx, Action<object> qxSerializer, qx.util.format.DateFormat dateFormat) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Serializes the properties of the given qooxdoo object. To get the
		/// serialization working, every property needs to have a string
		/// representation because the value of the property will be concatenated to the
		/// serialized string.</para>
		/// </summary>
		/// <param name="objectx">Any qooxdoo object</param>
		/// <param name="qxSerializer">Function used for serializing qooxdoo objects stored in the propertys of the object. Check for the type of classes </param>
		/// <param name="dateFormat">If a date formater is given, the format method of this given formater is used to convert date objects into strings.</param>
		/// <returns>The serialized object.</returns>
		[JsMethod(Name = "toUriParameter")]
		public static string ToUriParameter(qx.core.Object objectx, Action<object> qxSerializer, qx.util.format.DateFormat dateFormat) { throw new NotImplementedException(); }

		#endregion Methods
    }
}