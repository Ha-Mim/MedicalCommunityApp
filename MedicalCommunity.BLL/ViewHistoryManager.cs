using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCommunity.DAO;
using MedicalCommunity.DLL;

namespace MedicalCommunity.BLL
{
    public class ViewHistoryManager
    { 
        ViewHistoryDBGateway aViewHistoryDbGateway=new ViewHistoryDBGateway();
        public List<ViewHistory> ShowStory(string name)
        {
            return aViewHistoryDbGateway.ViewStory(name);
        } 
    }
}
