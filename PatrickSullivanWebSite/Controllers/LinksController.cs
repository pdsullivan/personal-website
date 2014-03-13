﻿using PatrickSullivanWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PatrickSullivanWebSite.Controllers
{
    public class LinksController : ApiController
    {
        public IHttpActionResult GetAllLinks()
        {
            var db = new List<Link>();
            db = (from x in Global.SiteDB.Links
                  where x.Type == "link"
                  select x).ToList();

            return Ok(db);
        }



    }
}
