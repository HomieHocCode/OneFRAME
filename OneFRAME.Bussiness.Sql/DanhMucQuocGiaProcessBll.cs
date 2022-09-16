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
    public class DanhMucQuocGiaProcessBll : DanhMucQuocGiaTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucQuocGiaProcessBll";
            }
        }

        public override DanhMucQuocGiaCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter)
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
                if (ODanhMucQuocGiaFilter == null)
                {
                    ODanhMucQuocGiaFilter = new DanhMucQuocGiaFilterCls();
                }
                Collection<DbParam>
                    ColDbParams = new Collection<DbParam>();
                string Query = "";

                Query = " select * from DanhMucQuocGia where 1=1 ";
                if (!string.IsNullOrEmpty(ODanhMucQuocGiaFilter.Keyword))
                {
                    ColDbParams.Add(new DbParam("Keyword", "%" + ODanhMucQuocGiaFilter.Keyword + "%"));
                    Query += " and DanhMucQuocGiaName like " + ActionSqlParam.SpecialChar + "Keyword";
                }
                Query += " order by STT";

                DataSet dsResult =
                        DBService.GetDataSet(ActionSqlParam.Trans, Query, ColDbParams.ToArray());
                DanhMucQuocGiaCls[] DanhMucQuocGias = DanhMucQuocGiaParser.ParseFromDataTable(dsResult.Tables[0]);

                dsResult.Clear();
                dsResult.Dispose();
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return DanhMucQuocGias;
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
        public override void Add(ActionSqlParamCls ActionSqlParam, DanhMucQuocGiaCls ODanhMucQuocGia)
        {
            //IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            //bool HasTrans = ActionSqlParam.Trans != null;
            //bool HasCommit = false;

            //if (!HasTrans)
            //{
            //    ActionSqlParam.Trans = DBService.BeginTransaction();
            //}

            //try
            //{
            //    if (string.IsNullOrEmpty(ODanhMucQuocGia.ID))
            //    {
            //        ODanhMucQuocGia.ID = System.Guid.NewGuid().ToString();
            //    }
            //    string Query = "select * from DanhMucQuocGia where Ma=" + ActionSqlParam.SpecialChar + "Ma ";
            //    DataTable dtCheck = DBService.GetDataTable(ActionSqlParam.Trans, Query, new DbParam[]
            //{
            //    new DbParam("Ma",ODanhMucQuocGia.Ma)
            //});

            //    if (dtCheck.Rows.Count == 0)
            //    {
            //        DBService.Insert(ActionSqlParam.Trans, "DanhMucQuocGia",
            //            new DbParam[]{
            //        new DbParam("ID",ODanhMucQuocGia.ID),
            //        new DbParam("MA",ODanhMucQuocGia.Ma),
            //        new DbParam("TEN",ODanhMucQuocGia.Ten),
            //        new DbParam("MOTA",ODanhMucQuocGia.MoTa),
            //        new DbParam("HIEULUC",ODanhMucQuocGia.HieuLuc),
            //        new DbParam("STT",ODanhMucQuocGia.STT),
            //        new DbParam("NGAYTAO",ODanhMucQuocGia.NgayTao),
            //        new DbParam("GHICHU",ODanhMucQuocGia.GhiChu),
            //        new DbParam("TUNGAY ",ODanhMucQuocGia.NgayHieuLuc),
            //        new DbParam("DENNGAY",ODanhMucQuocGia.NgayHetHieuLuc),
            //        new DbParam("CHAID",ODanhMucQuocGia.ChaID),
            //        new DbParam("BANBE",ODanhMucQuocGia.BanBe),
            //    });
            //    }
            //    else
            //    {
            //        string ID = (string)dtCheck.Rows[0]["ID"];
            //        DBService.Update(ActionSqlParam.Trans, "DanhMucQuocGia", "ID", ID,
            //            new DbParam[]{
            //        new DbParam("MA",ODanhMucQuocGia.Ma),
            //        new DbParam("TEN",ODanhMucQuocGia.Ten),
            //        new DbParam("MOTA",ODanhMucQuocGia.MoTa),
            //        new DbParam("HIEULUC",ODanhMucQuocGia.HieuLuc),
            //        new DbParam("STT",ODanhMucQuocGia.STT),
            //        new DbParam("NGAYTAO",ODanhMucQuocGia.NgayTao),
            //        new DbParam("GHICHU",ODanhMucQuocGia.GhiChu),
            //        new DbParam("TUNGAY",ODanhMucQuocGia.NgayHieuLuc),
            //        new DbParam("DENNGAY",ODanhMucQuocGia.NgayHetHieuLuc),
            //        new DbParam("CHAID" ,ODanhMucQuocGia.ChaID),
            //        new DbParam("BANBE",ODanhMucQuocGia.BanBe),
            //    });
            //    }
            //    if (!HasTrans && !HasCommit)
            //    {
            //        ActionSqlParam.Trans.Commit();
            //        ActionSqlParam.Trans = null;
            //        HasCommit = true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    if (!HasTrans && !HasCommit)
            //    {
            //        ActionSqlParam.Trans.Rollback();
            //        ActionSqlParam.Trans = null;
            //    }
            //    throw (ex);
            //}
          
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try

            {
                if (string.IsNullOrEmpty(ODanhMucQuocGia.ID))
                    ODanhMucQuocGia.ID = System.Guid.NewGuid().ToString();

                DBService.Insert(ActionSqlParam.Trans, "DanhMucQuocGia",
                        new DbParam[]{
                    new DbParam("ID",ODanhMucQuocGia.ID),
                    new DbParam("MA",ODanhMucQuocGia.Ma),
                    new DbParam("TEN",ODanhMucQuocGia.Ten),
                    new DbParam("MOTA",ODanhMucQuocGia.MoTa),
                    new DbParam("HIEULUC",ODanhMucQuocGia.HieuLuc),
                    new DbParam("STT",ODanhMucQuocGia.STT),
                    new DbParam("NGAYTAO",ODanhMucQuocGia.NgayTao),
                    new DbParam("GHICHU",ODanhMucQuocGia.GhiChu),
                    new DbParam("TUNGAY ",ODanhMucQuocGia.NgayHieuLuc),
                    new DbParam("DENNGAY",ODanhMucQuocGia.NgayHetHieuLuc),
                    new DbParam("CHAID",ODanhMucQuocGia.ChaID),
                    new DbParam("BANBE",ODanhMucQuocGia.BanBe),
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
        public override void Save(ActionSqlParamCls ActionSqlParam, string ID, DanhMucQuocGiaCls ODanhMucQuocGia)
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
                DBService.Update(ActionSqlParam.Trans, "DanhMucQuocGia", "ID", ID,
                   new DbParam[]{
                   new DbParam("MA",ODanhMucQuocGia.Ma),
                   new DbParam("TEN",ODanhMucQuocGia.Ten),
                   new DbParam("MOTA",ODanhMucQuocGia.MoTa),
                   new DbParam("HIEULUC",ODanhMucQuocGia.HieuLuc),
                   new DbParam("STT",ODanhMucQuocGia.STT),
                   new DbParam("NGAYTAO",ODanhMucQuocGia.NgayTao),
                   new DbParam("GHICHU",ODanhMucQuocGia.GhiChu),
                   new DbParam("TUNGAY",ODanhMucQuocGia.NgayHieuLuc),
                   new DbParam("DENNGAY",ODanhMucQuocGia.NgayHetHieuLuc),
                   new DbParam("CHAID",ODanhMucQuocGia.ChaID),
                   new DbParam("BANBE",ODanhMucQuocGia.BanBe),
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
                string DelQuery = " Delete from DanhMucQuocGia where Id=" + ActionSqlParam.SpecialChar + "Id";
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
        public override DanhMucQuocGiaCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id)
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
                        DBService.GetDataSet(ActionSqlParam.Trans, "select top 1 * from DanhMucQuocGia where (Id=" + ActionSqlParam.SpecialChar + "Id or Ma=" + ActionSqlParam.SpecialChar + "Id or Ten=" + ActionSqlParam.SpecialChar + "Id)  ", new DbParam[]{
                    new DbParam("Id",Id)
                });
                DanhMucQuocGiaCls ODanhMucQuocGia = null;
                if (dsResult.Tables[0].Rows.Count > 0)
                {
                    ODanhMucQuocGia = DanhMucQuocGiaParser.ParseFromDataRow(dsResult.Tables[0].Rows[0]);
                }
                dsResult.Clear();
                dsResult.Dispose();

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return ODanhMucQuocGia;
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
                DanhMucQuocGiaCls ODanhMucQuocGia = CreateModel(ActionSqlParam, Id);
                ODanhMucQuocGia.ID = NewId;
                Add(ActionSqlParam, ODanhMucQuocGia);

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
        public override DanhMucQuocGiaCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter, int PageIndex, int PageSize)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucQuocGiaFilter == null)
                    ODanhMucQuocGiaFilter = new DanhMucQuocGiaFilterCls();
                var skip = PageIndex * PageSize;
                string Query = " select * from DanhMucQuocGia where 1=1";

                if (!string.IsNullOrEmpty(ODanhMucQuocGiaFilter.Keyword))
                    Query += " and (UPPER(NgayTao) like UPPER(N'%" + ODanhMucQuocGiaFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucQuocGiaFilter.Keyword + "%')) ";
                //if (ODanhMucQuocGiaFilter.HieuLuc != (int)ONEMES3.DM.Model.Common.eSearch.SearchAll)
                //    Query += " and HIEULUC=" + ODanhMucQuocGiaFilter.HieuLuc;

                Query += " ORDER BY STT " +
                "OFFSET " + skip.ToString() + " ROWS " +
                "FETCH NEXT " + PageSize + " ROWS ONLY";

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                DanhMucQuocGiaCls[] DanhMucQuocGias = DanhMucQuocGiaParser.ParseFromDataTable(dsResult.Tables[0]);

                dsResult.Clear();
                dsResult.Dispose();
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return DanhMucQuocGias;
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
        public override DanhMucQuocGiaCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter, ref int recordTotal)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucQuocGiaFilter == null)
                    ODanhMucQuocGiaFilter = new DanhMucQuocGiaFilterCls();
                string Query = " select * from DanhMucQuocGia where 1 = 1 ";
                string recordTotalQuery = " select count(1) from DanhMucQuocGia where 1 = 1 ";

                if (!string.IsNullOrEmpty(ODanhMucQuocGiaFilter.Keyword))
                {
                    Query += " and (UPPER(NgayTao) like UPPER('%" + ODanhMucQuocGiaFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucQuocGiaFilter.Keyword + "%')) ";
                    recordTotalQuery += " and (UPPER(NgayTao) like UPPER('%" + ODanhMucQuocGiaFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucQuocGiaFilter.Keyword + "%')) ";
                }

                Query += " and HIEULUC = 1 ";

                Query += "ORDER BY STT " +
                    "OFFSET " + (ODanhMucQuocGiaFilter.PageIndex * ODanhMucQuocGiaFilter.PageSize) + " ROWS " +
                    "FETCH NEXT " + ODanhMucQuocGiaFilter.PageSize + " ROWS ONLY ";

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                DanhMucQuocGiaCls[] Icds = DanhMucQuocGiaParser.ParseFromDataTable(dsResult.Tables[0]);
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
        public override long Count(ActionSqlParamCls ActionSqlParam, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucQuocGiaFilter == null)
                    ODanhMucQuocGiaFilter = new DanhMucQuocGiaFilterCls();
                string Query = " select COUNT (*) from DanhMucQuocGia where 1=1 ";

                if (!string.IsNullOrEmpty(ODanhMucQuocGiaFilter.Keyword))
                    Query += " and (UPPER(MA) like UPPER(N'%" + ODanhMucQuocGiaFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucQuocGiaFilter.Keyword + "%')) ";
                //if (ODanhMucQuocGiaFilter.HieuLuc != (int)ONEMES3.DM.Model.Common.eSearch.SearchAll)
                //    Query += " and HIEULUC=" + ODanhMucQuocGiaFilter.HieuLuc;

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                long count = DanhMucQuocGiaParser.CountFromDataTable(dsResult.Tables[0]);

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
        public override DanhMucQuocGiaCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten)
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
                        DBService.GetDataSet(ActionSqlParam.Trans, "select top 1 * from DanhMucQuocGia where (Ten=" + ActionSqlParam.SpecialChar + "Ten)  ", new DbParam[]{
                    new DbParam("Ten",Ten)
                });
                DanhMucQuocGiaCls ODanhMucQuocGia = null;
                if (dsResult.Tables[0].Rows.Count > 0)
                {
                    ODanhMucQuocGia = DanhMucQuocGiaParser.ParseFromDataRow(dsResult.Tables[0].Rows[0]);
                }
                dsResult.Clear();
                dsResult.Dispose();

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return ODanhMucQuocGia;
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
