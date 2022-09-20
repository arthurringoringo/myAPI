namespace myApi.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User :Entity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }
    
    [Required]
    public string email { get; set; }

    [Required] 
    public string username { get; set; }

    [Required]
    public string hashed_password { get; set; }

}