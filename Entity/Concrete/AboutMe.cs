using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class AboutMe : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoLink { get; set; }

        public int ImageId { get; set; }
        public Image Image { get; set; }
    }
}
