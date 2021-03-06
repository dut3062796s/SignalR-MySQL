// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Data.Common;
using Pomelo.Data.MySql;
using JetBrains.Annotations;

namespace Pomelo.AspNetCore.SignalR.MySql
{
    internal static class DbDataReaderExtensions
    {
        public static byte[] GetBinary([NotNull]this DbDataReader reader, int ordinalIndex)
        {
            var sqlReader = reader as MySqlDataReader;
            if (sqlReader == null)
            {
                throw new NotSupportedException();
            }

            return sqlReader.GetBinary(ordinalIndex);
        }
    }
}
