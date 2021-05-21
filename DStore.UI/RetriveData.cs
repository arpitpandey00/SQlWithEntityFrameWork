using DStore.Data;
using DStore.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DStore.UI
{
    public class RetriveData
    {
        public static void StaffRecordOnRole()
            {
            using (DStoreContext context = new DStoreContext())
            {
                var query = from stafff in context.Set<Staff>() join roles in context.Set<Role>() on stafff.RoleId equals roles.RoleId
                            join address in context.Set<Address>() on stafff.AddressId equals address.AddressId
                            where roles.RoleName=="Sales"
                            select new
                            {
                                stafff.FirstName,
                                stafff.LastName,
                                stafff.PhoneNumber,
                                stafff.Salary,
                                address.AddressLine1,
                                address.AddressLine2,
                                address.City,
                                address.State,
                                address.Pincode,
                                roles.RoleName,
                                roles.Description,
                                stafff.Gender
                            };

                foreach (var staff in query)
                {
                    Console.WriteLine($"{staff.FirstName},{staff.LastName},{staff.Salary},{staff.PhoneNumber},{staff.Gender},{staff.AddressLine1}{staff.AddressLine2}" +
                     $"{staff.City}{staff.State}{staff.Pincode}");
                }
            }

        }
        public static void StaffRecordPhoneOrName()
        {
            using (DStoreContext context = new DStoreContext())
            {
                var query = from stafff in context.Set<Staff>()
                            join roles in context.Set<Role>() on stafff.RoleId equals roles.RoleId
                            join address in context.Set<Address>() on stafff.AddressId equals address.AddressId
                            where stafff.PhoneNumber == "9876543210" || stafff.FirstName == "Divya"
                            select new { stafff,address,roles} ;

                foreach (var staff in query)
                {
                    Console.WriteLine($"{staff.stafff.FirstName},{staff.stafff.LastName},{staff.stafff.Salary},{staff.stafff.PhoneNumber},{staff.stafff.Gender}," +
                        $"{staff.address.AddressLine1}{staff.address.AddressLine2}" +
                     $"{staff.address.City}{staff.address.State}{staff.address.Pincode},{staff.roles.RoleName}");
                }
            }
        }
        public static void ProductOutOfStock()
        {
            using(DStoreContext context = new DStoreContext())
            {
                var query = from product in context.Set<Product>() where product.InStock==false
                            
                            select ( new { product.ProductId }) ;
                var count = query.Count();

                Console.WriteLine($"No fo product out of stock {count}");
            }
        }
        public static void ProductNameCategoryStockPrice()
        {
            using (DStoreContext context = new DStoreContext())
            {
                var query = from product in context.Set<Product>()  join prodcategory in context.Set<ProductCategory>() on 
                            product.ProductId equals prodcategory.ProductId join category in  context.Set<Category>() on
                            prodcategory.CategoryId equals category.CategoryId
                            where product.ProductName=="Nestlry" || product.Manufacturer=="ncert"||product.InStock==true ||category.CategoryName=="Dairy"
                            select (new { product,category });
                
                foreach(var items in query)
                {
                    Console.WriteLine($"{items.product.ProductName},{items.product.InStock},{items.product.ExpiryDate},{items.category.CategoryName},{items.product.ProductCode}");
                
                }
            }
        }
        public static void ProductWithinCategory()
        {
            using (DStoreContext context = new DStoreContext())
            {
                var query = from category in context.Set<Category>() join prodcategory in context.Set<ProductCategory>() on
                            category.CategoryId equals prodcategory.CategoryId join product in context.Set<Product>() on
                            prodcategory.ProductId equals product.ProductId
                            group product by category.CategoryId into refGroup
                            select (new {   count = refGroup.Count<Product>(),CategoryId=refGroup.Key  });
               foreach(var item in query)
                {
                Console.WriteLine($"{item.CategoryId} {item.count}");
                }
            }

        }
        public static void MaxProductWithinCategoryInAscending()
        {
            using (DStoreContext context = new DStoreContext())
            {
                //var query = 
            }

        }
        public static void SupplierDetails()
        {
            using (DStoreContext context = new DStoreContext())
            {
                var query = from supplier in context.Set<Supplier>() join supplireprodorder in context.Set<SupplierProductOrder>() on
                            supplier.SupplierId equals supplireprodorder.SupplierId join prodt in context.Set<Product>() on
                            supplireprodorder.ProductId equals prodt.ProductId join address in context.Set<Address>() on
                            supplier.AddressId equals address.AddressId join prodorder in context.Set<ProductOrder>() on
                            supplireprodorder.ProductOrderId equals prodorder.ProductOrderId 
                            select (new {supplier,prodorder,prodt,address});
                foreach(var item in query)
                {
                    Console.WriteLine($"supplier : {item.supplier.SupplierName} supplied product : {item.prodt.ProductName} date of supply : {item.prodorder.OrderTime}" +
                        $"supplier address : { item.address.AddressLine1}{item.address.AddressLine2} {item.address.City},{item.address.State}({item.address.Pincode})");
                }
            }

        }
        public static void ProductAndSupplierWithRecentDatesOfSupply()
        {
            using (DStoreContext context = new DStoreContext())
            {
                var query = from product in context.Set<Product>() join posupplier in context.Set<SupplierProductOrder>() on
                            product.ProductId equals posupplier.ProductId join supplier in context.Set<Supplier>() on
                            posupplier.SupplierId equals supplier.SupplierId join po in context.Set<ProductOrder>() on
                            posupplier.ProductOrderId equals po.ProductOrderId join inventory in context.Set<Inventory>() on
                            product.ProductId equals inventory.ProductId
                            where  po.OrderTime.Date <= new DateTime(2021,04,01) || inventory.ProductQuantity >= 2
                            select (new {product,po,supplier,inventory});
                foreach(var item in query)
                {
                    Console.WriteLine($"{item.product.ProductName}-->{item.supplier.SupplierName}-->{item.po.OrderTime}-->{item.inventory.ProductQuantity}");
                }

            }

        }


    }
}
