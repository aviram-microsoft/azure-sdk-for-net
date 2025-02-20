// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Component container definition.
    /// &lt;see href=&quot;https://docs.microsoft.com/en-us/azure/machine-learning/reference-yaml-component-command&quot; /&gt;
    /// Serialized Name: ComponentContainer
    /// </summary>
    public partial class MachineLearningComponentContainerProperties : MachineLearningAssetContainer
    {
        /// <summary> Initializes a new instance of MachineLearningComponentContainerProperties. </summary>
        public MachineLearningComponentContainerProperties()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningComponentContainerProperties. </summary>
        /// <param name="description">
        /// The asset description text.
        /// Serialized Name: ResourceBase.description
        /// </param>
        /// <param name="properties">
        /// The asset property dictionary.
        /// Serialized Name: ResourceBase.properties
        /// </param>
        /// <param name="tags">
        /// Tag dictionary. Tags can be added, removed, and updated.
        /// Serialized Name: ResourceBase.tags
        /// </param>
        /// <param name="isArchived">
        /// Is the asset archived?
        /// Serialized Name: AssetContainer.isArchived
        /// </param>
        /// <param name="latestVersion">
        /// The latest version inside this container.
        /// Serialized Name: AssetContainer.latestVersion
        /// </param>
        /// <param name="nextVersion">
        /// The next auto incremental version
        /// Serialized Name: AssetContainer.nextVersion
        /// </param>
        internal MachineLearningComponentContainerProperties(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, bool? isArchived, string latestVersion, string nextVersion) : base(description, properties, tags, isArchived, latestVersion, nextVersion)
        {
        }
    }
}
