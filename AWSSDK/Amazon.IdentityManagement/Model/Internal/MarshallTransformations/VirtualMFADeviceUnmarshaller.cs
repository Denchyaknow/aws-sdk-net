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
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VirtualMFADevice Object
    /// </summary>  
    public class VirtualMFADeviceUnmarshaller : IUnmarshaller<VirtualMFADevice, XmlUnmarshallerContext>, IUnmarshaller<VirtualMFADevice, JsonUnmarshallerContext>
    {
        public VirtualMFADevice Unmarshall(XmlUnmarshallerContext context)
        {
            VirtualMFADevice unmarshalledObject = new VirtualMFADevice();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Base32StringSeed", targetDepth))
                    {
                        var unmarshaller = MemoryStreamUnmarshaller.GetInstance();
                        unmarshalledObject.Base32StringSeed = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EnableDate", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.GetInstance();
                        unmarshalledObject.EnableDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("QRCodePNG", targetDepth))
                    {
                        var unmarshaller = MemoryStreamUnmarshaller.GetInstance();
                        unmarshalledObject.QRCodePNG = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SerialNumber", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.SerialNumber = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("User", targetDepth))
                    {
                        var unmarshaller = UserUnmarshaller.GetInstance();
                        unmarshalledObject.User = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        public VirtualMFADevice Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static VirtualMFADeviceUnmarshaller instance;
        public static VirtualMFADeviceUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new VirtualMFADeviceUnmarshaller();
            }
            return instance;
        }

    }
}