// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The check availability request body. </summary>
    public partial class CheckCosmosDBNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of <see cref="CheckCosmosDBNameAvailabilityContent"/>. </summary>
        public CheckCosmosDBNameAvailabilityContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CheckCosmosDBNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The name of the resource for which availability needs to be checked. </param>
        /// <param name="resourceType"> The resource type. </param>
        internal CheckCosmosDBNameAvailabilityContent(string name, string resourceType)
        {
            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> The name of the resource for which availability needs to be checked. </summary>
        public string Name { get; set; }
        /// <summary> The resource type. </summary>
        public string ResourceType { get; set; }
    }
}
