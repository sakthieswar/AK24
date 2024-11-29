using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace AES.ApiTemplate.Models.Models
{
    public interface BaseEntity
    {
        
        public int id { get; set; }
    }
}
