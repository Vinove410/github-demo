using System;
using System.Collections.Generic;
using System.Text;
using static DIExample.VendorDal;

namespace DIExample
{
    class VendorBal : IVendorDAL, IVendorDL
    {
       VendorDal vendorDAL;

        #region Dependency from abstract class

        public override List<Vendor> SelectAllVendors()
        {
            List<Vendor> ListEmployees = new List<Vendor>();
            //Get the Vendors from the Database
            //for now we are hard coded the Vendor
            ListEmployees.Add(new Vendor() { ID = 1, Name = "Amar", Department = "Offline" });
            ListEmployees.Add(new Vendor() { ID = 2, Name = "Riya", Department = "Online" });
            ListEmployees.Add(new Vendor() { ID = 3, Name = "Shiv", Department = "Online" });
            return ListEmployees;
        }
        public class DI
        {
            private IVendorDL _av;

            public VendorBal vb
            {
                get { return _av as VendorBal; }
                set { _av = value; }
            }

            public DI(IVendorDL av)
            {
                _av = av;
            }

        }

        #endregion

        #region Interface D.I

        #region Constructor Injection
        //public IVendorDAL vendorDAL;
        //public VendorBal(IVendorDAL vendorDAL)
        //{
        //    this.vendorDAL = vendorDAL;
        //}
        #endregion

        #region Property
        //private IVendorDAL vendorDAL;
        //public IVendorDAL vendorDataObject
        //{
        //    set
        //    {
        //        this.vendorDAL = value;
        //    }
        //    get
        //    {
        //        if (vendorDataObject == null)
        //        {
        //            throw new Exception("vendor is not initialized");
        //        }
        //        else
        //        {
        //            return vendorDAL;
        //        }
        //    }
        //}

        #endregion

        #region Method
        //public IVendorDAL vendorDAL;

        //public List<Vendor> GetAllEmployees(IVendorDAL _vendorDAL)
        //{
        //    vendorDAL = _vendorDAL;
        //    return vendorDAL.SelectAllVendors();
        //}

        #endregion

        #endregion

        #region Traditional Approach
        public List<Vendor> GetVendors()
        {
            vendorDAL = new VendorDal();
            return vendorDAL.SelectAllVendors();

            //   return vendorDAL.SelectAllEmployees();
        }
        #endregion 


    }
}
