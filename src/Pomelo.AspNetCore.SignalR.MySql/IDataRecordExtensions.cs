// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

#if NET451
using System;
using System.Data;
using Pomelo.Data.MySql;

namespace Pomelo.AspNetCore.SignalR.MySql
{
    internal static class IDataRecordExtensions
    {
        public static byte[] GetBinary(this IDataRecord reader, int ordinalIndex)
        {
            var sqlReader = reader as SqlDataReader;
            if (sqlReader == null)
            {
                throw new NotSupportedException();
            }

            return sqlReader.GetSqlBinary(ordinalIndex).Value;
        }
    }
}
#endif
