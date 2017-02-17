﻿/********************************************************************************************************************************************
 * Copyright (C) 2016 Pieter-Uys Fourie
 * This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as 
 * published by the Free Software Foundation, either version 3 of the License, or any later version.
 *
 * This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty 
 * of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License along with this program. If not, see 
 * http://www.gnu.org/licenses/.
 */

using System.Collections.Generic;
using KodiRPC.Responses.Types.List;
using Newtonsoft.Json;

namespace KodiRPC.Responses.Files
{
    public class GetDirectoryResponse
    {
        [JsonProperty(PropertyName = "limits")]
        public LimitsReturned Limits { get; set; }
        [JsonProperty(PropertyName = "files")]
        public List<Types.List.Item.File> Files { get; set; }
    }
}