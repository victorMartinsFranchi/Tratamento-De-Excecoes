﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoDeExcecoes.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string mensage) : base(mensage)
        {
        }
    }
}