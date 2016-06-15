using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slap.Slap.Network.Slack {
    public class SlackPayload {

        /* It follows Slack's API Webhook JSON Payload naming conventions, so no C# conventions here. */

        public string text { get; set; }
        public string username { get; set; }
        public string icon_url { get; set; }

        public SlackPayload(string text, string username = "", string icon_url = "") {
            this.text = text;
            this.username = username;
            this.icon_url = icon_url;
        }

        public SlackPayload() : this("", "", "") { }

    }
}
