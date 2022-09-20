namespace myApi.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

public class Entity
{
    public DateTime created_on { get; set; } = DateTime.Now.ToUniversalTime();
    [DefaultValue("false")]
    public bool deleted { get; set; }
    [DefaultValue(null)]
    public DateTime? deleted_on { get; set; }
}