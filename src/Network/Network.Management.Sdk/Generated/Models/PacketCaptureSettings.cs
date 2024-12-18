// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// The storage location for a packet capture session.
    /// </summary>
    public partial class PacketCaptureSettings
    {
        /// <summary>
        /// Initializes a new instance of the PacketCaptureSettings class.
        /// </summary>
        public PacketCaptureSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PacketCaptureSettings class.
        /// </summary>

        /// <param name="fileCount">Number of file count. Default value of count is 10 and maximum number is
        /// 10000.
        /// </param>

        /// <param name="fileSizeInBytes">Number of bytes captured per packet. Default value in bytes 104857600
        /// (100MB) and maximum in bytes 4294967295 (4GB).
        /// </param>

        /// <param name="sessionTimeLimitInSeconds">Maximum duration of the capture session in seconds is 604800s (7 days) for
        /// a file. Default value in second 86400s (1 day).
        /// </param>
        public PacketCaptureSettings(int? fileCount = default(int?), long? fileSizeInBytes = default(long?), int? sessionTimeLimitInSeconds = default(int?))

        {
            this.FileCount = fileCount;
            this.FileSizeInBytes = fileSizeInBytes;
            this.SessionTimeLimitInSeconds = sessionTimeLimitInSeconds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets number of file count. Default value of count is 10 and maximum
        /// number is 10000.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fileCount")]
        public int? FileCount {get; set; }

        /// <summary>
        /// Gets or sets number of bytes captured per packet. Default value in bytes
        /// 104857600 (100MB) and maximum in bytes 4294967295 (4GB).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fileSizeInBytes")]
        public long? FileSizeInBytes {get; set; }

        /// <summary>
        /// Gets or sets maximum duration of the capture session in seconds is 604800s
        /// (7 days) for a file. Default value in second 86400s (1 day).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sessionTimeLimitInSeconds")]
        public int? SessionTimeLimitInSeconds {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.FileCount != null)
            {
                if (this.FileCount > 10000)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMaximum, "FileCount", 10000);
                }
                if (this.FileCount < 0)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "FileCount", 0);
                }
            }
            if (this.FileSizeInBytes != null)
            {
                if (this.FileSizeInBytes > 4294967295)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMaximum, "FileSizeInBytes", 4294967295);
                }
                if (this.FileSizeInBytes < 0)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "FileSizeInBytes", 0);
                }
            }
            if (this.SessionTimeLimitInSeconds != null)
            {
                if (this.SessionTimeLimitInSeconds > 604800)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMaximum, "SessionTimeLimitInSeconds", 604800);
                }
                if (this.SessionTimeLimitInSeconds < 0)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "SessionTimeLimitInSeconds", 0);
                }
            }
        }
    }
}