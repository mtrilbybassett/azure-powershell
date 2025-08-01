// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{
    using System.Linq;

    /// <summary>
    /// User assigned identity for the application.
    /// </summary>
    public partial class ApplicationUserAssignedIdentity
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationUserAssignedIdentity class.
        /// </summary>
        public ApplicationUserAssignedIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationUserAssignedIdentity class.
        /// </summary>

        /// <param name="name">The friendly name of user assigned identity.
        /// </param>

        /// <param name="principalId">The principal id of user assigned identity.
        /// </param>
        public ApplicationUserAssignedIdentity(string name, string principalId)

        {
            this.Name = name;
            this.PrincipalId = principalId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the friendly name of user assigned identity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets or sets the principal id of user assigned identity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "principalId")]
        public string PrincipalId {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
            if (this.PrincipalId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "PrincipalId");
            }


        }
    }
}