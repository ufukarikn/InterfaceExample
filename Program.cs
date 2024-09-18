using Interface;    

    var Customer = new Customer();
    Customer.Add();
    Customer.Delete();

    Console.WriteLine("************************");

    var Product = new Product();
    Product.Add();
    Product.Delete();
    Console.WriteLine(Product.Plus(9));

    Console.WriteLine("************************");

    var Tshirt = new Tshirt();
    Console.WriteLine(Tshirt.ChangeColor());

    Console.WriteLine("************************");

    var Short = new Short();
    Console.WriteLine(Short.ChangeColor());
