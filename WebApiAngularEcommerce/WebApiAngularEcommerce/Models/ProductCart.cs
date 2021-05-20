using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiAngularEcommerce
{
    public class ProductCart
    {
        public int ID { get; set; }
        [JsonIgnore]

        public virtual Product Product { get; set; }
        [JsonIgnore]

        public virtual Cart Cart { get; set; }
    }
}
