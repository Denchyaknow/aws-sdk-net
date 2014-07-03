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
    /// Container for the parameters to the CreateSAMLProvider operation.
    /// Creates an IAM entity to describe an identity provider (IdP) that supports SAML 2.0.
    /// 
    ///         
    /// <para>
    /// The SAML provider that you create with this operation can be used as a principal in
    /// a role's            trust policy to establish a trust relationship between AWS and a SAML identity
    /// provider. You            can create an IAM role that supports Web-based single sign-on (SSO)
    /// to the AWS Management Console or one            that supports API access to AWS. 
    /// </para>
    ///         
    /// <para>
    /// When you create the SAML provider, you upload an a SAML metadata document that you
    /// get from            your IdP and that includes the issuer's name, expiration information, and
    /// keys that can be            used to validate the SAML authentication response (assertions)
    /// that are received from the IdP.            You must generate the metadata document using the
    /// identity management software that is used as            your organization's IdP. 
    /// </para>
    ///         <note>This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version            4</a>.</note>        
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/STSMgmtConsole-SAML.html">Giving
    /// Console Access Using SAML</a> and <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/CreatingSAML.html">Creating                Temporary
    /// Security Credentials for SAML Federation</a> in the <i>Using Temporary                Credentials</i>
    /// guide. 
    /// </para>
    /// </summary>
    public partial class CreateSAMLProviderRequest : AmazonWebServiceRequest
    {
        private string _name;
        private string _sAMLMetadataDocument;


        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the provider to create.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateSAMLProviderRequest WithName(string name)
        {
            this._name = name;
            return this;
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }


        /// <summary>
        /// Gets and sets the property SAMLMetadataDocument. 
        /// <para>
        /// An XML document generated by an identity provider (IdP) that supports SAML 2.0. The
        /// document            includes the issuer's name, expiration information, and keys that can be
        /// used to validate the            SAML authentication response (assertions) that are received
        /// from the IdP. You must generate            the metadata document using the identity management
        /// software that is used as your            organization's IdP. 
        /// </para>
        ///         
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/CreatingSAML.html">Creating
        /// Temporary Security Credentials for SAML Federation</a> in the <i>Using Temporary                Security
        /// Credentials</i> guide. 
        /// </para>
        /// </summary>
        public string SAMLMetadataDocument
        {
            get { return this._sAMLMetadataDocument; }
            set { this._sAMLMetadataDocument = value; }
        }


        /// <summary>
        /// Sets the SAMLMetadataDocument property
        /// </summary>
        /// <param name="sAMLMetadataDocument">The value to set for the SAMLMetadataDocument property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateSAMLProviderRequest WithSAMLMetadataDocument(string sAMLMetadataDocument)
        {
            this._sAMLMetadataDocument = sAMLMetadataDocument;
            return this;
        }

        // Check to see if SAMLMetadataDocument property is set
        internal bool IsSetSAMLMetadataDocument()
        {
            return this._sAMLMetadataDocument != null;
        }

    }
}