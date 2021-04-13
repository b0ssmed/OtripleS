﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using OtripleS.Web.Api.Models.UserContacts;
using Newtonsoft.Json;
using OtripleS.Web.Api.Models.Fees;
using OtripleS.Web.Api.Models.ExamFees;

namespace OtripleS.Web.Api.Models.Users
{
    public class User : IdentityUser<Guid>
    {
        public override Guid Id
        {
            get => base.Id;
            set => base.Id = value;
        }

        public override string UserName
        {
            get => base.Email;
            set => base.Email = value;
        }

        public override string PhoneNumber
        {
            get => base.PhoneNumber;
            set => base.PhoneNumber = value;
        }

        public string Name { get; set; }
        public string FamilyName { get; set; }
        public UserStatus Status { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }

        public IEnumerable<UserContact> UserContacts { get; set; }

        [JsonIgnore]
        public IEnumerable<Fee> FeesCreatedByUser { get; set; }
        [JsonIgnore]
        public IEnumerable<Fee> FeesUpdatedByUser { get; set; }

        [JsonIgnore]
        public IEnumerable<ExamFee> ExamFeesCreatedByUser { get; set; }
        [JsonIgnore]
        public IEnumerable<ExamFee> ExamFeesUpdatedByUser { get; set; }
    }
}
