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
    public class DanhMucVungMienProcessBll : DanhMucVungMienTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucVungMienProcessBll";
            }
        }

        public override DanhMucVungMienCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucVungMienFilterCls ODanhMucVungMienFilter)
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
                if (ODanhMucVungMienFilter == null)
                {
                    ODanhMucVungMienFilter = new DanhMucVungMienFilterCls();
                }
                Collection<DbParam>
                    ColDbParams = new Collection<DbParam>();
                string Query = "";

                Query = " select * from DanhMucVungMien where 1=1 ";
                if (!string.IsNullOrEmpty(ODanhMucVungMienFilter.Keyword))
                {
                    ColDbParams.Add(new DbParam("Keyword", "%" + ODanhMucVungMienFilter.Keyword + "%"));
                    Query += " and DanhMucVungMienName like " + ActionSqlParam.SpecialChar + "Keyword";
                }
                Query += " order by STT";

                DataSet dsResult =
                        DBService.GetDataSet(ActionSqlParam.Trans, Query, ColDbParams.ToArray());
                DanhMucVungMienCls[] DanhMucVungMiens = DanhMucVungMienParser.ParseFromDataTable(dsResult.Tables[0]);

                dsResult.Clear();
                dsResult.Dispose();
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return DanhMucVungMiens;
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
        public override void Add(ActionSqlParamCls ActionSqlParam, DanhMucVungMienCls ODanhMucVungMien)
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
                if (string.IsNullOrEmpty(ODanhMucVungMien.ID))
                {
                    ODanhMucVungMien.ID = System.Guid.NewGuid().ToString();
                }
                string Query = "select * from DanhMucVungMien where Ma=" + ActionSqlParam.SpecialChar + "Ma ";
                DataTable dtCheck = DBService.GetDataTable(ActionSqlParam.Trans, Query, new DbParam[]
            {
                new DbParam("Ma",ODanhMucVungMien.Ma)
            });

                if (dtCheck.Rows.Count == 0)
                {
                    DBService.Insert(ActionSqlParam.Trans, "DanhMucVungMien",
                        new DbParam[]{
                    new DbParam("ID",ODanhMucVungMien.ID),
                    new DbParam("Ma",ODanhMucVungMien.Ma),
                    new DbParam("Ten",ODanhMucVungMien.Ten),
                    new DbParam("NgayTao",ODanhMucVungMien.NgayTao),
                    new DbParam("MoTa",ODanhMucVungMien.MoTa),
                    new DbParam("Stt",ODanhMucVungMien.STT),
                    new DbParam("HieuLuc",ODanhMucVungMien.HieuLuc),
                    new DbParam("TuNgay",ODanhMucVungMien.NgayHieuLuc),
                    new DbParam("DenNgay",ODanhMucVungMien.NgayHetHieuLuc),
                    new DbParam("GhiChu",ODanhMucVungMien.GhiChu),
                    new DbParam("ChaID",ODanhMucVungMien.ChaID),
                   
                });
                }
                else
                {
                    string ID = (string)dtCheck.Rows[0]["ID"];
                    DBService.Update(ActionSqlParam.Trans, "DanhMucVungMien", "ID", ID,
                        new DbParam[]{
                    new DbParam("Ma",ODanhMucVungMien.Ma),
                    new DbParam("Ten",ODanhMucVungMien.Ten),
                    new DbParam("NgayTao",ODanhMucVungMien.NgayTao),
                    new DbParam("MoTa",ODanhMucVungMien.MoTa),
                    new DbParam("Stt",ODanhMucVungMien.STT),
                    new DbParam("HieuLuc",ODanhMucVungMien.HieuLuc),
                    new DbParam("TuNgay",ODanhMucVungMien.NgayHieuLuc),
                    new DbParam("DenNgay",ODanhMucVungMien.NgayHetHieuLuc),
                    new DbParam("GhiChu",ODanhMucVungMien.GhiChu),
                    new DbParam("ChaID",ODanhMucVungMien.ChaID),
                  
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
        public override void Save(ActionSqlParamCls ActionSqlParam, string ID, DanhMucVungMienCls ODanhMucVungMien)
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
                DBService.Update(ActionSqlParam.Trans, "DanhMucVungMien", "ID", ID,
                   new DbParam[]{
                   new DbParam("Ma",ODanhMucVungMien.Ma),
                   new DbParam("Ten",ODanhMucVungMien.Ten),
                   new DbParam("NgayTao",ODanhMucVungMien.NgayTao),
                   new DbParam("MoTa",ODanhMucVungMien.MoTa),
                   new DbParam("Stt",ODanhMucVungMien.STT),
                   new DbParam("HieuLuc",ODanhMucVungMien.HieuLuc),
                   new DbParam("TuNgay",ODanhMucVungMien.NgayHieuLuc),
                   new DbParam("DenNgay",ODanhMucVungMien.NgayHetHieuLuc),
                   new DbParam("GhiChu",ODanhMucVungMien.GhiChu),
                   new DbParam("ChaID",ODanhMucVungMien.ChaID),
                   
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
                string DelQuery = " Delete from DanhMucVungMien where Id=" + ActionSqlParam.SpecialChar + "Id";
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
        public override DanhMucVungMienCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id)
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
                        DBService.GetDataSet(ActionSqlParam.Trans, "select top 1 * from DanhMucVungMien where (Id=" + ActionSqlParam.SpecialChar + "Id or Ma=" + ActionSqlParam.SpecialChar + "Id or Ten=" + ActionSqlParam.SpecialChar + "Id)  ", new DbParam[]{
                    new DbParam("Id",Id)
                });
                DanhMucVungMienCls ODanhMucVungMien = null;
                if (dsResult.Tables[0].Rows.Count > 0)
                {
                    ODanhMucVungMien = DanhMucVungMienParser.ParseFromDataRow(dsResult.Tables[0].Rows[0]);
                }
                dsResult.Clear();
                dsResult.Dispose();

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return ODanhMucVungMien;
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
                DanhMucVungMienCls ODanhMucVungMien = CreateModel(ActionSqlParam, Id);
                ODanhMucVungMien.ID = NewId;
                Add(ActionSqlParam, ODanhMucVungMien);

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
        public override DanhMucVungMienCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucVungMienFilterCls ODanhMucVungMienFilter, int PageIndex, int PageSize)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucVungMienFilter == null)
                    ODanhMucVungMienFilter = new DanhMucVungMienFilterCls();
                var skip = PageIndex * PageSize;
                string Query = " select * from DanhMucVungMien where 1=1";

                if (!string.IsNullOrEmpty(ODanhMucVungMienFilter.Keyword))
                    Query += " and (UPPER(NgayTao) like UPPER(N'%" + ODanhMucVungMienFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucVungMienFilter.Keyword + "%')) ";
                //if (ODanhMucVungMienFilter.HieuLuc != (int)ONEMES3.DM.Model.Common.eSearch.SearchAll)
                //    Query += " and HIEULUC=" + ODanhMucVungMienFilter.HieuLuc;

                Query += " ORDER BY STT " +
                "OFFSET " + skip.ToString() + " ROWS " +
                "FETCH NEXT " + PageSize + " ROWS ONLY";

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                DanhMucVungMienCls[] DanhMucVungMiens = DanhMucVungMienParser.ParseFromDataTable(dsResult.Tables[0]);

                dsResult.Clear();
                dsResult.Dispose();
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return DanhMucVungMiens;
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
        public override DanhMucVungMienCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucVungMienFilterCls ODanhMucVungMienFilter, ref int recordTotal)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucVungMienFilter == null)
                    ODanhMucVungMienFilter = new DanhMucVungMienFilterCls();
                string Query = " select * from DanhMucVungMien where 1 = 1 ";
                string recordTotalQuery = " select count(1) from DanhMucVungMien where 1 = 1 ";

                if (!string.IsNullOrEmpty(ODanhMucVungMienFilter.Keyword))
                {
                    Query += " and (UPPER(NgayTao) like UPPER('%" + ODanhMucVungMienFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucVungMienFilter.Keyword + "%')) ";
                    recordTotalQuery += " and (UPPER(NgayTao) like UPPER('%" + ODanhMucVungMienFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucVungMienFilter.Keyword + "%')) ";
                }

                Query += " and HIEULUC = 1 ";

                Query += "ORDER BY STT " +
                    "OFFSET " + (ODanhMucVungMienFilter.PageIndex * ODanhMucVungMienFilter.PageSize) + " ROWS " +
                    "FETCH NEXT " + ODanhMucVungMienFilter.PageSize + " ROWS ONLY ";

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                DanhMucVungMienCls[] Icds = DanhMucVungMienParser.ParseFromDataTable(dsResult.Tables[0]);
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
        public override long Count(ActionSqlParamCls ActionSqlParam, DanhMucVungMienFilterCls ODanhMucVungMienFilter)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucVungMienFilter == null)
                    ODanhMucVungMienFilter = new DanhMucVungMienFilterCls();
                string Query = " select COUNT (*) from DanhMucVungMien where 1=1 ";

                if (!string.IsNullOrEmpty(ODanhMucVungMienFilter.Keyword))
                    Query += " and (UPPER(MA) like UPPER(N'%" + ODanhMucVungMienFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucVungMienFilter.Keyword + "%')) ";
                //if (ODanhMucVungMienFilter.HieuLuc != (int)ONEMES3.DM.Model.Common.eSearch.SearchAll)
                //    Query += " and HIEULUC=" + ODanhMucVungMienFilter.HieuLuc;

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                long count = DanhMucVungMienParser.CountFromDataTable(dsResult.Tables[0]);

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
        public override DanhMucVungMienCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten)
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
                        DBService.GetDataSet(ActionSqlParam.Trans, "select top 1 * from DanhMucVungMien where (Ten=" + ActionSqlParam.SpecialChar + "Ten)  ", new DbParam[]{
                    new DbParam("Ten",Ten)
                });
                DanhMucVungMienCls ODanhMucVungMien = null;
                if (dsResult.Tables[0].Rows.Count > 0)
                {
                    ODanhMucVungMien = DanhMucVungMienParser.ParseFromDataRow(dsResult.Tables[0].Rows[0]);
                }
                dsResult.Clear();
                dsResult.Dispose();

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return ODanhMucVungMien;
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
