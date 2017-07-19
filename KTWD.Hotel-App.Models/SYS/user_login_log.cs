using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KTWD.Hotel_App.Models.SYS
{
 	[Table("user_login_log")]
	public class user_login_log
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
		/// login_info
        /// </summary>		
                public string login_info{ get; set; }     
		/// <summary>
		/// login_IP
        /// </summary>		
                public string login_IP{ get; set; }     
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

