﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public BaseEntity(int id)
        {
            Id = id;
        }
    }
}
