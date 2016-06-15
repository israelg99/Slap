using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Slap.Slap.Network;
using Slap.Slap.Network.Slack;

namespace Slap {
    internal class Program {
        private static void Main(string[] args) {

            SlackPayload payload = new SlackPayload();

            Console.WriteLine("\nPlease enter your Slack API Webhook URL:");
            string hook = Console.ReadLine();

            Console.WriteLine("\nPlease enter your message content:");
            payload.text = Console.ReadLine();

            Console.WriteLine("\nPlease enter your username:");
            payload.username = Console.ReadLine();

            Console.WriteLine("\nPlease enter your avatar URL:");
            payload.icon_url = Console.ReadLine();

            Task.Run(() =>
                SlackHttpHandler.POST(
                    hook: hook,
                    payload: payload));

            Console.WriteLine("\nSUCCESS! the task is running in a new thread!");

            Console.WriteLine("Your URL, username and icon have been saved.");

            Console.WriteLine();
            while (true) {
                Console.WriteLine("\nLet's do another message:");
                payload.text = Console.ReadLine();

                Task.Run(() =>
                SlackHttpHandler.POST(
                    hook: hook,
                    payload: payload));
            }



            /*Console.WriteLine("Initiating Slack HTTP POST task...");
            Task slackWebHook = new Task(() =>
                SlackHttpHandler.POST(hook: "https://hooks.slack.com/services/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",
                    text: "If this works\nIt'll be incredible!\nhttps://img.buzzfeed.com/buzzfeed-static/static/2014-07/18/8/enhanced/webdr10/anigif_enhanced-buzz-31768-1405685443-14.gif",
                    username: "GLaDOS",
                    icon_url: "https://s3-us-west-2.amazonaws.com/slack-files2/bot_icons/2016-06-15/51060793943_48.png"));
            Console.WriteLine("Slack HTTP POST task created successfully!");
            Console.WriteLine("Slack HTTP POST task is running...");
            slackWebHook.Start();
            Console.WriteLine("Slack HTTP POST task is finished running!");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();*/

        }
    }
}
