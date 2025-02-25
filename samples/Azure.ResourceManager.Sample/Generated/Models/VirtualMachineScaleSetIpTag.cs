// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary>
    /// Contains the IP tag associated with the public IP address.
    /// Serialized Name: VirtualMachineScaleSetIpTag
    /// </summary>
    public partial class VirtualMachineScaleSetIpTag
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetIpTag. </summary>
        public VirtualMachineScaleSetIpTag()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetIpTag. </summary>
        /// <param name="ipTagType">
        /// IP tag type. Example: FirstPartyUsage.
        /// Serialized Name: VirtualMachineScaleSetIpTag.ipTagType
        /// </param>
        /// <param name="tag">
        /// IP tag associated with the public IP. Example: SQL, Storage etc.
        /// Serialized Name: VirtualMachineScaleSetIpTag.tag
        /// </param>
        internal VirtualMachineScaleSetIpTag(string ipTagType, string tag)
        {
            IpTagType = ipTagType;
            Tag = tag;
        }

        /// <summary>
        /// IP tag type. Example: FirstPartyUsage.
        /// Serialized Name: VirtualMachineScaleSetIpTag.ipTagType
        /// </summary>
        public string IpTagType { get; set; }
        /// <summary>
        /// IP tag associated with the public IP. Example: SQL, Storage etc.
        /// Serialized Name: VirtualMachineScaleSetIpTag.tag
        /// </summary>
        public string Tag { get; set; }
    }
}
