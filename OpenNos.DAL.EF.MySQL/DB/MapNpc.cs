//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenNos.DAL.EF.MySQL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class MapNpc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MapNpc()
        {
            this.teleporter = new HashSet<Teleporter>();
            this.shop = new HashSet<Shop>();
        }
    
        public int MapNpcId { get; set; }
        public short NpcVNum { get; set; }
        public short MapId { get; set; }
        public short MapX { get; set; }
        public short MapY { get; set; }
        public bool Move { get; set; }
        public byte MoveType { get; set; }
        public short Position { get; set; }
        public bool IsSitting { get; set; }
        public short EffectDelay { get; set; }
        public short Effect { get; set; }
        public short Dialog { get; set; }
    
        public virtual NpcMonster npc { get; set; }
        public virtual Map map { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Teleporter> teleporter { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop> shop { get; set; }
    }
}
