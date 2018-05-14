using System;
using System.Threading.Tasks;
using AgrevlisBankBot.Utilities;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System.Diagnostics;
using AgrevlisBankBot.Extensions;

namespace AgrevlisBankBot
{
    [Serializable]
    [LuisModel("b78816d7-69ef-4ffb-8a5c-4911070c6fce", "e60605d81fba4744b0a86e25a7c58421")]
    public class ChatDialog : LuisDialog<object>
    {
        [LuisIntent("")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            try
            {
                var response = ChatResponse.Default;

                await context.PostAsync(response.ToUserLocale(context));

                context.Wait(MessageReceived);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [LuisIntent("Greeting")]
        public async Task Greeting(IDialogContext context, LuisResult result)
        {
            try
            {
                var response = ChatResponse.Greeting;

                await context.PostAsync(response.ToUserLocale(context));

                context.Wait(MessageReceived);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [LuisIntent("Farewell")]
        public async Task Farewell(IDialogContext context, LuisResult result)
        {
            try
            {
                var response = ChatResponse.Farewell;

                await context.PostAsync(response.ToUserLocale(context));

                context.Wait(MessageReceived);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }                                                                     

        [LuisIntent("Thanks")]
        public async Task Thanks(IDialogContext context, LuisResult result)
        {
            try
            {
                var response = ChatResponse.Thanks;

                await context.PostAsync(response.ToUserLocale(context));

                context.Wait(MessageReceived);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [LuisIntent("BankID")]
        public async Task BankID(IDialogContext context, LuisResult result)
        {
            try
            {
                var response = ChatResponse.BankID;

                await context.PostAsync(response.ToUserLocale(context));

                context.Wait(MessageReceived);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [LuisIntent("BID2031")]
        public async Task BID2031(IDialogContext context, LuisResult result)
        {
            try
            {
                var response = ChatResponse.BID2031;

                await context.PostAsync(response.ToUserLocale(context));

                context.Wait(MessageReceived);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [LuisIntent("BID1439")]
        public async Task BID1439(IDialogContext context, LuisResult result)
        {
            try
            {
                var response = ChatResponse.BID1439;

                await context.PostAsync(response.ToUserLocale(context));

                context.Wait(MessageReceived);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [LuisIntent("AddressChange")]
        public async Task AddressChange(IDialogContext context, LuisResult result)
        {
            try
            {
                var response = ChatResponse.AddressChange;

                await context.PostAsync(response.ToUserLocale(context));

                context.Wait(MessageReceived);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [LuisIntent("IBAN")]
        public async Task IBAN(IDialogContext context, LuisResult result)
        {
            try
            {
                var response = ChatResponse.IBAN;

                await context.PostAsync(response.ToUserLocale(context));

                context.Wait(MessageReceived);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [LuisIntent("OpenAccount")]
        public async Task OpenAccount(IDialogContext context, LuisResult result)
        {
            try
            {
                var response = ChatResponse.OpenAccount;

                await context.PostAsync(response.ToUserLocale(context));

                context.Wait(MessageReceived);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [LuisIntent("PinCode")]
        public async Task PinCode(IDialogContext context, LuisResult result)
        {
            try
            {
                var response = ChatResponse.PinCode;

                await context.PostAsync(response.ToUserLocale(context));

                context.Wait(MessageReceived);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [LuisIntent("PersonalCode")]
        public async Task PersonalCode(IDialogContext context, LuisResult result)
        {
            try
            {
                var response = ChatResponse.PersonalCode;

                await context.PostAsync(response.ToUserLocale(context));

                context.Wait(MessageReceived);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    
}