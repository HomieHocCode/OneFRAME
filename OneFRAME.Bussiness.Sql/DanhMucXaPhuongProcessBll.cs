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
    public class DanhMucXaPhuongProcessBll : DanhMucXaPhuongTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucXaPhuongProcessBll";
            }
        }

        public override DanhMucXaPhuongCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter)
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
                if (ODanhMucXaPhuongFilter == null)
                {
                    ODanhMucXaPhuongFilter = new DanhMucXaPhuongFilterCls();
                }
                Collection<DbParam>
                    ColDbParams = new Collection<DbParam>();
                string Query = "";

                Query = " select * from DanhMucXaPhuong where 1=1 ";
                if (!string.IsNullOrEmpty(ODanhMucXaPhuongFilter.Keyword))
                {
                    ColDbParams.Add(new DbParam("Keyword", "%" + ODanhMucXaPhuongFilter.Keyword + "%"));
                    Query += " and DanhMucXaPhuongName like " + ActionSqlParam.SpecialChar + "Keyword";
                }
                Query += " order by STT";

                DataSet dsResult =
                        DBService.GetDataSet(ActionSqlParam.Trans, Query, ColDbParams.ToArray());
                DanhMucXaPhuongCls[] DanhMucXaPhuongs = DanhMucXaPhuongParser.ParseFromDataTable(dsResult.Tables[0]);

                dsResult.Clear();
                dsResult.Dispose();
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return DanhMucXaPhuongs;
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
        public override void Add(ActionSqlParamCls ActionSqlParam, DanhMucXaPhuongCls ODanhMucXaPhuong)
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
                if (string.IsNullOrEmpty(ODanhMucXaPhuong.ID))
                {
                    ODanhMucXaPhuong.ID = System.Guid.NewGuid().ToString();
                }
                string Query = "select * from DanhMucXaPhuong where Ma=" + ActionSqlParam.SpecialChar + "Ma ";
                DataTable dtCheck = DBService.GetDataTable(ActionSqlParam.Trans, Query, new DbParam[]
            {
                new DbParam("Ma",ODanhMucXaPhuong.Ma)
            });

                if (dtCheck.Rows.Count == 0)
                {
                    DBService.Insert(ActionSqlParam.Trans, "DanhMucXaPhuong",
                        new DbParam[]{
                    new DbParam("ID",ODanhMucXaPhuong.ID),
                    new DbParam("MA",ODanhMucXaPhuong.Ma),
                    new DbParam("TEN",ODanhMucXaPhuong.Ten),
                    new DbParam("QUANHUYENID",ODanhMucXaPhuong.QuanHuyenID ),
                    new DbParam("MABCBYT",ODanhMucXaPhuong.MaBCBYT),
                    new DbParam("MOTA",ODanhMucXaPhuong.MoTa),
                    new DbParam("HIEULUC",ODanhMucXaPhuong.HieuLuc),
                    new DbParam("STT",ODanhMucXaPhuong.STT),
                    new DbParam("NGAYTAO",ODanhMucXaPhuong.NgayTao),
                    new DbParam("GHICHU",ODanhMucXaPhuong.GhiChu),
                    new DbParam("TUNGAY",ODanhMucXaPhuong.NgayHieuLuc),
                    new DbParam("DENNGAY ",ODanhMucXaPhuong.NgayHetHieuLuc),
                   
                });
                }
                else
                {
                    string ID = (string)dtCheck.Rows[0]["ID"];
                    DBService.Update(ActionSqlParam.Trans, "DanhMucXaPhuong", "ID", ID,
                        new DbParam[]{
                    new DbParam("MA",ODanhMucXaPhuong.Ma),
                    new DbParam("TEN",ODanhMucXaPhuong.Ten),
                    new DbParam("QUANHUYENID",ODanhMucXaPhuong.QuanHuyenID),
                    new DbParam("MOTA",ODanhMucXaPhuong.MoTa),
                    new DbParam("HIEULUC",ODanhMucXaPhuong.HieuLuc),
                    new DbParam("STT",ODanhMucXaPhuong.STT),
                    new DbParam("NGAYTAO",ODanhMucXaPhuong.NgayTao),
                    new DbParam("GHICHU",ODanhMucXaPhuong.GhiChu),
                    new DbParam("TUNGAY",ODanhMucXaPhuong.NgayHieuLuc),
                    new DbParam("DENNGAY",ODanhMucXaPhuong.NgayHetHieuLuc),
                    new DbParam("CHAID",ODanhMucXaPhuong.ChaID),
                    new DbParam("MABCBYT",ODanhMucXaPhuong.MaBCBYT),
                    
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
        public override void Save(ActionSqlParamCls ActionSqlParam, string ID, DanhMucXaPhuongCls ODanhMucXaPhuong)
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
                DBService.Update(ActionSqlParam.Trans, "DanhMucXaPhuong", "ID", ID,
                   new DbParam[]{
                   new DbParam("MA",ODanhMucXaPhuong.Ma),
                   new DbParam("TEN",ODanhMucXaPhuong.Ten),
                   new DbParam("QUANHUYENID",ODanhMucXaPhuong.QuanHuyenID),
                   new DbParam("MOTA",ODanhMucXaPhuong.MoTa),
                   new DbParam("HIEULUC",ODanhMucXaPhuong.HieuLuc),
                   new DbParam("STT",ODanhMucXaPhuong.STT),
                   new DbParam("NGAYTAO",ODanhMucXaPhuong.NgayTao),
                   new DbParam("GHICHU",ODanhMucXaPhuong.GhiChu),
                   new DbParam("TUNGAY",ODanhMucXaPhuong.NgayHieuLuc),
                   new DbParam("DENNGAY",ODanhMucXaPhuong.NgayHetHieuLuc),
                   new DbParam("CHAID",ODanhMucXaPhuong.ChaID),
                   new DbParam("MABCBYT",ODanhMucXaPhuong.MaBCBYT),
                  
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
                string DelQuery = " Delete from DanhMucXaPhuong where Id=" + ActionSqlParam.SpecialChar + "Id";
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
        public override DanhMucXaPhuongCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id)
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
                        DBService.GetDataSet(ActionSqlParam.Trans, "select top 1 * from DanhMucXaPhuong where (Id=" + ActionSqlParam.SpecialChar + "Id or Ma=" + ActionSqlParam.SpecialChar + "Id or Ten=" + ActionSqlParam.SpecialChar + "Id)  ", new DbParam[]{
                    new DbParam("Id",Id)
                });
                DanhMucXaPhuongCls ODanhMucXaPhuong = null;
                if (dsResult.Tables[0].Rows.Count > 0)
                {
                    ODanhMucXaPhuong = DanhMucXaPhuongParser.ParseFromDataRow(dsResult.Tables[0].Rows[0]);
                }
                dsResult.Clear();
                dsResult.Dispose();

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return ODanhMucXaPhuong;
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
                DanhMucXaPhuongCls ODanhMucXaPhuong = CreateModel(ActionSqlParam, Id);
                ODanhMucXaPhuong.ID = NewId;
                Add(ActionSqlParam, ODanhMucXaPhuong);

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
        public override DanhMucXaPhuongCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter, int PageIndex, int PageSize)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucXaPhuongFilter == null)
                    ODanhMucXaPhuongFilter = new DanhMucXaPhuongFilterCls();
                var skip = PageIndex * PageSize;
                string Query = " select * from DanhMucXaPhuong where 1=1";

                if (!string.IsNullOrEmpty(ODanhMucXaPhuongFilter.Keyword))
                    Query += " and (UPPER(MaBCBYT) like UPPER(N'%" + ODanhMucXaPhuongFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucXaPhuongFilter.Keyword + "%')) ";
                //if (ODanhMucXaPhuongFilter.HieuLuc != (int)ONEMES3.DM.Model.Common.eSearch.SearchAll)
                //    Query += " and HIEULUC=" + ODanhMucXaPhuongFilter.HieuLuc;

                Query += " ORDER BY STT " +
                "OFFSET " + skip.ToString() + " ROWS " +
                "FETCH NEXT " + PageSize + " ROWS ONLY";

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                DanhMucXaPhuongCls[] DanhMucXaPhuongs = DanhMucXaPhuongParser.ParseFromDataTable(dsResult.Tables[0]);

                dsResult.Clear();
                dsResult.Dispose();
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return DanhMucXaPhuongs;
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
        public override DanhMucXaPhuongCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter, ref long  recordTotal) //---
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucXaPhuongFilter == null)
                    ODanhMucXaPhuongFilter = new DanhMucXaPhuongFilterCls();
                string Query = " select * from DanhMucXaPhuong where 1 = 1 ";
                string recordTotalQuery = " select count(1) from DanhMucXaPhuong where 1 = 1 ";

                if (!string.IsNullOrEmpty(ODanhMucXaPhuongFilter.Keyword))
                {
                    Query += " and (UPPER(MaBCBYT) like UPPER('%" + ODanhMucXaPhuongFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucXaPhuongFilter.Keyword + "%')) ";
                    recordTotalQuery += " and (UPPER(MaBCBYT) like UPPER('%" + ODanhMucXaPhuongFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucXaPhuongFilter.Keyword + "%')) ";
                }

                Query += " and HIEULUC = 1 ";

                Query += "ORDER BY STT " +
                    "OFFSET " + (ODanhMucXaPhuongFilter.PageIndex * ODanhMucXaPhuongFilter.PageSize) + " ROWS " +
                    "FETCH NEXT " + ODanhMucXaPhuongFilter.PageSize + " ROWS ONLY ";

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                DanhMucXaPhuongCls[] Icds = DanhMucXaPhuongParser.ParseFromDataTable(dsResult.Tables[0]);
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
        public override long Count(ActionSqlParamCls ActionSqlParam, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucXaPhuongFilter == null)
                    ODanhMucXaPhuongFilter = new DanhMucXaPhuongFilterCls();
                string Query = " select COUNT (*) from DanhMucXaPhuong where 1=1 ";

                if (!string.IsNullOrEmpty(ODanhMucXaPhuongFilter.Keyword))
                    Query += " and (UPPER(MA) like UPPER(N'%" + ODanhMucXaPhuongFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucXaPhuongFilter.Keyword + "%')) ";
                //if (ODanhMucXaPhuongFilter.HieuLuc != (int)ONEMES3.DM.Model.Common.eSearch.SearchAll)
                //    Query += " and HIEULUC=" + ODanhMucXaPhuongFilter.HieuLuc;

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                long count = DanhMucXaPhuongParser.CountFromDataTable(dsResult.Tables[0]);

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
        public override DanhMucXaPhuongCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten)
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
                        DBService.GetDataSet(ActionSqlParam.Trans, "select top 1 * from DanhMucXaPhuong where (Ten=" + ActionSqlParam.SpecialChar + "Ten)  ", new DbParam[]{
                    new DbParam("Ten",Ten)
                });
                DanhMucXaPhuongCls ODanhMucXaPhuong = null;
                if (dsResult.Tables[0].Rows.Count > 0)
                {
                    ODanhMucXaPhuong = DanhMucXaPhuongParser.ParseFromDataRow(dsResult.Tables[0].Rows[0]);
                }
                dsResult.Clear();
                dsResult.Dispose();

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return ODanhMucXaPhuong;
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
