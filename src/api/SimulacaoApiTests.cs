using NUnit.Framework;
using Core;
using Fixtures;
using Allure.NUnit;
using Allure.NUnit.Attributes;
using Allure.Net.Commons;

namespace Api;

[AllureNUnit]
[AllureSuite("Simulacao API")]
[Parallelizable(ParallelScope.All)]
public class SimulacaoApiTests
{
    ApiClient api;
    MockServer mock;

    [OneTimeSetUp]
public void Setup()
{
    mock = new MockServer();
    mock.Start();
    api = new ApiClient("http://localhost:5050");
}
    [Test]
    public void CT01_API_Test()
    {
        var resp = api.Post("/api/v1/simulacao/vgbl", new { aporte = 550000 });
        Assert.AreEqual(200,(int)resp.StatusCode);
    }

    [Test]
    public void CT02_API_Test()
    {
        var resp = api.Post("/api/v1/simulacao/vgbl", new { aporte = 600000 });
        Assert.AreEqual(200,(int)resp.StatusCode);
    }

    [Test]
    public void CT03_API_Test()
    {
        var resp = api.Post("/api/v1/simulacao/vgbl", new { aporte = 650000 });
        Assert.AreEqual(200,(int)resp.StatusCode);
    }

    [Test]
    public void CT04_API_Test()
    {
        var resp = api.Post("/api/v1/simulacao/vgbl", new { aporte = 700000 });
        Assert.AreEqual(200,(int)resp.StatusCode);
    }

    [Test]
    public void CT05_API_Test()
    {
        var resp = api.Post("/api/v1/simulacao/vgbl", new { aporte = 750000 });
        Assert.AreEqual(200,(int)resp.StatusCode);
    }

    [Test]
    public void CT06_API_Test()
    {
        var resp = api.Post("/api/v1/simulacao/vgbl", new { aporte = 800000 });
        Assert.AreEqual(200,(int)resp.StatusCode);
    }

    [Test]
    public void CT07_API_Test()
    {
        var resp = api.Post("/api/v1/simulacao/vgbl", new { aporte = 850000 });
        Assert.AreEqual(200,(int)resp.StatusCode);
    }

    [Test]
    public void CT08_API_Test()
    {
        var resp = api.Post("/api/v1/simulacao/vgbl", new { aporte = 900000 });
        Assert.AreEqual(200,(int)resp.StatusCode);
    }

    [Test]
    public void CT09_API_Test()
    {
        var resp = api.Post("/api/v1/simulacao/vgbl", new { aporte = 950000 });
        Assert.AreEqual(200,(int)resp.StatusCode);
    }

    [Test]
    public void CT10_API_Test()
    {
        var resp = api.Post("/api/v1/simulacao/vgbl", new { aporte = 1000000 });
        Assert.AreEqual(200,(int)resp.StatusCode);
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        mock.Stop();
    }
}