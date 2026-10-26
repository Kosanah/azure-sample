using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

// Azure Functions sample: HTTP-triggered function returning JSON.
public class OrderFunction
{
    [Function("GetOrder")]
    public HttpResponseData Get([HttpTrigger(AuthorizationLevel.Function, "get", Route = "orders/{id}")] HttpRequestData req, int id)
    {
        var res = req.CreateResponse(System.Net.HttpStatusCode.OK);
        res.WriteString(System.Text.Json.JsonSerializer.Serialize(new { id, status = "Paid" }));
        return res;
    }
}
