﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTo.Core.Interfase
{
    public interface ICreateOrEditeViewModel<TKey>
    where TKey : struct
    {

        public TKey Id { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }


    }
}
