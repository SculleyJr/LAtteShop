using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using LatteShop.Controllers;
using Newtonsoft.Json;

namespace LatteShop.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string FavoriteCoffee { get; set; }

        [Required]
        public bool IsSubscribed { get; set; }

        public MemberShipType MemberShipType { get; set; }

        public byte MemberShipTypeId { get; set; }

    }
}