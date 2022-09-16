using OneFRAME.Bussiness.Template;
using OneFRAME.Core.Model;
using OneFRAME.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OneFRAME.Bussiness.Sql
{
    public class SqlBussinessProcess : BussinessProcessTemplate
    {
        public override string Id
        {
            get
            {
                return "SqlBussinessProcess";
            }
        }
        public override string ServiceName
        {
            get
            {
                return "MSSQL SERVICE";
            }
        }

        #region Danh mục
        public override IUnitProcess CreateUnitProcess()
        {
            return new UnitProcessBll();
        }
        #endregion
        public override IDanhMucDonViHanhChinhProcess CreateDanhMucDonViHanhChinhProcess()
        {
            return new DanhMucDonViHanhChinhProcessBll();
        }

        public override IDanhMucICDChuongProcess CreateDanhMucICDChuongProcess()
        {
            return new DanhMucICDChuongProcessBll();
        }
        public override IDanhMucXaPhuongProcess CreateDanhMucXaPhuongProcess()
        {
            return new DanhMucXaPhuongProcessBll();
        }
        public override IDanhMucQuocGiaProcess CreateDanhMucQuocGiaProcess()
        {
            return new DanhMucQuocGiaProcessBll();
        }
        public override IDanhMucVungMienProcess CreateDanhMucVungMienProcess()
        {
            return new DanhMucVungMienProcessBll();
        }
        public override IDanhMucTinhThanhProcess CreateDanhMucTinhThanhProcess()
        {
            return new DanhMucTinhThanhProcessBll();
        }
        public override IDanhMucQuanHuyenProcess CreateDanhMucQuanHuyenProcess()
        {
            return new DanhMucQuanHuyenProcessBll();
        }
        #region Nghiệp vụ

        #endregion
    }
}
