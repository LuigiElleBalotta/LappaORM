﻿// Copyright (C) Arctium Software.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Lappa_ORM.Logging
{
    public interface ILog
    {
        void Message(LogTypes logTypes, string message);
    }
}