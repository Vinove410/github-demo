using System;
using System.Collections.Generic;
using System.Text;

namespace DIExample
{
   public class VendorDal
    {
        #region Interface
        public interface IVendorDL // IVendorDAL  //Rename 
        {
            // List<Vendor> SelectAllVendors();
        }
        #endregion

        #region Abstract Class

        public abstract class IVendorDAL
        {
            public abstract List<Vendor> SelectAllVendors();


            //public List<Vendor> SelectAllVendors()
            //{
            //    List<Vendor> ListEmployees = new List<Vendor>();
            //    //Get the Vendors from the Database
            //    //for now we are hard coded the Vendor
            //    ListEmployees.Add(new Vendor() { ID = 1, Name = "Amar", Department = "Offline" });
            //    ListEmployees.Add(new Vendor() { ID = 2, Name = "Riya", Department = "Online" });
            //    ListEmployees.Add(new Vendor() { ID = 3, Name = "Shiv", Department = "Online" });
            //    return ListEmployees;
            //}
        }

        #endregion

        #region Traditional Approach
        //public List<Vendor> SelectAllVendors()
        //{
        //    List<Vendor> ListEmployees = new List<Vendor>();
        //    //Get the Vendors from the Database
        //    //for now we are hard coded the Vendor
        //    ListEmployees.Add(new Vendor() { ID = 1, Name = "Amar", Department = "Offline" });
        //    ListEmployees.Add(new Vendor() { ID = 2, Name = "Riya", Department = "Online" });
        //    ListEmployees.Add(new Vendor() { ID = 3, Name = "Shiv", Department = "Online" });
        //    return ListEmployees;
        //}
        #endregion

    }
}
