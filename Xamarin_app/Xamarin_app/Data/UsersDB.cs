using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Xamarin_app.Models;

namespace Xamarin_app.Data
{
    class UsersDB
    {
        readonly SQLiteAsyncConnection _connection;

        public UsersDB(string connectionString)
        {
            _connection = new SQLiteAsyncConnection(connectionString); 

            _connection.CreateTableAsync<Users>().Wait();
        }

        public Task<List<Users>> GetUsersAsync()
        {
            return _connection.Table<Users>().ToListAsync();
        }

        public Task<Users> GetUsersAsync(int id)
        {
            return _connection.Table<Users>()
                .Where(i => i.UserID == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveUserAsync(Users User)
        {
            if (User.UserID != 0)
            {
                return _connection.UpdateAsync(User);
            }
            else
            {
                return _connection.InsertAsync(User);
            }

        }

        public Task<int> DeleteUserAsync(Users User)
        {
            return _connection.DeleteAsync(User);
        }

    }

}
