// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The configuration settings of the custom Open ID Connect provider. </summary>
    public partial class ContainerAppCustomOpenIdConnectProviderConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="ContainerAppCustomOpenIdConnectProviderConfiguration"/>. </summary>
        public ContainerAppCustomOpenIdConnectProviderConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppCustomOpenIdConnectProviderConfiguration"/>. </summary>
        /// <param name="isEnabled"> &lt;code&gt;false&lt;/code&gt; if the custom Open ID provider provider should not be enabled; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="registration"> The configuration settings of the app registration for the custom Open ID Connect provider. </param>
        /// <param name="login"> The configuration settings of the login flow of the custom Open ID Connect provider. </param>
        internal ContainerAppCustomOpenIdConnectProviderConfiguration(bool? isEnabled, ContainerAppOpenIdConnectRegistration registration, ContainerAppOpenIdConnectLogin login)
        {
            IsEnabled = isEnabled;
            Registration = registration;
            Login = login;
        }

        /// <summary> &lt;code&gt;false&lt;/code&gt; if the custom Open ID provider provider should not be enabled; otherwise, &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The configuration settings of the app registration for the custom Open ID Connect provider. </summary>
        public ContainerAppOpenIdConnectRegistration Registration { get; set; }
        /// <summary> The configuration settings of the login flow of the custom Open ID Connect provider. </summary>
        public ContainerAppOpenIdConnectLogin Login { get; set; }
    }
}
