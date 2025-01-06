using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class user_model
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string age { get; set; }


        public static explicit operator user_model(user User)
        {
            string?[] names=User.name.Split(" ");
            return new user_model()
            {
                id = User?.id ?? 0,
                first_name = names?.Length > 0 ? names[0] : string.Empty,
                last_name= names?.Length > 0 ? names[1] : string.Empty,
                email=User?.email ?? string.Empty,
                password=User?.password ?? string.Empty,
            };
        }
    }
}
