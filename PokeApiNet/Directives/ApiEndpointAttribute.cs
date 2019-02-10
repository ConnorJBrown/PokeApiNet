﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PokeApiNet.Directives
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    internal class ApiEndpointAttribute : Attribute
    {
        public string ApiEndpoint { get; }

        public ApiEndpointAttribute(string apiEndpoint)
        {
            ApiEndpoint = apiEndpoint;
        }
    }
}