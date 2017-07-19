using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTWD.Hotel_App.Models.SYS{
    //sys_org
    [Table("sys_org")]
    public class sys_org
	{
   		     
      	/// <summary>
		/// auto_increment
        /// </summary>		
		private int _org_id;
        [Key]
        public int org_id
        {
            get{ return _org_id; }
            set{ _org_id = value; }
        }        
		/// <summary>
		/// dept_id
        /// </summary>		
		private string _dept_id;
        public string dept_id
        {
            get{ return _dept_id; }
            set{ _dept_id = value; }
        }        
		/// <summary>
		/// dept_name
        /// </summary>		
		private string _dept_name;
        public string dept_name
        {
            get{ return _dept_name; }
            set{ _dept_name = value; }
        }        
		/// <summary>
		/// parent_org_id
        /// </summary>		
		private int _parent_org_id;
        public int parent_org_id
        {
            get{ return _parent_org_id; }
            set{ _parent_org_id = value; }
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

