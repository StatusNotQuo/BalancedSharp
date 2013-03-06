﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BalancedSharp
{
    [DataContract]
    public class BankAccount : IBalancedServiceObject
    {
        [DataMember(Name = "account_number")]
        public string AccountNumber { get; set; }

        [DataMember(Name = "account_uri")]
        public string AccountUri { get; set; }

        [DataMember(Name = "bank_code")]
        public string BankCode { get; set; }

        [DataMember(Name = "account_number")]
        public string BankName { get; set; }

        [DataMember(Name = "can_debit")]
        public bool CanDebit { get; set; }

        [DataMember(Name = "created_at")]
        public string CreatedOn { get; set; }

        [DataMember(Name = "credits_uri")]
        public string CreditsUri { get; set; }

        [DataMember(Name = "fingerprint")]
        public string Fingerprint { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "is_valid")]
        public bool IsValid { get; set; }

        [DataMember(Name = "meta")]
        public Dictionary<string, string> Meta { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "routing_number")]
        public string RoutingNumber { get; set; }

        [DataMember(Name = "type")]
        public BankAccountType Type { get; set; }

        [DataMember(Name = "uri")]
        public string Uri { get; set; }

        [DataMember(Name = "verification_uri")]
        public string VerificationUri { get; set; }

        [DataMember(Name = "verifications_uri")]
        public string VerificationsUri { get; set; }

        public Status<BankAccount> Save()
        {
            return this.Service.BankAccount.Save(this);
        }

        public Status Delete()
        {
            return this.Service.BankAccount.Delete(this.Uri);
        }

        public IBalancedService Service
        {
            get;
            set;
        }
    }
}
