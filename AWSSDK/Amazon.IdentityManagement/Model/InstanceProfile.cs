/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// The InstanceProfile data type contains information about an instance profile.
    /// 
    ///         
    /// <para>
    ///  This data type is used as a response element in the following actions:
    /// </para>
    ///         <ul>            <li>
    /// <para>
    /// <a>CreateInstanceProfile</a>
    /// </para>
    /// </li>            <li>
    /// <para>
    /// <a>GetInstanceProfile</a>
    /// </para>
    /// </li>            <li>
    /// <para>
    /// <a>ListInstanceProfiles</a>
    /// </para>
    /// </li>            <li>
    /// <para>
    /// <a>ListInstanceProfilesForRole</a>
    /// </para>
    /// </li>        </ul>
    /// </summary>
    public partial class InstanceProfile
    {
        private string _arn;
        private DateTime? _createDate;
        private string _instanceProfileId;
        private string _instanceProfileName;
        private string _path;
        private List<Role> _roles = new List<Role>();


        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) specifying the instance profile. For more information
        /// about            ARNs and how to use them in policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html"
        /// target="_blank">Identifiers for IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }


        /// <summary>
        /// Sets the Arn property
        /// </summary>
        /// <param name="arn">The value to set for the Arn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceProfile WithArn(string arn)
        {
            this._arn = arn;
            return this;
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }


        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date when the instance profile was created.
        /// </para>
        /// </summary>
        public DateTime CreateDate
        {
            get { return this._createDate.GetValueOrDefault(); }
            set { this._createDate = value; }
        }


        /// <summary>
        /// Sets the CreateDate property
        /// </summary>
        /// <param name="createDate">The value to set for the CreateDate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceProfile WithCreateDate(DateTime createDate)
        {
            this._createDate = createDate;
            return this;
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property InstanceProfileId. 
        /// <para>
        /// The stable and unique string identifying the instance profile. For more information
        /// about            IDs, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html"
        /// target="_blank">Identifiers for IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        public string InstanceProfileId
        {
            get { return this._instanceProfileId; }
            set { this._instanceProfileId = value; }
        }


        /// <summary>
        /// Sets the InstanceProfileId property
        /// </summary>
        /// <param name="instanceProfileId">The value to set for the InstanceProfileId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceProfile WithInstanceProfileId(string instanceProfileId)
        {
            this._instanceProfileId = instanceProfileId;
            return this;
        }

        // Check to see if InstanceProfileId property is set
        internal bool IsSetInstanceProfileId()
        {
            return this._instanceProfileId != null;
        }


        /// <summary>
        /// Gets and sets the property InstanceProfileName. 
        /// <para>
        /// The name identifying the instance profile.
        /// </para>
        /// </summary>
        public string InstanceProfileName
        {
            get { return this._instanceProfileName; }
            set { this._instanceProfileName = value; }
        }


        /// <summary>
        /// Sets the InstanceProfileName property
        /// </summary>
        /// <param name="instanceProfileName">The value to set for the InstanceProfileName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceProfile WithInstanceProfileName(string instanceProfileName)
        {
            this._instanceProfileName = instanceProfileName;
            return this;
        }

        // Check to see if InstanceProfileName property is set
        internal bool IsSetInstanceProfileName()
        {
            return this._instanceProfileName != null;
        }


        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// Path to the instance profile. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html"
        /// target="_blank">Identifiers for IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }


        /// <summary>
        /// Sets the Path property
        /// </summary>
        /// <param name="path">The value to set for the Path property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceProfile WithPath(string path)
        {
            this._path = path;
            return this;
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }


        /// <summary>
        /// Gets and sets the property Roles. 
        /// <para>
        /// The role associated with the instance profile.
        /// </para>
        /// </summary>
        public List<Role> Roles
        {
            get { return this._roles; }
            set { this._roles = value; }
        }

        /// <summary>
        /// Sets the Roles property
        /// </summary>
        /// <param name="roles">The values to add to the Roles collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceProfile WithRoles(params Role[] roles)
        {
            foreach (var element in roles)
            {
                this._roles.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Roles property
        /// </summary>
        /// <param name="roles">The values to add to the Roles collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceProfile WithRoles(IEnumerable<Role> roles)
        {
            foreach (var element in roles)
            {
                this._roles.Add(element);
            }
            return this;
        }
        // Check to see if Roles property is set
        internal bool IsSetRoles()
        {
            return this._roles != null && this._roles.Count > 0; 
        }

    }
}