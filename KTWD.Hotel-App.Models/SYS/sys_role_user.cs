using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTWD.Hotel_App.Models.SYS{
    //sys_role_user
    [Table("sys_role_user")]
    public class sys_role_user
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
		/// user_id
        /// </summary>		
		private string _user_id;
        public string user_id
        {
            get{ return _user_id; }
            set{ _user_id = value; }
        }        
		   
	}
}

