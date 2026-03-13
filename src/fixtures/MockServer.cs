
using WireMock.Server;
using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;
using Newtonsoft.Json;

namespace Fixtures;

public class MockServer
{
    public WireMockServer Server { get; private set; }

    public void Start()
    {
        Server = WireMockServer.Start(5050);

        Server.Given(Request.Create().WithPath("/api/v1/simulacao/vgbl").UsingPost())
        .RespondWith(Response.Create().WithCallback(request =>
        {
            dynamic body = JsonConvert.DeserializeObject(request.Body);
            decimal aporte = body.aporte;

            decimal excedente = aporte > 600000 ? aporte - 600000 : 0;
            decimal iof = excedente * 0.05m;

            return new WireMock.ResponseMessage
            {
                StatusCode = 200,
                Body = JsonConvert.SerializeObject(new { iof = iof })
            };
        }));
    }

    public void Stop()
    {
        Server.Stop();
    }
}
