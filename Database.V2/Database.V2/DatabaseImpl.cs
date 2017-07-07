using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.V2
{
    public class DatabaseImpl : IDatabase
    {
        
        Dictionary<Type, Dictionary<int, object>> database = new Dictionary<Type, Dictionary<int, object>>();

        public void Delete<T>(int id)
            where T : IEntity
        {
            if (!database.ContainsKey(typeof(T)))
            {

                return;
            }

            var entityDictionary = database[typeof(T)];

            if (entityDictionary.ContainsKey(id))
                database[typeof(T)].Remove(id);

            
        }

        public T Get<T>(int id)
            where T : IEntity
        {
            if (!database.ContainsKey(typeof(T)))
            {
                return default(T);
            }

            var entityDictionary = database[typeof(T)];

            if (!entityDictionary.ContainsKey(id))
                return default(T);
            

            return (T)entityDictionary[id];
        }

        public IList<T> GetAll<T>()
            where T : IEntity
        {
            throw new NotImplementedException();
        }


        public void Insert<T>(T entity)
            where T : IEntity
        {
            if (null == entity)
                throw new ArgumentNullException("entity");

            if (!database.ContainsKey(typeof(T)))
            {
                database.Add(typeof(T), new Dictionary<int, object>());
            }

            if (database[typeof(T)].ContainsKey(entity.Id))
                throw new DuplicateEntityInDatabaseException();

            database[typeof(T)].Add(entity.Id, entity);
        }

        public void Update<T>(T entity)
            where T : IEntity
        {
            if (!database.ContainsKey(typeof(T)))
                return;

            var entityDictionary = database[typeof(T)];

            if (!entityDictionary.ContainsKey(entity.Id))
                return;
            entityDictionary[entity.Id] = entity;
            
        }
    }
}
