﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp.Domen.Models;

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<User>? Users { get; set; } = null;
}
