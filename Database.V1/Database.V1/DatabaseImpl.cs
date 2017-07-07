using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.V1
{
    public class DatabaseImpl : IDatabase
    {
        Dictionary<int, Dosar> database = new Dictionary<int, Dosar>();

        public void Delete(int id)
        {
            if (database.ContainsKey(id))
            {
                database.Remove(id);
            }

        }

        public Dosar Get(int id)
        {
            if (database.ContainsKey(id))
            {
                return database[id];
            }
            return null;
        }

        public void Insert(Dosar entity)
        {
            database.Add(entity.Id, entity);
        }

        public void Update(Dosar entity)
        {
            if (database.ContainsKey(entity.Id))
            {
                database[entity.Id] = entity;
            }
            
        }
        
    }
}
