using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTWD.Hotel_App.Models.SYS{
    //sys_function
    [Table("sys_function")]
    public class sys_function
	{
        /// <summary>
        /// auto_increment
        /// </summary>		
        [Key]
        private int _function_id;
        public int function_id
        {
            get{ return _function_id; }
            set{ _function_id = value; }
        }        
		/// <summary>
		/// function_name
        /// </summary>		
		private string _function_name;
        public string function_name
        {
            get{ return _function_name; }
            set{ _function_name = value; }
        }        
		/// <summary>
		/// function_addr
        /// </summary>		
		private string _function_addr;
        public string function_addr
        {
            get{ return _function_addr; }
            set{ _function_addr = value; }
        }        
		/// <summary>
		/// component
        /// </summary>		
		private string _component;
        public string component
        {
            get{ return _component; }
            set{ _component = value; }
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

