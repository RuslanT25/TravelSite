using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class ReaderReview : BaseEntity
    {
        public string UserName { get; set; }
        public string Review {  get; set; }

        public int ImageId { get; set; }
        public Image Image { get; set; }

        public int AboutMeId { get; set; }
        public AboutMe AboutMe { get; set; }
    }
}
