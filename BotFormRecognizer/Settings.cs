using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Components.Routing;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotFormRecognizer
{
    internal static class Settings
    {
        public static string ConnectionString = "DefaultEndpointsProtocol=https;AccountName=deakin19073460464;AccountKey=j/Cx75OcHnHuAhRdXbPYsEJ+6VLskh2v3hRIrd4lEkRf/BtyD8c3ieY7eSh2YHD1Uz0sljat77B/+AStzkntwg==;EndpointSuffix=core.windows.net";
        public static string ContainerName = "formbotstorage";
        public static string Key = "j/Cx75OcHnHuAhRdXbPYsEJ+6VLskh2v3hRIrd4lEkRf/BtyD8c3ieY7eSh2YHD1Uz0sljat77B/+AStzkntwg==";
        public static string Endpoint = "https://deakin19073460464.blob.core.windows.net/formbotstorage";

        public static string FormKey = "e031556998fc4061bf83e09d732b487e";
        public static string FormEndpoint = "https://formreconshane01.cognitiveservices.azure.com/";
        
    }
}
