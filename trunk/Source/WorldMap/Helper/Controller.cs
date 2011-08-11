﻿using NCRVisual.web.Services;
using System.Linq;
using NCRVisual.web.DataModel;
using System;
using System.Collections.Generic;
using System.ServiceModel.DomainServices.Client;
using System.Windows.Media;

namespace WorldMap.Helper
{
    /// <summary>
    /// Controller class for worldmap, get data from database
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// The context of services working with WB database
        /// </summary>
        public WBDomainContext Context { get; set; }

        /// <summary>
        /// Converter to turn sql geometry type to Silverlight collection Point
        /// </summary>
        public WKTToGeomatryPoint GeomatryConverter { get; set; }

        #region EventHandler
        /// <summary>
        /// Event after loading base data completed
        /// </summary>
        public event EventHandler LoadInitDataCompleted;

        /// <summary>
        /// Event after loading tab data completed
        /// </summary>
        public event EventHandler GetTabCountryDataCompleted;

        /// <summary>
        /// Event after loading tab indicator completed
        /// </summary>
        public event EventHandler GetView_TabIndicatorQueryCompleted;

        /// <summary>
        /// Event after getting import data completed
        /// </summary>
        public event EventHandler GetImportData_Completed;

        /// <summary>
        /// Event after gettin export data completed
        /// </summary>
        public event EventHandler GetExportData_Completed;

        /// <summary>
        /// Event after getting Border of a country completed;
        /// </summary>
        public event EventHandler GetBorder_completed;

        /// <summary>
        /// Event after getting WB Project list of a country completed;
        /// </summary>
        public event EventHandler GetCountryWBProject_completed;

        public event EventHandler LoadUserData_Completed;
        public event EventHandler InsertMsnUser_Completed;        
        public event EventHandler LoadUserCountry_Completed;
        public event EventHandler LoadUserIndicator_Completed;
        public event EventHandler LoadUserGraph_Completed;

        /// <summary>
        /// Event after finish saving CountryList data
        /// </summary>
        public event EventHandler SaveCountryListCompleted;

        /// <summary>
        /// Event after search country complete
        /// </summary>
        public event EventHandler SearchCountryByIndicators_Completed;

        /// <summary>
        /// Event after finish saving IndicatorList data
        /// </summary>
        public event EventHandler SaveIndicatorListCompleted;

        /// <summary>
        /// Event after finish saving IndicatorList data
        /// </summary>
        public event EventHandler SaveGraphCompleted;

        public event EventHandler LoadUserComment_Completed;

        /// <summary>
        /// Event after finish saving a comment
        /// </summary>
        public event EventHandler SaveComment_completed;

        public event EventHandler GetProject_Completed;

        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        public Controller()
        {
            //Default indicators
            Context = new WBDomainContext();
            GeomatryConverter = new WKTToGeomatryPoint();

            //Note: Get indicator data
            var loadTabIndicator = Context.Load(Context.GetView_TabIndicatorQuery());
            loadTabIndicator.Completed += new EventHandler(loadTabIndicator_Completed);

            //Note: get country data
            var loadCountry = Context.Load(Context.GetTbl_countriesQuery());
            loadCountry.Completed += new System.EventHandler(load_Completed);
            
            LoadUserComment();
        }

        void loadTabIndicator_Completed(object sender, EventArgs e)
        {
            if (this.GetView_TabIndicatorQueryCompleted != null)
            {
                GetView_TabIndicatorQueryCompleted(sender, e);
            }
        }

        void load_Completed(object sender, System.EventArgs e)
        {
            if (this.LoadInitDataCompleted != null)
            {
                LoadInitDataCompleted(null, null);
            }
        }

        /// <summary>
        /// Get a country record base on its name
        /// </summary>
        /// <param name="countryName"></param>
        /// <returns></returns>
        public tbl_countries GetCountry(string countryName)
        {
            var country = from n in Context.tbl_countries
                          where n.country_name == countryName
                          select n;

            foreach (var a in country)
            {
                return a as tbl_countries;
            }

            return null;
        }

        /// <summary>
        /// Get a country record base on its Id
        /// </summary>
        /// <param name="countryName"></param>
        /// <returns></returns>
        public tbl_countries GetCountry(int countryId)
        {
            var country = from n in Context.tbl_countries
                          where n.country_id_pk == countryId
                          select n;

            foreach (var a in country)
            {
                return a as tbl_countries;
            }

            return null;
        }

