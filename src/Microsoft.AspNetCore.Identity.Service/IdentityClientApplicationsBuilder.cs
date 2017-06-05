﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.AspNetCore.Identity.Service
{
    public class IdentityClientApplicationsBuilder<TApplication> : IIdentityClientApplicationsBuilder
    {
        private readonly IdentityBuilder _builder;

        public IdentityClientApplicationsBuilder(IdentityBuilder builder)
        {
            _builder = builder;
        }

        public IServiceCollection Services => _builder.Services;

        public Type ApplicationType => typeof(TApplication);
        public Type UserType => _builder.UserType;
        public Type RoleType => _builder.RoleType;
    }
}
