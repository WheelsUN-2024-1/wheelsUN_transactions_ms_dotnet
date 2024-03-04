﻿namespace wheelsUN_transactions_ms.Models
{
    /// <summary>
    /// Modelo de datos para la dirección
    /// </summary>
    public class Address
    {
        public string street1 { get; set; }
        public string street2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string postalCode { get; set; }
        public string phone { get; set; }
    }
}