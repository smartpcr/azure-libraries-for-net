// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StorSimple;
    using Microsoft.Azure.Management.StorSimple.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The feature.
    /// </summary>
    public partial class Feature
    {
        /// <summary>
        /// Initializes a new instance of the Feature class.
        /// </summary>
        public Feature()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Feature class.
        /// </summary>
        /// <param name="name">The name of the feature.</param>
        /// <param name="status">The feature support status. Possible values
        /// include: 'NotAvailable', 'UnsupportedDeviceVersion',
        /// 'Supported'</param>
        public Feature(string name, FeatureSupportStatus status)
        {
            Name = name;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the feature.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the feature support status. Possible values include:
        /// 'NotAvailable', 'UnsupportedDeviceVersion', 'Supported'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public FeatureSupportStatus Status { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
