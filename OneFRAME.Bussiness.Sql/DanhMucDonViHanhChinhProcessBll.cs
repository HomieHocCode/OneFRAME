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
    public class DanhMucDonViHanhChinhProcessBll : DanhMucDonViHanhChinhTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucDonViHanhChinhProcessBll";
            }
        }

        public override DanhMucDonViHanhChinhCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter)
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
                if (ODanhMucDonViHanhChinhFilter == null)
                {
                    ODanhMucDonViHanhChinhFilter = new DanhMucDonViHanhChinhFilterCls();
                }
                Collection<DbParam>
                    ColDbParams = new Collection<DbParam>();
                string Query = "";

                Query = " select * from DanhMucDonViHanhChinh where 1=1 ";
                if (!string.IsNullOrEmpty(ODanhMucDonViHanhChinhFilter.Keyword))
                {
                    ColDbParams.Add(new DbParam("Keyword", "%" + ODanhMucDonViHanhChinhFilter.Keyword + "%"));
                    Query += " and DanhMucDonViHanhChinhName like " + ActionSqlParam.SpecialChar + "Keyword";
                }
                Query += " order by STT";

                DataSet dsResult =
                        DBService.GetDataSet(ActionSqlParam.Trans, Query, ColDbParams.ToArray());
                DanhMucDonViHanhChinhCls[] DanhMucDonViHanhChinhs = DanhMucDonViHanhChinhParser.ParseFromDataTable(dsResult.Tables[0]);

                dsResult.Clear();
                dsResult.Dispose();
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return DanhMucDonViHanhChinhs;
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
        public override void Add(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh)
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
                if (string.IsNullOrEmpty(ODanhMucDonViHanhChinh.ID))
                {
                    ODanhMucDonViHanhChinh.ID = System.Guid.NewGuid().ToString();
                }
                string Query = "select * from DanhMucDonViHanhChinh where Ma=" + ActionSqlParam.SpecialChar + "Ma ";
                DataTable dtCheck = DBService.GetDataTable(ActionSqlParam.Trans, Query, new DbParam[]
            {
                new DbParam("Ma",ODanhMucDonViHanhChinh.Ma)
            });

                if (dtCheck.Rows.Count == 0)
                {
                    DBService.Insert(ActionSqlParam.Trans, "DanhMucDonViHanhChinh",
                        new DbParam[]{
                    new DbParam("ID",ODanhMucDonViHanhChinh.ID),
                    new DbParam("Ma",ODanhMucDonViHanhChinh.Ma),
                    new DbParam("Ten",ODanhMucDonViHanhChinh.Ten),
                    new DbParam("TenTat",ODanhMucDonViHanhChinh.TenTat),
                    new DbParam("MieuTa",ODanhMucDonViHanhChinh.MieuTa),
                    new DbParam("STT",ODanhMucDonViHanhChinh.STT),
                    new DbParam("HieuLuc",ODanhMucDonViHanhChinh.HieuLuc),
                    new DbParam("QuocGiaId",ODanhMucDonViHanhChinh.QuocGiaId),
                    new DbParam("VungId",ODanhMucDonViHanhChinh.VungId),
                    new DbParam("TinhThanhId",ODanhMucDonViHanhChinh.TinhThanhId),
                    new DbParam("QuanHuyenId",ODanhMucDonViHanhChinh.QuanHuyenId),
                    new DbParam("XaPhuongId",ODanhMucDonViHanhChinh.XaPhuongId),
                });
                }
                else
                {
                    string ID = (string)dtCheck.Rows[0]["ID"];
                    DBService.Update(ActionSqlParam.Trans, "DanhMucDonViHanhChinh", "ID", ID,
                        new DbParam[]{
                    new DbParam("Ma",ODanhMucDonViHanhChinh.Ma),
                    new DbParam("Ten",ODanhMucDonViHanhChinh.Ten),
                    new DbParam("TenTat",ODanhMucDonViHanhChinh.TenTat),
                    new DbParam("MieuTa",ODanhMucDonViHanhChinh.MieuTa),
                    new DbParam("STT",ODanhMucDonViHanhChinh.STT),
                    new DbParam("HieuLuc",ODanhMucDonViHanhChinh.HieuLuc),
                    new DbParam("QuocGiaId",ODanhMucDonViHanhChinh.QuocGiaId),
                    new DbParam("VungId",ODanhMucDonViHanhChinh.VungId),
                    new DbParam("TinhThanhId",ODanhMucDonViHanhChinh.TinhThanhId),
                    new DbParam("QuanHuyenId",ODanhMucDonViHanhChinh.QuanHuyenId),
                    new DbParam("XaPhuongId",ODanhMucDonViHanhChinh.XaPhuongId),
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
        public override void Save(ActionSqlParamCls ActionSqlParam, string ID, DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh)
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
                DBService.Update(ActionSqlParam.Trans, "DanhMucDonViHanhChinh", "ID", ID,
                   new DbParam[]{
                   new DbParam("Ma",ODanhMucDonViHanhChinh.Ma),
                   new DbParam("Ten",ODanhMucDonViHanhChinh.Ten),
                   new DbParam("TenTat",ODanhMucDonViHanhChinh.TenTat),
                   new DbParam("MieuTa",ODanhMucDonViHanhChinh.MieuTa),
                   new DbParam("STT",ODanhMucDonViHanhChinh.STT),
                   new DbParam("HieuLuc",ODanhMucDonViHanhChinh.HieuLuc),
                   new DbParam("QuocGiaId",ODanhMucDonViHanhChinh.QuocGiaId),
                   new DbParam("VungId",ODanhMucDonViHanhChinh.VungId),
                   new DbParam("TinhThanhId",ODanhMucDonViHanhChinh.TinhThanhId),
                   new DbParam("QuanHuyenId",ODanhMucDonViHanhChinh.QuanHuyenId),
                   new DbParam("XaPhuongId",ODanhMucDonViHanhChinh.XaPhuongId),
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
                string DelQuery = " Delete from DanhMucDonViHanhChinh where Id=" + ActionSqlParam.SpecialChar + "Id";
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
        public override DanhMucDonViHanhChinhCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id)
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
                        DBService.GetDataSet(ActionSqlParam.Trans, "select top 1 * from DanhMucDonViHanhChinh where (Id=" + ActionSqlParam.SpecialChar + "Id or Ma=" + ActionSqlParam.SpecialChar + "Id or Ten=" + ActionSqlParam.SpecialChar + "Id)  ", new DbParam[]{
                    new DbParam("Id",Id)
                });
                DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh = null;
                if (dsResult.Tables[0].Rows.Count > 0)
                {
                    ODanhMucDonViHanhChinh = DanhMucDonViHanhChinhParser.ParseFromDataRow(dsResult.Tables[0].Rows[0]);
                }
                dsResult.Clear();
                dsResult.Dispose();

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return ODanhMucDonViHanhChinh;
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
                DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh = CreateModel(ActionSqlParam, Id);
                ODanhMucDonViHanhChinh.ID = NewId;
                Add(ActionSqlParam, ODanhMucDonViHanhChinh);

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
        public override DanhMucDonViHanhChinhCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, int PageIndex, int PageSize)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucDonViHanhChinhFilter == null)
                    ODanhMucDonViHanhChinhFilter = new DanhMucDonViHanhChinhFilterCls();
                var skip = PageIndex * PageSize;
                string Query = " select * from DanhMucDonViHanhChinh where 1=1";

                if (!string.IsNullOrEmpty(ODanhMucDonViHanhChinhFilter.Keyword))
                    Query += " and (UPPER(TENTAT) like UPPER(N'%" + ODanhMucDonViHanhChinhFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucDonViHanhChinhFilter.Keyword + "%')) ";
                //if (ODanhMucDonViHanhChinhFilter.HieuLuc != (int)ONEMES3.DM.Model.Common.eSearch.SearchAll)
                //    Query += " and HIEULUC=" + ODanhMucDonViHanhChinhFilter.HieuLuc;

                Query += " ORDER BY STT " +
                "OFFSET " + skip.ToString() + " ROWS " +
                "FETCH NEXT " + PageSize + " ROWS ONLY";

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                DanhMucDonViHanhChinhCls[] DanhMucDonViHanhChinhs = DanhMucDonViHanhChinhParser.ParseFromDataTable(dsResult.Tables[0]);

                dsResult.Clear();
                dsResult.Dispose();
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return DanhMucDonViHanhChinhs;
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
        public override DanhMucDonViHanhChinhCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, ref long recordTotal)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucDonViHanhChinhFilter == null)
                    ODanhMucDonViHanhChinhFilter = new DanhMucDonViHanhChinhFilterCls();
                string Query = " select * from DanhMucDonViHanhChinh where 1 = 1 ";
                string recordTotalQuery = " select count(1) from DanhMucDonViHanhChinh where 1 = 1 ";

                if (!string.IsNullOrEmpty(ODanhMucDonViHanhChinhFilter.Keyword))
                {
                    Query += " and (UPPER(TENTAT) like UPPER('%" + ODanhMucDonViHanhChinhFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucDonViHanhChinhFilter.Keyword + "%')) ";
                    recordTotalQuery += " and (UPPER(TENTAT) like UPPER('%" + ODanhMucDonViHanhChinhFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucDonViHanhChinhFilter.Keyword + "%')) ";
                }

                Query += " and HIEULUC = 1 ";

                Query += "ORDER BY STT " +
                    "OFFSET " + (ODanhMucDonViHanhChinhFilter.PageIndex * ODanhMucDonViHanhChinhFilter.PageSize) + " ROWS " +
                    "FETCH NEXT " + ODanhMucDonViHanhChinhFilter.PageSize + " ROWS ONLY ";

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                DanhMucDonViHanhChinhCls[] Icds = DanhMucDonViHanhChinhParser.ParseFromDataTable(dsResult.Tables[0]);
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
        public override long Count(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucDonViHanhChinhFilter == null)
                    ODanhMucDonViHanhChinhFilter = new DanhMucDonViHanhChinhFilterCls();
                string Query = " select COUNT (*) from DanhMucDonViHanhChinh where 1=1 ";

                if (!string.IsNullOrEmpty(ODanhMucDonViHanhChinhFilter.Keyword))
                    Query += " and (UPPER(MA) like UPPER(N'%" + ODanhMucDonViHanhChinhFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucDonViHanhChinhFilter.Keyword + "%')) ";
                //if (ODanhMucDonViHanhChinhFilter.HieuLuc != (int)ONEMES3.DM.Model.Common.eSearch.SearchAll)
                //    Query += " and HIEULUC=" + ODanhMucDonViHanhChinhFilter.HieuLuc;

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                long count = DanhMucDonViHanhChinhParser.CountFromDataTable(dsResult.Tables[0]);

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
        public override DanhMucDonViHanhChinhCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten)
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
                        DBService.GetDataSet(ActionSqlParam.Trans, "select top 1 * from DanhMucDonViHanhChinh where (Ten=" + ActionSqlParam.SpecialChar + "Ten)  ", new DbParam[]{
                    new DbParam("Ten",Ten)
                });
                DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh = null;
                if (dsResult.Tables[0].Rows.Count > 0)
                {
                    ODanhMucDonViHanhChinh = DanhMucDonViHanhChinhParser.ParseFromDataRow(dsResult.Tables[0].Rows[0]);
                }
                dsResult.Clear();
                dsResult.Dispose();

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return ODanhMucDonViHanhChinh;
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
