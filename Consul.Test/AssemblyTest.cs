﻿// -----------------------------------------------------------------------
//  <copyright file="AssemblyTest.cs" company="PlayFab Inc">
//    Copyright 2015 PlayFab Inc.
//    Copyright 2020 G-Research Limited
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//  </copyright>
// -----------------------------------------------------------------------

using System;
using Xunit;
using System.Reflection;

namespace Consul.Test
{
    public class AssemblyTest
    {
        [Fact]
        public void Assembly_IsStrongNamed()
        {

            Type type = typeof(ConsulClient);
            TypeInfo typeInfo = type.GetTypeInfo();
            string name = typeInfo.Assembly.FullName.ToString();
            Assert.Contains("PublicKeyToken", typeInfo.Assembly.FullName);

        }
    }
}