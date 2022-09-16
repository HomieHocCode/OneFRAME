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
    public class DanhMucTinhThanhProcessBll : DanhMucTinhThanhTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucTinhThanhProcessBll";
            }
        }

        public override DanhMucTinhThanhCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter)
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
                if (ODanhMucTinhThanhFilter == null)
                {
                    ODanhMucTinhThanhFilter = new DanhMucTinhThanhFilterCls();
                }
                Collection<DbParam>
                    ColDbParams = new Collection<DbParam>();
                string Query = "";

                Query = " select * from DanhMucTinhThanh where 1=1 ";
                if (!string.IsNullOrEmpty(ODanhMucTinhThanhFilter.Keyword))
                {
                    ColDbParams.Add(new DbParam("Keyword", "%" + ODanhMucTinhThanhFilter.Keyword + "%"));
                    Query += " and DanhMucTinhThanhName like " + ActionSqlParam.SpecialChar + "Keyword";
                }
                Query += " order by STT";

                DataSet dsResult =
                        DBService.GetDataSet(ActionSqlParam.Trans, Query, ColDbParams.ToArray());
                DanhMucTinhThanhCls[] DanhMucTinhThanhs = DanhMucTinhThanhParser.ParseFromDataTable(dsResult.Tables[0]);

                dsResult.Clear();
                dsResult.Dispose();
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return DanhMucTinhThanhs;
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
        public override void Add(ActionSqlParamCls ActionSqlParam, DanhMucTinhThanhCls ODanhMucTinhThanh)
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
                if (string.IsNullOrEmpty(ODanhMucTinhThanh.ID))
                {
                    ODanhMucTinhThanh.ID = System.Guid.NewGuid().ToString();
                }
                string Query = "select * from DanhMucTinhThanh where Ma=" + ActionSqlParam.SpecialChar + "Ma ";
                DataTable dtCheck = DBService.GetDataTable(ActionSqlParam.Trans, Query, new DbParam[]
            {
                new DbParam("Ma",ODanhMucTinhThanh.Ma)
            });

                if (dtCheck.Rows.Count == 0)
                {
                    DBService.Insert(ActionSqlParam.Trans, "DanhMucTinhThanh",
                        new DbParam[]{
                            new DbParam("ID", ODanhMucTinhThanh.ID),
                            new DbParam("Ma", ODanhMucTinhThanh.Ma),
                            new DbParam("Ten", ODanhMucTinhThanh.Ten),
                            new DbParam("QuocGiaID", ODanhMucTinhThanh.QuocGiaID),
                            new DbParam("VungID", ODanhMucTinhThanh.VungID),
                            new DbParam("MoTa ", ODanhMucTinhThanh.MoTa),
                            new DbParam("HieuLuc", ODanhMucTinhThanh.HieuLuc),
                            new DbParam("STT", ODanhMucTinhThanh.STT),
                            new DbParam("NgayTao", ODanhMucTinhThanh.NgayTao),
                            new DbParam("TuNgay", ODanhMucTinhThanh.NgayHieuLuc),
                            new DbParam("GhiChu ", ODanhMucTinhThanh.GhiChu),
                            new DbParam("DenNgay", ODanhMucTinhThanh.NgayHetHieuLuc),
                            new DbParam("MaBCBYT", ODanhMucTinhThanh.MaBCBYT),
                            new DbParam("ChaID", ODanhMucTinhThanh.ChaID),
                });
                }
                else
                {
                    string ID = (string)dtCheck.Rows[0]["ID"];
                    DBService.Update(ActionSqlParam.Trans, "DanhMucTinhThanh", "ID", ID,
                        new DbParam[]{
                            new DbParam("ID", ODanhMucTinhThanh.ID),
                            new DbParam("Ma", ODanhMucTinhThanh.Ma),
                            new DbParam("Ten", ODanhMucTinhThanh.Ten),
                            new DbParam("QuocGiaID", ODanhMucTinhThanh.QuocGiaID),
                            new DbParam("VungID", ODanhMucTinhThanh.VungID),
                            new DbParam("MoTa ", ODanhMucTinhThanh.MoTa),
                            new DbParam("STT", ODanhMucTinhThanh.STT),
                            new DbParam("HieuLuc", ODanhMucTinhThanh.HieuLuc),
                            new DbParam("NgayTao", ODanhMucTinhThanh.NgayTao),
                            new DbParam("GhiChu ", ODanhMucTinhThanh.GhiChu),
                            new DbParam("TuNgay", ODanhMucTinhThanh.NgayHieuLuc),
                            new DbParam("DenNgay", ODanhMucTinhThanh.NgayHetHieuLuc),
                            new DbParam("MaBCBYT", ODanhMucTinhThanh.MaBCBYT),
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
        public override void Save(ActionSqlParamCls ActionSqlParam, string ID, DanhMucTinhThanhCls ODanhMucTinhThanh)
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
                DBService.Update(ActionSqlParam.Trans, "DanhMucTinhThanh", "ID", ID,
                   new DbParam[]{
                   new DbParam("ID", ODanhMucTinhThanh.ID),
                            new DbParam("Ma", ODanhMucTinhThanh.Ma),
                            new DbParam("Ten", ODanhMucTinhThanh.Ten),
                            new DbParam("QuocGiaID", ODanhMucTinhThanh.QuocGiaID),
                            new DbParam("VungID", ODanhMucTinhThanh.VungID),
                            new DbParam("MoTa ", ODanhMucTinhThanh.MoTa),
                            new DbParam("STT", ODanhMucTinhThanh.STT),
                            new DbParam("GhiChu ", ODanhMucTinhThanh.GhiChu),
                            new DbParam("HieuLuc", ODanhMucTinhThanh.HieuLuc),
                            new DbParam("NgayTao", ODanhMucTinhThanh.NgayTao),
                            new DbParam("TuNgay", ODanhMucTinhThanh.NgayHieuLuc),
                            new DbParam("DenNgay", ODanhMucTinhThanh.NgayHetHieuLuc),
                            new DbParam("MaBCBYT", ODanhMucTinhThanh.MaBCBYT),
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
                string DelQuery = " Delete from DanhMucTinhThanh where Id=" + ActionSqlParam.SpecialChar + "Id";
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
        public override DanhMucTinhThanhCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id)
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
                        DBService.GetDataSet(ActionSqlParam.Trans, "select top 1 * from DanhMucTinhThanh where (Id=" + ActionSqlParam.SpecialChar + "Id or Ma=" + ActionSqlParam.SpecialChar + "Id or Ten=" + ActionSqlParam.SpecialChar + "Id)  ", new DbParam[]{
                    new DbParam("Id",Id)
                });
                DanhMucTinhThanhCls ODanhMucTinhThanh = null;
                if (dsResult.Tables[0].Rows.Count > 0)
                {
                    ODanhMucTinhThanh = DanhMucTinhThanhParser.ParseFromDataRow(dsResult.Tables[0].Rows[0]);
                }
                dsResult.Clear();
                dsResult.Dispose();

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return ODanhMucTinhThanh;
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
                DanhMucTinhThanhCls ODanhMucTinhThanh = CreateModel(ActionSqlParam, Id);
                ODanhMucTinhThanh.ID = NewId;
                Add(ActionSqlParam, ODanhMucTinhThanh);

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
        public override DanhMucTinhThanhCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter, int PageIndex, int PageSize)
        
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucTinhThanhFilter == null)
                    ODanhMucTinhThanhFilter = new DanhMucTinhThanhFilterCls();
                var skip = PageIndex * PageSize;
                string Query = " select * from DanhMucTinhThanh where 1=1";

                if (!string.IsNullOrEmpty(ODanhMucTinhThanhFilter.Keyword))
                    Query += " and (UPPER(MA) like UPPER(N'%" + ODanhMucTinhThanhFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucTinhThanhFilter.Keyword + "%')) ";
                //if (ODanhMucTinhThanhFilter.HieuLuc != (int)ONEMES3.DM.Model.Common.eSearch.SearchAll)
                //    Query += " and HIEULUC=" + ODanhMucTinhThanhFilter.HieuLuc;

                Query += " ORDER BY STT " +
                "OFFSET " + skip.ToString() + " ROWS " +
                "FETCH NEXT " + PageSize + " ROWS ONLY";

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                DanhMucTinhThanhCls[] DanhMucTinhThanhs = DanhMucTinhThanhParser.ParseFromDataTable(dsResult.Tables[0]);

                dsResult.Clear();
                dsResult.Dispose();
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return DanhMucTinhThanhs;
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
        public override DanhMucTinhThanhCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter, ref int recordTotal)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucTinhThanhFilter == null)
                    ODanhMucTinhThanhFilter = new DanhMucTinhThanhFilterCls();
                string Query = " select * from DanhMucTinhThanh where 1 = 1 ";
                string recordTotalQuery = " select count(1) from DanhMucTinhThanh where 1 = 1 ";

                if (!string.IsNullOrEmpty(ODanhMucTinhThanhFilter.Keyword))
                {
                    Query += " and (UPPER(TENTAT) like UPPER('%" + ODanhMucTinhThanhFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucTinhThanhFilter.Keyword + "%')) ";
                    recordTotalQuery += " and (UPPER(TENTAT) like UPPER('%" + ODanhMucTinhThanhFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucTinhThanhFilter.Keyword + "%')) ";
                }

                Query += " and HIEULUC = 1 ";

                Query += "ORDER BY STT " +
                    "OFFSET " + (ODanhMucTinhThanhFilter.PageIndex * ODanhMucTinhThanhFilter.PageSize) + " ROWS " +
                    "FETCH NEXT " + ODanhMucTinhThanhFilter.PageSize + " ROWS ONLY ";

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                DanhMucTinhThanhCls[] Icds = DanhMucTinhThanhParser.ParseFromDataTable(dsResult.Tables[0]);
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
        public override long Count(ActionSqlParamCls ActionSqlParam, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucTinhThanhFilter == null)
                    ODanhMucTinhThanhFilter = new DanhMucTinhThanhFilterCls();
                string Query = " select COUNT (*) from DanhMucTinhThanh where 1=1 ";

                if (!string.IsNullOrEmpty(ODanhMucTinhThanhFilter.Keyword))
                    Query += " and (UPPER(MA) like UPPER(N'%" + ODanhMucTinhThanhFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucTinhThanhFilter.Keyword + "%')) ";
                //if (ODanhMucTinhThanhFilter.HieuLuc != (int)ONEMES3.DM.Model.Common.eSearch.SearchAll)
                //    Query += " and HIEULUC=" + ODanhMucTinhThanhFilter.HieuLuc;

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                long count = DanhMucTinhThanhParser.CountFromDataTable(dsResult.Tables[0]);

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
        public override DanhMucTinhThanhCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten)
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
                        DBService.GetDataSet(ActionSqlParam.Trans, "select top 1 * from DanhMucTinhThanh where (Ten=" + ActionSqlParam.SpecialChar + "Ten)  ", new DbParam[]{
                    new DbParam("Ten",Ten)
                });
                DanhMucTinhThanhCls ODanhMucTinhThanh = null;
                if (dsResult.Tables[0].Rows.Count > 0)
                {
                    ODanhMucTinhThanh = DanhMucTinhThanhParser.ParseFromDataRow(dsResult.Tables[0].Rows[0]);
                }
                dsResult.Clear();
                dsResult.Dispose();

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return ODanhMucTinhThanh;
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
