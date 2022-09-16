using OneFRAME.Call.Bussiness.Template;
using OneFRAME.Core.Model;using OneFRAME.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneFRAME.Call.Bussiness.Sql
{
    public class CoreSqlProcess : BussinessProcessTemplate
    {
        public override string Id
        {
            get
            {
                return "CoreSqlProcess";
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
        public override IDanhMucDonViHanhChinhProcess CreateDanhMucDonViHanhChinhProcess()
        {
            return new DanhMucDonViHanhChinhProcessBll();
        }

        public override IDanhMucICDChuongProcess CreateDanhMucICDChuongProcess()
        {
            return new DanhMucICDChuongProcessBll();
        }
        public override IDanhMucQuocGiaProcess CreateDanhMucQuocGiaProcess()
        {
            return new DanhMucQuocGiaProcessBll();
        }
        public override IDanhMucXaPhuongProcess CreateDanhMucXaPhuongProcess()
        {
            return new DanhMucXaPhuongProcessBll();
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
        #endregion

        #region Nghiệp vụ
        #endregion
    }
}
 