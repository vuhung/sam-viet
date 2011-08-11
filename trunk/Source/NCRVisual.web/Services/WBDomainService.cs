﻿
namespace NCRVisual.web.Services
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;
    using NCRVisual.web.DataModel;


    // Implements application logic using the WBEntities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public partial class WBDomainService : LinqToEntitiesDomainService<WBEntities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'ref_country_indicator' query.
        public IQueryable<ref_country_indicator> GetRef_country_indicator()
        {
            return this.ObjectContext.ref_country_indicator;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'ref_project_millenium' query.
        public IQueryable<ref_project_millenium> GetRef_project_millenium()
        {
            return this.ObjectContext.ref_project_millenium;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'ref_tab_indicator' query.
        public IQueryable<ref_tab_indicator> GetRef_tab_indicator()
        {
            return this.ObjectContext.ref_tab_indicator;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'ref_user_country' query.
        public IQueryable<ref_user_country> GetRef_user_country()
        {
            return this.ObjectContext.ref_user_country;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'ref_user_indicator' query.
        public IQueryable<ref_user_indicator> GetRef_user_indicator()
        {
            return this.ObjectContext.ref_user_indicator;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'ref_user_indicator_graph' query.
        public IQueryable<ref_user_indicator_graph> GetRef_user_indicator_graph()
        {
            return this.ObjectContext.ref_user_indicator_graph;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'ref_user_tab' query.
        public IQueryable<ref_user_tab> GetRef_user_tab()
        {
            return this.ObjectContext.ref_user_tab;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'tbl_comments' query.
        public IQueryable<tbl_comments> GetTbl_comments()
        {
            return this.ObjectContext.tbl_comments;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'tbl_countries' query.
        public IQueryable<tbl_countries> GetTbl_countries()
        {
            return this.ObjectContext.tbl_countries;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'tbl_graphs' query.
        public IQueryable<tbl_graphs> GetTbl_graphs()
        {
            return this.ObjectContext.tbl_graphs;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'tbl_income_levels' query.
        public IQueryable<tbl_income_levels> GetTbl_income_levels()
        {
            return this.ObjectContext.tbl_income_levels;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'tbl_indicators' query.
        public IQueryable<tbl_indicators> GetTbl_indicators()
        {
            return this.ObjectContext.tbl_indicators;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'tbl_lending_types' query.
        public IQueryable<tbl_lending_types> GetTbl_lending_types()
        {
            return this.ObjectContext.tbl_lending_types;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'tbl_millenium' query.
        public IQueryable<tbl_millenium> GetTbl_millenium()
        {
            return this.ObjectContext.tbl_millenium;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'tbl_projects' query.
        public IQueryable<tbl_projects> GetTbl_projects()
        {
            return this.ObjectContext.tbl_projects;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'tbl_regions' query.
        public IQueryable<tbl_regions> GetTbl_regions()
        {
            return this.ObjectContext.tbl_regions;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'tbl_tabs' query.
        public IQueryable<tbl_tabs> GetTbl_tabs()
        {
            return this.ObjectContext.tbl_tabs;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'tbl_trades' query.
        public IQueryable<tbl_trades> GetTbl_trades()
        {
            return this.ObjectContext.tbl_trades;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'tbl_users' query.
        public IQueryable<tbl_users> GetTbl_users()
        {
            return this.ObjectContext.tbl_users;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'TM_WORLD_BORDERS_SIMPL_0_2' query.
        public IQueryable<TM_WORLD_BORDERS_SIMPL_0_2> GetTM_WORLD_BORDERS_SIMPL_0_2()
        {
            return this.ObjectContext.TM_WORLD_BORDERS_SIMPL_0_2;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'View_CountryBorder' query.
        public IQueryable<View_CountryBorder> GetView_CountryBorder()
        {
            return this.ObjectContext.View_CountryBorder;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'View_CountryIndicator' query.
        public IQueryable<View_CountryIndicator> GetView_CountryIndicator()
        {
            return this.ObjectContext.View_CountryIndicator;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'View_CountryIndicatorTab' query.
        public IQueryable<View_CountryIndicatorTab> GetView_CountryIndicatorTab()
        {
            return this.ObjectContext.View_CountryIndicatorTab;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'View_GeneralCountry' query.
        public IQueryable<View_GeneralCountry> GetView_GeneralCountry()
        {
            return this.ObjectContext.View_GeneralCountry;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'View_TabIndicator' query.
        public IQueryable<View_TabIndicator> GetView_TabIndicator()
        {
            return this.ObjectContext.View_TabIndicator;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'View_User_Country' query.
        public IQueryable<View_User_Country> GetView_User_Country()
        {
            return this.ObjectContext.View_User_Country;
        }
    }
}


