using IsKaiser.Management.Core.DataAccess.EntityFramework;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Dal.Concrete.EntityFramework
{
    public class EfCustomerDal : EfRepositoryBase<Customer, IsKaiserContext>, ICustomerDal
    {
        public void AddWithTransaction(Customer customer, CustomerAccountant customerAccountant, 
            CustomerDirector customerDirector, CustomerPurchasingStaff purchasingStaff)
        {
            using (IsKaiserContext context=new IsKaiserContext())
            {
                using(var transaction=context.Database.BeginTransaction())
                {
                    context.Customers.Add(customer);
                    context.SaveChanges();

                    customerAccountant.CustomerId = customer.CustomerId;
                    context.CustomerAccountants.Add(customerAccountant);
                    context.SaveChanges();

                    customerDirector.CustomerId = customer.CustomerId;
                    context.CustomerDirectors.Add(customerDirector);
                    context.SaveChanges();

                    purchasingStaff.CustomerId = customer.CustomerId;
                    context.CustomerPurchasingStaffs.Add(purchasingStaff);
                    context.SaveChanges();

                    transaction.Commit();

                }
            }
        }

        public void DeleteWithTransaction(Customer customer, CustomerAccountant customerAccountant,
            CustomerDirector customerDirector, CustomerPurchasingStaff purchasingStaff)
        {
            using (IsKaiserContext context = new IsKaiserContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    context.Customers.Remove(customer);
                    context.SaveChanges();

                    context.CustomerAccountants.Remove(customerAccountant);
                    context.SaveChanges();
                    
                    context.CustomerDirectors.Remove(customerDirector);
                    context.SaveChanges();
                    
                    context.CustomerPurchasingStaffs.Remove(purchasingStaff);
                    context.SaveChanges();

                    transaction.Commit();

                }
            }
        }

        public CustomerAccountant GetAccountant(int customerId)
        {
            using (IsKaiserContext context = new IsKaiserContext())
            {
                return context.CustomerAccountants.FirstOrDefault(c => c.CustomerId == customerId);
            }
        }
        
        public CustomerDirector GetDirector(int customerId)
        {
            using (IsKaiserContext context = new IsKaiserContext())
            {
                return context.CustomerDirectors.FirstOrDefault(c => c.CustomerId == customerId);
            }
        }

        public CustomerPurchasingStaff GetPurchasingStaff(int customerId)
        {
            using (IsKaiserContext context=new IsKaiserContext())
            {
                return context.CustomerPurchasingStaffs.FirstOrDefault(c => c.CustomerId == customerId);
            }
        }

        public void UpdateWithTransaction(Customer customer, CustomerAccountant customerAccountant, 
            CustomerDirector customerDirector, CustomerPurchasingStaff purchasingStaff)
        {
            using (IsKaiserContext context = new IsKaiserContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    context.Customers.Update(customer);
                    context.SaveChanges();

                  
                    context.CustomerAccountants.Update(customerAccountant);
                    context.SaveChanges();

                  
                    context.CustomerDirectors.Update(customerDirector);
                    context.SaveChanges();

              
                    context.CustomerPurchasingStaffs.Update(purchasingStaff);
                    context.SaveChanges();

                    transaction.Commit();

                }
            }
        }
    }
}
