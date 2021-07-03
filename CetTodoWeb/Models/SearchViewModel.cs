using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetTodoWeb.Models
{
    public class SearchViewModel
    {
        public string SearchText { get; set; }
        public bool ShowAll { get; set; }

        public List<TodoItem> Result { get; set; }

    }
}
