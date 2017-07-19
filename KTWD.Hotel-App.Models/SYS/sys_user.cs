using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTWD.Hotel_App.Models.SYS{
    //sys_user
    [Table("sys_user")]
    public class sys_user
	{
   		     
      	/// <summary>
		/// user_id
        /// </summary>		
		private string _user_id;
        [Key]
        public string user_id
        {
            get{ return _user_id; }
            set{ _user_id = value; }
        }        
		/// <summary>
		/// user_name
        /// </summary>		
		private string _user_name;
        public string user_name
        {
            get{ return _user_name; }
            set{ _user_name = value; }
        }        
		/// <summary>
		/// mobile
        /// </summary>		
		private string _mobile;
        public string mobile
        {
            get{ return _mobile; }
            set{ _mobile = value; }
        }        
		/// <summary>
		/// weixin
        /// </summary>		
		private string _weixin;
        public string weixin
        {
            get{ return _weixin; }
            set{ _weixin = value; }
        }        
		/// <summary>
		/// email
        /// </summary>		
		private string _email;
        public string email
        {
            get{ return _email; }
            set{ _email = value; }
        }        
		/// <summary>
		/// pwd
        /// </summary>		
		private string _pwd;
        public string pwd
        {
            get{ return _pwd; }
            set{ _pwd = value; }
        }        
		/// <summary>
		/// last_login_time
        /// </summary>		
		private string _last_login_time;
        public string last_login_time
        {
            get{ return _last_login_time; }
            set{ _last_login_time = value; }
        }        
		/// <summary>
		/// org_id
        /// </summary>		
		private int _org_id;
        public int org_id
        {
            get{ return _org_id; }
            set{ _org_id = value; }
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
		/// updatedAt
        /// </summary>		
		private DateTime _updatedat;
        public DateTime updatedAt
        {
            get{ return _updatedat; }
            set{ _updatedat = value; }
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
		/// isvalid
        /// </summary>		
		private bool _isvalid;
        public bool isvalid
        {
            get{ return _isvalid; }
            set{ _isvalid = value; }
        }        
		   
	}
}

