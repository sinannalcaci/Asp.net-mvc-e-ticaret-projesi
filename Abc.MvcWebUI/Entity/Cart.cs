using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class Cart
    {

        public int Id { get; set; }

        public string UserId { get; set; }

        public List<CartItem> CartItems { get; set; }
    }
}