using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Review_Management
{
    internal class ProductReview
    {
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool Islike { get; set; }
    }
}
