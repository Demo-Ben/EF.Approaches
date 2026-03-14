using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class UsersExt
    {
        public string UserId { get; set; }
        public string NetworkId { get; set; }

        public virtual User User { get; set; }
    }
}
