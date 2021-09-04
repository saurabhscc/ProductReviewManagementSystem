using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagement
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReview> review)
        {
            var recordedData = (from list in review
                                orderby list.Rating descending
                                select list).Take(3);

            foreach (var item in recordedData)
            {
                Console.WriteLine("Product Id: " + item.ProductID + "\tUser Id: " + item.UserID + "\tProduct Rating: " + item.Rating  + "\tProduct Review:" + item.Review + "\tIs Like: " + item.IsLike);
            }
        }
    }
}
