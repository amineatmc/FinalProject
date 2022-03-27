// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
class Program
{
    static void Main(string[] args)
    {
        ProductTest();
        //CategoryTest();

    }

    public static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        foreach (var item in categoryManager.GetAll().Data)
        {
            Console.WriteLine(item.CategoryName);
        }
    }

    public static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal()
            ,new CategoryManager(new EfCategoryDal()));
        var result = productManager.GetProductDetails();
        if (result.Success==true)
        {
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.ProductName+ " / " + item.CategoryName+"/"+item.UnitPrice);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
      
    }
}
