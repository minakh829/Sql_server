using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using NUnit.Framework;

namespace file4.Controllers
{
    [TestFixture]
    public class homecontrollertest
    {

        public void  IndexTest()

        {

            var controller = new HomeController();
            var view = controller.Index();
            Assert.NotNull(view);
        }
    }
}