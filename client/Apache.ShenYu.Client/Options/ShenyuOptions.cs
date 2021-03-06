/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Collections.Generic;

namespace Apache.ShenYu.Client.Options
{
    public class ShenyuOptions
    {
        public const string Shenyu = "Shenyu";

        public RegisterOptions Register { get; set; }
        public ClientOptions Client { get; set; }

        public class RegisterOptions
        {
            /// <summary>
            /// register types, including http, zookeeper.
            /// </summary>
            public string RegisterType { get; set; } = "http";
            public string ServerList { get; set; }
            
            public Dictionary<string, string> Props { get; set; }
            
            
        }

        public class ClientOptions
        {
            public string AppName { get; set; }
            public string ContextPath { get; set; }
            public bool IsFull { get; set; } = false;
            public string ClientType { get; set; }
        }
    }
}
