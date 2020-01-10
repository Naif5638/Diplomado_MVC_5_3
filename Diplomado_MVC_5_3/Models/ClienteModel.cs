using Diplomado_MVC_5_3.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diplomado_MVC_5_3.Models
{
    public class ClienteModel : Cliente
    {
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}