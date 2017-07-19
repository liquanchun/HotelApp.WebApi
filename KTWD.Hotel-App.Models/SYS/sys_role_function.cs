using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KTWD.Hotel_App.Models.SYS
{
 	[Table("sys_role_function")]
	public class sys_role_function
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
		/// function_id
        /// </summary>		
                public int function_id{ get; set; }     
		   
	}
}

