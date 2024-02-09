﻿using Login_using_Middleware.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseLoginMiddleware();

app.Run(async context =>
{
    await context.Response.WriteAsync("No Response");
});

