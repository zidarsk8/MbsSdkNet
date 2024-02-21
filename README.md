# Mbs SDK
----------------
Mbs SDK is a client library that enables easier integration with the Mbs web interface. SDK provides entities (messages sent to and recevived from the server) as well as websocket connection handling.

### Installation
SDK can be obtained from [nuget repository](https://www.nuget.org/packages/Sportradar.Mbs.Sdk).

### Usage

#### Initialize the SDK

Create [MbsSdkConfig](https://github.com/sportradar/MbsSdkNet/blob/main/src/Sportradar.Mbs.Sdk/MbsSdkConfig.cs) configuration object with the values provided by Sportradar:

```C#
MbsSdkConfig config = new MbsSdkConfig(
        wsServer, authServer, authClientId, authClientSecret, authAudience, operatorId);
```

Use the `config` to create [MbsSdk](https://github.com/sportradar/MbsSdkNet/blob/main/src/Sportradar.Mbs.Sdk/MbsSdk.cs) instance and establish a connection to the server:

```C#
MbsSdk mbsSdk = new MbsSdk(config);
mbsSdk.Connect();
```

The SDK is threadsafe and a single instance can be used for the entire application lifespan.

#### Use the SDK

Operations that are supported by the SDK are grouped into protocols, eg: all ticket operations are available under [ITicketProtocol](https://github.com/sportradar/MbsSdkNet/blob/main/src/Sportradar.Mbs.Sdk/Protocol/ITicketProtocol.cs).  

The SDK instances exposes all the protocols through getter property, eg:

```C#
mbsSdk.TicketProtocol;
```

Each operation (method) exposed by the protocol is generally of a request/response form. Each method accepts its Request object (eg: TicketRequest, CancelRequest, ...) and returns matching Response object (eg: TicketResponse, CancelResponse, ...) and each method can be used in async or blocking context:

```C#
// create appropriate request
OperationRequest request = new OperationRequest();
// async
OperationResponse response = await mbsSdk.Protocol.executeOperationAsync(request);
// blocking
OperationResponse response = mbsSdk.Protocol.executeOperationAsync(request).Result;
```

Example of ticket place operation:

```C#
TicketRequest request = new TicketRequest
{
    Context = new TicketContext
    {
        LimitId = 1234567890,
        ... // omitted for brevity
    },
    TicketId = "ticketId-1234567890",
    ... // omitted for brevity
};
TicketResponse response = await sdk.TicketProtocol.SendTicketAsync(request);
```

#### Close the SDK

When MbsSdk instance is not needed anymore, invoke `Dispose()` to release the resources:

```C#
mbsSdk.Dispose();
```

### Further reading

[Betradar documentation](https://docs.betradar.com)
