﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.JobRouter
{
    internal static class Extensions
    {
        public static IDictionary<TK, TV> Append<TK, TV>(this IDictionary<TK, TV> first, IDictionary<TK, TV> second)
        {
            second.ToList().ForEach(pair => first[pair.Key] = pair.Value);
            return second;
        }
    }
}
