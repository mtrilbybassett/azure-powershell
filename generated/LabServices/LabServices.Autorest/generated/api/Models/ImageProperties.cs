// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Extensions;

    /// <summary>Properties of an image resource.</summary>
    public partial class ImageProperties :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImageProperties,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImagePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImageUpdateProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImageUpdateProperties __imageUpdateProperties = new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ImageUpdateProperties();

        /// <summary>Backing field for <see cref="Author" /> property.</summary>
        private string _author;

        /// <summary>The image author.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string Author { get => this._author; }

        /// <summary>Backing field for <see cref="AvailableRegion" /> property.</summary>
        private System.Collections.Generic.List<string> _availableRegion;

        /// <summary>The available regions of the image in the shared gallery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> AvailableRegion { get => this._availableRegion; set => this._availableRegion = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>A description of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string Description { get => this._description; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The image display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; }

        /// <summary>Is the image enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inherited)]
        public string EnabledState { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImageUpdatePropertiesInternal)__imageUpdateProperties).EnabledState; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImageUpdatePropertiesInternal)__imageUpdateProperties).EnabledState = value ?? null; }

        /// <summary>Backing field for <see cref="IconUrl" /> property.</summary>
        private string _iconUrl;

        /// <summary>URL of the image icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string IconUrl { get => this._iconUrl; }

        /// <summary>Internal Acessors for Author</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImagePropertiesInternal.Author { get => this._author; set { {_author = value;} } }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImagePropertiesInternal.Description { get => this._description; set { {_description = value;} } }

        /// <summary>Internal Acessors for DisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImagePropertiesInternal.DisplayName { get => this._displayName; set { {_displayName = value;} } }

        /// <summary>Internal Acessors for IconUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImagePropertiesInternal.IconUrl { get => this._iconUrl; set { {_iconUrl = value;} } }

        /// <summary>Internal Acessors for OSState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImagePropertiesInternal.OSState { get => this._oSState; set { {_oSState = value;} } }

        /// <summary>Internal Acessors for OSType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImagePropertiesInternal.OSType { get => this._oSType; set { {_oSType = value;} } }

        /// <summary>Internal Acessors for Offer</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImagePropertiesInternal.Offer { get => this._offer; set { {_offer = value;} } }

        /// <summary>Internal Acessors for Plan</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImagePropertiesInternal.Plan { get => this._plan; set { {_plan = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImagePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Publisher</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImagePropertiesInternal.Publisher { get => this._publisher; set { {_publisher = value;} } }

        /// <summary>Internal Acessors for SharedGalleryId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImagePropertiesInternal.SharedGalleryId { get => this._sharedGalleryId; set { {_sharedGalleryId = value;} } }

        /// <summary>Internal Acessors for Sku</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImagePropertiesInternal.Sku { get => this._sku; set { {_sku = value;} } }

        /// <summary>Internal Acessors for TermsStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImagePropertiesInternal.TermsStatus { get => this._termsStatus; set { {_termsStatus = value;} } }

        /// <summary>Internal Acessors for Version</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImagePropertiesInternal.Version { get => this._version; set { {_version = value;} } }

        /// <summary>Backing field for <see cref="OSState" /> property.</summary>
        private string _oSState;

        /// <summary>The OS State of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string OSState { get => this._oSState; }

        /// <summary>Backing field for <see cref="OSType" /> property.</summary>
        private string _oSType;

        /// <summary>The OS Type of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string OSType { get => this._oSType; }

        /// <summary>Backing field for <see cref="Offer" /> property.</summary>
        private string _offer;

        /// <summary>The ID of an offer associated with the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string Offer { get => this._offer; }

        /// <summary>Backing field for <see cref="Plan" /> property.</summary>
        private string _plan;

        /// <summary>The ID of marketplace plan associated with the image (optional).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string Plan { get => this._plan; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Current provisioning state of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Publisher" /> property.</summary>
        private string _publisher;

        /// <summary>The ID of the publisher of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string Publisher { get => this._publisher; }

        /// <summary>Backing field for <see cref="SharedGalleryId" /> property.</summary>
        private string _sharedGalleryId;

        /// <summary>The ID for the image in the shared gallery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string SharedGalleryId { get => this._sharedGalleryId; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private string _sku;

        /// <summary>The image SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string Sku { get => this._sku; }

        /// <summary>Backing field for <see cref="TermsStatus" /> property.</summary>
        private string _termsStatus;

        /// <summary>The status of image terms of use (enabled = accepted, disabled = not accepted).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string TermsStatus { get => this._termsStatus; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>The image version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string Version { get => this._version; }

        /// <summary>Creates an new <see cref="ImageProperties" /> instance.</summary>
        public ImageProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__imageUpdateProperties), __imageUpdateProperties);
            await eventListener.AssertObjectIsValid(nameof(__imageUpdateProperties), __imageUpdateProperties);
        }
    }
    /// Properties of an image resource.
    public partial interface IImageProperties :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImageUpdateProperties
    {
        /// <summary>The image author.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The image author.",
        SerializedName = @"author",
        PossibleTypes = new [] { typeof(string) })]
        string Author { get;  }
        /// <summary>The available regions of the image in the shared gallery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The available regions of the image in the shared gallery.",
        SerializedName = @"availableRegions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AvailableRegion { get; set; }
        /// <summary>A description of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A description of the image.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>The image display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The image display name.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get;  }
        /// <summary>URL of the image icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"URL of the image icon.",
        SerializedName = @"iconUrl",
        PossibleTypes = new [] { typeof(string) })]
        string IconUrl { get;  }
        /// <summary>The OS State of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The OS State of the image.",
        SerializedName = @"osState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Generalized", "Specialized")]
        string OSState { get;  }
        /// <summary>The OS Type of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The OS Type of the image.",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Windows", "Linux")]
        string OSType { get;  }
        /// <summary>The ID of an offer associated with the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The ID of an offer associated with the image.",
        SerializedName = @"offer",
        PossibleTypes = new [] { typeof(string) })]
        string Offer { get;  }
        /// <summary>The ID of marketplace plan associated with the image (optional).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The ID of marketplace plan associated with the image (optional).",
        SerializedName = @"plan",
        PossibleTypes = new [] { typeof(string) })]
        string Plan { get;  }
        /// <summary>Current provisioning state of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Current provisioning state of the image.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Creating", "Updating", "Deleting", "Succeeded", "Failed", "Locked")]
        string ProvisioningState { get;  }
        /// <summary>The ID of the publisher of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The ID of the publisher of the image.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string Publisher { get;  }
        /// <summary>The ID for the image in the shared gallery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The ID for the image in the shared gallery.",
        SerializedName = @"sharedGalleryId",
        PossibleTypes = new [] { typeof(string) })]
        string SharedGalleryId { get;  }
        /// <summary>The image SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The image SKU.",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(string) })]
        string Sku { get;  }
        /// <summary>The status of image terms of use (enabled = accepted, disabled = not accepted).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of image terms of use (enabled = accepted, disabled = not accepted).",
        SerializedName = @"termsStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string TermsStatus { get;  }
        /// <summary>The image version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The image version.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get;  }

    }
    /// Properties of an image resource.
    internal partial interface IImagePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImageUpdatePropertiesInternal
    {
        /// <summary>The image author.</summary>
        string Author { get; set; }
        /// <summary>The available regions of the image in the shared gallery.</summary>
        System.Collections.Generic.List<string> AvailableRegion { get; set; }
        /// <summary>A description of the image.</summary>
        string Description { get; set; }
        /// <summary>The image display name.</summary>
        string DisplayName { get; set; }
        /// <summary>URL of the image icon.</summary>
        string IconUrl { get; set; }
        /// <summary>The OS State of the image.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Generalized", "Specialized")]
        string OSState { get; set; }
        /// <summary>The OS Type of the image.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Windows", "Linux")]
        string OSType { get; set; }
        /// <summary>The ID of an offer associated with the image.</summary>
        string Offer { get; set; }
        /// <summary>The ID of marketplace plan associated with the image (optional).</summary>
        string Plan { get; set; }
        /// <summary>Current provisioning state of the image.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Creating", "Updating", "Deleting", "Succeeded", "Failed", "Locked")]
        string ProvisioningState { get; set; }
        /// <summary>The ID of the publisher of the image.</summary>
        string Publisher { get; set; }
        /// <summary>The ID for the image in the shared gallery.</summary>
        string SharedGalleryId { get; set; }
        /// <summary>The image SKU.</summary>
        string Sku { get; set; }
        /// <summary>The status of image terms of use (enabled = accepted, disabled = not accepted).</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.LabServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string TermsStatus { get; set; }
        /// <summary>The image version.</summary>
        string Version { get; set; }

    }
}