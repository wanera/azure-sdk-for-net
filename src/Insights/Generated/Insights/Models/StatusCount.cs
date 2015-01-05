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
using Microsoft.Azure.Insights.Models;

namespace Microsoft.Azure.Insights.Models
{
    /// <summary>
    /// The status count.
    /// </summary>
    public partial class StatusCount
    {
        private int _count;
        
        /// <summary>
        /// Optional. The count.
        /// </summary>
        public int Count
        {
            get { return this._count; }
            set { this._count = value; }
        }
        
        private LocalizableString _status;
        
        /// <summary>
        /// Optional. The status.
        /// </summary>
        public LocalizableString Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the StatusCount class.
        /// </summary>
        public StatusCount()
        {
        }
    }
}
