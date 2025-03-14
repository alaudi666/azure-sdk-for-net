// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> Customer-initiated diagnostic log collection storage properties. </summary>
    public partial class DiagnosticStorageProperties
    {
        /// <summary> Initializes a new instance of <see cref="DiagnosticStorageProperties"/>. </summary>
        /// <param name="authenticationType"> Authentication Type. </param>
        /// <param name="resourceId"> ResourceId of the diagnostic storage account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        public DiagnosticStorageProperties(DiagnosticStorageAuthenticationType authenticationType, ResourceIdentifier resourceId)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));

            AuthenticationType = authenticationType;
            ResourceId = resourceId;
        }

        /// <summary> Initializes a new instance of <see cref="DiagnosticStorageProperties"/>. </summary>
        /// <param name="authenticationType"> Authentication Type. </param>
        /// <param name="connectionString"> ConnectionString of the diagnostic storage account. </param>
        /// <param name="resourceId"> ResourceId of the diagnostic storage account. </param>
        internal DiagnosticStorageProperties(DiagnosticStorageAuthenticationType authenticationType, string connectionString, ResourceIdentifier resourceId)
        {
            AuthenticationType = authenticationType;
            ConnectionString = connectionString;
            ResourceId = resourceId;
        }

        /// <summary> Authentication Type. </summary>
        public DiagnosticStorageAuthenticationType AuthenticationType { get; set; }
        /// <summary> ConnectionString of the diagnostic storage account. </summary>
        public string ConnectionString { get; set; }
        /// <summary> ResourceId of the diagnostic storage account. </summary>
        public ResourceIdentifier ResourceId { get; set; }
    }
}
