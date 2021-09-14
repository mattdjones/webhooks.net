namespace JamieMagee.Octokit.Webhooks.Events
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using JamieMagee.Octokit.Webhooks.Converter;
    using JamieMagee.Octokit.Webhooks.Models;

    [WebhookEventType(WebhookEventType.InstallationRepositories)]
    [JsonConverter(typeof(WebhookConverter<InstallationRepositoriesEvent>))]
    public abstract record InstallationRepositoriesEvent : WebhookEvent
    {
        [JsonPropertyName("installation")]
        public new Models.Installation Installation { get; init; } = null!;

        [JsonPropertyName("repository_selection")]
        public InstallationRepositorySelection RepositorySelection { get; init; }

        [JsonPropertyName("repositories_added")]
        public IEnumerable<Models.InstallationRepositoriesEvent.Repository> RepositoriesAdded { get; init; }

        [JsonPropertyName("repositories_removed")]
        public IEnumerable<Models.InstallationRepositoriesEvent.Repository> RepositoriesRemoved { get; init; }

        [JsonPropertyName("requester")]
        public User? Requester { get; init; }
    }
}
