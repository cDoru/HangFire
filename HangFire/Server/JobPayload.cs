﻿// This file is part of HangFire.
// Copyright © 2013 Sergey Odinokov.
// 
// HangFire is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// HangFire is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with HangFire.  If not, see <http://www.gnu.org/licenses/>.

using System.Collections.Generic;

namespace HangFire.Server
{
    internal class JobPayload
    {
        public JobPayload(
            string id, string queue, Dictionary<string, string> job)
        {
            Id = id;
            Queue = queue;
            Job = job;
        }

        public string Id { get; private set; }
        public string Queue { get; private set; }
        public Dictionary<string, string> Job { get; private set; }
    }
}