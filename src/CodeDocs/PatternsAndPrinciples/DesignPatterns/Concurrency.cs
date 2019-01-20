using System;
namespace CodeDocs
{
    [Flags]
    public enum Concurrency
    {
        NotSet = 0,

        ActiveObject = 1,
        Balking = 2,
        BindingProperties = 4,
        ComputeKernel = 8,
        DoubleCheckedLocking = 16,
        EventBasedAsynchronous = 32,
        GuardedSuspension = 64,
        Join = 128,
        Lock = 256,
        MessagingDesign = 512,
        Monitor = 1_024,
        Reactor = 2_048,
        ReadWriterLock = 4_096,
        Scheduler = 8_192,
        ThreadPool = 16_384,
        ThreadSpecificStorage = 32_768,
    }
}