        /// <summary>
        /// Get the overview country data
        /// </summary>
        /// <param name="country_pk"></param>
        public void GetTabCountryData(int country_pk)
        {
            var loadTabCountryData = Context.Load(Context.GetCountryGeneralInfoQuery(country_pk));
            loadTabCountryData.Completed += new EventHandler(loadTabCountryData_Completed);
        }

        /// <summary>
        /// Get the WKT for country border
        /// </summary>
        /// <param name="countryCode"></param>
        public void GetCountryBorder(string countryCode, SolidColorBrush color, string tooltip)
        {
            EntityQuery<View_CountryBorder> query = Context.GetCountryBorderQuery(countryCode);
            Action<LoadOperation<View_CountryBorder>> completeProcessing = delegate(LoadOperation<View_CountryBorder> loadOp)
            {
                if (!loadOp.HasError)
                {
                    loadBorder_Completed(loadOp.Entities, color, countryCode, tooltip);
                }
                else
                {
                    //LogAndNotify(loadOp.Error);
                }

            };
            LoadOperation<View_CountryBorder> loadOperation = Context.Load(query, completeProcessing, true);
        }

        private void loadBorder_Completed(IEnumerable<View_CountryBorder> results, SolidColorBrush countryColor, string countryCode, string tooltip)
        {
            foreach (View_CountryBorder result in results)
            {
                if (GetBorder_completed != null)
                {
                    GetBorder_completed(new object[4] { GeomatryConverter.GetObject(result.geom), countryColor, countryCode, tooltip }, null);
                }
            }
        }

        void loadTabCountryData_Completed(object sender, EventArgs e)
        {
            if (GetTabCountryDataCompleted != null)
            {
                GetTabCountryDataCompleted(sender, e);
            }
        }

        public void GetImportData(int importCountryId, List<int> exportCountryLists, int year)
        {
            var getImportData = Context.Load(Context.GetImportDataQuery(importCountryId, exportCountryLists, year));
            getImportData.Completed += new EventHandler(getImportData_Completed);
        }

        void getImportData_Completed(object sender, EventArgs e)
        {
            if (GetImportData_Completed != null)
            {
                GetImportData_Completed(sender, e);
            }
        }

        public void GetExportData(int exportCountryId, List<int> importCountryLists, int year)
        {
            var getExportData = Context.Load(Context.GetImportDataQuery(exportCountryId, importCountryLists, year));
            getExportData.Completed += new EventHandler(getExportData_Completed);
        }

        void getExportData_Completed(object sender, EventArgs e)
        {
            if (GetExportData_Completed != null)
            {
                GetExportData_Completed(sender, e);
            }
        }

        public void GetWBProject(int project_id_pk)
        {
            var getProjectData = Context.Load(Context.GetProjectQuery(project_id_pk));
            getProjectData.Completed += new EventHandler(getProjectData_Completed);
        }

        void getProjectData_Completed(object sender, EventArgs e)
        {
            if (GetProject_Completed != null)
            {
                GetProject_Completed(sender, e);
            }
        }

        /// <summary>
        /// Get country project data
        /// </summary>
        /// <param name="countryId"></param>
        public void GetCountryWBProject(int countryId)
        {
            var getCountryProjectData = Context.Load(Context.GetCountryProjectsQuery(countryId));
            getCountryProjectData.Completed += new EventHandler(getCountryProjectData_Completed);
        }

        void getCountryProjectData_Completed(object sender, EventArgs e)
        {
            if (GetCountryWBProject_completed != null)
            {
                GetCountryWBProject_completed(sender, e);
            }
        }

        #region save n load data

        public void InsertUser(tbl_users tbl_user)
        {
            Context.tbl_users.Add(tbl_user);
            var a = Context.SubmitChanges();
            a.Completed += new EventHandler(insertMsnUser_Completed);
        }

        void insertMsnUser_Completed(object sender, EventArgs e)
        {
            if (this.InsertMsnUser_Completed != null)
            {
                InsertMsnUser_Completed(sender, e);
            }
        }

