﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFStore.Domain.Base;


namespace IFStore.Domain.Entities
{
    public class Cidade : BaseEntity<int>
    {
        public string Nome { get; set; }
        public string Estado { get; set; }

    }
}
