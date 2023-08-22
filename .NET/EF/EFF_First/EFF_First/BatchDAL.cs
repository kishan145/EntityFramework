using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFF_First
{
    public class BatchDAL
    {
        DbHandler db;

        public int InsertRecord(Batch batch)
        {

            
            try
            { 
                using(db = new DbHandler())
                {
                    db.Batches.Add(batch);
                    int i = db.SaveChanges();
                    return i;

                }
                

            }
            catch
            {
                return 0;
            }
           
        }

        public IEnumerable<Batch> DisplayAllRecords()
        {
            using (db = new DbHandler())
            {
                return db.Batches.ToList();

            }
         

        }
    }
}
