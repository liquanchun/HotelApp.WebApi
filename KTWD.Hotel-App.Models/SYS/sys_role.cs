using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KTWD.Hotel_App.Models.SYS
{
    [Table("sys_role")]
    public class sys_role
    {
        /// <summary>
        /// auto_increment
        /// </summary>		
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int role_id { get; set; }
        /// <summary>
        /// role_name
        /// </summary>		
        public string role_name { get; set; }
        /// <summary>
        /// role_desc
        /// </summary>		
        public string role_desc { get; set; }
        /// <summary>
        /// createdAt
        /// </summary>		
        public DateTime createdAt { get; set; }
        /// <summary>
        /// updatedAt
        /// </summary>		
        public DateTime updatedAt { get; set; }

    }
}

