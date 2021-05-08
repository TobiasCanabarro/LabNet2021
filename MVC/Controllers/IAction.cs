using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public interface IAction<T>
    {
        ActionResult Index();

        ActionResult Insert(T view);

        ActionResult Update(T view);

        ActionResult Delete(int id);
    }
}
