﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Management.ServiceFabricManagedClusters.Models;

namespace Microsoft.Azure.Commands.ServiceFabric.Models
{
    public class PSManagedNodeType : NodeType
    {
        public PSManagedNodeType(NodeType nodeType)
            : base(id: nodeType.Id,
                   name: nodeType.Name,
                   type: nodeType.Type,
                   tags: nodeType.Tags,
                   isPrimary: nodeType.IsPrimary,
                   vmInstanceCount: nodeType.VMInstanceCount,
                   dataDiskSizeGb: nodeType.DataDiskSizeGb,
                   dataDiskType: nodeType.DataDiskType,
                   provisioningState: nodeType.ProvisioningState,
                   placementProperties: nodeType.PlacementProperties,
                   capacities: nodeType.Capacities,
                   applicationPorts: nodeType.ApplicationPorts,
                   ephemeralPorts: nodeType.EphemeralPorts,
                   vmSize: nodeType.VMSize,
                   vmImagePublisher: nodeType.VMImagePublisher,
                   vmImageOffer: nodeType.VMImageOffer,
                   vmImageSku: nodeType.VMImageSku,
                   vmImageVersion: nodeType.VMImageVersion,
                   vmSecrets: nodeType.VMSecrets,
                   vmExtensions: nodeType.VMExtensions,
                   vmManagedIdentity: nodeType.VMManagedIdentity,
                   isStateless: nodeType.IsStateless,
                   multiplePlacementGroups: nodeType.MultiplePlacementGroups,
                   vmSharedGalleryImageId: nodeType.VMSharedGalleryImageId,
                   securityType: nodeType.SecurityType,
                   secureBootEnabled: nodeType.SecureBootEnabled,
                   enableNodePublicIP: nodeType.EnableNodePublicIP,
                   natGatewayId: nodeType.NatGatewayId,
                   vmImagePlan: nodeType.VMImagePlan)
        {
        }
    }
}
