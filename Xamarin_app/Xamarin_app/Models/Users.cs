using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace Xamarin_app.Models
{
    internal class Users
    {
        [PrimaryKey, AutoIncrement]
        public int UserID { get; set; } 
        public string Name { get; set; }
        public string Password { get; set; }    

    }
}
