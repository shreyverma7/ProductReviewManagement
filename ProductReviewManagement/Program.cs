using ProductReviewManagement;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Product review Management");
        List<Product> list = new List<Product>();
        list.Add(new Product()
        {
            ProductID = 1,
            UserID = 1,
            Rating =5,
            Review = "Good",
            isLike = true,
        });
        list.Add(new Product()
        {
            ProductID = 1,
            UserID = 2,
            Rating = 4,
            Review = "Good",
            isLike = true,
        });
        list.Add(new Product()
        {
            ProductID = 1,
            UserID = 3,
            Rating = 3,
            Review = "Avg",
            isLike = true,
        });
        list.Add(new Product()
        {
            ProductID = 1,
            UserID = 4,
            Rating = 1,
            Review = "bad",
            isLike = false,
        });
        list.Add(new Product()
        {
            ProductID = 2,
            UserID = 1,
            Rating = 1,
            Review = "bad",
            isLike = false,
        });
        list.Add(new Product()
        {
            ProductID = 2,
            UserID = 2,
            Rating = 3,
            Review = "Avg",
            isLike = true,
        });
        list.Add(new Product()
        {
            ProductID = 2,
            UserID = 3,
            Rating = 4,
            Review = "Good",
            isLike = true,
        });
        list.Add(new Product()
        {
            ProductID = 2,
            UserID = 5,
            Rating = 5,
            Review = "Good",
            isLike = true,
        });
        list.Add(new Product()
        {
            ProductID = 3,
            UserID = 5,
            Rating = 5,
            Review = "Good",
            isLike = true,
        });
        list.Add(new Product()
        {
            ProductID = 3,
            UserID = 4,
            Rating = 5,
            Review = "Good",
            isLike = true,
        });
        list.Add(new Product()
        {
            ProductID = 3,
            UserID = 3,
            Rating = 3,
            Review = "avg",
            isLike = true,
        });
        list.Add(new Product()
        {
            ProductID = 3,
            UserID = 2,
            Rating = 1,
            Review = "bad",
            isLike = false,
        });
        list.Add(new Product()
        {
            ProductID = 4,
            UserID = 1,
            Rating = 5,
            Review = "Good",
            isLike = true,
        });
        list.Add(new Product()
        {
            ProductID = 4,
            UserID = 2,
            Rating = 5,
            Review = "Good",
            isLike = true,
        });
        list.Add(new Product()
        {
            ProductID = 4,
            UserID = 3,
            Rating = 3,
            Review = "avg",
            isLike = true,
        });
        list.Add(new Product()
        {
            ProductID = 4,
            UserID = 4,
            Rating = 1,
            Review = "bad",
            isLike = false,
        });
    }
}