using SQLite;

namespace Xamarin_app.Models
{
    internal class Users
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Login { get; set; }

        public int Password { get; set; }
    }
}
