// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtRenameRules.Models
{
    /// <summary> The instance view of a virtual machine extension handler. </summary>
    public partial class VirtualMachineExtensionHandlerInstanceView
    {
        /// <summary> Initializes a new instance of VirtualMachineExtensionHandlerInstanceView. </summary>
        internal VirtualMachineExtensionHandlerInstanceView()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineExtensionHandlerInstanceView. </summary>
        /// <param name="virtualMachineExtensionHandlerInstanceViewType"> Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;. </param>
        /// <param name="typeHandlerVersion"> Specifies the version of the script handler. </param>
        /// <param name="status"> The extension handler status. </param>
        internal VirtualMachineExtensionHandlerInstanceView(string virtualMachineExtensionHandlerInstanceViewType, string typeHandlerVersion, InstanceViewStatus status)
        {
            VirtualMachineExtensionHandlerInstanceViewType = virtualMachineExtensionHandlerInstanceViewType;
            TypeHandlerVersion = typeHandlerVersion;
            Status = status;
        }

        /// <summary> Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;. </summary>
        public string VirtualMachineExtensionHandlerInstanceViewType { get; }
        /// <summary> Specifies the version of the script handler. </summary>
        public string TypeHandlerVersion { get; }
        /// <summary> The extension handler status. </summary>
        public InstanceViewStatus Status { get; }
    }
}
