using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoungBLL.Model
{
    class UserDAL
    {

        public Guid User_Id { get; set; }

        public String Salutation { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        [DisplayName("User Name")]
        [StringLength(30)]
        public String UserId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [DisplayName("First Name")]
        [StringLength(50)]
        public String UserFirstName { get; set; }


        public String UserMI { get; set; }

       
        [Required(ErrorMessage = "Last Name is required")]
        [DisplayName("Last Name")]
        [StringLength(50)]
        public String UserLastName { get; set; }


        public String EmailId { get; set; }

        public String Password { get; set; }


        public String Status { get; set; }
    
    }
}
