// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> RackSkuList represents a list of rack SKUs. </summary>
    internal partial class RackSkuList
    {
        /// <summary> Initializes a new instance of <see cref="RackSkuList"/>. </summary>
        internal RackSkuList()
        {
            Value = new ChangeTrackingList<NetworkCloudRackSkuData>();
        }

        /// <summary> Initializes a new instance of <see cref="RackSkuList"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="value"> The list of Rack SKUs. </param>
        internal RackSkuList(string nextLink, IReadOnlyList<NetworkCloudRackSkuData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
        /// <summary> The list of Rack SKUs. </summary>
        public IReadOnlyList<NetworkCloudRackSkuData> Value { get; }
    }
}
