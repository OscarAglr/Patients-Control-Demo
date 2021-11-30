﻿using HealtyALTF4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Controllers
{
    public class CitaController : IControllers<CitaModel>
    {
        CitaModel model = new CitaModel();
        public bool ChangeState(CitaModel t)
        {
            throw new NotImplementedException();
        }

        public bool Create(CitaModel t)
        {
            try
            {
                t.Create();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable ShowTables()
        {
            return model.ShowTables();
        }

        public int Update(CitaModel t)
        {
            throw new NotImplementedException();
        }
    }
}