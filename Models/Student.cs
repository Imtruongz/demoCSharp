using System.ComponentModel;

namespace Demo.Models
{
    public class Student
    {
        [DisplayName("Mã SV")]
        public string Id { get; set; } // Properties
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }
        [DisplayName("Họ và tên")]
        public string FullName { get; set; }
        [DisplayName("Giới tính")]
        public bool Gender { get; set; }
        [DisplayName("Ngày sinh")]
        public DateTime BirthDay { get; set; }
        [DisplayName("Ghi chú")]
        public string Note { get; set; }

    }
}
