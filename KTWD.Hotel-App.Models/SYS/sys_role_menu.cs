using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KTWD.Hotel_App.Models.SYS
{
 	[Table("sys_role_menu")]
	public class sys_role_menu
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
		/// menu_id
        /// </summary>		
                public int menu_id{ get; set; }     
		   
	}
}

