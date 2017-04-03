using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Luis;
using System.Threading.Tasks;

namespace MSChatBot
{
    [LuisModel("a7087335-0d78-4829-9696-3409667dfc0a", "c8edb6584d2b4c019413b8e7457ff6e9")]
    [Serializable]
    public class MSChatBotLuisDialog : LuisDialog<object>
    {
        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("I'm sorry. I didn't understand you.");
            context.Wait(MessageReceived);
        }

        [LuisIntent("AboutMe")]
        public async Task AboutMe(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(@"Jerry is currently trying to get all of this stuff to work for the group project");
            context.Wait(MessageReceived);
        }
    }
}