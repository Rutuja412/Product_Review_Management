using System;
using System.Collections.Generic;

namespace Product_Review_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Produdct Review Management");
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
            new ProductReview(){ProductID=1,UserID=1,Rating=8,Review="Good",Islike=true},
            new ProductReview(){ProductID=2,UserID=1,Rating=2,Review="Average",Islike=false},
            new ProductReview(){ProductID=3,UserID=2,Rating=3,Review="Average",Islike=false},
            new ProductReview(){ProductID=4,UserID=1,Rating=4,Review="Good",Islike=true},
            new ProductReview(){ProductID=5,UserID=1,Rating=5,Review="Excellent",Islike=true},
            new ProductReview(){ProductID=6,UserID=2,Rating=1,Review="Bad",Islike=false},
            new ProductReview(){ProductID=7,UserID=2,Rating=2,Review="Average",Islike=false},
            new ProductReview(){ProductID=8,UserID=3,Rating=3,Review="Average",Islike=false},
            new ProductReview(){ProductID=9,UserID=2,Rating=4,Review="Good",Islike=true},
            new ProductReview(){ProductID=10,UserID=2,Rating=5,Review="Excellent",Islike=true},
            new ProductReview(){ProductID=11,UserID=3,Rating=1,Review="Bad",Islike=false},
            new ProductReview(){ProductID=12,UserID=3,Rating=2,Review="Average",Islike=false},
            new ProductReview(){ProductID=13,UserID=3,Rating=3,Review="Average",Islike=false},
            new ProductReview(){ProductID=14,UserID=3,Rating=4,Review="Good",Islike=true},
            new ProductReview(){ProductID=15,UserID=3,Rating=5,Review="Excellent",Islike=true},
            new ProductReview(){ProductID=16,UserID=4,Rating=1,Review="Bad",Islike=false},
            new ProductReview(){ProductID=17,UserID=5,Rating=2,Review="Average",Islike=false},
            new ProductReview(){ProductID=18,UserID=4,Rating=3,Review="Average",Islike=false},
            new ProductReview(){ProductID=19,UserID=4,Rating=4,Review="Good",Islike=true},
            new ProductReview(){ProductID=20,UserID=6,Rating=5,Review="Excellent",Islike=true},
            new ProductReview(){ProductID=21,UserID=10,Rating=1,Review="Bad",Islike=false},
            new ProductReview(){ProductID=22,UserID=10,Rating=2,Review="Average",Islike=false},
            new ProductReview(){ProductID=23,UserID=10,Rating=3,Review="Good",Islike=true},
            new ProductReview(){ProductID=24,UserID=10,Rating=4,Review="Good",Islike=true},
            new ProductReview(){ProductID=25,UserID=10,Rating=5,Review="Excellent",Islike=true},
            };
            //foreach (var list in productReviewList)
            //{
            //    Console.WriteLine("ProductID :" + list.ProductID + "  " + "UserID :" + list.UserID + "  " + "Rating :" + list.Rating + "  " + "Review :" + list.Review + "  " + "isLike :" + list.Islike);
            //}
            Management management = new Management();
            //UC2
            //  management.Top3Records(productReviewList);
            //uc3
            // management.RetriveRecords(productReviewList);
            //uc4
            //  management.RetrieveCountOfRecords(productReviewList);
            //uc5
           // management.RetriveproductIDAndReviewFromList(productReviewList);
            //Uc6
            management.SkipTop5Records(productReviewList);

        }
    }
}
