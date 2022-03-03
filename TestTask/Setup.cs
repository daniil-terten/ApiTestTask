using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using TechTalk.SpecFlow;
using TestTask.Client;

namespace TestTask
{
    [Binding]
    class Setup
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            GlobalVariables.reqresClient = new ReqresClient();
            GlobalVariables.reqresClient.client = new HttpClient();
        }
    }
}
