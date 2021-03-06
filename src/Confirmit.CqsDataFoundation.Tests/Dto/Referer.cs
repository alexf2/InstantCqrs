﻿
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Firmglobal.Framework.CqsDataFoundation.Validation;

namespace Confirmit.CqsDataFoundation.Tests.Dto
{
    [DataContract(Namespace = "http://www.confirmit.com/")]
    class Referer
    {
        [DataMember(Order = 1)]
        [Required]
        [MaxLength(10)]
        [MinLength(5)]
        public string Code { get; set; }

        [DataMember(Order = 2)]
        [ValidateObject]
        public Address2 Address { get; set; }
    }
}
