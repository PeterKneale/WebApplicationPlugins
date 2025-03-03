﻿using WebApplicationPlugins;
using WebPlugin1;

[assembly: WebApplicationPlugin(typeof(ChatPlugin))]

namespace WebPlugin1;

public sealed class ChatPlugin : WebApplicationPlugin
{
    public override void ConfigureWebApplicationBuilder(WebApplicationBuilder builder)
    {
        builder.Services.AddSignalR();
    }

    public override void ConfigureWebApplication(WebApplication app)
    {
        app.MapHub<Chat>("/chat");
    }
}