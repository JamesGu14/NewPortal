using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace WEB.Models
{

    public class EsuperfundUserModels
    {
        private const string USERNAME = "ESUPERFUND_LOGIN_SESSION";
        public int ID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string EmailAddress { get; set; }
        public string FundName { get; set; }
        public string EstabDate { get; set; }
        public string FundTFN { get; set; }
        public string ABN { get; set; }

        public EsuperfundUserModels()
        {
            ID = 1;
            UserName = "test";
            PassWord = "test";
            EmailAddress = "123@test.com";
            FundName = "test fund";
            FundTFN = "111 222 333";
            ABN = "11122233322";

        }
    }
}
