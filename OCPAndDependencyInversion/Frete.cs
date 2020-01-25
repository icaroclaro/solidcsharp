﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OCPAndDependencyInversion
{
    class Frete : IServicoDeEntrega
    {
        public double Para(string cidade)
        {

            if ("SAO PAULO".Equals(cidade.ToUpper()))
            {
                return 15;
            }
            return 30;
        }
    }
}
