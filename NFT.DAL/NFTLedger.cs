//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NFT.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class NFTLedger
    {
        public int Id { get; set; }
        public int SmartContractId { get; set; }
        public string CurrentOwner { get; set; }
        public string TransferFrom { get; set; }
        public string TransferTo { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual deployednft deployednft { get; set; }
    }
}
