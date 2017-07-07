using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.V1
{
    public class DatabaseImpl : IDatabase
    {
        Dictionary<int, Dosar> storage = new Dictionary<int, Dosar>();

        public void Delete(int id)
        {
            if (!HasKey(id))
                return;

            storage.Remove(id);
        }

        public Dosar Get(int id)
        {
            if (!HasKey(id))
                return null;

            return storage[id];
        }

        public IList<Dosar> GetAll()
        {
            IList<Dosar> newList = new List<Dosar>();
            foreach(KeyValuePair<int, Dosar> entry in storage)
            {
                newList.Add(entry.Value);
            }
            return newList;
        }

        public void Insert(Dosar entity)
        {
            if (null == entity)
                throw new ArgumentNullException("entity");

            if (HasKey(entity.Id))
                throw new DuplicateEntityInDatabaseException(entity.Id);

            storage.Add(entity.Id, entity);
        }

        public void Update(Dosar entity)
        {
            storage[entity.Id] = entity;
        }

        private bool HasKey(int id)
        {
            return storage.ContainsKey(id);
        }
    }
}
