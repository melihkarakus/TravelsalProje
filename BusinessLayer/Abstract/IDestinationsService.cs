﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDestinationsService : IGenericService<Destinations>
    {
        public Destinations TGetDestinationWithGuide(int id);
        public List<Destinations> TGetLast4Destinations();
    }
}
