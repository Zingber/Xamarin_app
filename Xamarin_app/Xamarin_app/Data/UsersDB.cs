using System.Collections.Generic;
using SQLite;
using Xamarin_app.Models;
using System.Threading.Tasks;

namespace Xamarin_app.Data
{
    internal class UsersDB
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
        public Task<Users> GetUserAsync(int id)
        {
            return _connection.Table<Users>()
                .Where(u => u.Id == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveUserAsync(Users users)
        {
            if (users.Id != 0)
            {
                return _connection.UpdateAsync(users);
            }
            else
            {
                return _connection.InsertAsync(users);
            }
        }

        public Task<int> DeleteUserAsync(Users user)
        {
            return  _connection.DeleteAsync(user);
        }

    }
}
