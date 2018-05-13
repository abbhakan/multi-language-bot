using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgrevlisBankBot
{
    public static class ChatResponse
    {
        public static readonly string Greeting = "Hi! I can answer your questions about Banking. \n\n" +
            "If you need personal assistance please call us on 915 04800 (+47 915 04800 from abroad), and we will help you.";        
        public static readonly string Farewell = "Thanks for chatting. Goodbye.";
        public static readonly string Default = "Sorry I didn't understand. Can you say that again please?";        
        public static readonly string Thanks = "Glad I could help.";
        public static readonly string BankID = "BankID is a personal and simple electronic proof of identity for secure identification and signing online. In the physical world you identify yourself with a passport, driver’s licence or bank card. In the electronic world you may use your BankID to certify your identity.\n \n\n\n\nRead about BankID, BankID on your mobile and more information on bankid.no. https://www.bankid.no/en/company/";
        public static readonly string BID2031 = "Error code BID 2031 usually occurs due to two main reasons:\n \n\n\n\n1. You are using Internet Explorer 9, 10 or 11 on a computer at work\n\nIn order to use BankID on your computer at work, IT Support needs to include the following url: https://csfe.bankid.no in Trusted sites for Internet Explorer. More information is available (in Norwegian) at bankid.no\n \n\n\n\n2. You are using a browser that is not resently updated\n\nYou need to update your browser to a newer version. You can do this by clicking \"settings\" and \"about\" in most common browsers to check for updates manually.";
        public static readonly string BID1439 = "Error code BID 1439 usually occurs if you enter a wrong one time code from your code device several times. This usually happens if you:\n\nhave different code devices and use a wrong one\n\nalso have BankID from another bank and forget to choose DNB in the first step of the login procedure\n \n\n\n\nCall us on 915 04800 (+47 915 04800 from abroad), and we will help you.";
        public static readonly string AddressChange = "If you have recently moved within Norway, the change of address must be reported to the Norwegian National Population Register. Our systems are automatically updated based on the changes made in the Register.\n \n\n\n\nPlease visit Norwegian Tax Administration for further information.\nhttp://www.skatteetaten.no/en/international-pages/ \n\n \n\n";
        public static readonly string IBAN = "The IBAN is specified in your bank statement. You can find it in your Internet bank. \n \n\n\n\nYou can also generate your IBAN number here. https://www.dnb.no/en/business/calculators/Iban.html";
        public static readonly string OpenAccount = "You can open a new account in the Internet bank. \n\nLog in, choose Banking & loans and Open new account in the menu\n\nSelect the type of account you wish to open and click the Open button to continue\n\nFollow the on-screen instructions, accept the account information and click Confirm\n\nYour new account is then ready for use.";
        public static readonly string PINCode = "You can retrieve the PIN code for your cards in the Internet bank. \n\nLog in, choose Banking & loans and View PIN code in the menu\n\nClick the dropdown menu and choose your preferred card and expiry date\n\nClick Confirm and follow the on-screen instructions";
        public static readonly string PersonalCode = "You can do this in the Internet bank. Log in using either BankID or BankID mobile. Choose Settings and Personal code in the menu. Enter a 4 digit code of your choice and click Confirm. Your new Personal code is ready to use.\n \n\n\n\nYou are also welcome to call us 24 hours a day, every day on 915 04800. From abroad, please call +47 915 04800";
    }
}