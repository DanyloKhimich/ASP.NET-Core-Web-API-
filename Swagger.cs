[HttpGet("user/{userId}")]

public async Task<ActionResult<User>> GetUser(int userId)

{

    var httpClient = new HttpClient();

    var response = await httpClient.GetStringAsync($"http://user-service-url/api/users/{userId}");

    var user = JsonConvert.DeserializeObject<User>(response);

    return Ok(user);

}
services.AddSwaggerGen(c =>

{

    c.SwaggerDoc("v1", new OpenApiInfo { Title = "OrderService", Version = "v1" });

});

 

app.UseSwagger();

app.UseSwaggerUI(c =>

{

    c.SwaggerEndpoint("/swagger/v1/swagger.json", "OrderService v1");

});