        void loadUserData_Completed(IEnumerable<tbl_users> r, string cid)
        {
            var a = from n in r
                    where n.msn_id == cid
                    select n;
            tbl_users user = null;
            foreach (tbl_users x in a)
            {
                user = x;
            }
            if (this.LoadUserData_Completed != null)
            {
                LoadUserData_Completed(user, null);
            }
        }


        public void CheckExist(string cid)
        {

            //EntityQuery<View_CountryBorder> query = Context.GetCountryBorderQuery(countryCode);
            Action<LoadOperation<tbl_users>> completeProcessing = delegate(LoadOperation<tbl_users> loadOp)
            {
                if (!loadOp.HasError)
                {
                    loadUserData_Completed(loadOp.Entities, cid);
                }
                else
                {
                    //LogAndNotify(loadOp.Error);
                }

            };
            //LoadOperation<View_CountryBorder> loadOperation = Context.Load(query, completeProcessing, true);
            var loadUser_Data = Context.Load(Context.GetUserQuery(cid), completeProcessing, true);

        }

        public tbl_users GetUser(string cid)
        {
            Context.Load(Context.GetUserQuery(cid));
            var user = from n in Context.tbl_users
                       where n.msn_id == cid
                       select n;

            foreach (var a in user)
            {
                return a as tbl_users;
            }

            return null;
        }

        void loadUserCountry_Completed(IEnumerable<ref_user_country> r, tbl_users tbl_users, List<ref_user_country> countries)
        {

            var a = from n in r
                    where tbl_users.user_id_pk == n.user_id
                    select n;
            foreach (ref_user_country x in a)
            {
                Context.ref_user_countries.Remove(x);
            }
            foreach (ref_user_country x in countries)
            {
                x.user_id = tbl_users.user_id_pk;
                Context.ref_user_countries.Add(x);
            }

            Action<SubmitOperation> saveComplete = delegate(SubmitOperation comp)
            {
                if (!comp.HasError)
                {
                    if (SaveCountryListCompleted != null)
                    {
                        SaveCountryListCompleted("Your country List has been saved", null);
                    }
                }                
            };

            Context.SubmitChanges(saveComplete, true);
        }        

        public void InsertUserCountry(tbl_users tbl_user, List<ref_user_country> countries)
        {
            //EntityQuery<View_CountryBorder> query = Context.GetCountryBorderQuery(countryCode);
            Action<LoadOperation<ref_user_country>> completeProcessing = delegate(LoadOperation<ref_user_country> loadOp)
            {
                if (!loadOp.HasError)
                {
                    loadUserCountry_Completed(loadOp.Entities, tbl_user, countries);
                }
                else
                {
                    //LogAndNotify(loadOp.Error);
                }
            };
            //LoadOperation<View_CountryBorder> loadOperation = Context.Load(query, completeProcessing, true);
            var loadUser_Data = Context.Load(Context.GetRef_user_countryQuery(), completeProcessing, true);
        }

        void loadRefUserCountry_Completed(object sender, EventArgs e)
        {
            if (this.LoadUserCountry_Completed != null)
            {
                LoadUserCountry_Completed(sender, e);
            }
        }

        public void LoadUserCountry()
        {
            var loadRefUserCountry = Context.Load(Context.GetRef_user_countryQuery());
            loadRefUserCountry.Completed += new EventHandler(loadRefUserCountry_Completed);
        }

        public List<ref_user_country> LoadRefUserCountry(tbl_users tbl_user)
        {
            var ref_user_country = from n in Context.ref_user_countries
                                   where n.user_id == tbl_user.user_id_pk
                                   select n;
            List<ref_user_country> listCountry = new List<ref_user_country>();
            foreach (var a in ref_user_country)
            {
                listCountry.Add(a);
            }
            return listCountry;
        }

        #endregion

