//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_
{
    /// <summary>
    /// Adds polling to the DataSource Utility.
    /// </summary>
    public partial class Pollable : Y_.DataSource_.Local
    {
        /// <summary>
        /// Clears all intervals.
        /// </summary>
        public void clearAllIntervals(){}
        /// <summary>
        /// Disables polling mechanism associated with the given interval ID.
        /// </summary>
        public void clearInterval(Y_.DataType_.Number id){}
        /// <summary>
        /// Sets up a polling mechanism to send requests at set intervals and
        /// forward responses to given callback.
        /// </summary>
        public Y_.DataType_.Number setInterval(Y_.DataType_.Number msec, object request){return null;}
    }
}
