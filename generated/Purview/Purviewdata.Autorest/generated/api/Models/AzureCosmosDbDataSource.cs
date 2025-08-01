// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.DoNotFormat]
    public partial class AzureCosmosDbDataSource :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureCosmosDbDataSource,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureCosmosDbDataSourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSource __dataSource = new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.DataSource();

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public string AccountUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureCosmosDbPropertiesInternal)Property).AccountUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureCosmosDbPropertiesInternal)Property).AccountUri = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public global::System.DateTime? CollectionLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourcePropertiesInternal)Property).CollectionLastModifiedAt; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public string CollectionReferenceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourcePropertiesInternal)Property).CollectionReferenceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourcePropertiesInternal)Property).CollectionReferenceName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public string CollectionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourcePropertiesInternal)Property).CollectionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourcePropertiesInternal)Property).CollectionType = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public global::System.DateTime? CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourcePropertiesInternal)Property).CreatedAt; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IProxyResourceInternal)__dataSource).Id; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string Kind { get => "AzureCosmosDb"; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourceInternal)__dataSource).Kind = "AzureCosmosDb"; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourcePropertiesInternal)Property).LastModifiedAt; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureDataSourcePropertiesInternal)Property).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureDataSourcePropertiesInternal)Property).Location = value ?? null; }

        /// <summary>Internal Acessors for Collection</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourcePropertiesCollection Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureCosmosDbDataSourceInternal.Collection { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourcePropertiesInternal)Property).Collection; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourcePropertiesInternal)Property).Collection = value ?? null /* model class */; }

        /// <summary>Internal Acessors for CollectionLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureCosmosDbDataSourceInternal.CollectionLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourcePropertiesInternal)Property).CollectionLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourcePropertiesInternal)Property).CollectionLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for CreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureCosmosDbDataSourceInternal.CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourcePropertiesInternal)Property).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourcePropertiesInternal)Property).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureCosmosDbDataSourceInternal.LastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourcePropertiesInternal)Property).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourcePropertiesInternal)Property).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureCosmosDbDataSourceProperties Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureCosmosDbDataSourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.AzureCosmosDbDataSourceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Scan</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScan> Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourceInternal.Scan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourceInternal)__dataSource).Scan; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourceInternal)__dataSource).Scan = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IProxyResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IProxyResourceInternal)__dataSource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IProxyResourceInternal)__dataSource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IProxyResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IProxyResourceInternal)__dataSource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IProxyResourceInternal)__dataSource).Name = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IProxyResourceInternal)__dataSource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureCosmosDbDataSourceProperties _property;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureCosmosDbDataSourceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.AzureCosmosDbDataSourceProperties()); set => this._property = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public string ResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureDataSourcePropertiesInternal)Property).ResourceGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureDataSourcePropertiesInternal)Property).ResourceGroup = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public string ResourceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureDataSourcePropertiesInternal)Property).ResourceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureDataSourcePropertiesInternal)Property).ResourceName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScan> Scan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourceInternal)__dataSource).Scan; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public string SubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureDataSourcePropertiesInternal)Property).SubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureDataSourcePropertiesInternal)Property).SubscriptionId = value ?? null; }

        /// <summary>Creates an new <see cref="AzureCosmosDbDataSource" /> instance.</summary>
        public AzureCosmosDbDataSource()
        {
            this.__dataSource.Kind = "AzureCosmosDb";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__dataSource), __dataSource);
            await eventListener.AssertObjectIsValid(nameof(__dataSource), __dataSource);
        }
    }
    public partial interface IAzureCosmosDbDataSource :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSource
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"accountUri",
        PossibleTypes = new [] { typeof(string) })]
        string AccountUri { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CollectionLastModifiedAt { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"referenceName",
        PossibleTypes = new [] { typeof(string) })]
        string CollectionReferenceName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string CollectionType { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedAt { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastModifiedAt { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"resourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroup { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"resourceName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    internal partial interface IAzureCosmosDbDataSourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourceInternal
    {
        string AccountUri { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IDataSourcePropertiesCollection Collection { get; set; }

        global::System.DateTime? CollectionLastModifiedAt { get; set; }

        string CollectionReferenceName { get; set; }

        string CollectionType { get; set; }

        global::System.DateTime? CreatedAt { get; set; }

        global::System.DateTime? LastModifiedAt { get; set; }

        string Location { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureCosmosDbDataSourceProperties Property { get; set; }

        string ResourceGroup { get; set; }

        string ResourceName { get; set; }

        string SubscriptionId { get; set; }

    }
}