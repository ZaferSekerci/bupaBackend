﻿using System;
using System.Collections.Generic;

namespace BupaAcibademWebApi.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Cards = new HashSet<Card>();
            Orders = new HashSet<Order>();
            Payments = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Card> Cards { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}