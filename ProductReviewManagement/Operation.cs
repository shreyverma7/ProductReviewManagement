using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Operation
    {
        //UC2
        public void RetrieveTopRecords(List<Product> list)
        {
            var result = list.Where(x => x.Rating == 5).Take(3);
            Display(result.ToList());
        }
        public void Display(List<Product> list)
        {
            foreach (var data in list) 
            {
                Console.WriteLine(data.ProductID);
                Console.WriteLine(data.UserID);
                Console.WriteLine(data.Rating);
                Console.WriteLine(data.Review);
                Console.WriteLine(data.isLike);
                Console.WriteLine("-------------------------------");

            }
        }

        //UC3
        public void RetrieveAllRecordsWithCondition(List<Product> list)
        {
            var result = list.Where(x => x.Rating > 3 && (x.ProductID == 1 || x.ProductID == 4 || x.ProductID == 9));
            Display(result.ToList());
        }
        //UC4
        public void UsingGroupBy(List<Product> list)
        {
            var result = list.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key,Count = x.Count()});
            foreach(var data in result)
            {
                Console.WriteLine(data.ProductID +"   "+data.Count);
            }
        }
        //UC5
        public void RetreiveProductIdAndReview (List<Product> list)
        {
            var result = list.Select(x => new { ProductId = x.ProductID, Review = x.Review});
            foreach (var data in result)
            {
                Console.WriteLine(data.ProductId +"    "+ data.Review);
            }
        }
        //UC6
        public void SkipTopRecords(List<Product> list)
        {
            var result = list.Skip(5);
            Display(result.ToList());
        }
        //UC7
        public void RetreiveProductIdAndReviews(List<Product> list)
        {
            var result = list.Select(x => new { ProductId = x.ProductID, Review = x.Review });
            foreach (var data in result)
            {
                Console.WriteLine(data.ProductId + "    " + data.Review);
            }
        }
        //UC8
        DataTable table = new DataTable();
        public void AddDataToDataTable(List<Product> list) 
        {
            table.Columns.Add("ProductId").DataType = typeof(int);
            table.Columns.Add("UserId").DataType = typeof(int);
            table.Columns.Add("Rating").DataType = typeof(int);
            table.Columns.Add("Review").DataType = typeof(string);
            table.Columns.Add("IsLike").DataType = typeof(bool);
            foreach(var data in list)
            {
                table.Rows.Add(data.ProductID,data.UserID,data.Rating,data.Review,data.isLike);
            }
            foreach(var item in table.AsEnumerable())
            {
                Console.WriteLine(item.Field<int>("ProductId"));
                Console.WriteLine(item.Field<int>("UserID"));
                Console.WriteLine(item.Field<int>("Rating"));
                Console.WriteLine(item.Field<string>("Review"));
                Console.WriteLine(item.Field<bool>("IsLike"));
                Console.WriteLine("::::::::::::::::::::::::::::::");
            }
        }
        //UC9
        public void RetreiveRecordsFromDataTable()
        {
            var result = table.AsEnumerable().Where(x => x.Field<bool>("IsLike").Equals(true));
            foreach(var item in result.AsEnumerable())
            {
                Console.WriteLine(item.Field<int>("ProductId"));
            }
        }
        //UC10
        public void AvgRating(List<Product> list)
        {
            var result = list.Average(x => x.Rating);
            Console.WriteLine(result);
        }

    }
}
