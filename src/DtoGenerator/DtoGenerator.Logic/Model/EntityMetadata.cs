﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoGenerator.Logic.Model
{
    public class EntityMetadata
    {
        public EntityMetadata()
        {
            this.Properties = new List<PropertyMetadata>();
        }

        public List<PropertyMetadata> Properties { get; set; }
    }
}
