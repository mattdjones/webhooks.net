﻿namespace Octokit.Webhooks.Models.CheckRunEvent
{
    using System.Text.Json.Serialization;
    using JetBrains.Annotations;

    [PublicAPI]
    public sealed record CheckRunPullRequest
    {
        [JsonPropertyName("url")]
        public string Url { get; init; } = null!;

        [JsonPropertyName("id")]
        public long Id { get; init; }

        [JsonPropertyName("number")]
        public long Number { get; init; }

        [JsonPropertyName("head")]
        public CheckRunPullRequestHead Head { get; init; } = null!;

        [JsonPropertyName("base")]
        public CheckRunPullRequestBase Base { get; init; } = null!;
    }
}
