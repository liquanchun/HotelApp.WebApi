using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTWD.Hotel_App.Models.SYS{
    //sys_role
    [Table("sys_role")]
    public class sys_role
	{
      	/// <summary>
		/// auto_increment
        /// </summary>		
		private int _role_id;
        [Key]
        public int role_id
        {
            get{ return _role_id; }
            set{ _role_id = value; }
        }        
		/// <summary>
		/// role_name
        /// </summary>		
		private string _role_name;
        public string role_name
        {
            get{ return _role_name; }
            set{ _role_name = value; }
        }        
		/// <summary>
		/// role_desc
        /// </summary>		
		private string _role_desc;
        public string role_desc
        {
            get{ return _role_desc; }
            set{ _role_desc = value; }
        }        
		/// <summary>
		/// createdAt
        /// </summary>		
		private DateTime _createdat;
        public DateTime createdAt
        {
            get{ return _createdat; }
            set{ _createdat = value; }
        }        
		/// <summary>
		/// updatedAt
        /// </summary>		
		private DateTime _updatedat;
        public DateTime updatedAt
        {
            get{ return _updatedat; }
            set{ _updatedat = value; }
        }        
		   
	}
}

