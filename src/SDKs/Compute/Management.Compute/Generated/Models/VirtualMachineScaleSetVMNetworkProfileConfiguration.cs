// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a virtual machine scale set VM network profile.
    /// </summary>
    public partial class VirtualMachineScaleSetVMNetworkProfileConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMNetworkProfileConfiguration class.
        /// </summary>
        public VirtualMachineScaleSetVMNetworkProfileConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMNetworkProfileConfiguration class.
        /// </summary>
        /// <param name="networkInterfaceConfigurations">The list of network
        /// configurations.</param>
        public VirtualMachineScaleSetVMNetworkProfileConfiguration(IList<VirtualMachineScaleSetNetworkConfiguration> networkInterfaceConfigurations = default(IList<VirtualMachineScaleSetNetworkConfiguration>))
        {
            NetworkInterfaceConfigurations = networkInterfaceConfigurations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of network configurations.
        /// </summary>
        [JsonProperty(PropertyName = "networkInterfaceConfigurations")]
        public IList<VirtualMachineScaleSetNetworkConfiguration> NetworkInterfaceConfigurations { get; set; }

    }
}