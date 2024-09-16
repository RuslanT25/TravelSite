using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Sponsor : BaseEntity
    {
        public int? ImageId { get; set; }
        public Image? Image { get; set; }
        public string Link { get; set; }
    }
}
