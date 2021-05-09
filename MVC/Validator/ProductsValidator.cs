using Entities.Exception;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Validator
{
    public class ProductsValidator : Validator
    {
        private readonly int _invalid = 0;

        public bool IsValid(int id)
        {
            return id != _invalid;
        }

    }
}
