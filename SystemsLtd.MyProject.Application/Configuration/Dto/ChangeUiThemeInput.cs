﻿using System.ComponentModel.DataAnnotations;

namespace SystemsLtd.MyProject.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [MaxLength(32)]
        public string Theme { get; set; }
    }
}