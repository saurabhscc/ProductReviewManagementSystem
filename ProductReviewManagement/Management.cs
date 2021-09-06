﻿using System;
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
                Console.WriteLine("Product ID: " + item.ProductID + "\tUser ID: " + item.UserID + "\tProduct Rating: " + item.Rating  + "\tProduct Review:" + item.Review + "\tIsLike: " + item.IsLike);
            }
        }
        public void RetrivePerticularRecord(List<ProductReview> review)
        {
            var recordedData = from list in review
                               where (list.ProductID == 1 || list.ProductID == 4 || list.ProductID == 9) && list.Rating > 3
                               select list;
            foreach (var item in recordedData)
            {
                Console.WriteLine("Product ID: " + item.ProductID + "\tUser ID: " + item.UserID + "\tProduct Rating: " + item.Rating + "\tProduct Review:" + item.Review + "\tIs Like: " + item.IsLike);
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
                Console.WriteLine("Product ID : " + item.ProductID + "\t\tProduct Rating : " + item.Rating);
            }
        }
        public void SkipTopFiveRecords(List<ProductReview> review)
        {
            var recordedData =( from list in review
                               select list).Skip(5);
            foreach (var item in recordedData)
            {
                Console.WriteLine("Product ID : " + item.ProductID + "\t\tProduct Rating : " + item.Rating);
            }
        }
        public void SelectIdAndReview(List<ProductReview> review)
        {
            var recordedData = from list in review
                               select new { list.ProductID, list.Review };
           
                                
            foreach (var item in recordedData)
            {
                Console.WriteLine("Product ID : " + item.ProductID + "\t\tProduct Review : " + item.Review);
            }
        
        }
        public void DataTable(List<ProductReview> review)
        {
            dataTable.Columns.Add("ProductID", typeof(int));
            dataTable.Columns.Add("UserID", typeof(int));
            dataTable.Columns.Add("Rating", typeof(double));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("IsLike", typeof(bool));
            var recordedData = from list in review
                               select list;
            foreach (var item in recordedData)
            {
                dataTable.Rows.Add(item.ProductID, item.UserID, item.Rating, item.Review, item.IsLike);
            }
            var dataRow = from list in dataTable.AsEnumerable() select list;
            foreach (var item in dataRow)
            {
                Console.WriteLine(item.Field<int>("ProductID") + " " + item.Field<int>("UserID") + " " +
                    item.Field<double>("Rating") + " " + item.Field<string>("Review") + " " +
                    item.Field<bool>("IsLike") + " ");
            }
        }
        public void RetriveRecordzFromDataTable(List<ProductReview> review)
        {
            var recordedData = from list in review
                               where list.IsLike = true
                               orderby list.ProductID
                               select list;

            foreach (var item in recordedData)
            {
                Console.WriteLine("Product ID: " + item.ProductID + "User ID: " + item.UserID + "Product Rating: " + item.Rating + "Product Review: " + item.Review + "Is Like: " + item.IsLike);
            }
        }
        public void AveragePerProductID(List<ProductReview> review)
        {
            var recordedData = review.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, AverageRating = x.Average(x => x.Rating) });
            foreach (var item in recordedData)
            {
                Console.WriteLine(item.ProductID + " " + item.AverageRating);
            }
        }
        public void RetriveRecordUsingReview(List<ProductReview> review,string msg)
        {
            var recordedData = from list in review
                               where list.Review == msg
                               select list;
            foreach(var item in recordedData)
            {
                Console.WriteLine("Product ID: " + item.ProductID + "User ID: " + item.UserID + "Product Rating: " + item.Rating + "Product Review: " + item.Review + "Is Like: " + item.IsLike);

            }

        }
        public void Operations()
        {
            Program program = new Program();
            while (choice !=15)
            {
                Console.WriteLine("\n Enter 1. Display top Three records\n Enter 2.Display Selected records\n Enter 3.Display Count of Records For ProductID\n Enter 4.Display ProductId And Review \n Enter 5.Skip Top Five Records \n Enter 6.Display ProductId And Review \n Enter 7.Display Datatable\n Enter 8.Display Record IsLike \n Enter 9.Display Average Per ProductID \n Enter 10.Display Record Using Review   \n Enter 11.exit ");
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
                    case 7:
                        DataTable(Program.List);
                        break;
                    case 8:
                        RetriveRecordzFromDataTable(Program.List);
                        break;
                    case 9:
                        AveragePerProductID(Program.List);
                        break;
                    case 10:
                        RetriveRecordUsingReview(Program.List, "nice");
                        break;
                    default:
                        Console.WriteLine("Entered wrong input");
                        break;
                }
            }
        }
    }
}
