// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.TrafficManager.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for MonitorProtocol.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(MonitorProtocolConverter))]
    public struct MonitorProtocol : System.IEquatable<MonitorProtocol>
    {
        private MonitorProtocol(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly MonitorProtocol HTTP = "HTTP";

        public static readonly MonitorProtocol HTTPS = "HTTPS";

        public static readonly MonitorProtocol TCP = "TCP";


        /// <summary>
        /// Underlying value of enum MonitorProtocol
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for MonitorProtocol
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type MonitorProtocol
        /// </summary>
        public bool Equals(MonitorProtocol e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to MonitorProtocol
        /// </summary>
        public static implicit operator MonitorProtocol(string value)
        {
            return new MonitorProtocol(value);
        }

        /// <summary>
        /// Implicit operator to convert MonitorProtocol to string
        /// </summary>
        public static implicit operator string(MonitorProtocol e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum MonitorProtocol
        /// </summary>
        public static bool operator == (MonitorProtocol e1, MonitorProtocol e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum MonitorProtocol
        /// </summary>
        public static bool operator != (MonitorProtocol e1, MonitorProtocol e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for MonitorProtocol
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is MonitorProtocol && Equals((MonitorProtocol)obj);
        }

        /// <summary>
        /// Returns for hashCode MonitorProtocol
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
