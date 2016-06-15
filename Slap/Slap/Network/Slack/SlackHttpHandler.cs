using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Slap.Slap.Network.Slack {
    public static class SlackHttpHandler {
        public static void POST(string hook, SlackPayload payload) {
            string strPayload = JsonConvert.SerializeObject(
                payload,
                Formatting.Indented,
                new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }
            );

            ClientHttpHandler.POST(hook, strPayload);
        }

        public static void POST(string hook, string text, string username = "", string icon_url = "") {
            POST(hook, new SlackPayload(text, username, icon_url));
        }
    }
}
