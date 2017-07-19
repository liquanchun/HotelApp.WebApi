using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KTWD.Hotel_App.Models.SYS
{
 	[Table("sys_org")]
	public class sys_org
	{   		     
      	/// <summary>
		/// auto_increment
        /// </summary>		
        	 	[Key]
	 	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		        public int org_id{ get; set; }     
		/// <summary>
		/// dept_id
        /// </summary>		
                public string dept_id{ get; set; }     
		/// <summary>
		/// dept_name
        /// </summary>		
                public string dept_name{ get; set; }     
		/// <summary>
		/// parent_org_id
        /// </summary>		
                public int parent_org_id{ get; set; }     
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

