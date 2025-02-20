// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Output of the task that gets TDE certificates in Base64 encoded format. </summary>
    public partial class GetTdeCertificatesSqlTaskOutput
    {
        /// <summary> Initializes a new instance of GetTdeCertificatesSqlTaskOutput. </summary>
        internal GetTdeCertificatesSqlTaskOutput()
        {
            ValidationErrors = new ChangeTrackingList<ReportableException>();
        }

        /// <summary> Initializes a new instance of GetTdeCertificatesSqlTaskOutput. </summary>
        /// <param name="base64EncodedCertificates"> Mapping from certificate name to base 64 encoded format. </param>
        /// <param name="validationErrors"> Validation errors. </param>
        internal GetTdeCertificatesSqlTaskOutput(string base64EncodedCertificates, IReadOnlyList<ReportableException> validationErrors)
        {
            Base64EncodedCertificates = base64EncodedCertificates;
            ValidationErrors = validationErrors;
        }

        /// <summary> Mapping from certificate name to base 64 encoded format. </summary>
        public string Base64EncodedCertificates { get; }
        /// <summary> Validation errors. </summary>
        public IReadOnlyList<ReportableException> ValidationErrors { get; }
    }
}
