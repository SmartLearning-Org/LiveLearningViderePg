using Newtonsoft.Json;
using openai;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training3
{
    internal class PromptReader
    {
        private static readonly string key = "-- INDTAST NØGLEN FRA FAGETS SIDE HER --";
        private readonly string[] lines;

        public event Action<string>? OnAnswerReceived;
        
        public PromptReader(string filename)
        {
            lines = File.ReadAllLines(filename, Encoding.Latin1);
        }

        public int GetNumberOfLinesInFile()
        {
            return lines.Length;
        }

        public async Task ExecutePromptsAsync()
        {
            foreach (var line in lines)
            {
                var response = await PromptChatGptAsync(line);
                OnAnswerReceived?.Invoke(response);
            }
        }

        private static async Task<string> PromptChatGptAsync(string metafor)
        {
            string sentence = $"Programmering er som {metafor}, fordi";
            var response = await ChatService.promptGpt4Async($"Færdiggør denne sætning '{sentence}...'", key);
            if (response.Reason == "stop")
            {
                if (response.Message.Contains(sentence))
                {
                    return response.Message;
                }
                else
                {
                    return $"{sentence} {response.Message}";
                }
            } else
            {
                return "";
            }

        }
    }
}
