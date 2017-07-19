using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTWD.Hotel_App.Models.SYS{
    //user_access_log
    [Table("user_access_log")]
    public class user_access_log
	{

        /// <summary>
        /// auto_increment
        /// </summary>		
        [Key]
        private int _id;
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
		/// menu_id
        /// </summary>		
		private int _menu_id;
        public int menu_id
        {
            get{ return _menu_id; }
            set{ _menu_id = value; }
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
		/// <summary>
		/// desc
        /// </summary>		
		private string _desc;
        public string desc
        {
            get{ return _desc; }
            set{ _desc = value; }
        }        
		   
	}
}

