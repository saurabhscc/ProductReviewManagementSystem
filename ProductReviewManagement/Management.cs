using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagement
{
    public class Management
    {
        public static int choice;
        public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReview> review)
        {
            var recordedData = (from list in review
                                orderby list.Rating descending
                                select list).Take(3);

            foreach (var item in recordedData)
            {
                Console.WriteLine("Product Id: " + item.ProductID + "\tUser Id: " + item.UserID + "\tProduct Rating: " + item.Rating  + "\tProduct Review:" + item.Review + "\tIsLike: " + item.IsLike);
            }
        }
        public void RetrivePerticularRecord(List<ProductReview> review)
        {
            var recordedData = from list in review
                               where (list.ProductID == 1 || list.ProductID == 4 || list.ProductID == 9) && list.Rating > 3
                               select list;
            foreach (var item in recordedData)
            {
                Console.WriteLine("Product Id: " + item.ProductID + "\tUser Id: " + item.UserID + "\tProduct Rating: " + item.Rating + "\tProduct Review:" + item.Review + "\tIs Like: " + item.IsLike);
            }
        }
        public void RetriveCountOfREcords(List<ProductReview> review)
        {
            var recordedData = review.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });

            foreach (var item in recordedData)
            {
                Console.WriteLine(item.ProductID + "---" + item.Count);
            }
        }
        public void RetriveProductIdAndReview(List<ProductReview> review)
        {
            var recordedData = from list in review
                               select new { list.ProductID, list.Rating };
            foreach (var item in recordedData)
            {
                Console.WriteLine("Product Id : " + item.ProductID + "\t\tProduct Rating : " + item.Rating);
            }
        }
        public void SkipTopFiveRecords(List<ProductReview> review)
        {
            var recordedData =( from list in review
                               select list).Skip(5);
            foreach (var item in recordedData)
            {
                Console.WriteLine("Product Id : " + item.ProductID + "\t\tProduct Rating : " + item.Rating);
            }
        }
        public void SelectIdAndReview(List<ProductReview> review)
        {
            var recordedData = from list in review
                               select new { list.ProductID, list.Review };
           
                                
            foreach (var item in recordedData)
            {
                Console.WriteLine("Product Id : " + item.ProductID + "\t\tProduct Review : " + item.Review);
            }
        
        }
        public void Operations()
        {
            Program program = new Program();
            while (choice !=10)
            {
                Console.WriteLine("\n Enter 1 for Display top Three records\n Enter 2 for Display Selected records\n Enter 3 for Display Count of Records For ProductID\n Enter 4 for Display ProductId And Review \n Enter 5 for Skip Top Five Records \n Enter 6 for Display ProductId And Review  \n Enter 7 for exit ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        TopRecords(Program.List);
                        break;
                    case 2:
                        RetrivePerticularRecord(Program.List);
                        break;
                    case 3:
                        RetriveCountOfREcords(Program.List);
                        break;
                    case 4:
                        RetriveProductIdAndReview(Program.List);
                        break;
                    case 5:
                        SkipTopFiveRecords(Program.List);
                        break;
                    case 6:
                        SelectIdAndReview(Program.List);
                        break;
                    default:
                        Console.WriteLine("Entered wrong input");
                        break;
                }
            }
        }
    }
}
