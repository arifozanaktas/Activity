﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity.Dto.Product;
public class UpdateProductRequestDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int UnitPrice { get; set; }
    public int Stock { get; set; }
}
