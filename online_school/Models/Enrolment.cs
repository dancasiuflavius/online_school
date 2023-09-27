﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_school.Models
{
    internal class Enrolment
    {
        private string _id;
        private string _idCurs;
        private string _idElev;

        public Enrolment()
        {

        }
        public Enrolment(string id, string idCurs, string idElev)
        {
            _id = id;
            _idCurs = idCurs;
            _idElev = idElev;
        }
        public Enrolment(string proprietati)
        {
            string[] atribute = proprietati.Split(',');

            _id = atribute[0];
            _idCurs = atribute[1];
            _idElev = atribute[2];
        }
        public string GetId()
        {
            return _id;
        }
        public void SetId(string id)
        {
            _id = id;
        }
        public string GetIdCurs()
        {
            return _idCurs;
        }
        public void SetIdCurs(string idCurs)
        {
            _idCurs = idCurs;
        }
        public string GetIdElev()
        {
            return _idElev;
        }
        public void SetIdElev(string idElev)
        {
            _idElev = idElev;
        }


    }
}
