using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training3.openai
{
    public class PromptResponse
    {
        public string Message { get; set; }
        public string Reason { get; set; }

        public PromptResponse(string message, string reason)
        {
            Message = message;
            Reason = reason;
        }
    }
}
