// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{
    using System.Linq;

    /// <summary>
    /// Describes the partition scheme of a singleton-partitioned, or
    /// non-partitioned service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Singleton")]
    public partial class SingletonPartitionScheme : Partition
    {
        /// <summary>
        /// Initializes a new instance of the SingletonPartitionScheme class.
        /// </summary>
        public SingletonPartitionScheme()
        {
            CustomInit();
        }


        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}