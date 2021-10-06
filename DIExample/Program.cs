using System;
using System.Collections.Generic;
using static DIExample.VendorDal;

namespace DIExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Abstract Class
            //VendorBal.DI  vbl = new VendorBal.DI(new VendorBal());
            //List<Vendor> lstvendor = vbl.vb.SelectAllVendors();
            //foreach (Vendor vdr in lstvendor)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", vdr.ID, vdr.Name, vdr.Department);
            //}
            //Console.ReadKey();
            #endregion

            #region Constructor Dependency 
            //VendorBal vBL = new VendorBal(new VendorDal());
            //List<Vendor> lstvendor = vbl.GetVendors();
            //foreach (Vendor vdr in lstvendor)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", vdr.ID, vdr.Name, vdr.Department);
            //}
            //Console.ReadKey();
            #endregion


            #region Property
            //VendorBal vbl = new VendorBal();
            //vbl.vendorDataObject = new VendorDal();

            //List<Vendor> lstvendor = vbl.GetVendors();
            //foreach (Vendor vdr in lstvendor)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", vdr.ID, vdr.Name, vdr.Department);
            //}
            //Console.ReadKey();

            #endregion

            #region Method
            //VendorBal vbl = new VendorBal();           
            //List<Vendor> lstvendor = vbl.GetVendors(new VendorDal());
            //foreach (Vendor vdr in lstvendor)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", vdr.ID, vdr.Name, vdr.Department);
            //}
            //Console.ReadKey();
            #endregion

            #region Traditional
            VendorBal vbr = new VendorBal();
            List<Vendor> lstvendor = vbr.GetVendors();
            foreach (Vendor vdr in lstvendor)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", vdr.ID, vdr.Name, vdr.Department);
            }
            Console.ReadKey();
            #endregion
        }
    }
}
