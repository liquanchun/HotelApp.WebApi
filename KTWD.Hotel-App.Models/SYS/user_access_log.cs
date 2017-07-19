using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KTWD.Hotel_App.Models.SYS
{
 	[Table("user_access_log")]
	public class user_access_log
	{   		     
      	/// <summary>
		/// auto_increment
        /// </summary>		
        	 	[Key]
	 	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		        public int id{ get; set; }     
		/// <summary>
		/// user_id
        /// </summary>		
                public string user_id{ get; set; }     
		/// <summary>
		/// menu_id
        /// </summary>		
                public int menu_id{ get; set; }     
		/// <summary>
		/// function_id
        /// </summary>		
                public int function_id{ get; set; }     
		/// <summary>
		/// createdAt
        /// </summary>		
                public DateTime createdAt{ get; set; }     
		/// <summary>
		/// updatedAt
        /// </summary>		
                public DateTime updatedAt{ get; set; }     
		/// <summary>
		/// desc
        /// </summary>		
                public string desc{ get; set; }     
		   
	}
}

