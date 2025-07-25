// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{
    using System.Linq;

    /// <summary>
    /// The application resource.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ApplicationResource : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationResource class.
        /// </summary>
        public ApplicationResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationResource class.
        /// </summary>

        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </param>

        /// <param name="name">The name of the resource
        /// </param>

        /// <param name="type">The type of the resource. E.g. &#34;Microsoft.Compute/virtualMachines&#34; or
        /// &#34;Microsoft.Storage/storageAccounts&#34;
        /// </param>

        /// <param name="systemData">Azure Resource Manager metadata containing createdBy and modifiedBy
        /// information.
        /// </param>

        /// <param name="tags">Resource tags.
        /// </param>

        /// <param name="identity">Describes the managed identities for an Azure resource.
        /// </param>

        /// <param name="location">The geo-location where the resource lives
        /// </param>

        /// <param name="managedIdentities">List of user assigned identities for the application, each mapped to a
        /// friendly name.
        /// </param>

        /// <param name="provisioningState">The current deployment or provisioning state, which only appears in the
        /// response
        /// </param>

        /// <param name="version">The version of the application type as defined in the application manifest.
        /// This name must be the full Arm Resource ID for the referenced application
        /// type version.
        /// </param>

        /// <param name="parameters">List of application parameters with overridden values from their default
        /// values specified in the application manifest.
        /// </param>

        /// <param name="upgradePolicy">Describes the policy for a monitored application upgrade.
        /// </param>
        public ApplicationResource(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), ManagedIdentity identity = default(ManagedIdentity), string location = default(string), System.Collections.Generic.IList<ApplicationUserAssignedIdentity> managedIdentities = default(System.Collections.Generic.IList<ApplicationUserAssignedIdentity>), string provisioningState = default(string), string version = default(string), System.Collections.Generic.IDictionary<string, string> parameters = default(System.Collections.Generic.IDictionary<string, string>), ApplicationUpgradePolicy upgradePolicy = default(ApplicationUpgradePolicy))

        : base(id, name, type, systemData)
        {
            this.Tags = tags;
            this.Identity = identity;
            this.Location = location;
            this.ManagedIdentities = managedIdentities;
            this.ProvisioningState = provisioningState;
            this.Version = version;
            this.Parameters = parameters;
            this.UpgradePolicy = upgradePolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags {get; set; }

        /// <summary>
        /// Gets or sets describes the managed identities for an Azure resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "identity")]
        public ManagedIdentity Identity {get; set; }

        /// <summary>
        /// Gets or sets the geo-location where the resource lives
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location {get; set; }

        /// <summary>
        /// Gets or sets list of user assigned identities for the application, each
        /// mapped to a friendly name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.managedIdentities")]
        public System.Collections.Generic.IList<ApplicationUserAssignedIdentity> ManagedIdentities {get; set; }

        /// <summary>
        /// Gets the current deployment or provisioning state, which only appears in
        /// the response
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets or sets the version of the application type as defined in the
        /// application manifest.
        /// This name must be the full Arm Resource ID for the referenced application
        /// type version.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.version")]
        public string Version {get; set; }

        /// <summary>
        /// Gets or sets list of application parameters with overridden values from
        /// their default values specified in the application manifest.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.parameters")]
        public System.Collections.Generic.IDictionary<string, string> Parameters {get; set; }

        /// <summary>
        /// Gets or sets describes the policy for a monitored application upgrade.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.upgradePolicy")]
        public ApplicationUpgradePolicy UpgradePolicy {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {



            if (this.ManagedIdentities != null)
            {
                foreach (var element in this.ManagedIdentities)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }



            if (this.UpgradePolicy != null)
            {
                this.UpgradePolicy.Validate();
            }
        }
    }
}