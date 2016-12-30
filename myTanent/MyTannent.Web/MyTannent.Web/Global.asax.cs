using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using MyTanent.DataModel.Model;
using MyTanent.DataModel.Datamodel;

namespace MyTannent.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

            Mapper.CreateMap<tblUser, UserModel>();
            Mapper.CreateMap<UserModel, tblUser>();
            Mapper.CreateMap<RoomModel, tblRoom>();
            Mapper.CreateMap<tblRoom, RoomModel>();
            Mapper.CreateMap<StateModel, tblState>();
            Mapper.CreateMap<tblState, StateModel>();
            Mapper.CreateMap<CityModel, tblCity>();
            Mapper.CreateMap<tblCity, CityModel>();
            Mapper.CreateMap<TanentDocumentsModel, tblTanentDocument>();
            Mapper.CreateMap<tblTanentDocument, TanentDocumentsModel>();

        }
    }
}