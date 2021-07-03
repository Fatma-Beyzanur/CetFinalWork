using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetTodoWeb.Models
{
    public class CetUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual List<TodoItem> TodoItems { get; set; }

    }
}
