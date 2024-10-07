using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.DTo
{
    public class UserCreationDto
    {
        [Key]
        public long ID_User { get; set; }

        [Required(ErrorMessage = " نام را وارد کنید ")]
        [StringLength(100)]
        public string FristName { get; set; }

        [Required(ErrorMessage = " نام خانوادگی را وارد کنید ")]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required(ErrorMessage = " موبایل را وارد کنید ")]
        [StringLength(15)]
        public string Mobile { get; set; }

        [StringLength(100)]
        public string Emile { get; set; }

        [StringLength(200)]
        public string Images { get; set; }

        public bool ISActive { get; set; }

        [Required(ErrorMessage = " نام کاریری را وارد کنید ")]
        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

    }
}
