using System;
using System.Collections.Generic;
using System.Text;

namespace XamDesignPattern
{
    public class PrototypeModel
    {
        public string Recipient { get; set; }
        public string Content { get; set; }
        public string Sender { get; set; }
        public DateTime Time { get; set; }
        public PrototypeModel CloneMe(PrototypeModel t)
        {
            // A partial or incomplete copy. Any reference type of the source object will not be copied and will keep on referring to the same memory location.
            return (PrototypeModel)this.MemberwiseClone();
        }
    }
}
