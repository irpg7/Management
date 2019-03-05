using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.WinUI.Utilities
{
    public class ExcelImporter:IExcelImporter
    {
        Customer importedCustomer;
        CustomerAccountant importedAccountant;
        CustomerDirector importedDirector;
        CustomerPurchasingStaff importedStaff;
        public void ImportXl(string path,ICustomerService customerService)
        {
            try
            {
                string xlConn = string
                .Format($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={path};Extended Properties=\"Excel 12.0;HDR=NO;\"");

                using (OleDbConnection xconn = new OleDbConnection(xlConn))
                {
                    OleDbCommand xcmd = new OleDbCommand("select * from [Sayfa1$]", xconn);
                    OleDbDataReader xdr;

                    xconn.Open();
                    xdr = xcmd.ExecuteReader();
                    while (xdr.Read())
                    {
                        importedCustomer = new Customer
                        {
                            CustomerCode = xdr[0].ToString(),
                            CustomerName = xdr[1].ToString(),
                            CustomerTaxNo = xdr[2].ToString(),
                            CustomerTaxDepartment = xdr[3].ToString(),
                            CustomerAddress = xdr[4].ToString()
                        };
                        
                        importedDirector = new CustomerDirector
                        {
                            CustomerId = importedCustomer.CustomerId,
                            DirectorName = xdr[5].ToString(),
                            DirectorTitle = xdr[6].ToString(),
                            DirectorGsm = xdr[7].ToString(),
                            DirectorMail = xdr[8].ToString(),
                            DirectorPhone = xdr[9].ToString()
                        };
                        importedStaff = new CustomerPurchasingStaff {
                            CustomerId=importedCustomer.CustomerId,
                            PurchaseStaffName=xdr[10].ToString(),
                            PurchaseStaffGsm=xdr[11].ToString(),
                            PurchaseStaffMail=xdr[12].ToString(),
                            PurchaseStaffPhone=xdr[13].ToString()
                        };
                        importedAccountant = new CustomerAccountant
                        {
                            CustomerId = importedCustomer.CustomerId,
                            AccountantName = xdr[14].ToString(),
                            AccountantGsm = xdr[15].ToString(),
                            AccountantMail = xdr[16].ToString(),
                            AccountantPhone = xdr[17].ToString(),
                            AccountantExpiry = Convert.ToDateTime(xdr[18],CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat)
                        };
                        customerService.Add(importedCustomer,importedAccountant,importedDirector,importedStaff);
                    }
                    xconn.Close();
                }
            }
            catch(Exception exception)
            {
                throw new Exception($"Hata {importedCustomer.CustomerName} " + 
                    exception.Message+"\r Hatalı kayıt Silindi.");
            }
        }
        
    }
}
