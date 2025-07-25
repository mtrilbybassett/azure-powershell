// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.NetApp.Models
{
    using System.Linq;

    /// <summary>
    /// Replication properties
    /// </summary>
    public partial class ReplicationObject
    {
        /// <summary>
        /// Initializes a new instance of the ReplicationObject class.
        /// </summary>
        public ReplicationObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReplicationObject class.
        /// </summary>

        /// <param name="replicationId">Id
        /// </param>

        /// <param name="endpointType">Indicates whether the local volume is the source or destination for the
        /// Volume Replication
        /// Possible values include: &#39;src&#39;, &#39;dst&#39;</param>

        /// <param name="replicationSchedule">Schedule
        /// Possible values include: &#39;_10minutely&#39;, &#39;hourly&#39;, &#39;daily&#39;</param>

        /// <param name="remoteVolumeResourceId">The resource ID of the remote volume. Required for cross region and cross
        /// zone replication
        /// </param>

        /// <param name="remotePath">The full path to a volume that is to be migrated into ANF. Required for
        /// Migration volumes
        /// </param>

        /// <param name="remoteVolumeRegion">The remote region for the other end of the Volume Replication.
        /// </param>

        /// <param name="destinationReplications">A list of destination replications
        /// </param>
        public ReplicationObject(string replicationId = default(string), string endpointType = default(string), string replicationSchedule = default(string), string remoteVolumeResourceId = default(string), RemotePath remotePath = default(RemotePath), string remoteVolumeRegion = default(string), System.Collections.Generic.IList<DestinationReplication> destinationReplications = default(System.Collections.Generic.IList<DestinationReplication>))

        {
            this.ReplicationId = replicationId;
            this.EndpointType = endpointType;
            this.ReplicationSchedule = replicationSchedule;
            this.RemoteVolumeResourceId = remoteVolumeResourceId;
            this.RemotePath = remotePath;
            this.RemoteVolumeRegion = remoteVolumeRegion;
            this.DestinationReplications = destinationReplications;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets id
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "replicationId")]
        public string ReplicationId {get; private set; }

        /// <summary>
        /// Gets indicates whether the local volume is the source or destination for
        /// the Volume Replication Possible values include: &#39;src&#39;, &#39;dst&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endpointType")]
        public string EndpointType {get; private set; }

        /// <summary>
        /// Gets or sets schedule Possible values include: &#39;_10minutely&#39;, &#39;hourly&#39;, &#39;daily&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "replicationSchedule")]
        public string ReplicationSchedule {get; set; }

        /// <summary>
        /// Gets or sets the resource ID of the remote volume. Required for cross
        /// region and cross zone replication
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "remoteVolumeResourceId")]
        public string RemoteVolumeResourceId {get; set; }

        /// <summary>
        /// Gets or sets the full path to a volume that is to be migrated into ANF.
        /// Required for Migration volumes
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "remotePath")]
        public RemotePath RemotePath {get; set; }

        /// <summary>
        /// Gets or sets the remote region for the other end of the Volume Replication.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "remoteVolumeRegion")]
        public string RemoteVolumeRegion {get; set; }

        /// <summary>
        /// Gets a list of destination replications
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "destinationReplications")]
        public System.Collections.Generic.IList<DestinationReplication> DestinationReplications {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {




            if (this.RemotePath != null)
            {
                this.RemotePath.Validate();
            }


        }
    }
}