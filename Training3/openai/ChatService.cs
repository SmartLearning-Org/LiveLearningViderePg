using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Training3.openai;

namespace openai
{
    public class ChatService

    {
        
        public static Task<PromptResponse> promptGpt4Async(string prompt, string key)
        {
            var messages = new Message[]
            {
                    new Message()
                    {
                        role = "user",
                        content = prompt
                    }
            };

            return promptGpt4Async(messages, key);

        }
            
        public static async Task<PromptResponse> promptGpt4Async(Message[] messages, string key)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage();

            request.Method = HttpMethod.Post;
            request.RequestUri = new Uri($"https://smartopenaiproxy.azurewebsites.net/api/OpenAIProxy?Key={key}");

            var json = JsonConvert.SerializeObject(new ChatRequest()
            {
                model = "gpt-3.5-turbo",
                messages = messages,
            });

            request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            client.Timeout = TimeSpan.FromSeconds(120);
            var response = await client.SendAsync(request);
            var responseText = await response.Content.ReadAsStringAsync();
            
            ChatResponse chatResponse = JsonConvert.DeserializeObject<ChatResponse>(responseText);
            
            string reason = chatResponse.choices[0].finish_reason;

            string text = chatResponse.choices[0].message.content;
            return new PromptResponse(message: text, reason: reason);
        }


    }
}
