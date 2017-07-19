using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTWD.Hotel_App.Models.SYS{
    //sys_role_function
    [Table("sys_role_function")]
    public class sys_role_function
	{
        private int _id;
        [Key]
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
      	/// <summary>
		/// role_id
        /// </summary>		
		private int _role_id;
        public int role_id
        {
            get{ return _role_id; }
            set{ _role_id = value; }
        }        
		/// <summary>
		/// function_id
        /// </summary>		
		private int _function_id;
        public int function_id
        {
            get{ return _function_id; }
            set{ _function_id = value; }
        }        
		   
	}
}

