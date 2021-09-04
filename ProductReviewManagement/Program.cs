using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Product Review Management");
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=5,Review="Good,isLike=True"},
                new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="nice,isLike=True"},
                new ProductReview(){ProductID=3,UserID=1,Rating=5,Review="Good,isLike=True"},
                new ProductReview(){ProductID=4,UserID=1,Rating=4,Review="nice,isLike=True"},
                new ProductReview(){ProductID=5,UserID=1,Rating=5,Review="Good,isLike=True"},
                new ProductReview(){ProductID=6,UserID=1,Rating=3,Review="Good,isLike=True"},
                new ProductReview(){ProductID=7,UserID=2,Rating=5,Review="Good,isLike=True"},
                new ProductReview(){ProductID=8,UserID=2,Rating=5,Review="Good,isLike=True"},
                new ProductReview(){ProductID=9,UserID=1,Rating=5,Review="Good,isLike=True"},
                new ProductReview(){ProductID=10,UserID=1,Rating=5,Review="Good,isLike=True"},
                new ProductReview(){ProductID=11,UserID=1,Rating=4,Review="nice,isLike=True"},
                new ProductReview(){ProductID=12,UserID=1,Rating=5,Review="Good,isLike=True"},
                new ProductReview(){ProductID=13,UserID=1,Rating=2,Review="nice,isLike=True"},
                new ProductReview(){ProductID=14,UserID=1,Rating=5,Review="Good,isLike=True"},
                new ProductReview(){ProductID=15,UserID=3,Rating=5,Review="Good,isLike=True"},
                new ProductReview(){ProductID=16,UserID=3,Rating=2,Review="nice,isLike=True"},
                new ProductReview(){ProductID=17,UserID=1,Rating=4,Review="nice,isLike=True"},
                new ProductReview(){ProductID=18,UserID=1,Rating=5,Review="Good,isLike=True"},
                new ProductReview(){ProductID=19,UserID=4,Rating=1,Review="bad,isLike=True"},
                new ProductReview(){ProductID=20,UserID=4,Rating=5,Review="Good,isLike=True"},
                new ProductReview(){ProductID=21,UserID=1,Rating=5,Review="Good,isLike=True"},
                new ProductReview(){ProductID=22,UserID=1,Rating=1,Review="bad,isLike=True"},
                new ProductReview(){ProductID=23,UserID=1,Rating=4,Review="nice,isLike=True"},
                new ProductReview(){ProductID=24,UserID=1,Rating=1,Review="bad,isLike=True"},
                new ProductReview(){ProductID=25,UserID=1,Rating=5,Review="Good,isLike=True"},
            };
        }
    }
}
