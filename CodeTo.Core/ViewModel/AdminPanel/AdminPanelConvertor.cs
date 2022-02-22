﻿using CodeTo.Core.Interfase;
using CodeTo.Domain.Entities.Users;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTo.Core.ViewModel.AdminPanel
{
    public class AdminPanelIndexViewModel : IIndexVeiwModel<int>
    {
        public int Id { get; set; }
        [Display(Name = "ایمیل")]
        public string Email { get; set; }
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }
        [Display(Name = "شماره تلفن")]
        public string Mobile { get; set; }
        [Display(Name = "تصویر کاربر")]
        public string ImageName { get; set; }
        [Display(Name = "تاریخ ثبت نام")]
        public DateTime CreateDate { get; set; }
        public List<AdminPanelIndexViewModel> users { get; set; }
        [Display(Name = "تعداد صفحه")]
        public int PageCount { get; set; }
        [Display(Name = "صحفه فعلی")]
        public int CurrentPage { get; set; }
        public bool IsActived { get; set; }
        public List<Role> PermissionList { get; set; }
        public bool IsDelete { get; set; }
    }


    public class AdminPanelCreateOrEditViewModel : ICreateOrEditeViewModel<int>
    {
        public int Id { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200)]
        public string Title { get; set; }

        [Display(Name = "تاریخ ثبت نام")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "تاریخ به روز رسانی")]
        public DateTime? ModifyDate { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200)]
        [EmailAddress(ErrorMessage = "لطفا آدرس ایمیل را صحیح وارد نمایید")]
        public string Email { get; set; }

        [Display(Name = "شماره تلفن")]
        public string Mobile { get; set; }

        [Display(Name = "تصویر کاربر")]
        public string ImageName { get; set; }

        [Display(Name = "تصویر کاربر")]
        public IFormFile Avataname { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200)]
        public string Password { get; set; }
        public List<byte> PermissionList { get; set; }
    }



    public class AminUserListForShow
    {
        public List<AdminPanelIndexViewModel> users { get; set; }
        [Display(Name = "تعداد صفحه")]
        public int PageCount { get; set; }
        [Display(Name = "صحفه فعلی")]
        public int CurrentPage { get; set; }

    }
}
