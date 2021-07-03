using CetTodoWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetTodoWeb.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryMenuViewComponent(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(bool ShowEmpty=true)
        {
            var items =await dbContext.Categories.Where(c=> ShowEmpty || c.TodoItems.Any() ).ToListAsync();
            return View(items);
        }
    }
}
