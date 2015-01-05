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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Sql;
using Microsoft.Azure.Management.Sql.Models;

namespace Microsoft.Azure.Management.Sql
{
    /// <summary>
    /// The Windows Azure SQL Database management API provides a RESTful set of
    /// web services that interact with Windows Azure SQL Database services to
    /// manage your databases. The API enables users to create, retrieve,
    /// update, and delete databases and servers.
    /// </summary>
    public static partial class SecurityOperationsExtensions
    {
        /// <summary>
        /// Gets Azure SQL Database security policy object according to a given
        /// Azure SQL Database Server and Database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.ISecurityOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Database Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// Azure SQL Database hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database for which the security
        /// policy is being retreived.
        /// </param>
        /// <returns>
        /// Represents the response to a get Azure SQL Database security policy
        /// request
        /// </returns>
        public static DatabaseSecurityPolicyGetResponse Get(this ISecurityOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISecurityOperations)s).GetAsync(resourceGroupName, serverName, databaseName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets Azure SQL Database security policy object according to a given
        /// Azure SQL Database Server and Database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.ISecurityOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Database Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// Azure SQL Database hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database for which the security
        /// policy is being retreived.
        /// </param>
        /// <returns>
        /// Represents the response to a get Azure SQL Database security policy
        /// request
        /// </returns>
        public static Task<DatabaseSecurityPolicyGetResponse> GetAsync(this ISecurityOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return operations.GetAsync(resourceGroupName, serverName, databaseName, CancellationToken.None);
        }
        
        /// <summary>
        /// Updates an Azure SQL Database security policy object.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.ISecurityOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Database Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server to which the
        /// Azure SQL Database belongs.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to which the security
        /// policy is applied.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for updating a security policy.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Update(this ISecurityOperations operations, string resourceGroupName, string serverName, string databaseName, DatabaseSecurityPolicyUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISecurityOperations)s).UpdateAsync(resourceGroupName, serverName, databaseName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Updates an Azure SQL Database security policy object.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Management.Sql.ISecurityOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Database Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server to which the
        /// Azure SQL Database belongs.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to which the security
        /// policy is applied.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for updating a security policy.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> UpdateAsync(this ISecurityOperations operations, string resourceGroupName, string serverName, string databaseName, DatabaseSecurityPolicyUpdateParameters parameters)
        {
            return operations.UpdateAsync(resourceGroupName, serverName, databaseName, parameters, CancellationToken.None);
        }
    }
}
