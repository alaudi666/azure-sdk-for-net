// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> The UnknownDigitalTwinsEndpointResourceProperties. </summary>
    internal partial class UnknownDigitalTwinsEndpointResourceProperties : DigitalTwinsEndpointResourceProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownDigitalTwinsEndpointResourceProperties"/>. </summary>
        /// <param name="endpointType"> The type of Digital Twins endpoint. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="createdOn"> Time when the Endpoint was added to DigitalTwinsInstance. </param>
        /// <param name="authenticationType"> Specifies the authentication type being used for connecting to the endpoint. Defaults to 'KeyBased'. If 'KeyBased' is selected, a connection string must be specified (at least the primary connection string). If 'IdentityBased' is select, the endpointUri and entityPath properties must be specified. </param>
        /// <param name="deadLetterSecret"> Dead letter storage secret for key-based authentication. Will be obfuscated during read. </param>
        /// <param name="deadLetterUri"> Dead letter storage URL for identity-based authentication. </param>
        /// <param name="identity"> Managed identity properties for the endpoint. </param>
        internal UnknownDigitalTwinsEndpointResourceProperties(EndpointType endpointType, DigitalTwinsEndpointProvisioningState? provisioningState, DateTimeOffset? createdOn, DigitalTwinsAuthenticationType? authenticationType, string deadLetterSecret, Uri deadLetterUri, DigitalTwinsManagedIdentityReference identity) : base(endpointType, provisioningState, createdOn, authenticationType, deadLetterSecret, deadLetterUri, identity)
        {
            EndpointType = endpointType;
        }
    }
}
