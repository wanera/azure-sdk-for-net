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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The definition of a Protection Container mapping object properties.
    /// </summary>
    public partial class ProtectionContainerMappingProperties
    {
        private string _health;
        
        /// <summary>
        /// Optional. Health of pairing.
        /// </summary>
        public string Health
        {
            get { return this._health; }
            set { this._health = value; }
        }
        
        private IList<HealthError> _healthErrorDetails;
        
        /// <summary>
        /// Optional. Health error.
        /// </summary>
        public IList<HealthError> HealthErrorDetails
        {
            get { return this._healthErrorDetails; }
            set { this._healthErrorDetails = value; }
        }
        
        private string _policyId;
        
        /// <summary>
        /// Optional. Policy Id.
        /// </summary>
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }
        
        private MappingProviderConfigurationSettings _providerSpecificDetails;
        
        /// <summary>
        /// Optional. Provider specific details.
        /// </summary>
        public MappingProviderConfigurationSettings ProviderSpecificDetails
        {
            get { return this._providerSpecificDetails; }
            set { this._providerSpecificDetails = value; }
        }
        
        private string _state;
        
        /// <summary>
        /// Optional. Association Status
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private string _targetProtectionContainerFriendlyName;
        
        /// <summary>
        /// Optional. Friendly name of paired container.
        /// </summary>
        public string TargetProtectionContainerFriendlyName
        {
            get { return this._targetProtectionContainerFriendlyName; }
            set { this._targetProtectionContainerFriendlyName = value; }
        }
        
        private string _targetProtectionContainerId;
        
        /// <summary>
        /// Optional. Paired protection container ID.
        /// </summary>
        public string TargetProtectionContainerId
        {
            get { return this._targetProtectionContainerId; }
            set { this._targetProtectionContainerId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ProtectionContainerMappingProperties class.
        /// </summary>
        public ProtectionContainerMappingProperties()
        {
            this.HealthErrorDetails = new LazyList<HealthError>();
        }
    }
}
