﻿using System;
namespace Testability
{
    public class Order
    {
        public float TotalPrice { get; set; }
        public DateTime DatePlaced { get; set; }
        public Shipment Shipment { get; set; }

        public bool IsShipped { get { return Shipment != null; } }
    }
}

