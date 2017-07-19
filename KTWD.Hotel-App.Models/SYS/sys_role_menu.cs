using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTWD.Hotel_App.Models.SYS{
    //sys_role_menu
    [Table("sys_role_menu")]
    public class sys_role_menu
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
		/// menu_id
        /// </summary>		
		private int _menu_id;
        public int menu_id
        {
            get{ return _menu_id; }
            set{ _menu_id = value; }
        }        
		   
	}
}

