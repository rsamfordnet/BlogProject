﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogProject.Models;

public class BlogUser : IdentityUser  //AspNet Users Table
{
    [Required]
    [StringLength(50, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long", MinimumLength = 2)]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long", MinimumLength = 2)]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }


    [Required]
    [StringLength(50, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long", MinimumLength = 2)]
    [Display(Name = "Last Name")]
    public string DisplayName { get; set; }

    public byte[] ImageData { get; set; }
    public string ContentType { get; set; }

    [StringLength(200, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long", MinimumLength = 2)]
    public string FacebookUrl { get; set; }
    [StringLength(200, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long", MinimumLength = 2)]
    public string TwitterUrl { get; set; }
    [StringLength(200, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long", MinimumLength = 2)]
    public string GitHub { get; set; }

    [NotMapped]
    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }

    public virtual ICollection<Blog> Blogs { get; set; } = new HashSet<Blog>();
    public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();
}
