// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtRenameRules.Models
{
    /// <summary> Specifies additional XML formatted information that can be included in the Unattend.xml file, which is used by Windows Setup. Contents are defined by setting name, component name, and the pass in which the content is applied. </summary>
    public partial class AdditionalUnattendContent
    {
        /// <summary> Initializes a new instance of AdditionalUnattendContent. </summary>
        public AdditionalUnattendContent()
        {
        }

        /// <summary> Initializes a new instance of AdditionalUnattendContent. </summary>
        /// <param name="passName"> The pass name. Currently, the only allowable value is OobeSystem. </param>
        /// <param name="componentName"> The component name. Currently, the only allowable value is Microsoft-Windows-Shell-Setup. </param>
        /// <param name="settingName"> Specifies the name of the setting to which the content applies. Possible values are: FirstLogonCommands and AutoLogon. </param>
        /// <param name="content"> Specifies the XML formatted content that is added to the unattend.xml file for the specified path and component. The XML must be less than 4KB and must include the root element for the setting or feature that is being inserted. </param>
        internal AdditionalUnattendContent(PassName? passName, ComponentName? componentName, SettingName? settingName, string content)
        {
            PassName = passName;
            ComponentName = componentName;
            SettingName = settingName;
            Content = content;
        }

        /// <summary> The pass name. Currently, the only allowable value is OobeSystem. </summary>
        public PassName? PassName { get; set; }
        /// <summary> The component name. Currently, the only allowable value is Microsoft-Windows-Shell-Setup. </summary>
        public ComponentName? ComponentName { get; set; }
        /// <summary> Specifies the name of the setting to which the content applies. Possible values are: FirstLogonCommands and AutoLogon. </summary>
        public SettingName? SettingName { get; set; }
        /// <summary> Specifies the XML formatted content that is added to the unattend.xml file for the specified path and component. The XML must be less than 4KB and must include the root element for the setting or feature that is being inserted. </summary>
        public string Content { get; set; }
    }
}
