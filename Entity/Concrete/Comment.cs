using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Comment : BaseEntity
    {
        public string Message { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public int? ImageId { get; set; }
        public Image? Image { get; set; }
    }
}
