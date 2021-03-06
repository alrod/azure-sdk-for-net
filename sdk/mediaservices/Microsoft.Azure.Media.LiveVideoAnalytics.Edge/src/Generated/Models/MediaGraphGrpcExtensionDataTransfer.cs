// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Media.LiveVideoAnalytics.Edge.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes how media should be transferred to the inferencing engine.
    /// </summary>
    public partial class MediaGraphGrpcExtensionDataTransfer
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MediaGraphGrpcExtensionDataTransfer class.
        /// </summary>
        public MediaGraphGrpcExtensionDataTransfer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MediaGraphGrpcExtensionDataTransfer class.
        /// </summary>
        /// <param name="mode">How frame data should be transmitted to the
        /// inferencing engine. Possible values include: 'Embedded',
        /// 'SharedMemory'</param>
        /// <param name="sharedMemorySizeMiB">The size of the buffer for all
        /// in-flight frames in mebibytes if mode is SharedMemory. Should not
        /// be specificed otherwise.</param>
        public MediaGraphGrpcExtensionDataTransfer(string mode, string sharedMemorySizeMiB = default(string))
        {
            SharedMemorySizeMiB = sharedMemorySizeMiB;
            Mode = mode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the size of the buffer for all in-flight frames in
        /// mebibytes if mode is SharedMemory. Should not be specificed
        /// otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "sharedMemorySizeMiB")]
        public string SharedMemorySizeMiB { get; set; }

        /// <summary>
        /// Gets or sets how frame data should be transmitted to the
        /// inferencing engine. Possible values include: 'Embedded',
        /// 'SharedMemory'
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Mode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Mode");
            }
        }
    }
}