        #region Save n load indicators
        public void SaveIndicatorList(List<int> listIndicator, tbl_users user)
        {
            //EntityQuery<View_CountryBorder> query = Context.GetCountryBorderQuery(countryCode);
            Action<LoadOperation<ref_user_indicator>> completeProcessing = delegate(LoadOperation<ref_user_indicator> loadOp)
            {
                if (!loadOp.HasError)
                {
                    loadUserIndicator_Completed(loadOp.Entities, user, listIndicator);
                }
                else
                {
                    //LogAndNotify(loadOp.Error);
                }

            };
            //LoadOperation<View_CountryBorder> loadOperation = Context.Load(query, completeProcessing, true);
            var loadUser_Data = Context.Load(Context.GetRef_user_indicatorQuery(), completeProcessing, true);
        }
        void loadUserIndicator_Completed(IEnumerable<ref_user_indicator> r, tbl_users user, List<int> listIndicator)
        {
            var ref_user_indicators = from n in r
                                      where n.user_id == user.user_id_pk
                                      select n;
            foreach (ref_user_indicator ref_user_indicator in ref_user_indicators)
            {
                Context.ref_user_indicators.Remove(ref_user_indicator);
            }

            foreach (int i in listIndicator)
            {
                ref_user_indicator ref_user_indicator = new ref_user_indicator();
                ref_user_indicator.user_id = user.user_id_pk;
                ref_user_indicator.indicator_id = i;
                var x = from n in Context.ref_user_indicators
                        where (n.user_id == ref_user_indicator.user_id) && (n.indicator_id == i)
                        select n;
                if (x.Count() == 0)
                    Context.ref_user_indicators.Add(ref_user_indicator);
            }            

            Action<SubmitOperation> saveComplete = delegate(SubmitOperation comp)
            {
                if (!comp.HasError)
                {
                    if (SaveIndicatorListCompleted != null)
                    {
                        SaveIndicatorListCompleted("Your Indicator List has been saved", null);
                    }
                }
            };

            Context.SubmitChanges(saveComplete, true);
        }

        public void LoadUserIndicator()
        {
            var loadUserIndicator = Context.Load(Context.GetRef_user_indicatorQuery());
            loadUserIndicator.Completed += new EventHandler(loadRefUserIndicator_Completed);

        }

        void loadRefUserIndicator_Completed(object sender, EventArgs e)
        {
            if (LoadUserIndicator_Completed != null)
            {
                LoadUserIndicator_Completed(sender, e);
            }
        }

        public List<ref_user_indicator> LoadRefUserIndicator(tbl_users tbl_user)
        {
            var ref_user_indicator = from n in Context.ref_user_indicators
                                     where n.user_id == tbl_user.user_id_pk
                                     select n;
            List<ref_user_indicator> listIndicators = new List<ref_user_indicator>();
            foreach (var a in ref_user_indicator)
            {
                listIndicators.Add(a);
            }
            return listIndicators;
        }
        #endregion

        #region Search Country

        public void SearchCountryByIndicator(int indicatorId, int year, double? fromValue, double? toValue)
        {
            EntityQuery<ref_country_indicator> query = Context.GetCountryByIndicatorsQuery(indicatorId, year, fromValue, toValue);
            Action<LoadOperation<ref_country_indicator>> completeProcessing = delegate(LoadOperation<ref_country_indicator> loadOp)
            {
                if (!loadOp.HasError)
                {
                    SearchCountryByIndicator_Completed(loadOp.Entities);
                }
                else
                {
                    //LogAndNotify(loadOp.Error);
                }

            };
            LoadOperation<ref_country_indicator> loadOperation = Context.Load(query, completeProcessing, true);
        }

        private void SearchCountryByIndicator_Completed(IEnumerable<ref_country_indicator> result)
        {
            if (SearchCountryByIndicators_Completed != null)
            {
                SearchCountryByIndicators_Completed(result, null);
            }
        }

        #endregion

        #region save and load graph

        public void LoadUserGraph()
        {
            var loadUserGraph = Context.Load(Context.GetTbl_graphsQuery());
            loadUserGraph.Completed += new EventHandler(loadUserGraph_Completed);
        }

        public List<tbl_graphs> LoadUserGraph(tbl_users user)
        {
            var userGraph = from n in Context.tbl_graphs
                            where n.user_id == user.user_id_pk
                            select n;

            List<tbl_graphs> graphs = new List<tbl_graphs>();
            foreach (var graph in userGraph)
            {
                graphs.Add(graph);
            }

            return graphs;
        }

        void loadUserGraph_Completed(object sender, EventArgs e)
        {
            if (LoadUserGraph_Completed != null)
            {
                LoadUserGraph_Completed(sender, e);
            }
        }        

