using DStore.Data.Infrastructure;
using System;

namespace DStore.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");
            // entered categories
            //using(DStoreContext context = new DStoreContext())
            //{
            //    context.Categories.Add(new Data.Category { CategoryName = "Chocolate" });
            //    context.Categories.Add(new Data.Category { CategoryName = "Book" });
            //    context.Categories.Add(new Data.Category { CategoryName = "Dairy" });
            //    context.Categories.Add(new Data.Category { CategoryName = "Cosmetic" });
            //    context.SaveChanges();
            //    Console.WriteLine("data Added Successfully");
            //}
            //using(DStoreContext context = new DStoreContext())
            //{
            //    context.Addresses.AddRange(new Data.Address {AddressLine1="govind nagar",AddressLine2="123/7 a block",City= "kanpur", State= "uttar pradesh", Pincode="208014" },
            //       new Data.Address { AddressLine1 = "geetapuram", AddressLine2 = "A1 vaishali apartment", City = "jabalpur", State = "madhya paradesh", Pincode = "230914" },
            //        new Data.Address { AddressLine1 = "sanjayghandhi puram", AddressLine2 = "near hotel pinacle", City = "balco", State = "chattisghar", Pincode = "340013" },
            //         new Data.Address { AddressLine1 = "121/3", AddressLine2 = "F block", City = "patna", State = "bihar", Pincode = "554612" });
            //    context.SaveChanges();
            //    Console.WriteLine("data Added Successfully");
            //}
            //using (DStoreContext context = new DStoreContext())
            //{
            //    context.Suppliers.AddRange(new Data.Supplier { SupplierName= "Peter", SupplierAge= 30, AddressId=1 ,Gender= "M" ,PhoneNumber= "7875767972" },
            //        new Data.Supplier { SupplierName = "Kylie", SupplierAge = 20, AddressId = 2, Gender = "F", PhoneNumber = "7874447972" },
            //        new Data.Supplier { SupplierName = "Pushpa", SupplierAge = 25, AddressId = 3, Gender = "F", PhoneNumber = "7875777772" },
            //        new Data.Supplier { SupplierName = "Udit", SupplierAge = 27, AddressId = 4, Gender = "M", PhoneNumber = "7875761111" }
            //        );
            //    context.SaveChanges();
            //    Console.WriteLine("data Added Successfully");
            //}
            //-----------------------
            //using (DStoreContext context = new DStoreContext())
            //{
            //    context.SupplierProductOrders.AddRange(
            //        new Data.SupplierProductOrder { ProductId =1, ProductOrderId = 6, SupplierId = 3 },
            //    new Data.SupplierProductOrder { ProductId = 2, ProductOrderId = 7, SupplierId = 2 },
            //    new Data.SupplierProductOrder { ProductId = 3, ProductOrderId = 5, SupplierId = 1 },
            //    new Data.SupplierProductOrder {ProductId = 4, ProductOrderId = 8, SupplierId = 3 },
            //    new Data.SupplierProductOrder { ProductId = 5, ProductOrderId = 4, SupplierId = 4 },
            //    new Data.SupplierProductOrder { ProductId = 2, ProductOrderId = 9, SupplierId = 4 },
            //    new Data.SupplierProductOrder { ProductId = 6, ProductOrderId = 3, SupplierId = 1 },
            //    new Data.SupplierProductOrder { ProductId = 7, ProductOrderId = 12, SupplierId = 2 },
            //    new Data.SupplierProductOrder { ProductId = 8, ProductOrderId = 2, SupplierId = 3 },
            //    new Data.SupplierProductOrder { ProductId = 4, ProductOrderId = 1, SupplierId = 2 },
            //    new Data.SupplierProductOrder { ProductId = 3, ProductOrderId = 10, SupplierId = 1 },
            //    new Data.SupplierProductOrder { ProductId = 1, ProductOrderId = 11, SupplierId = 4 }

            //   );
            //    context.SaveChanges();
            //    Console.WriteLine("data Added Successfully");
            //}
            //using (DStoreContext context = new DStoreContext())
            //{
            //    context.productOrders.AddRange(
            //        new Data.ProductOrder { OrderTime= new DateTime(2021,01,11), Qunatity= 10 },
            //        new Data.ProductOrder { OrderTime = new DateTime(2021 , 05 , 15), Qunatity =1},
            //        new Data.ProductOrder { OrderTime = new DateTime(2021 , 03 , 17), Qunatity =3},
            //        new Data.ProductOrder { OrderTime = new DateTime(2020 , 01 ,11), Qunatity =2},
            //        new Data.ProductOrder { OrderTime = new DateTime(2021 , 05 , 11), Qunatity =9},
            //        new Data.ProductOrder { OrderTime = new DateTime(2021 , 05 , 12), Qunatity =6},
            //        new Data.ProductOrder { OrderTime = new DateTime(2021 , 05 , 13), Qunatity =4},
            //        new Data.ProductOrder { OrderTime = new DateTime(2020 , 11 , 17), Qunatity = 2 },
            //        new Data.ProductOrder { OrderTime = new DateTime(2021 , 05 , 14), Qunatity = 7 },
            //        new Data.ProductOrder { OrderTime = new DateTime(2021 ,02 , 15), Qunatity = 20 },
            //        new Data.ProductOrder { OrderTime = new DateTime(2021 , 03 , 12), Qunatity = 3 },
            //        new Data.ProductOrder { OrderTime = new DateTime(2020 , 10 , 30), Qunatity = 1 }
            //        );
            //    context.SaveChanges();
            //    Console.WriteLine("data Added Successfully");
            //}
            //using (DStoreContext context = new DStoreContext())
            //{
            //    context.Roles.AddRange(
            //        new Data.Role { RoleName = "Sales", Description = "sales executive" },
            //        new Data.Role { RoleName = "Manager", Description = "Brach manager" },
            //        new Data.Role { RoleName = "Help Desk", Description = "For help 24 X 7" },
            //        new Data.Role { RoleName = "Security", Description = "Gaurds" },
            //        new Data.Role { RoleName = "Reception", Description = "Billing Counter" },
            //        new Data.Role { RoleName = "Senior Manager", Description = "Zone manager" }

            //        );
            //    context.SaveChanges();
            //    Console.WriteLine("data Added Successfully");
            //}
            //using (DStoreContext context = new DStoreContext())
            //{
            //    context.Addresses.AddRange(new Data.Address { AddressLine1 = "jankipuram", AddressLine2 = "near green city", City = "Lucknow", State = "uttar pradesh", Pincode = "209801" },
            //       new Data.Address { AddressLine1 = "imambada", AddressLine2 = "ganges apartment", City = "Gwalior", State = "madhya pradesh", Pincode = "667542" },
            //        new Data.Address { AddressLine1 = "cp", AddressLine2 = "flat no 112 ,amarpali", City = "Delhi", State = "delhi", Pincode = "567882" },
            //         new Data.Address { AddressLine1 = "thaden", AddressLine2 = "g block", City = "Mumbai", State = "maharashtra", Pincode = "456711" });
            //    context.SaveChanges();
            //    Console.WriteLine("data Added Successfully");
            //}
            //using (DStoreContext context = new DStoreContext())
            //{
            //    context.Staffs.AddRange(
            //    new Data.Staff { FirstName= "Alex", LastName="kumar",AddressId=3,Gender="M",PhoneNumber= "9876543210", Salary=10000,RoleId=1},
            //    new Data.Staff { FirstName = "Natasha", LastName = "Carry", AddressId =4, Gender = "F", PhoneNumber = "9876543211", Salary =10000, RoleId =1},
            //    new Data.Staff { FirstName = "Emma", LastName = "Watson", AddressId =1, Gender = "F", PhoneNumber = "9876543212", Salary =10000, RoleId =1},
            //    new Data.Staff { FirstName = "Parker", LastName = "Ben", AddressId =6, Gender = "M", PhoneNumber = "9876543213", Salary =10000, RoleId =1},
            //    new Data.Staff { FirstName = "Abhimanyu", LastName = "Rajpoot", AddressId =2, Gender = "M", PhoneNumber = "9876543214", Salary = 28000, RoleId =2},
            //    new Data.Staff { FirstName = "Gauri", LastName = "Kumari", AddressId =7, Gender = "F", PhoneNumber = "9876543215", Salary = 28000, RoleId =2},
            //    new Data.Staff { FirstName = "Ram", LastName = "Prasad", AddressId =2, Gender = "M", PhoneNumber = "9876543216", Salary =9000, RoleId =3},
            //    new Data.Staff { FirstName = "Rehan", LastName = "Sultan", AddressId =5, Gender = "M", PhoneNumber = "9876543217", Salary = 7500, RoleId =4},
            //    new Data.Staff { FirstName = "Hema", LastName = "Venkatesh", AddressId =8, Gender = "F", PhoneNumber = "9876543218", Salary = 7500, RoleId =4},
            //    new Data.Staff { FirstName = "Pralay", LastName = "Hota", AddressId =1, Gender = "M", PhoneNumber = "9876543219", Salary =12500, RoleId =5},
            //     new Data.Staff { FirstName = "Divya", LastName = "Singhanaya", AddressId = 1, Gender = "F", PhoneNumber = "9876543220", Salary =12500, RoleId = 5 },
            //      new Data.Staff { FirstName = "Abhishesh", LastName = "Chaturvedi", AddressId = 1, Gender = "M", PhoneNumber = "9876543221", Salary =39500, RoleId = 6 }
            //        );
            //    context.SaveChanges();
            //    Console.WriteLine("data Added Successfully");


            //}



        }
    }
}
