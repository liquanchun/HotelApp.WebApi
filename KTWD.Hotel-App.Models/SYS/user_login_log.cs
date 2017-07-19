using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTWD.Hotel_App.Models.SYS{
    //user_login_log
    [Table("user_login_log")]
    public class user_login_log
	{
      	/// <summary>
		/// auto_increment
        /// </summary>		
		private int _id;
        [Key]
        public int id
        {
            get{ return _id; }
            set{ _id = value; }
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
		/// <summary>
		/// login_info
        /// </summary>		
		private string _login_info;
        public string login_info
        {
            get{ return _login_info; }
            set{ _login_info = value; }
        }        
		/// <summary>
		/// login_IP
        /// </summary>		
		private string _login_ip;
        public string login_IP
        {
            get{ return _login_ip; }
            set{ _login_ip = value; }
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

