﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Messaging.ServiceBus.Primitives
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Provides interface definition of a token provider.
    /// </summary>
    internal interface ITokenProvider
    {
        /// <summary>
        /// Gets a <see cref="SecurityToken"/>.
        /// </summary>
        /// <param name="appliesTo">The URI which the access token applies to</param>
        /// <param name="timeout">The time span that specifies the timeout value for the message that gets the security token</param>
        /// <returns><see cref="SecurityToken"/></returns>
        Task<SecurityToken> GetTokenAsync(string appliesTo, TimeSpan timeout);
    }
}