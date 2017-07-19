using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KTWD.Hotel_App.Models.SYS
{
 	[Table("sys_menu")]
	public class sys_menu
	{   		     
      	/// <summary>
		/// auto_increment
        /// </summary>		
        	 	[Key]
	 	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		        public int menu_id{ get; set; }     
		/// <summary>
		/// menu_name
        /// </summary>		
                public string menu_name{ get; set; }     
		/// <summary>
		/// parent_menu_id
        /// </summary>		
                public int parent_menu_id{ get; set; }     
		/// <summary>
		/// menu_level
        /// </summary>		
                public int menu_level{ get; set; }     
		/// <summary>
		/// menu_addr
        /// </summary>		
                public string menu_addr{ get; set; }     
		/// <summary>
		/// createdAt
        /// </summary>		
                public DateTime createdAt{ get; set; }     
		/// <summary>
		/// updatedAt
        /// </summary>		
                public DateTime updatedAt{ get; set; }     
		   
	}
}

