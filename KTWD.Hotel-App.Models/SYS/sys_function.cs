using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KTWD.Hotel_App.Models.SYS
{
    [Table("sys_function")]
    public class sys_function
    {

        /// <summary>
        /// auto_increment
        /// </summary>		
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int function_id { get; set; }
        /// <summary>
        /// function_name
        /// </summary>		
        public string function_name { get; set; }
        /// <summary>
        /// function_addr
        /// </summary>		
        public string function_addr { get; set; }
        /// <summary>
        /// component
        /// </summary>		
        public string component { get; set; }
        /// <summary>
        /// menu_id
        /// </summary>		
        public int menu_id { get; set; }
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

