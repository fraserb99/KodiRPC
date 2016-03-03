﻿using System.Collections.Generic;
using KodiRPC.Responses.Types.Video.Details;
using Newtonsoft.Json;

namespace KodiRPC.Responses.VideoLibrary
{
    public class GetTvShowsResponse
    {
        [JsonProperty(PropertyName = "tvshows")]
        public List<TvShow> Result { get; set; }
    }
}
