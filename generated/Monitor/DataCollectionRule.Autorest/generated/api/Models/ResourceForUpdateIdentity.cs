// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Extensions;

    /// <summary>Managed Service Identity.</summary>
    public partial class ResourceForUpdateIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IResourceForUpdateIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IResourceForUpdateIdentityInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentity"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentity __managedServiceIdentity = new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.ManagedServiceIdentity();

        /// <summary>Internal Acessors for PrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal.PrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal)__managedServiceIdentity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal)__managedServiceIdentity).PrincipalId = value ?? null; }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal.TenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal)__managedServiceIdentity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal)__managedServiceIdentity).TenantId = value ?? null; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Inherited)]
        public string PrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal)__managedServiceIdentity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Inherited)]
        public string TenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal)__managedServiceIdentity).TenantId; }

        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal)__managedServiceIdentity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal)__managedServiceIdentity).Type = value ; }

        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IUserAssignedIdentities UserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal)__managedServiceIdentity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal)__managedServiceIdentity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Creates an new <see cref="ResourceForUpdateIdentity" /> instance.</summary>
        public ResourceForUpdateIdentity()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__managedServiceIdentity), __managedServiceIdentity);
            await eventListener.AssertObjectIsValid(nameof(__managedServiceIdentity), __managedServiceIdentity);
        }
    }
    /// Managed Service Identity.
    public partial interface IResourceForUpdateIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentity
    {

    }
    /// Managed Service Identity.
    internal partial interface IResourceForUpdateIdentityInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IManagedServiceIdentityInternal
    {

    }
}