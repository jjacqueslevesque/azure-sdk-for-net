// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrivateEndpointConnectionsOperations.
    /// </summary>
    public static partial class PrivateEndpointConnectionsOperationsExtensions
    {
            /// <summary>
            /// Gets a private endpoint connection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            public static PrivateEndpointConnection Get(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string serverName, string privateEndpointConnectionName)
            {
                return operations.GetAsync(resourceGroupName, serverName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a private endpoint connection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> GetAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string serverName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Approve or reject a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// </param>
            /// <param name='parameters'>
            /// </param>
            public static PrivateEndpointConnection CreateOrUpdate(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string serverName, string privateEndpointConnectionName, PrivateEndpointConnection parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, privateEndpointConnectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Approve or reject a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// </param>
            /// <param name='parameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> CreateOrUpdateAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string serverName, string privateEndpointConnectionName, PrivateEndpointConnection parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, privateEndpointConnectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// </param>
            public static void Delete(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string serverName, string privateEndpointConnectionName)
            {
                operations.DeleteAsync(resourceGroupName, serverName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string serverName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all private endpoint connections on a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            public static IPage<PrivateEndpointConnection> ListByServer(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string serverName)
            {
                return operations.ListByServerAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all private endpoint connections on a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PrivateEndpointConnection>> ListByServerAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Approve or reject a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// </param>
            /// <param name='parameters'>
            /// </param>
            public static PrivateEndpointConnection BeginCreateOrUpdate(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string serverName, string privateEndpointConnectionName, PrivateEndpointConnection parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, privateEndpointConnectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Approve or reject a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// </param>
            /// <param name='parameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> BeginCreateOrUpdateAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string serverName, string privateEndpointConnectionName, PrivateEndpointConnection parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, privateEndpointConnectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// </param>
            public static void BeginDelete(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string serverName, string privateEndpointConnectionName)
            {
                operations.BeginDeleteAsync(resourceGroupName, serverName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string serverName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serverName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all private endpoint connections on a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PrivateEndpointConnection> ListByServerNext(this IPrivateEndpointConnectionsOperations operations, string nextPageLink)
            {
                return operations.ListByServerNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all private endpoint connections on a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PrivateEndpointConnection>> ListByServerNextAsync(this IPrivateEndpointConnectionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
