using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFF_First
{
    public class BatchBAL
    {
        BatchDAL dl = new BatchDAL();

        public bool CheckInsert(Batch batch)
        {
            int result = dl.InsertRecord(batch);
            return result > 0 ? true : false ;
        }
                                        
        public IList<Batch> DisplayAllBatchRecord()
        {
           
            return dl.DisplayAllRecords().ToList();
        }
    }
}
