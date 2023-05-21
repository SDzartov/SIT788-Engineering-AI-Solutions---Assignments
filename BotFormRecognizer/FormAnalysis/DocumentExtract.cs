using Azure.AI.FormRecognizer.DocumentAnalysis;
using Azure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Documents.SystemFunctions;

namespace BotFormRecognizer.FormAnalysis
{

    internal class DocumentExtract
    {
        readonly DocumentAnalysisClient client;
        public DocumentExtract(string key, string endpoint)
        {
            var credential = new AzureKeyCredential(key);
            client = new DocumentAnalysisClient(new Uri(endpoint), credential);
        }

        public async Task<string> Extract(string url)
        {
            var documentUrl = new Uri(url);
            var operation = await client.AnalyzeDocumentFromUriAsync(WaitUntil.Completed, "model01", documentUrl);
            var cards = operation.Value;
            return ExtractValue(cards);
        }

        private string ExtractValue(AnalyzeResult businessCards)
        {
            var contactName = string.Empty;

            businessCards.Documents[0].Fields.TryGetValue("graphics", out var graphicsField);

            if (graphicsField != null)
            {
                var graphicsValue = graphicsField.Value.AsString();
                contactName = graphicsValue;
            }
        return contactName;
        }    
    }
}