using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KTWD.Hotel_App.Models.SYS
{
 	[Table("sys_role_user")]
	public class sys_role_user
	{   		     
      	/// <summary>
		/// auto_increment
        /// </summary>		
        	 	[Key]
	 	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		        public int id{ get; set; }     
		/// <summary>
		/// role_id
        /// </summary>		
                public int role_id{ get; set; }     
		/// <summary>
		/// user_id
        /// </summary>		
                public string user_id{ get; set; }     
		   
	}
}

