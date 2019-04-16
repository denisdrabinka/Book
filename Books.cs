using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject2
{
    public class Book
    {
        public int Id { get; set; }
        public string NameSource { get; set; }
        public string InfoSource { get; set; }
        public string MyImageSource1 { get; set; }
        public string MyImageSource2 { get; set; }
        public string MainWindow_xamlSource { get; set; }
        public string MainWindow_csSource { get; set; }
        public string VideoSource { get; set; }
        public double? VideoTime { get; set; }
        public string Class_Source1 { get; set; }
        public string Class_Source2 { get; set; }
        public string Class_Source3 { get; set; }
        public string Class_Source4 { get; set; }
        public string Class_Source5 { get; set; }
        public string Class_Source6 { get; set; }
        public string Class_Source7 { get; set; }
        public string Class_Source8 { get; set; }
        public string Class_Source9 { get; set; }
        public string Class_Source10 { get; set; }
        public string App_configSource { get; set; }
        public string App_xamlSource { get; set; }
        public string App_xaml_csSource { get; set; }
    }

    public class BooksContext : DbContext
    {
        public BooksContext() : base("DefaultConnection")
        {

        }
        public DbSet<Book> Books { get; set; }
    }

}
