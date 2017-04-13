/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using Recombee.ApiClient.Util;


namespace Recombee.ApiClient.ApiRequests
{
    /// <summary>Add user property</summary>
    /// <remarks>Adding an user property is somehow equivalent to adding a column to the table of users. The users may be characterized by various properties of different types.
    /// </remarks>
    public class AddUserProperty : Request
    {
        private readonly string propertyName;
        /// <summary>Name of the user property to be created. Currently, the following names are reserved:`id`, `userid`, case insensitively. Also, the length of the property name must not exceed 63 characters.
        /// </summary>
        public string PropertyName
        {
            get {return propertyName;}
        }
        private readonly string type;
        /// <summary>Value type of the user property to be created. One of: `int`, `double`, `string`, `boolean`, `timestamp`, `set`
        /// </summary>
        public string Type
        {
            get {return type;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="propertyName">Name of the user property to be created. Currently, the following names are reserved:`id`, `userid`, case insensitively. Also, the length of the property name must not exceed 63 characters.
        /// </param>
        /// <param name="type">Value type of the user property to be created. One of: `int`, `double`, `string`, `boolean`, `timestamp`, `set`
        /// </param>
        public AddUserProperty (string propertyName, string type): base(HttpMethod.Put, 1000)
        {
            this.propertyName = propertyName;
            this.type = type;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/users/properties/{0}", PropertyName);
        }
    
        /// <summary>Get query parameters</summary>
        /// <returns>Dictionary containing values of query parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> QueryParameters()
        {
           var parameters =  new Dictionary<string, object>()
            {
                {"type", Type}
            };
            return parameters;
        }
    
        /// <summary>Get body parameters</summary>
        /// <returns>Dictionary containing  values of body parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> BodyParameters()
        {
           var parameters =  new Dictionary<string, object>()
            {
        
            };
            return parameters;
        }
    
    }
}