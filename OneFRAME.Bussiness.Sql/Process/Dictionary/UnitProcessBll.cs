using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Bussiness.Template;
using OneFRAME.Core.Model;using OneFRAME.Model;
using OneFRAME.Core.Bussiness.Sql; using OneFRAME.Database.Service;

namespace OneFRAME.Bussiness.Sql
{
    public class UnitProcessBll : UnitTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlUnitProcessBll";
            }
        }


        public override UnitCls[] Reading(
            ActionSqlParamCls ActionSqlParam,
            UnitFilterCls OUnitFilter, bool HasCommit = false)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            

            if (!HasTrans)
            {
                ActionSqlParam.Trans = DBService.BeginTransaction();
            }

            try
            {
                if (OUnitFilter == null)
                {
                    OUnitFilter = new UnitFilterCls();
                }
                Collection<DbParam>
                    ColDbParams = new Collection<DbParam>();
                string Query = "";

                Query = " select * from TableUnit where 1=1 ";
                if (!string.IsNullOrEmpty(OUnitFilter.Keyword))
                {
                    ColDbParams.Add(new DbParam("Keyword", "%" + OUnitFilter.Keyword + "%"));
                    Query += " and UnitName like " + ActionSqlParam.SpecialChar + "Keyword";
                }

                Query += " order by SortIndex";

                DataSet dsResult =
                        DBService.GetDataSet(ActionSqlParam.Trans, Query, ColDbParams.ToArray());
                UnitCls[] Units = UnitParser.ParseFromDataTable(dsResult.Tables[0]);

                dsResult.Clear();
                dsResult.Dispose();

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return Units;
            }
            catch (Exception ex)
            {
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Rollback();
                    ActionSqlParam.Trans = null;
                }
                throw (ex);
            }
        }


        public override AjaxOut ReadingWithPage(
            ActionSqlParamCls ActionSqlParam, 
            UnitFilterCls OUnitFilter, bool HasCommit = false)
        {
            AjaxOut RetAjaxOut = new AjaxOut();

            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            

            if (!HasTrans)
            {
                ActionSqlParam.Trans = DBService.BeginTransaction();
            }

            try
            {
                if (OUnitFilter == null)
                {
                    OUnitFilter = new UnitFilterCls();
                }
                Collection<DbParam>
                    ColDbParams = new Collection<DbParam>();
                string Query = "";

                Query = " select * from TableUnit where 1=1 ";
                if (!string.IsNullOrEmpty(OUnitFilter.Keyword))
                {
                    ColDbParams.Add(new DbParam("Keyword", "%" + OUnitFilter.Keyword + "%"));
                    Query += " and UnitName like " + ActionSqlParam.SpecialChar + "Keyword";
                }

                Query += " order by SortIndex";
                
                DataSet dsResult =
                        DBService.GetDataSet(ActionSqlParam.Trans, Query, ColDbParams.ToArray());
                RetAjaxOut.RetNumber = dsResult.Tables[0].Rows.Count;
                
                UnitCls[] Units = UnitParser.ParseFromDataTable(dsResult.Tables[0]);

                dsResult.Clear();
                dsResult.Dispose();

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }

                
                RetAjaxOut.RetObject = Units;
                return RetAjaxOut;
            }
            catch (Exception ex)
            {
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Rollback();
                    ActionSqlParam.Trans = null;
                }
                throw (ex);
            }
        }

        public override void Add(ActionSqlParamCls ActionSqlParam, UnitCls OUnit, bool HasCommit = false)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            

            if (!HasTrans)
            {
                ActionSqlParam.Trans = DBService.BeginTransaction();
            }

            try
            {
                if (string.IsNullOrEmpty(OUnit.UnitId))
                {
                    OUnit.UnitId = System.Guid.NewGuid().ToString();
                }

                string Query = "select * from TableUnit where UnitCode="+ActionSqlParam.SpecialChar+"UnitCode ";
                DataTable dtCheck = DBService.GetDataTable(ActionSqlParam.Trans, Query, new DbParam[]
                {
                    new DbParam("UnitCode",OUnit.UnitCode)
                });

                if (dtCheck.Rows.Count == 0)
                {
                    DBService.Insert(ActionSqlParam.Trans, "TableUnit",
                        new DbParam[]{
                        new DbParam("UnitId",OUnit.UnitId),
                        new DbParam("UnitCode",OUnit.UnitCode),
                        new DbParam("UnitName",OUnit.UnitName),
                        new DbParam("SortIndex",OUnit.SortIndex),
                        new DbParam("Active",OUnit.Active),
                    });
                }
                else
                {
                    string UnitId = (string)dtCheck.Rows[0]["UnitId"];
                    DBService.Update(ActionSqlParam.Trans, "TableUnit", "UnitId", UnitId,
                        new DbParam[]{
                        new DbParam("UnitName",OUnit.UnitName),
                    });
                }
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
            }
            catch (Exception ex)
            {
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Rollback();
                    ActionSqlParam.Trans = null;
                }
                throw (ex);
            }
        }

        public override void Save(ActionSqlParamCls ActionSqlParam, string UnitId, UnitCls OUnit, bool HasCommit = false)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            

            if (!HasTrans)
            {
                ActionSqlParam.Trans = DBService.BeginTransaction();
            }

            try
            {
                DBService.Update(ActionSqlParam.Trans, "TableUnit", "UnitId", UnitId,
                    new DbParam[]{
                        new DbParam("UnitCode",OUnit.UnitCode),
                        new DbParam("UnitName",OUnit.UnitName),
                        new DbParam("SortIndex",OUnit.SortIndex),
                        new DbParam("Active",OUnit.Active),
                    });

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
            }
            catch (Exception ex)
            {
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Rollback();
                    ActionSqlParam.Trans = null;
                }
                throw (ex);
            }
        }

        public override void Delete(ActionSqlParamCls ActionSqlParam, string UnitId, bool HasCommit = false)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            

            if (!HasTrans)
            {
                ActionSqlParam.Trans = DBService.BeginTransaction();
            }

            try
            {
                string DelQuery = " Delete from TableUnit where UnitId="+ActionSqlParam.SpecialChar+"UnitId";
                DBService.ExecuteNonQuery(ActionSqlParam.Trans, DelQuery, 
                    new DbParam[]
                    {
                        new DbParam("UnitId", UnitId)
                    });

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
            }
            catch (Exception ex)
            {
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Rollback();
                    ActionSqlParam.Trans = null;
                }
                throw (ex);
            }
        }

        public override UnitCls CreateModel(ActionSqlParamCls ActionSqlParam, string UnitId, bool HasCommit = false)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            

            if (!HasTrans)
            {
                ActionSqlParam.Trans = DBService.BeginTransaction();
            }

            try
            {
                DataSet dsResult =
                        DBService.GetDataSet(ActionSqlParam.Trans, "select * from TableUnit where (UnitId="+ActionSqlParam.SpecialChar+"UnitId or UnitCode="+ActionSqlParam.SpecialChar+"UnitId)  ", new DbParam[]{
                        new DbParam("UnitId",UnitId)
                    });
                UnitCls OUnit = null;
                if (dsResult.Tables[0].Rows.Count > 0)
                {
                    OUnit = UnitParser.ParseFromDataRow(dsResult.Tables[0].Rows[0]);
                }
                dsResult.Clear();
                dsResult.Dispose();

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return OUnit;
            }
            catch (Exception ex)
            {
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Rollback();
                    ActionSqlParam.Trans = null;
                }
                throw (ex);
            }
        }

        public override string Duplicate(ActionSqlParamCls ActionSqlParam, string UnitId, bool HasCommit = false)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            

            string NewUnitId = System.Guid.NewGuid().ToString();
            if (!HasTrans)
            {
                ActionSqlParam.Trans = DBService.BeginTransaction();
            }

            try
            {
                UnitCls OUnit = CreateModel(ActionSqlParam, UnitId);
                OUnit.UnitId = NewUnitId;
                Add(ActionSqlParam, OUnit);

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return NewUnitId;
            }
            catch (Exception ex)
            {
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Rollback();
                    ActionSqlParam.Trans = null;
                }
                throw (ex);
            }
        }
    }
}
