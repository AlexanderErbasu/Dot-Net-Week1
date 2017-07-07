using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.V1
{
    public class DatabaseImpl : IDatabase
    {
        Dictionary<int, Dosar> dictionaryStorage = new Dictionary<int, Dosar>();
        List<Dosar> listStorage = new List<Dosar>();

        public void Delete(int id)
        {
            if (!HasKey(id))
                return;
                     
            dictionaryStorage.Remove(id);
            listStorage.Remove(dictionaryStorage[id]);

        }

        public Dosar Get(int id)
        {
            if (!HasKey(id))
                return null;

            return dictionaryStorage[id];
        }

        public IList<Dosar> GetAll()
        {
            return listStorage;
        }

        public void Insert(Dosar entity)
        {
            if (null == entity)
                throw new ArgumentNullException("entity");

            if (HasKey(entity.Id))
                throw new DuplicateEntityInDatabaseException(entity.Id);

            dictionaryStorage.Add(entity.Id, entity);
            listStorage.Add(entity);
        }

        public void Update(Dosar entity)
        {
            dictionaryStorage[entity.Id] = entity;
        }

        private bool HasKey(int id)
        {
            return dictionaryStorage.ContainsKey(id);
        }
    }
}
