//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace traveling.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class like
    {
        public int likeID { get; set; }
        public int userLikeID { get; set; }
        public int postLikeID { get; set; }
        public byte[] likes { get; set; }
        public byte[] dislike { get; set; }
    
        public virtual post post { get; set; }
        public virtual user_s user_s { get; set; }
    }
}