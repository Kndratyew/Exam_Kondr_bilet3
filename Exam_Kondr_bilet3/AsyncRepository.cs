using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exam_Kondr_bilet3
{
    public class AsyncRepository
    {
        SQLiteAsyncConnection database;

        public AsyncRepository(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
        }

        public async Task CreateTable()
        {
            await database.CreateTableAsync<Stud>();
        }
        public async Task<List<Stud>> GetItemsAsync()
        {
            return await database.Table<Stud>().ToListAsync();

        }
        public async Task<Stud> GetItemAsync(int id)
        {
            return await database.GetAsync<Stud>(id);
        }
        public async Task<int> DeleteItemAsync(Stud item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(Stud item)
        {
            if (item.Id != 0)
            {
                await database.UpdateAsync(item);
                return item.Id;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }
    }
}