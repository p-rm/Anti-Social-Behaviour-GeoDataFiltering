﻿using ldn.DataProvider.Provider;
using memamjome.GeoMapData.Models;
using memamjome.KMeanCluster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace memamjome.GeoMapData.Controllers
{
    public class ClusteredBloods4Controller : ApiController
    {
        public IEnumerable<Marker> GetAllClusteredBloods4()
        {
            return ControllerHelper.GetClusterMakers(4);
        }
    }
}
