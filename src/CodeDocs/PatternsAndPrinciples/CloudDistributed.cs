using System;
namespace CodeDocs
{
    // https://en.wikipedia.org/wiki/Architectural_pattern

    public enum CloudDistributed
    {
        NotSet = 0,

        Ambassador = 1,
        AntiCorruptionLayer = 2,
        Bulkhead = 4,
        CacheAside = 8,
        CircuitBreaker = 16,
        CQRS = 32,
        CompensatingTransaction = 64,
        CompetingConsumers = 128,
        ComputerResourceConsolidation = 256,
        EventSourcing = 512,
        ExternalConfigurationStore = 1_024,
        FederatedIdentity = 2_048,
        Gatekeeper = 4_096,
        IndexTable = 8_192,
        LeaderElection = 16_384,
        MapReduce = 32_768,
        MaterializedView = 65_536,
        Pipes = 131_072,
        Filters = 262_144,
        PriorityQueue = 524_288,
        PublisherSubscriber = 1_048_576,
        QueueBasedLoadingLeveling = 2_097_152,
        Retry = 4_194_304,
        SchedulerAgentSupervisor = 8_388_608,
        Sharding = 16_777_216,
        Sidecar = 33_554_432,
        Strangler = 67_108_864,
        Throttling = 134_217_728,
        ValetKey = 268_435_456

    }
}
