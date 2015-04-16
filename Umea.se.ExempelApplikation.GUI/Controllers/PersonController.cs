using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Umea.se.ExempelApplikation.DataObjectLibrary;
using Umea.se.ExempelApplikation.GUI.Helpers;
using Umea.se.ExempelApplikation.GUI.Helpers.Contracts;
using Umea.se.ExempelApplikation.GUI.Models;
using Umea.se.ExempelApplikation.ServiceWrapper;
using Umea.se.ExempelApplikation.ServiceWrapper.Contracts;
using Umea.se.ExempelApplikation.Utilities;
using Umea.se.ExempelApplikation.Utilities.Exceptions;
using Umea.se.ExempelApplikation.Utilities.Resources;

namespace Umea.se.ExempelApplikation.GUI.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonServiceWrapper _personServiceWrapper;
        private readonly ICourseServiceWrapper _courseServiceWrapper;
        private readonly IHemortServiceWrapper _homeServiceWrapper;
        private readonly IMessageHelper _messageHelper;

        public PersonController() : this(new PersonServiceWrapper(), new CourseServiceWrapper(), new HemortServiceWrapper(), new MessageHelper())  {
        }

        public PersonController(IPersonServiceWrapper personServiceWrapper, ICourseServiceWrapper courseServiceWrapper, IHemortServiceWrapper homeServiceWrapper, IMessageHelper messageHelper)
        {
            _personServiceWrapper = personServiceWrapper;
            _courseServiceWrapper = courseServiceWrapper;
            _homeServiceWrapper = homeServiceWrapper;
            _messageHelper = messageHelper;
        }

        public ViewResult Index(SokPersonViewModel sokPersonViewModel)
        {
            //Sidan består av en sök-del och en resultat-del. Sökdelens inputfält är definierade i SokPersonViewModel, så labeltexter sätts där. 
            //Resultatet av en sökning lagras även den i SokPersonViewModel som en lista med Person.
            //Resultatets rubriktexter hämtas alla från Strings.
            if (!sokPersonViewModel.HideResults)
            {
                sokPersonViewModel.PersonList = new List<Person>();
                sokPersonViewModel.HideResults = true;
                return View(sokPersonViewModel);
            }

            var discriminator = sokPersonViewModel.Discriminator == null ? null : sokPersonViewModel.Discriminator.ToString();

            sokPersonViewModel.HideResults = false;
            sokPersonViewModel.PersonList = _personServiceWrapper.GetPersonerByMany(sokPersonViewModel.FirstName, discriminator, null);
            return View(sokPersonViewModel);
        }

        public ActionResult Details(string id, bool editMode = false, bool isNyAnvandare = false, string returnUrl = "")
        {
            var model = new PersonViewModel {ID = Convert.ToInt32(id), EditMode = editMode, ReturnUrl = returnUrl, IsNyAnvandare = isNyAnvandare};
            FillModel(model);

            return View(model);
        }

        private void FillModel(PersonViewModel personViewModel)
        {
            //Hämtar info om en person, hämtar del från vår databas(person) och dels från en extern datakälla. Av båda dessa
            //fylls objektet PersonInformation
            personViewModel.PersonInformation = _personServiceWrapper.GetPersonInformationById(personViewModel.ID);

            //Discriminator dropdownen är en Enumdropdown som fylls från Enums.Discriminator och valet som är gjort för personen sedan
            //tidigare sätts här i koden
            //@Html.EnumDropDownListFor(m => m.DiscriminatorVal, @Strings.Valj_dot, new { @class = "selectpicker toolbar-responsive-control toolbar-button-separator form-control", onchange = "hideShowFromDiskriminator();" })
            Enums.Discriminator personDiscriminator;
            Enum.TryParse(personViewModel.PersonInformation.Discriminator, out personDiscriminator);
            personViewModel.DiscriminatorVal = personDiscriminator;

            //Hämtar alla course för att fylla i dropdown, är en flervalsdropdown
            //Flervalslistboxen. De val som är gjorda för personen sedan tidigare måste lagras i ett eget fält och sedan i script
            //fixas så de markeras i dropdownen från @Html.HiddenFor(m => m.CourseDefaultVal, new { id = "course-default" })
            //m.CourseVal kommer att innehålla de val som gäller när sidan sparas
            //@Html.DropDownListFor(m => m.CourseVal, new SelectList(Model.Courses, "CourseID", "Title"), new { @class = "selectpicker selectpickercourse toolbar-responsive-control toolbar-button-separator form-control", multiple = "true", id = "cource-select" })
            personViewModel.Courses = _courseServiceWrapper.GetCourses();
            var selectedIds = string.Join(",", personViewModel.PersonInformation.Course.ToList().Select(r => r.CourseID).ToArray());
            personViewModel.CourseDefaultVal = selectedIds;

            //Hämtar alla home för att fylla i dropdown, är en sökbar dropdown
            //Valet som är gjort för personen sedan tidigare sätts i sidan genom värdet på m.PersonInformation.HomeId 
            //@Html.DropDownListFor(m => m.PersonInformation.HomeId, new SelectList(Model.Homes, "HomeId", "HomeText"), new { @class = "selectpicker toolbar-responsive-control toolbar-button-separator form-control" })
            personViewModel.Homes = _homeServiceWrapper.GetHomes();
        }

        public ActionResult Free(string personId, string returnUrl, string freeChoice)
        {
            try
            {
                if (freeChoice == null)
                    throw new LogicValidationException("Personen har redan varit ledig tillräckligt mycket");
                _messageHelper.ShowNotification(TempData, Constants.NotificationTypes.Success, Strings.FreeText, Strings.Free);
            }
            catch (LogicValidationException ex)
            {
                _messageHelper.ShowAlert(TempData, Constants.AlertTypes.Danger, Strings.Free, ex.Message);
            }
            return (RedirectToAction("Details", new { id = personId, returnUrl, editMode = "false" }));

        }

        public ActionResult ErrorHantering()
        {
            try
            {
                throw new Exception("Test för att visa felhanteringen");
            }
            catch (LogicValidationException ex)
            {
                _messageHelper.ShowAlert(TempData, Constants.AlertTypes.Danger, Strings.Free, ex.Message);
            }
            return (RedirectToAction("Index"));

        }


    }
}