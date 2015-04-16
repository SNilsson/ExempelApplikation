using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Umea.se.ExempelApplikation.GUI.Helpers;
using Umea.se.ExempelApplikation.GUI.Helpers.Contracts;
using Umea.se.ExempelApplikation.GUI.Models;
using Umea.se.ExempelApplikation.ServiceWrapper;
using Umea.se.ExempelApplikation.ServiceWrapper.Contracts;
using Umea.se.ExempelApplikation.Utilities.Extensions;

namespace Umea.se.ExempelApplikation.GUI.Controllers
{
    public class HemortController : Controller
    {
        private readonly IHemortServiceWrapper _homeServiceWrapper;
        private readonly IMessageHelper _messageHelper;

        public HemortController() : this(new HemortServiceWrapper(), new MessageHelper())  {
        }

        public HemortController(IHemortServiceWrapper homeServiceWrapper, IMessageHelper messageHelper)
        {
            _homeServiceWrapper = homeServiceWrapper;
            _messageHelper = messageHelper;
        }

        // GET: Hemort
        public ActionResult Index()
        {
            var hemortViewModel = new HemortViewModel();
            hemortViewModel.CountryList = _homeServiceWrapper.GetCountries();
            hemortViewModel.HemortList = _homeServiceWrapper.GetHomes();
            return View(hemortViewModel);
        }

        public ActionResult GetHomes(int countryId)
        {
            var hemortList = _homeServiceWrapper.GetHomesByCountryId(countryId);
            return PartialView("_Homes", hemortList);         

        }

        public ActionResult GetAllHomes()
        {
            var hemortList = _homeServiceWrapper.GetHomes();
            return PartialView("_Homes", hemortList);

        }

        //Metod för att visa extensions. StreamExtensions ToByteArray(Stream stream)
        private void AnvandsEj()
        {
            var sr = new StreamReader("C:\temp\temp.text");
            var stream = sr.BaseStream;
            stream.ToByteArray();
        }
    }
}