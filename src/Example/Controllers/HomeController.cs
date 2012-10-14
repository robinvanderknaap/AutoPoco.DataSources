using System;
using System.Web.Mvc;
using AutoPoco;
using AutoPoco.DataSources;
using Example.Models;

namespace Example.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Basic()
        {
            // Create factory for poco's and setup datasources
            var pocoFactory = AutoPocoContainer.Configure(x =>
            {
                x.Conventions(c => c.UseDefaultConventions());
                x.AddFromAssemblyContainingType<User>();
                x.Include<User>()
                    .Setup(u => u.Email).Use<EmailAddressSource>()
                    .Setup(u => u.Firstname).Use<FirstNameSource>()
                    .Setup(u => u.Lastname).Use<LastNameSource>()
                    .Setup(u => u.DateOfBirth).Use<DateOfBirthSource>();
            });

            // Get session from factory
            var pocoSession = pocoFactory.CreateSession();

            // Get 10 users
            var users = pocoSession.List<User>(10).Get();

            return View(users);
        }

        public ActionResult Custom()
        {
            // Create factory for poco's and setup datasources
            var pocoFactory = AutoPocoContainer.Configure(x =>
            {
                x.Conventions(c => c.UseDefaultConventions());
                x.AddFromAssemblyContainingType<Company>();
                x.Include<Company>()
                    .Setup(c => c.CompanyName).Use<CompanySource>()
                    .Setup(c => c.CompanySize).Use<EnumSource<CompanySizeEnum>>()
                    .Setup(c => c.Email).Use<ExtendedEmailAddressSource>()
                    .Setup(c => c.Street).Use<StreetSource>()
                    .Setup(c => c.Postal).Use<PostalSource>()
                    .Setup(c => c.City).Use<CitySource>()
                    .Setup(c => c.Url).Use<UrlSource>();
            });

            // Get session from factory
            var pocoSession = pocoFactory.CreateSession();

            // Get 10 companies
            var companies = pocoSession.List<Company>(10).Get();

            return View(companies);
        }

        public ActionResult ValueTypes()
        {
            // Create factory for poco's and setup datasources
            var pocoFactory = AutoPocoContainer.Configure(x =>
            {
                x.Conventions(c => c.UseDefaultConventions());
                x.AddFromAssemblyContainingType<PocoLoco>();
                x.Include<PocoLoco>()
                    .Setup(c => c.SomeInt).Use<IntegerSource>(100, 500)
                    .Setup(c => c.SomeFloat).Use<FloatSource>(10, 50)
                    .Setup(c => c.SomeDouble).Use<DoubleSource>(60, 5000)
                    .Setup(c => c.SomeDecimal).Use<DecimalSource>(-50m, -30m)
                    .Setup(c => c.SomeDateTime).Use<DateTimeSource>(DateTime.Now, DateTime.Now.AddYears(1))
                    .Setup(c => c.SomeBool).Use<BooleanSource>()
                    .Setup(c => c.SomeTimeSpan).Use<TimeSpanSource>(TimeSpan.Zero, TimeSpan.FromHours(10));
            });

            // Get session from factory
            var pocoSession = pocoFactory.CreateSession();

            // Get ten pocoloco's
            var pocoLoco = pocoSession.List<PocoLoco>(10).Get();

            return View(pocoLoco);
        }

        public ActionResult Dutch()
        {
            // Create factory for poco's and setup datasources
            var pocoFactory = AutoPocoContainer.Configure(x =>
            {
                x.Conventions(c => c.UseDefaultConventions());
                x.AddFromAssemblyContainingType<DutchUser>();
                x.Include<DutchUser>()
                    .Setup(c => c.Firstname).Use<FirstNameSource>()
                    .Setup(c => c.Middlename).Use<DutchMiddlenameSource>()
                    .Setup(c => c.Lastname).Use<LastNameSource>()
                    .Setup(c => c.Email).Use<ExtendedEmailAddressSource>()
                    .Setup(c => c.Telephone).Use<DutchTelephoneSource>()
                    .Setup(c => c.Mobile).Use<DutchMobileSource>()
                    .Setup(c => c.City).Use<DutchCitySource>()
                    .Setup(c => c.Postal).Use<DutchPostalSource>();
            });

            // Get session from factory
            var pocoSession = pocoFactory.CreateSession();

            // Get ten dutch users
            var dutchUser = pocoSession.List<DutchUser>(10).Get();

            return View(dutchUser);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
