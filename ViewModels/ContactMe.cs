﻿using System.ComponentModel.DataAnnotations;

namespace BlogProject.ViewModels;

public class ContactMe
{
    [Required]
    [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at most {1} characters long.", MinimumLength = 2)]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    [StringLength(80, ErrorMessage = "The {0} must be at least {2} and at most {1} characters long.", MinimumLength = 2)]
    public string Email { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at most {1} characters long.", MinimumLength = 2)]
    public string Subject { get; set; }

    [Required]
    [StringLength(500, ErrorMessage = "The {0} must be at least {2} and at most {1} characters long.", MinimumLength = 2)]
    public string Message { get; set; }
}
