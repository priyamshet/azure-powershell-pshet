// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    public partial class WorkspaceConnectionPersonalAccessToken :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionPersonalAccessToken,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IWorkspaceConnectionPersonalAccessTokenInternal
    {

        /// <summary>Backing field for <see cref="Pat" /> property.</summary>
        private string _pat;

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Pat { get => this._pat; set => this._pat = value; }

        /// <summary>Creates an new <see cref="WorkspaceConnectionPersonalAccessToken" /> instance.</summary>
        public WorkspaceConnectionPersonalAccessToken()
        {

        }
    }
    public partial interface IWorkspaceConnectionPersonalAccessToken :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"pat",
        PossibleTypes = new [] { typeof(string) })]
        string Pat { get; set; }

    }
    internal partial interface IWorkspaceConnectionPersonalAccessTokenInternal

    {
        string Pat { get; set; }

    }
}