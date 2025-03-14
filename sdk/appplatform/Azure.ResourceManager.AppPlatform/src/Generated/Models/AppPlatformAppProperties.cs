// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> App resource properties payload. </summary>
    public partial class AppPlatformAppProperties
    {
        /// <summary> Initializes a new instance of <see cref="AppPlatformAppProperties"/>. </summary>
        public AppPlatformAppProperties()
        {
            AddonConfigs = new ChangeTrackingDictionary<string, IDictionary<string, BinaryData>>();
            CustomPersistentDisks = new ChangeTrackingList<AppCustomPersistentDisk>();
            LoadedCertificates = new ChangeTrackingList<AppLoadedCertificate>();
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformAppProperties"/>. </summary>
        /// <param name="isPublic"> Indicates whether the App exposes public endpoint. </param>
        /// <param name="uriString"> URL of the App. </param>
        /// <param name="addonConfigs"> Collection of addons. </param>
        /// <param name="provisioningState"> Provisioning state of the App. </param>
        /// <param name="fqdn"> Fully qualified dns Name. </param>
        /// <param name="isHttpsOnly"> Indicate if only https is allowed. </param>
        /// <param name="temporaryDisk"> Temporary disk settings. </param>
        /// <param name="persistentDisk"> Persistent disk settings. </param>
        /// <param name="customPersistentDisks"> List of custom persistent disks. </param>
        /// <param name="isEndToEndTlsEnabled"> Indicate if end to end TLS is enabled. </param>
        /// <param name="loadedCertificates"> Collection of loaded certificates. </param>
        /// <param name="vnetAddons"> Additional App settings in vnet injection instance. </param>
        /// <param name="ingressSettings"> App ingress settings payload. </param>
        internal AppPlatformAppProperties(bool? isPublic, string uriString, IDictionary<string, IDictionary<string, BinaryData>> addonConfigs, AppPlatformAppProvisioningState? provisioningState, string fqdn, bool? isHttpsOnly, AppTemporaryDisk temporaryDisk, AppPersistentDisk persistentDisk, IList<AppCustomPersistentDisk> customPersistentDisks, bool? isEndToEndTlsEnabled, IList<AppLoadedCertificate> loadedCertificates, AppVnetAddons vnetAddons, AppIngressSettings ingressSettings)
        {
            IsPublic = isPublic;
            UriString = uriString;
            AddonConfigs = addonConfigs;
            ProvisioningState = provisioningState;
            Fqdn = fqdn;
            IsHttpsOnly = isHttpsOnly;
            TemporaryDisk = temporaryDisk;
            PersistentDisk = persistentDisk;
            CustomPersistentDisks = customPersistentDisks;
            IsEndToEndTlsEnabled = isEndToEndTlsEnabled;
            LoadedCertificates = loadedCertificates;
            VnetAddons = vnetAddons;
            IngressSettings = ingressSettings;
        }

        /// <summary> Indicates whether the App exposes public endpoint. </summary>
        public bool? IsPublic { get; set; }
        /// <summary> URL of the App. </summary>
        public string UriString { get; }
        /// <summary> Collection of addons. </summary>
        public IDictionary<string, IDictionary<string, BinaryData>> AddonConfigs { get; }
        /// <summary> Provisioning state of the App. </summary>
        public AppPlatformAppProvisioningState? ProvisioningState { get; }
        /// <summary> Fully qualified dns Name. </summary>
        public string Fqdn { get; }
        /// <summary> Indicate if only https is allowed. </summary>
        public bool? IsHttpsOnly { get; set; }
        /// <summary> Temporary disk settings. </summary>
        public AppTemporaryDisk TemporaryDisk { get; set; }
        /// <summary> Persistent disk settings. </summary>
        public AppPersistentDisk PersistentDisk { get; set; }
        /// <summary> List of custom persistent disks. </summary>
        public IList<AppCustomPersistentDisk> CustomPersistentDisks { get; }
        /// <summary> Indicate if end to end TLS is enabled. </summary>
        public bool? IsEndToEndTlsEnabled { get; set; }
        /// <summary> Collection of loaded certificates. </summary>
        public IList<AppLoadedCertificate> LoadedCertificates { get; }
        /// <summary> Additional App settings in vnet injection instance. </summary>
        public AppVnetAddons VnetAddons { get; set; }
        /// <summary> App ingress settings payload. </summary>
        public AppIngressSettings IngressSettings { get; set; }
    }
}
