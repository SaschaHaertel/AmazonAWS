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

/*
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MachineLearning.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MachineLearning.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3DataSpec Marshaller
    /// </summary>       
    public class S3DataSpecMarshaller : IRequestMarshaller<S3DataSpec, JsonMarshallerContext> 
    {
        public void Marshall(S3DataSpec requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDataLocationS3())
            {
                context.Writer.WritePropertyName("DataLocationS3");
                context.Writer.Write(requestObject.DataLocationS3);
            }

            if(requestObject.IsSetDataRearrangement())
            {
                context.Writer.WritePropertyName("DataRearrangement");
                context.Writer.Write(requestObject.DataRearrangement);
            }

            if(requestObject.IsSetDataSchema())
            {
                context.Writer.WritePropertyName("DataSchema");
                context.Writer.Write(requestObject.DataSchema);
            }

            if(requestObject.IsSetDataSchemaLocationS3())
            {
                context.Writer.WritePropertyName("DataSchemaLocationS3");
                context.Writer.Write(requestObject.DataSchemaLocationS3);
            }

        }

        public readonly static S3DataSpecMarshaller Instance = new S3DataSpecMarshaller();

    }
}