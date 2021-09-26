using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ConsoleAppExampleGenerics
{
    class PropagationSNT
    {
        //this class will be used to connnect to the objetive Server, PC, Router or device in the Network...
        HttpClient SNTClient; 
        protected string URLStringNeeded =null;
        public PropagationSNT(string AssignURL)
        {
            URLStringNeeded = AssignURL;
            SNTClient = new HttpClient();
            SNTClient.BaseAddress = new Uri(URLStringNeeded);
        }
    }
}
