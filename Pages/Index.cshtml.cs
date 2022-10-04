using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebEFmn.Models;

namespace WebEFmn.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly SchoolDbContext dbContext;

        public IEnumerable<Subject> Subjects { get; set; }

        public IndexModel(ILogger<IndexModel> logger, SchoolDbContext dbContext)
        {
            _logger = logger;
            this.dbContext = dbContext;
        }

        public void OnGet()
        {
            Subjects = dbContext.Subjects.AsEnumerable();
        }
        public void OnGetAdd() //?handler=Add
        {
            dbContext.Subjects.Add(new Subject { SubjectName = "AAA" });

            Subjects = dbContext.Subjects.AsEnumerable();

            dbContext.SaveChanges();
        }

    }
}