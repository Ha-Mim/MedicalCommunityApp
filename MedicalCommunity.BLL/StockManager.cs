using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCommunityAutomation.DAL;
using MedicalCommunityAutomation.DAO;

namespace MedicalCommunityAutomation.BLL
{
   public class StockManager
    {
       StockDbGateway aStockDbGateway = new StockDbGateway();

       public List<Stock> GetAll(int centerId)
       {
           return aStockDbGateway.GetAll(centerId);
       }

       public string AddStockDetails(Stock aStock)
       {
           aStockDbGateway.AddInventoryDetails(aStock);
           return "Saved";
       }
    }
}
