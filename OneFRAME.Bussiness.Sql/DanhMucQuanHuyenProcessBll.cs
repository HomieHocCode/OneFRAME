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
    public class DanhMucQuanHuyenProcessBll : DanhMucQuanHuyenTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucQuanHuyenProcessBll";
            }
        }

        public override DanhMucQuanHuyenCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter)
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
                if (ODanhMucQuanHuyenFilter == null)
                {
                    ODanhMucQuanHuyenFilter = new DanhMucQuanHuyenFilterCls();
                }
                Collection<DbParam>
                    ColDbParams = new Collection<DbParam>();
                string Query = "";

                Query = " select * from DanhMucQuanHuyen where 1=1 ";
                if (!string.IsNullOrEmpty(ODanhMucQuanHuyenFilter.Keyword))
                {
                    ColDbParams.Add(new DbParam("Keyword", "%" + ODanhMucQuanHuyenFilter.Keyword + "%"));
                    Query += " and DanhMucQuanHuyenName like " + ActionSqlParam.SpecialChar + "Keyword";
                }
                Query += " order by STT";

                DataSet dsResult =
                        DBService.GetDataSet(ActionSqlParam.Trans, Query, ColDbParams.ToArray());
                DanhMucQuanHuyenCls[] DanhMucQuanHuyens = DanhMucQuanHuyenParser.ParseFromDataTable(dsResult.Tables[0]);

                dsResult.Clear();
                dsResult.Dispose();
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return DanhMucQuanHuyens;
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
        public override void Add(ActionSqlParamCls ActionSqlParam, DanhMucQuanHuyenCls ODanhMucQuanHuyen)
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
                if (string.IsNullOrEmpty(ODanhMucQuanHuyen.ID))
                {
                    ODanhMucQuanHuyen.ID = System.Guid.NewGuid().ToString();
                }
                string Query = "select * from DanhMucQuanHuyen where Ma=" + ActionSqlParam.SpecialChar + "Ma ";
                DataTable dtCheck = DBService.GetDataTable(ActionSqlParam.Trans, Query, new DbParam[]
            {
                new DbParam("Ma",ODanhMucQuanHuyen.Ma)
            });

                if (dtCheck.Rows.Count == 0)
                {
                    DBService.Insert(ActionSqlParam.Trans, "DanhMucQuanHuyen",
                        new DbParam[]{
                            new DbParam("ID", ODanhMucQuanHuyen.ID),
                            new DbParam("Ma", ODanhMucQuanHuyen.Ma),
                            new DbParam("Ten", ODanhMucQuanHuyen.Ten),
                            new DbParam("TinhThanhID", ODanhMucQuanHuyen.TinhThanhID),
                           // new DbParam("VungID", ODanhMucQuanHuyen.VungID),
                            new DbParam("MoTa ", ODanhMucQuanHuyen.MoTa),
                            new DbParam("HieuLuc", ODanhMucQuanHuyen.HieuLuc),
                            new DbParam("STT", ODanhMucQuanHuyen.STT),
                            new DbParam("NgayTao", ODanhMucQuanHuyen.NgayTao),
                            new DbParam("TuNgay", ODanhMucQuanHuyen.NgayHieuLuc),
                            new DbParam("GhiChu ", ODanhMucQuanHuyen.GhiChu),
                            new DbParam("DenNgay", ODanhMucQuanHuyen.NgayHetHieuLuc),
                            new DbParam("MaBCBYT", ODanhMucQuanHuyen.MaBCBYT),
                            new DbParam("ChaID", ODanhMucQuanHuyen.ChaID),
                });
                }
                else
                {
                    string ID = (string)dtCheck.Rows[0]["ID"];
                    DBService.Update(ActionSqlParam.Trans, "DanhMucQuanHuyen", "ID", ID,
                        new DbParam[]{
                            new DbParam("ID", ODanhMucQuanHuyen.ID),
                            new DbParam("Ma", ODanhMucQuanHuyen.Ma),
                            new DbParam("Ten", ODanhMucQuanHuyen.Ten),
                            new DbParam("TinhThanhID", ODanhMucQuanHuyen.TinhThanhID),
                           // new DbParam("VungID", ODanhMucQuanHuyen.VungID),
                            new DbParam("MoTa ", ODanhMucQuanHuyen.MoTa),
                            new DbParam("STT", ODanhMucQuanHuyen.STT),
                            new DbParam("HieuLuc", ODanhMucQuanHuyen.HieuLuc),
                            new DbParam("NgayTao", ODanhMucQuanHuyen.NgayTao),
                            new DbParam("GhiChu ", ODanhMucQuanHuyen.GhiChu),
                            new DbParam("TuNgay", ODanhMucQuanHuyen.NgayHieuLuc),
                            new DbParam("DenNgay", ODanhMucQuanHuyen.NgayHetHieuLuc),
                            new DbParam("MaBCBYT", ODanhMucQuanHuyen.MaBCBYT),
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
        public override void Save(ActionSqlParamCls ActionSqlParam, string ID, DanhMucQuanHuyenCls ODanhMucQuanHuyen)
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
                DBService.Update(ActionSqlParam.Trans, "DanhMucQuanHuyen", "ID", ID,
                   new DbParam[]{
                   new DbParam("ID", ODanhMucQuanHuyen.ID),
                            new DbParam("Ma", ODanhMucQuanHuyen.Ma),
                            new DbParam("Ten", ODanhMucQuanHuyen.Ten),
                            new DbParam("TinhThanhID", ODanhMucQuanHuyen.TinhThanhID),
                            //new DbParam("VungID", ODanhMucQuanHuyen.VungID),
                            new DbParam("MoTa ", ODanhMucQuanHuyen.MoTa),
                            new DbParam("STT", ODanhMucQuanHuyen.STT),
                            new DbParam("GhiChu ", ODanhMucQuanHuyen.GhiChu),
                            new DbParam("HieuLuc", ODanhMucQuanHuyen.HieuLuc),
                            new DbParam("NgayTao", ODanhMucQuanHuyen.NgayTao),
                            new DbParam("TuNgay", ODanhMucQuanHuyen.NgayHieuLuc),
                            new DbParam("DenNgay", ODanhMucQuanHuyen.NgayHetHieuLuc),
                            new DbParam("MaBCBYT", ODanhMucQuanHuyen.MaBCBYT),
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
                string DelQuery = " Delete from DanhMucQuanHuyen where Id=" + ActionSqlParam.SpecialChar + "Id";
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
        public override DanhMucQuanHuyenCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id)
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
                        DBService.GetDataSet(ActionSqlParam.Trans, "select top 1 * from DanhMucQuanHuyen where (Id=" + ActionSqlParam.SpecialChar + "Id or Ma=" + ActionSqlParam.SpecialChar + "Id or Ten=" + ActionSqlParam.SpecialChar + "Id)  ", new DbParam[]{
                    new DbParam("Id",Id)
                });
                DanhMucQuanHuyenCls ODanhMucQuanHuyen = null;
                if (dsResult.Tables[0].Rows.Count > 0)
                {
                    ODanhMucQuanHuyen = DanhMucQuanHuyenParser.ParseFromDataRow(dsResult.Tables[0].Rows[0]);
                }
                dsResult.Clear();
                dsResult.Dispose();

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return ODanhMucQuanHuyen;
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
                DanhMucQuanHuyenCls ODanhMucQuanHuyen = CreateModel(ActionSqlParam, Id);
                ODanhMucQuanHuyen.ID = NewId;
                Add(ActionSqlParam, ODanhMucQuanHuyen);

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
        public override DanhMucQuanHuyenCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter, int PageIndex, int PageSize)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucQuanHuyenFilter == null)
                    ODanhMucQuanHuyenFilter = new DanhMucQuanHuyenFilterCls();
                var skip = PageIndex * PageSize;
                string Query = " select * from DanhMucQuanHuyen where 1=1";

                if (!string.IsNullOrEmpty(ODanhMucQuanHuyenFilter.Keyword))
                    Query += " and (UPPER(TENTAT) like UPPER(N'%" + ODanhMucQuanHuyenFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucQuanHuyenFilter.Keyword + "%')) ";
                //if (ODanhMucQuanHuyenFilter.HieuLuc != (int)ONEMES3.DM.Model.Common.eSearch.SearchAll)
                //    Query += " and HIEULUC=" + ODanhMucQuanHuyenFilter.HieuLuc;

                Query += " ORDER BY STT " +
                "OFFSET " + skip.ToString() + " ROWS " +
                "FETCH NEXT " + PageSize + " ROWS ONLY";

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                DanhMucQuanHuyenCls[] DanhMucQuanHuyens = DanhMucQuanHuyenParser.ParseFromDataTable(dsResult.Tables[0]);

                dsResult.Clear();
                dsResult.Dispose();
                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return DanhMucQuanHuyens;
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
        public override DanhMucQuanHuyenCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter, ref int recordTotal)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucQuanHuyenFilter == null)
                    ODanhMucQuanHuyenFilter = new DanhMucQuanHuyenFilterCls();
                string Query = " select * from DanhMucQuanHuyen where 1 = 1 ";
                string recordTotalQuery = " select count(1) from DanhMucQuanHuyen where 1 = 1 ";

                if (!string.IsNullOrEmpty(ODanhMucQuanHuyenFilter.Keyword))
                {
                    Query += " and (UPPER(TENTAT) like UPPER('%" + ODanhMucQuanHuyenFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucQuanHuyenFilter.Keyword + "%')) ";
                    recordTotalQuery += " and (UPPER(TENTAT) like UPPER('%" + ODanhMucQuanHuyenFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucQuanHuyenFilter.Keyword + "%')) ";
                }

                Query += " and HIEULUC = 1 ";

                Query += "ORDER BY STT " +
                    "OFFSET " + (ODanhMucQuanHuyenFilter.PageIndex * ODanhMucQuanHuyenFilter.PageSize) + " ROWS " +
                    "FETCH NEXT " + ODanhMucQuanHuyenFilter.PageSize + " ROWS ONLY ";

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                DanhMucQuanHuyenCls[] Icds = DanhMucQuanHuyenParser.ParseFromDataTable(dsResult.Tables[0]);
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
        public override long Count(ActionSqlParamCls ActionSqlParam, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter)
        {
            IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);
            bool HasTrans = ActionSqlParam.Trans != null;
            bool HasCommit = false;
            if (!HasTrans)
                ActionSqlParam.Trans = DBService.BeginTransaction();
            try
            {
                if (ODanhMucQuanHuyenFilter == null)
                    ODanhMucQuanHuyenFilter = new DanhMucQuanHuyenFilterCls();
                string Query = " select COUNT (*) from DanhMucQuanHuyen where 1=1 ";

                if (!string.IsNullOrEmpty(ODanhMucQuanHuyenFilter.Keyword))
                    Query += " and (UPPER(MA) like UPPER(N'%" + ODanhMucQuanHuyenFilter.Keyword + "%') OR UPPER(TEN) like UPPER(N'%" + ODanhMucQuanHuyenFilter.Keyword + "%')) ";
                //if (ODanhMucQuanHuyenFilter.HieuLuc != (int)ONEMES3.DM.Model.Common.eSearch.SearchAll)
                //    Query += " and HIEULUC=" + ODanhMucQuanHuyenFilter.HieuLuc;

                DataSet dsResult = DBService.GetDataSet(ActionSqlParam.Trans, Query);
                long count = DanhMucQuanHuyenParser.CountFromDataTable(dsResult.Tables[0]);

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
        public override DanhMucQuanHuyenCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten)
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
                        DBService.GetDataSet(ActionSqlParam.Trans, "select top 1 * from DanhMucQuanHuyen where (Ten=" + ActionSqlParam.SpecialChar + "Ten)  ", new DbParam[]{
                    new DbParam("Ten",Ten)
                });
                DanhMucQuanHuyenCls ODanhMucQuanHuyen = null;
                if (dsResult.Tables[0].Rows.Count > 0)
                {
                    ODanhMucQuanHuyen = DanhMucQuanHuyenParser.ParseFromDataRow(dsResult.Tables[0].Rows[0]);
                }
                dsResult.Clear();
                dsResult.Dispose();

                if (!HasTrans && !HasCommit)
                {
                    ActionSqlParam.Trans.Commit();
                    ActionSqlParam.Trans = null;
                    HasCommit = true;
                }
                return ODanhMucQuanHuyen;
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