        public void saveGraph(tbl_graphs graph,string message)
        {
            //Temporary graphId
            graph.graph_id_pk = -1;

            Context.tbl_graphs.Add(graph);

            Action<SubmitOperation> saveComplete = delegate(SubmitOperation comp)
            {
                if (!comp.HasError)
                {
                    if (SaveGraphCompleted != null)
                    {
                        SaveGraphCompleted(message, null);
                    }
                }
            };
            Context.SubmitChanges(saveComplete, true);            
        }

        public void deleteGraph(tbl_graphs graph)
        {
            Context.tbl_graphs.Remove(graph);
            Context.SubmitChanges();
        }

        #endregion

        #region function for rss reader
        LoadOperation loadUserFavTabOp;
        LoadOperation loadRefUserTab;
        public void GetUserFavTab(tbl_users user)
        {
            loadRefUserTab = Context.Load(from n in Context.GetRef_user_tabQuery()
                                          where n.user_id == user.user_id_pk
                                          select n);
            loadRefUserTab.Completed += new EventHandler(loadRefUserTab_Completed);
        }

        private void loadRefUserTab_Completed(object sender, EventArgs e)
        {
            List<ref_user_tab> ref_user_tabList = new List<ref_user_tab>();

            var tmpE = loadRefUserTab.Entities;
            foreach (object o in tmpE)
            {
                ref_user_tabList.Add((ref_user_tab)o);
            }

            List<int> tblTabsPKList = new List<int>();

            foreach (ref_user_tab tmpRUT in ref_user_tabList)
            {
                tblTabsPKList.Add(tmpRUT.tab_id);
            }
            loadUserFavTabOp = this.Context.Load<tbl_tabs>(
                from t in Context.GetTbl_tabsInPKListQuery((IEnumerable<int>)tblTabsPKList)
                where 1 == 1
                select t
            );
            loadUserFavTabOp.Completed += new EventHandler(tbl_tabsLoadOpCompleted);
        }

        private void tbl_tabsLoadOpCompleted(object sender, EventArgs ea)
        {
            if (loadUserFavTabOp != null)
            {
                List<tbl_tabs> returnList = new List<tbl_tabs>();

                var tmpE = loadUserFavTabOp.Entities;

                foreach (object o in tmpE)
                {
                    returnList.Add((tbl_tabs)o);
                }

                LoadUserFavTabEventArgs eventArgs = new LoadUserFavTabEventArgs();
                eventArgs.UserFavTabs = returnList;

                LoadUserFavTabCompleted(sender, eventArgs);
            }
        }

        public delegate void LoadUserFavTabCompletedDelegate(object sender, LoadUserFavTabEventArgs e);
        public event LoadUserFavTabCompletedDelegate LoadUserFavTabCompleted;

        public class LoadUserFavTabEventArgs : EventArgs
        {
            public List<tbl_tabs> UserFavTabs { get; set; }
        }

        #region functions for rss options
        #endregion

        #endregion

        #region comments
        public void LoadUserComment()
        {
            var loadUserComment = Context.Load(Context.GetTbl_commentsQuery());
            loadUserComment.Completed += new EventHandler(loadUserComment_Completed);
        }

        public void loadUserComment_Completed(object sender, EventArgs e)
        {
            if (LoadUserComment_Completed != null)
            {
                LoadUserComment_Completed(sender, e);
            }            
        }

        public void SaveComment(tbl_comments comment)
        {
            Context.tbl_comments.Add(comment);
            Action<SubmitOperation> saveComplete = delegate(SubmitOperation comp)
            {
                if (!comp.HasError)
                {
                    if (SaveComment_completed != null)
                    {
                        SaveComment_completed(null, null);
                    }
                }
            };
            Context.SubmitChanges(saveComplete, true);            
        }

        public void DeleteComment(tbl_comments comment)
        {
            var comments = from n in Context.tbl_comments
                           where n.comment_id_pk==comment.comment_id_pk
                           select n;
            foreach (tbl_comments x in comments)
            {
                Context.tbl_comments.Remove(x);
            }
            Context.SubmitChanges();
        }
        
        public List<tbl_comments> LoadComment(int projectId)
        {
            List<tbl_comments> result = new List<tbl_comments>();
            var comments = from n in Context.tbl_comments
                           where n.project_id == projectId
                           select n;
            foreach (tbl_comments x in comments)
            {
                result.Add(x);
            }
            return result;
        }

        #endregion        
    }
}