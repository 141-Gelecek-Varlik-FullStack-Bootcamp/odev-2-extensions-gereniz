using System;
using System.ComponentModel.DataAnnotations;

namespace Extensions
{
    public enum UserTypes
    {
        [Display(Name = "Yönetici")]
        userType1 = 1,

        [Display(Name = "Yazılımcı")]
        userType2 = 2,

        [Display(Name = "Kullanıcı")]
        userType3 = 3,

        [Display(Name = "Analist")]
        userType4 = 4
    }
}
