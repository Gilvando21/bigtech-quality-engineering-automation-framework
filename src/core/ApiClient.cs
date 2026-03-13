
using RestSharp;

namespace Core;

public class ApiClient
{
    private RestClient client;

    public ApiClient(string baseUrl)
    {
        client = new RestClient(baseUrl);
    }

    public RestResponse Post(string endpoint, object body)
    {
        var req = new RestRequest(endpoint, Method.Post);
        req.AddJsonBody(body);
        return client.Execute(req);
    }
}
