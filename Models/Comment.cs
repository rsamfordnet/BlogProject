﻿using BlogProject.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Models;

public class Comment
{
    public int Id { get; set; }
    public int PostId { get; set; } //forgiegn key
    public string BlogUserId { get; set; } // foreign key
    public string ModeratorId { get; set; } //foreign key

    [Required]
    [StringLength(500, ErrorMessage = "The {0} must be at least {2} and no more thatn {1} characters long", MinimumLength = 2)]
    [Display(Name = "Comment")]
    public string Body { get; set; }

    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
    public DateTime? Moderated { get; set; }
    public DateTime? Deleted { get; set; }


    [StringLength(500, ErrorMessage = "The {0} must be at least {2} and no more thatn {1} characters long", MinimumLength = 2)]
    [Display(Name = "Moderated Comment")]
    public string ModeratedBody { get; set; }

    public ModerationType ModerationType { get; set; }

    //Navigation properties
    public virtual Post Post { get; set; }
    public virtual BlogUser BlogUser { get; set; }
    public virtual BlogUser Moderator { get; set; }
}



