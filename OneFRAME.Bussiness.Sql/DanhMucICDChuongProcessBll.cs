using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;
using OneFRAME.Model;
using OneFRAME.Bussiness.Template;
using OneFRAME.Core.Bussiness.Sql;
using OneFRAME.Database.Service;

namespace OneFRAME.Bussiness.Sql
{
    public class DanhMucICDChuongProcessBll : DanhMucICDChuongTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucICDChuongProcessBll";
            }
        }

        public override DanhMucICDChuongCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;

            if (!HasTrans)
            {
                ActionSqlParam.Trans = DBService.BeginTransaction();
            }

            try
            {
                if (ODanhMucICDChuongFilter == null)
                {
                    ODanhMucICDChuongFilter = new DanhMucICDChuongFilterCls();
                }
                Collection<DbParam>
                    ColDbParams = new Collection<DbParam>();
                string Query = "";

                Query = " select * from DanhMucICDChuong where 1=1 ";
                if (!string.IsNullOrEmpty(ODanhMucICDChuongFilter.Keyword))
                {
                    ColDbParams.Add(new DbParam("Keyword", "%" + ODanhMucICDChuongFilter.Keyword + "%"));
                    Query += " and DanhMucICDChuongName like " + ActionSqlParam.SpecialChar + "Keyword";
                }
                Query += " order by STT";

                DataSet dsResult =
                        DBService.GetDataSet(ActionSqlParam.Trans, Query, ColDbParams.ToArray());
                DanhMucICDChuongCls[] DanhMucICDChuongs = DanhMucICDChuongParser.ParseFromDataTable(dsResult.Tables[0]);

                dsResult.Clear();
                dsResult.Dispose();
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return DanhMucICDChuongs;
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
        public override void Add(ActionSqlParamCls ActionSqlParam, DanhMucICDChuongCls ODanhMucICDChuong)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;

            if (!HasTrans)
            {
                ActionSqlParam.Trans = DBService.BeginTransaction();
            }

            try
            {
                if (string.IsNullOrEmpty(ODanhMucICDChuong.ID))
                {
                    ODanhMucICDChuong.ID = System.Guid.NewGuid().ToString();
                }
                string Query = "select * from DanhMucICDChuong where Ma=" + ActionSqlParam.SpecialChar + "Ma ";
                DataTable dtCheck = DBService.GetDataTable(ActionSqlParam.Trans, Query, new DbParam[]
            {
                new DbParam("Ma",ODanhMucICDChuong.Ma)
            });

                if (dtCheck.Rows.Count == 0)
                {
                    DBService.Insert(ActionSqlParam.Trans, "DanhMucICDChuong",
                        new DbParam[]{
                            new DbParam("ID", ODanhMucICDChuong.ID),
                            new DbParam("Ma", ODanhMucICDChuong.Ma),
                            new DbParam("Ten", ODanhMucICDChuong.Ten),
                            new DbParam("GhiChu ", ODanhMucICDChuong.GhiChu),
                            new DbParam("MoTa ", ODanhMucICDChuong.MoTa),
                            new DbParam("STT", ODanhMucICDChuong.STT),
                            new DbParam("HieuLuc", ODanhMucICDChuong.HieuLuc),
                            new DbParam("NgayTao", ODanhMucICDChuong.NgayTao),
                            new DbParam("TuNgay", ODanhMucICDChuong.NgayHieuLuc),
                            new DbParam("DenNgay", ODanhMucICDChuong.NgayHetHieuLuc),
                            new DbParam("MaBCBYT", ODanhMucICDChuong.MaBCBYT),
                });
                }
                else
                {
                    string ID = (string)dtCheck.Rows[0]["ID"];
                    DBService.Update(ActionSqlParam.Trans, "DanhMucICDChuong", "ID", ID,
                        new DbParam[]{
                            new DbParam("ID", ODanhMucICDChuong.ID),
                            new DbParam("Ma", ODanhMucICDChuong.Ma),
                            new DbParam("Ten", ODanhMucICDChuong.Ten),
                            new DbParam("GhiChu ", ODanhMucICDChuong.GhiChu),
                            new DbParam("MoTa ", ODanhMucICDChuong.MoTa),
                            new DbParam("STT", ODanhMucICDChuong.STT),
                            new DbParam("HieuLuc", ODanhMucICDChuong.HieuLuc),
                            new DbParam("NgayTao", ODanhMucICDChuong.NgayTao),
                            new DbParam("TuNgay", ODanhMucICDChuong.NgayHieuLuc),
                            new DbParam("DenNgay", ODanhMucICDChuong.NgayHetHieuLuc),
                            new DbParam("MaBCBYT", ODanhMucICDChuong.MaBCBYT),
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
        public override void Save(ActionSqlParamCls ActionSqlParam, string ID, DanhMucICDChuongCls ODanhMucICDChuong)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;

            if (!HasTrans)
            {
                ActionSqlParam.Trans = DBService.BeginTransaction();
            }

            try
            {
                DBService.Update(ActionSqlParam.Trans, "DanhMucICDChuong", "ID", ID,
                   new DbParam[]{
                   new DbParam("ID", ODanhMucICDChuong.ID),
                            new DbParam("Ma", ODanhMucICDChuong.Ma),
                            new DbParam("Ten", ODanhMucICDChuong.Ten),
                            new DbParam("GhiChu ", ODanhMucICDChuong.GhiChu),
                            new DbParam("MoTa ", ODanhMucICDChuong.MoTa),
                            new DbParam("STT", ODanhMucICDChuong.STT),
                            new DbParam("HieuLuc", ODanhMucICDChuong.HieuLuc),
                            new DbParam("NgayTao", ODanhMucICDChuong.NgayTao),
                            new DbParam("TuNgay", ODanhMucICDChuong.NgayHieuLuc),
                            new DbParam("DenNgay", ODanhMucICDChuong.NgayHetHieuLuc),
                            new DbParam("MaBCBYT", ODanhMucICDChuong.MaBCBYT),
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
        public override void Delete(ActionSqlParamCls ActionSqlParam, string Id)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
            {
                ActionSqlParam.Trans = DBService.BeginTransaction();
            }

            try
            {
                string DelQuery = " Delete from DanhMucICDChuong where Id=" + ActionSqlParam.SpecialChar + "Id";
                DBService.ExecuteNonQuery(ActionSqlParam.Trans, DelQuery,
                    new DbParam[]
                {
                    new DbParam("Id", Id)
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
        public override DanhMucICDChuongCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;

            if (!HasTrans)
            {
                ActionSqlParam.Trans = DBService.BeginTransaction();
            }

            try
            {
                DataSet dsResult =
                        DBService.GetDataSet(ActionSqlParam.Trans, "select top 1 * from DanhMucICDChuong where (Id=" + ActionSqlParam.SpecialChar + "Id or Ma=" + ActionSqlParam.SpecialChar + "Id or Ten=" + ActionSqlParam.SpecialChar + "Id)  ", new DbParam[]{
                    new DbParam("Id",Id)
                });
                DanhMucICDChuongCls ODanhMucICDChuong = null;
                if (dsResult.Tables[0].Rows.Count > 0)
                {
                    ODanhMucICDChuong = DanhMucICDChuongParser.ParseFromDataRow(dsResult.Tables[0].Rows[0]);
                }
                dsResult.Clear();
                dsResult.Dispose();

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return ODanhMucICDChuong;
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
        public override string Duplicate(ActionSqlParamCls ActionSqlParam, string Id)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;

            string NewId = System.Guid.NewGuid().ToString();
            if (!HasTrans)
            {
                ActionSqlParam.Trans = DBService.BeginTransaction();
            }

            try
            {
                DanhMucICDChuongCls ODanhMucICDChuong = CreateModel(ActionSqlParam, Id);
                ODanhMucICDChuong.ID = NewId;
                Add(ActionSqlParam, ODanhMucICDChuong);

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return NewId;
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
        public override DanhMucICDChuongCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter, int PageIndex, int PageSize)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucICDChuongFilter == null)
                    ODanhMucICDChuongFilter = new DanhMucICDChuongFilterCls();
                var skip = PageIndex * PageSize;
                string Query = " select * from DanhMucICDChuong where 1=1";

                if (!string.IsNullOrEmpty(ODanhMucICDChuongFilter.Keyword))
                    Query += " and (UPPER(TENTAT) like UPPER(N'%" + ODanhMucICDChuongFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucICDChuongFilter.Keyword + "%')) ";
                //if (ODanhMucICDChuongFilter.HieuLuc != (int)ONEMES3.DM.Model.Common.eSearch.SearchAll)
                //    Query += " and HIEULUC=" + ODanhMucICDChuongFilter.HieuLuc;

                Query += " ORDER BY STT " +
                "OFFSET " + skip.ToString() + " ROWS " +
                "FETCH NEXT " + PageSize + " ROWS ONLY";

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                DanhMucICDChuongCls[] DanhMucICDChuongs = DanhMucICDChuongParser.ParseFromDataTable(dsResult.Tables[0]);

                dsResult.Clear();
                dsResult.Dispose();
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return DanhMucICDChuongs;
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
        public override DanhMucICDChuongCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter, ref int recordTotal)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucICDChuongFilter == null)
                    ODanhMucICDChuongFilter = new DanhMucICDChuongFilterCls();
                string Query = " select * from DanhMucICDChuong where 1 = 1 ";
                string recordTotalQuery = " select count(1) from DanhMucICDChuong where 1 = 1 ";

                if (!string.IsNullOrEmpty(ODanhMucICDChuongFilter.Keyword))
                {
                    Query += " and (UPPER(TENTAT) like UPPER('%" + ODanhMucICDChuongFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucICDChuongFilter.Keyword + "%')) ";
                    recordTotalQuery += " and (UPPER(TENTAT) like UPPER('%" + ODanhMucICDChuongFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucICDChuongFilter.Keyword + "%')) ";
                }

                Query += " and HIEULUC = 1 ";

                Query += "ORDER BY STT " +
                    "OFFSET " + (ODanhMucICDChuongFilter.PageIndex * ODanhMucICDChuongFilter.PageSize) + " ROWS " +
                    "FETCH NEXT " + ODanhMucICDChuongFilter.PageSize + " ROWS ONLY ";

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                DanhMucICDChuongCls[] Icds = DanhMucICDChuongParser.ParseFromDataTable(dsResult.Tables[0]);
                recordTotal = int.Parse(DBService.GetDataSet(ActionSqlParam.Trans, recordTotalQuery).Tables[0].Rows[0][0].ToString());

                dsResult.Clear();
                dsResult.Dispose();
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return Icds;
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
        public override long Count(ActionSqlParamCls ActionSqlParam, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucICDChuongFilter == null)
                    ODanhMucICDChuongFilter = new DanhMucICDChuongFilterCls();
                string Query = " select COUNT (*) from DanhMucICDChuong where 1=1 ";

                if (!string.IsNullOrEmpty(ODanhMucICDChuongFilter.Keyword))
                    Query += " and (UPPER(MA) like UPPER(N'%" + ODanhMucICDChuongFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucICDChuongFilter.Keyword + "%')) ";
                //if (ODanhMucICDChuongFilter.HieuLuc != (int)ONEMES3.DM.Model.Common.eSearch.SearchAll)
                //    Query += " and HIEULUC=" + ODanhMucICDChuongFilter.HieuLuc;

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                long count = DanhMucICDChuongParser.CountFromDataTable(dsResult.Tables[0]);

                dsResult.Clear();
                dsResult.Dispose();
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return count;
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
        public override DanhMucICDChuongCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;

            if (!HasTrans)
            {
                ActionSqlParam.Trans = DBService.BeginTransaction();
            }

            try
            {
                DataSet dsResult =
                        DBService.GetDataSet(ActionSqlParam.Trans, "select top 1 * from DanhMucICDChuong where (Ten=" + ActionSqlParam.SpecialChar + "Ten)  ", new DbParam[]{
                    new DbParam("Ten",Ten)
                });
                DanhMucICDChuongCls ODanhMucICDChuong = null;
                if (dsResult.Tables[0].Rows.Count > 0)
                {
                    ODanhMucICDChuong = DanhMucICDChuongParser.ParseFromDataRow(dsResult.Tables[0].Rows[0]);
                }
                dsResult.Clear();
                dsResult.Dispose();

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return ODanhMucICDChuong;
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
