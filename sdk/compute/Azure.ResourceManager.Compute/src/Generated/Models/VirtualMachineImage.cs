// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a Virtual Machine Image. </summary>
    public partial class VirtualMachineImage : VirtualMachineImageBase
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineImage"/>. </summary>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="location"> The supported Azure location of the resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public VirtualMachineImage(string name, AzureLocation location) : base(name, location)
        {
            Argument.AssertNotNull(name, nameof(name));

            DataDiskImages = new ChangeTrackingList<DataDiskImage>();
            Features = new ChangeTrackingList<VirtualMachineImageFeature>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineImage"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="location"> The supported Azure location of the resource. </param>
        /// <param name="tags"> Specifies the tags that are assigned to the virtual machine. For more information about using tags, see [Using tags to organize your Azure resources](https://docs.microsoft.com/azure/azure-resource-manager/resource-group-using-tags.md). </param>
        /// <param name="extendedLocation"> The extended location of the Virtual Machine. </param>
        /// <param name="plan"> Used for establishing the purchase context of any 3rd Party artifact through MarketPlace. </param>
        /// <param name="osDiskImage"> Contains the os disk image information. </param>
        /// <param name="dataDiskImages"> The list of data disk images information. </param>
        /// <param name="automaticOSUpgradeProperties"> Describes automatic OS upgrade properties on the image. </param>
        /// <param name="hyperVGeneration"> Specifies the HyperVGeneration Type. </param>
        /// <param name="disallowed"> Specifies disallowed configuration for the VirtualMachine created from the image. </param>
        /// <param name="features"></param>
        /// <param name="architecture"> Specifies the Architecture Type. </param>
        /// <param name="imageDeprecationStatus"> Describes image deprecation status properties on the image. </param>
        internal VirtualMachineImage(ResourceIdentifier id, string name, AzureLocation location, IDictionary<string, string> tags, ExtendedLocation extendedLocation, PurchasePlan plan, OSDiskImage osDiskImage, IList<DataDiskImage> dataDiskImages, AutomaticOSUpgradeProperties automaticOSUpgradeProperties, HyperVGeneration? hyperVGeneration, DisallowedConfiguration disallowed, IList<VirtualMachineImageFeature> features, ArchitectureType? architecture, ImageDeprecationStatus imageDeprecationStatus) : base(id, name, location, tags, extendedLocation)
        {
            Plan = plan;
            OSDiskImage = osDiskImage;
            DataDiskImages = dataDiskImages;
            AutomaticOSUpgradeProperties = automaticOSUpgradeProperties;
            HyperVGeneration = hyperVGeneration;
            Disallowed = disallowed;
            Features = features;
            Architecture = architecture;
            ImageDeprecationStatus = imageDeprecationStatus;
        }

        /// <summary> Used for establishing the purchase context of any 3rd Party artifact through MarketPlace. </summary>
        public PurchasePlan Plan { get; set; }
        /// <summary> Contains the os disk image information. </summary>
        internal OSDiskImage OSDiskImage { get; set; }
        /// <summary> The operating system of the osDiskImage. </summary>
        public SupportedOperatingSystemType? OSDiskImageOperatingSystem
        {
            get => OSDiskImage is null ? default(SupportedOperatingSystemType?) : OSDiskImage.OperatingSystem;
            set
            {
                OSDiskImage = value.HasValue ? new OSDiskImage(value.Value) : null;
            }
        }

        /// <summary> The list of data disk images information. </summary>
        public IList<DataDiskImage> DataDiskImages { get; }
        /// <summary> Describes automatic OS upgrade properties on the image. </summary>
        internal AutomaticOSUpgradeProperties AutomaticOSUpgradeProperties { get; set; }
        /// <summary> Specifies whether automatic OS upgrade is supported on the image. </summary>
        public bool? AutomaticOSUpgradeSupported
        {
            get => AutomaticOSUpgradeProperties is null ? default(bool?) : AutomaticOSUpgradeProperties.AutomaticOSUpgradeSupported;
            set
            {
                AutomaticOSUpgradeProperties = value.HasValue ? new AutomaticOSUpgradeProperties(value.Value) : null;
            }
        }

        /// <summary> Specifies the HyperVGeneration Type. </summary>
        public HyperVGeneration? HyperVGeneration { get; set; }
        /// <summary> Specifies disallowed configuration for the VirtualMachine created from the image. </summary>
        internal DisallowedConfiguration Disallowed { get; set; }
        /// <summary> VM disk types which are disallowed. </summary>
        public VirtualMachineDiskType? DisallowedVmDiskType
        {
            get => Disallowed is null ? default : Disallowed.VmDiskType;
            set
            {
                if (Disallowed is null)
                    Disallowed = new DisallowedConfiguration();
                Disallowed.VmDiskType = value;
            }
        }

        /// <summary> Gets the features. </summary>
        public IList<VirtualMachineImageFeature> Features { get; }
        /// <summary> Specifies the Architecture Type. </summary>
        public ArchitectureType? Architecture { get; set; }
        /// <summary> Describes image deprecation status properties on the image. </summary>
        public ImageDeprecationStatus ImageDeprecationStatus { get; set; }
    }
}
