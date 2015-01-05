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
using Microsoft.WindowsAzure.Management.Compute;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute
{
    /// <summary>
    /// The Service Management API provides programmatic access to much of the
    /// functionality available through the Management Portal. The Service
    /// Management API is a REST API. All API operations are performed over
    /// SSL, and are mutually authenticated using X.509 v3 certificates.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460799.aspx for
    /// more information)
    /// </summary>
    public static partial class VirtualMachineOSImageOperationsExtensions
    {
        /// <summary>
        /// Share an already replicated OS image. This operation is only for
        /// publishers. You have to be registered as image publisher with
        /// Windows Azure to be able to call this.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <param name='imageName'>
        /// Required. The name of the virtual machine image to share.
        /// </param>
        /// <param name='permission'>
        /// Required. The sharing permission: public, msdn, or private.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse BeginSharing(this IVirtualMachineOSImageOperations operations, string imageName, string permission)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineOSImageOperations)s).BeginSharingAsync(imageName, permission);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Share an already replicated OS image. This operation is only for
        /// publishers. You have to be registered as image publisher with
        /// Windows Azure to be able to call this.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <param name='imageName'>
        /// Required. The name of the virtual machine image to share.
        /// </param>
        /// <param name='permission'>
        /// Required. The sharing permission: public, msdn, or private.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> BeginSharingAsync(this IVirtualMachineOSImageOperations operations, string imageName, string permission)
        {
            return operations.BeginSharingAsync(imageName, permission, CancellationToken.None);
        }
        
        /// <summary>
        /// Unreplicate an OS image to multiple target locations. This
        /// operation is only for publishers. You have to be registered as
        /// image publisher with Windows Azure to be able to call this. Note:
        /// The operation removes the published copies of the user OS Image.
        /// It does not remove the actual user OS Image. To remove the actual
        /// user OS Image, the publisher will have to call Delete OS Image.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <param name='imageName'>
        /// Required. The name of the virtual machine image to replicate. Note:
        /// The OS Image Name should be the user OS Image, not the published
        /// name of the OS Image.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse BeginUnreplicating(this IVirtualMachineOSImageOperations operations, string imageName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineOSImageOperations)s).BeginUnreplicatingAsync(imageName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Unreplicate an OS image to multiple target locations. This
        /// operation is only for publishers. You have to be registered as
        /// image publisher with Windows Azure to be able to call this. Note:
        /// The operation removes the published copies of the user OS Image.
        /// It does not remove the actual user OS Image. To remove the actual
        /// user OS Image, the publisher will have to call Delete OS Image.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <param name='imageName'>
        /// Required. The name of the virtual machine image to replicate. Note:
        /// The OS Image Name should be the user OS Image, not the published
        /// name of the OS Image.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> BeginUnreplicatingAsync(this IVirtualMachineOSImageOperations operations, string imageName)
        {
            return operations.BeginUnreplicatingAsync(imageName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Create OS Image operation adds an operating system image that
        /// is stored in a storage account and is available from the image
        /// repository.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157192.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Virtual Machine Image
        /// operation.
        /// </param>
        /// <returns>
        /// Parameters returned from the Create Virtual Machine Image operation.
        /// </returns>
        public static VirtualMachineOSImageCreateResponse Create(this IVirtualMachineOSImageOperations operations, VirtualMachineOSImageCreateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineOSImageOperations)s).CreateAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Create OS Image operation adds an operating system image that
        /// is stored in a storage account and is available from the image
        /// repository.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157192.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Virtual Machine Image
        /// operation.
        /// </param>
        /// <returns>
        /// Parameters returned from the Create Virtual Machine Image operation.
        /// </returns>
        public static Task<VirtualMachineOSImageCreateResponse> CreateAsync(this IVirtualMachineOSImageOperations operations, VirtualMachineOSImageCreateParameters parameters)
        {
            return operations.CreateAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The Delete OS Image operation deletes the specified OS image from
        /// your image repository.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157203.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <param name='imageName'>
        /// Required. The name of the image to delete.
        /// </param>
        /// <param name='deleteFromStorage'>
        /// Required. Specifies that the source blob for the image should also
        /// be deleted from storage.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IVirtualMachineOSImageOperations operations, string imageName, bool deleteFromStorage)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineOSImageOperations)s).DeleteAsync(imageName, deleteFromStorage);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Delete OS Image operation deletes the specified OS image from
        /// your image repository.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157203.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <param name='imageName'>
        /// Required. The name of the image to delete.
        /// </param>
        /// <param name='deleteFromStorage'>
        /// Required. Specifies that the source blob for the image should also
        /// be deleted from storage.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IVirtualMachineOSImageOperations operations, string imageName, bool deleteFromStorage)
        {
            return operations.DeleteAsync(imageName, deleteFromStorage, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get OS Image operation retrieves the details for an operating
        /// system image from the image repository.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157191.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <param name='imageName'>
        /// Required. The name of the OS image to retrieve.
        /// </param>
        /// <returns>
        /// A virtual machine image associated with your subscription.
        /// </returns>
        public static VirtualMachineOSImageGetResponse Get(this IVirtualMachineOSImageOperations operations, string imageName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineOSImageOperations)s).GetAsync(imageName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get OS Image operation retrieves the details for an operating
        /// system image from the image repository.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157191.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <param name='imageName'>
        /// Required. The name of the OS image to retrieve.
        /// </param>
        /// <returns>
        /// A virtual machine image associated with your subscription.
        /// </returns>
        public static Task<VirtualMachineOSImageGetResponse> GetAsync(this IVirtualMachineOSImageOperations operations, string imageName)
        {
            return operations.GetAsync(imageName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets OS Image's properties and its replication details. This
        /// operation is only for publishers. You have to be registered as
        /// image publisher with Windows Azure to be able to call this.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <param name='imageName'>
        /// Required. The name of the virtual machine image to replicate.
        /// </param>
        /// <returns>
        /// The Get Details OS Images operation response.
        /// </returns>
        public static VirtualMachineOSImageGetDetailsResponse GetDetails(this IVirtualMachineOSImageOperations operations, string imageName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineOSImageOperations)s).GetDetailsAsync(imageName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets OS Image's properties and its replication details. This
        /// operation is only for publishers. You have to be registered as
        /// image publisher with Windows Azure to be able to call this.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <param name='imageName'>
        /// Required. The name of the virtual machine image to replicate.
        /// </param>
        /// <returns>
        /// The Get Details OS Images operation response.
        /// </returns>
        public static Task<VirtualMachineOSImageGetDetailsResponse> GetDetailsAsync(this IVirtualMachineOSImageOperations operations, string imageName)
        {
            return operations.GetDetailsAsync(imageName, CancellationToken.None);
        }
        
        /// <summary>
        /// The List OS Images operation retrieves a list of the operating
        /// system images from the image repository.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157191.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <returns>
        /// The List OS Images operation response.
        /// </returns>
        public static VirtualMachineOSImageListResponse List(this IVirtualMachineOSImageOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineOSImageOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List OS Images operation retrieves a list of the operating
        /// system images from the image repository.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157191.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <returns>
        /// The List OS Images operation response.
        /// </returns>
        public static Task<VirtualMachineOSImageListResponse> ListAsync(this IVirtualMachineOSImageOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Replicate an OS image to multiple target locations. This operation
        /// is only for publishers. You have to be registered as image
        /// publisher with Windows Azure to be able to call this.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <param name='imageName'>
        /// Required. The name of the virtual machine OS image to replicate.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Replicate Virtual Machine
        /// Image operation.
        /// </param>
        /// <returns>
        /// The response body contains the published name of the image.
        /// </returns>
        public static VirtualMachineOSImageReplicateResponse Replicate(this IVirtualMachineOSImageOperations operations, string imageName, VirtualMachineOSImageReplicateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineOSImageOperations)s).ReplicateAsync(imageName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Replicate an OS image to multiple target locations. This operation
        /// is only for publishers. You have to be registered as image
        /// publisher with Windows Azure to be able to call this.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <param name='imageName'>
        /// Required. The name of the virtual machine OS image to replicate.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Replicate Virtual Machine
        /// Image operation.
        /// </param>
        /// <returns>
        /// The response body contains the published name of the image.
        /// </returns>
        public static Task<VirtualMachineOSImageReplicateResponse> ReplicateAsync(this IVirtualMachineOSImageOperations operations, string imageName, VirtualMachineOSImageReplicateParameters parameters)
        {
            return operations.ReplicateAsync(imageName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Share an already replicated OS image. This operation is only for
        /// publishers. You have to be registered as image publisher with
        /// Windows Azure to be able to call this.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <param name='imageName'>
        /// Required. The name of the virtual machine image to share.
        /// </param>
        /// <param name='permission'>
        /// Required. The sharing permission: public, msdn, or private.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static OperationStatusResponse Share(this IVirtualMachineOSImageOperations operations, string imageName, string permission)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineOSImageOperations)s).ShareAsync(imageName, permission);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Share an already replicated OS image. This operation is only for
        /// publishers. You have to be registered as image publisher with
        /// Windows Azure to be able to call this.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <param name='imageName'>
        /// Required. The name of the virtual machine image to share.
        /// </param>
        /// <param name='permission'>
        /// Required. The sharing permission: public, msdn, or private.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static Task<OperationStatusResponse> ShareAsync(this IVirtualMachineOSImageOperations operations, string imageName, string permission)
        {
            return operations.ShareAsync(imageName, permission, CancellationToken.None);
        }
        
        /// <summary>
        /// Unreplicate an OS image to multiple target locations. This
        /// operation is only for publishers. You have to be registered as
        /// image publisher with Windows Azure to be able to call this. Note:
        /// The operation removes the published copies of the user OS Image.
        /// It does not remove the actual user OS Image. To remove the actual
        /// user OS Image, the publisher will have to call Delete OS Image.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <param name='imageName'>
        /// Required. The name of the virtual machine image to replicate. Note:
        /// The OS Image Name should be the user OS Image, not the published
        /// name of the OS Image.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static OperationStatusResponse Unreplicate(this IVirtualMachineOSImageOperations operations, string imageName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineOSImageOperations)s).UnreplicateAsync(imageName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Unreplicate an OS image to multiple target locations. This
        /// operation is only for publishers. You have to be registered as
        /// image publisher with Windows Azure to be able to call this. Note:
        /// The operation removes the published copies of the user OS Image.
        /// It does not remove the actual user OS Image. To remove the actual
        /// user OS Image, the publisher will have to call Delete OS Image.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <param name='imageName'>
        /// Required. The name of the virtual machine image to replicate. Note:
        /// The OS Image Name should be the user OS Image, not the published
        /// name of the OS Image.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static Task<OperationStatusResponse> UnreplicateAsync(this IVirtualMachineOSImageOperations operations, string imageName)
        {
            return operations.UnreplicateAsync(imageName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Update OS Image operation updates an OS image that in your
        /// image repository.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157198.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <param name='imageName'>
        /// Required. The name of the virtual machine image to be updated.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update Virtual Machine Image
        /// operation.
        /// </param>
        /// <returns>
        /// Parameters returned from the Create Virtual Machine Image operation.
        /// </returns>
        public static VirtualMachineOSImageUpdateResponse Update(this IVirtualMachineOSImageOperations operations, string imageName, VirtualMachineOSImageUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineOSImageOperations)s).UpdateAsync(imageName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Update OS Image operation updates an OS image that in your
        /// image repository.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157198.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineOSImageOperations.
        /// </param>
        /// <param name='imageName'>
        /// Required. The name of the virtual machine image to be updated.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update Virtual Machine Image
        /// operation.
        /// </param>
        /// <returns>
        /// Parameters returned from the Create Virtual Machine Image operation.
        /// </returns>
        public static Task<VirtualMachineOSImageUpdateResponse> UpdateAsync(this IVirtualMachineOSImageOperations operations, string imageName, VirtualMachineOSImageUpdateParameters parameters)
        {
            return operations.UpdateAsync(imageName, parameters, CancellationToken.None);
        }
    }
}
