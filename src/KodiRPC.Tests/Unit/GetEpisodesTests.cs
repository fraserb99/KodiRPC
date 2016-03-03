﻿using System;
using KodiRPC.Responses.VideoLibrary;
using KodiRPC.RPC.RequestResponse.Params.VideoLibrary;
using KodiRPC.RPC.Specifications.Properties;
using KodiRPC.Tests.Unit.Common;
using KodiRPC.Tests.Unit.Common.ExpectedResults;
using NUnit.Framework;

namespace KodiRPC.Tests.Unit
{
    public partial class GetEpisodesTests : BaseTest
    {
        [Test]
        public void GivenAJsonString_WhenGettingAllEpisodes_ItShouldReturnAListOfEpisodes()
        {
            var parameters = new GetEpisodesParams
            {
                Properties = new [] { EpisodeProperties.Title }
            };

            var mock = GetKodiServiceMock(parameters);
            var service = mock.Object;
            var actual = service.GetEpisodes(parameters, "UnitTests");
            var expected = Episodes.GetList();

            Assert.IsInstanceOf<GetEpisodesResponse>(actual);
            Assert.That(actual.Result.Count, Is.EqualTo(expected.Result.Count));
            AssertThatPropertyValuesAreEquals(actual, expected);
        }
    }
}