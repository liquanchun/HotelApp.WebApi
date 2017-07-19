using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTWD.Hotel_App.Models.SYS{
    //sys_menu
    [Table("sys_menu")]
    public class sys_menu
	{
   		     
      	/// <summary>
		/// auto_increment
        /// </summary>		
		private int _menu_id;
        [Key]
        public int menu_id
        {
            get{ return _menu_id; }
            set{ _menu_id = value; }
        }        
		/// <summary>
		/// menu_name
        /// </summary>		
		private string _menu_name;
        public string menu_name
        {
            get{ return _menu_name; }
            set{ _menu_name = value; }
        }        
		/// <summary>
		/// parent_menu_id
        /// </summary>		
		private int _parent_menu_id;
        public int parent_menu_id
        {
            get{ return _parent_menu_id; }
            set{ _parent_menu_id = value; }
        }        
		/// <summary>
		/// menu_level
        /// </summary>		
		private int _menu_level;
        public int menu_level
        {
            get{ return _menu_level; }
            set{ _menu_level = value; }
        }        
		/// <summary>
		/// menu_addr
        /// </summary>		
		private string _menu_addr;
        public string menu_addr
        {
            get{ return _menu_addr; }
            set{ _menu_addr = value; }
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

