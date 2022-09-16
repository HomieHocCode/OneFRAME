using OneFRAME.Core.Model;using OneFRAME.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneFRAME.Bussiness.Template
{
    public interface IBussinessProcess
    {
        string Id { get; }
        string ServiceName { get; }

        #region Danh mục
        IUnitProcess CreateUnitProcess();
        #endregion
        IDanhMucDonViHanhChinhProcess CreateDanhMucDonViHanhChinhProcess();
        IDanhMucICDChuongProcess CreateDanhMucICDChuongProcess();
        IDanhMucQuocGiaProcess CreateDanhMucQuocGiaProcess();
        IDanhMucXaPhuongProcess CreateDanhMucXaPhuongProcess();
        IDanhMucVungMienProcess CreateDanhMucVungMienProcess();
        IDanhMucTinhThanhProcess CreateDanhMucTinhThanhProcess();
        IDanhMucQuanHuyenProcess CreateDanhMucQuanHuyenProcess();

        #region Nghiệp vụ
        #endregion
    }

    public class BussinessProcessTemplate : IBussinessProcess
    {
        public virtual string Id { get { return null; } }
        public virtual string ServiceName { get { return null; } }

        #region Danh mục
        public virtual IUnitProcess CreateUnitProcess() { return null; }
        public virtual IDanhMucDonViHanhChinhProcess CreateDanhMucDonViHanhChinhProcess() { return null; }

        public virtual IDanhMucICDChuongProcess CreateDanhMucICDChuongProcess() { return null; }
        public virtual IDanhMucQuocGiaProcess CreateDanhMucQuocGiaProcess() { return null; }
        public virtual IDanhMucXaPhuongProcess CreateDanhMucXaPhuongProcess() { return null; }
        public virtual IDanhMucVungMienProcess CreateDanhMucVungMienProcess() { return null; }
        public virtual IDanhMucTinhThanhProcess CreateDanhMucTinhThanhProcess() { return null; }
        public virtual IDanhMucQuanHuyenProcess CreateDanhMucQuanHuyenProcess() { return null; }

        #endregion

        #region Nghiệp vụ
        #endregion

    }
}
 