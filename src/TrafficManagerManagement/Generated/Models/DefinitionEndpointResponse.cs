// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.WindowsAzure.Management.TrafficManager.Models;

namespace Microsoft.WindowsAzure.Management.TrafficManager.Models
{
    /// <summary>
    /// The Endpoint status.
    /// </summary>
    public partial class DefinitionEndpointResponse
    {
        private string _domainName;
        
        /// <summary>
        /// Optional. The endpoint domain name.
        /// </summary>
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }
        
        private string _location;
        
        /// <summary>
        /// Optional. Specifies the location of an endpoint of type Any. This
        /// is required for Performance policies
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private int? _minChildEndpoints;
        
        /// <summary>
        /// Optional. Specifies the minimum amount of child endpoints in a
        /// nested profile that has to be online for the endpoint to be
        /// considered online.
        /// </summary>
        public int? MinChildEndpoints
        {
            get { return this._minChildEndpoints; }
            set { this._minChildEndpoints = value; }
        }
        
        private DefinitionEndpointMonitorStatus _monitorStatus;
        
        /// <summary>
        /// Optional. Indicates health status for the endpoint.
        /// </summary>
        public DefinitionEndpointMonitorStatus MonitorStatus
        {
            get { return this._monitorStatus; }
            set { this._monitorStatus = value; }
        }
        
        private EndpointStatus _status;
        
        /// <summary>
        /// Optional. The status of monitoring for the endpoint.
        /// </summary>
        public EndpointStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private EndpointType _type;
        
        /// <summary>
        /// Optional. Specifies the type of the endpoint.
        /// </summary>
        public EndpointType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        private int? _weight;
        
        /// <summary>
        /// Optional. Specifies the weight of an endpoint in a weighted round
        /// robin policy.
        /// </summary>
        public int? Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DefinitionEndpointResponse class.
        /// </summary>
        public DefinitionEndpointResponse()
        {
        }
    }
}
