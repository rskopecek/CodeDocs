using System;
namespace CodeDocs
{
    // https://en.wikipedia.org/wiki/Architectural_pattern
    [Flags]
    public enum Architectural : long
    {
        NotSet = 0,

        ADR = 1,
        ActiveRecord = 2,
        Broker = 4,
        ClientServer = 8,
        CBD = 16,
        DAO = 32,
        DTO = 64,
        DDD = 128,
        ECS = 256,
        EDA = 512,
        FrontController = 1_024,
        IdentityMap = 2_048,
        Interceptor = 4_096,
        ImplicitInvocation = 8_192,
        InversionOfControl = 16_384,
        Model2 = 32_768,
        MOM = 65_536,
        Microservices = 131_073,
        MVA = 262_144,
        MVC = 524_288,
        MVP = 1_048_576,
        MVVM = 2_097_152,
        Monolithic = 4_194_304,
        Multitier = 8_388_608,
        NakedObjects = 16_777_216,
        ORB = 33_554_432,
        P2P = 67_108_864,
        PublishSubscribe = 134_217_728,
        PAC = 268_435_456,
        REST = 536_870_912,
        SOA = 1_073_741_824,
        ServiceLocator = 2_147_483_648,
        SN = 4_294_967_296,
        SBA = 8_589_934_592,
        Specification = 17_179_869_184
    }
}
