using OneFRAME.Core.Model;
using OneFRAME.Model;
using OneFRAME.Utility;
using OneFRAME.TempService;
using OneFRAME.Bussiness.Template;
using OneFRAME.Call.Bussiness.Utility;
using OneFRAME.UploadUtility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Web;
using Spire.Xls;
using System.Globalization;
using OneFRAME.Core.Call.Bussiness.Utility;

namespace OneFRAME.UploadUtility
{
    public class ProcessImportHandlerUtility
    {
        public enum eFileType
        {
            DM_CHISO = 1,
            DM_DICHVU = 2,
            DM_DONVIHANHCHINH = 3,
            DM_LOAIMAU = 4,
            DM_LOAIXETNGHIEM = 5,
            DM_BENHNHAN = 6,
            DM_ICD = 7,
            DM_NGUOIDUNG = 8,
            DM_VIKHUAN = 9,
            DM_KHANGSINH = 10,
            DM_GIATRIBINHTHUONG = 11,
            DM_DOITUONG = 12,
            DM_KHOAPHONG = 13,
            DM_DICHVULIENKET = 14,
            DM_BENHVIEN = 15,
            DM_NGHENGHIEP = 16,
            DM_CONGTY = 17,
            DM_TINHHINHCHUYENMON = 18,
            FILE_THONGTINLOQC = 19,
            FILE_KETQUAQC = 20,
            DM_NOILUUTRU = 21,
            DM_THIETBI = 22,
            DM_CHISODICHVU = 23,
            DM_NHOMKHANGSINH = 24,
            DM_KYTHUATXETNGHIEM = 25,
            DM_KYTHUATVISINH = 26,
            DM_LOAIMAUVISINH = 27,
            DM_NHOMVIKHUAN = 28,
            DM_CHATLUONGMAU = 29,
            OWNER_USER = 30,
            DM_NHUOMSOI = 31,
            DM_KETQUANHUOMSOI = 32,
            DM_DEKHANG = 33,
            DM_KETQUADEKHANG = 34,
            DM_QUOCGIA=35,
            DM_VUNGMIEN= 36,
            DM_TINHTHANH =37,
            DM_XAPHUONG = 38,
            DM_QUANHUYEN = 39,
        }
        public static void ProcessRequestSessionImportFile(HttpContext context)
        {
            Collection<UploadHandlerResultCls>
              ColUploadHandlerResults = new Collection<UploadHandlerResultCls> { };
            UploadHandlerResultCls OUploadHandlerResult = new UploadHandlerResultCls();
            int Enum = 0;
            string RealFile = "";
            string Ext = "";
            bool IsMulti = false;
            try
            {
                RenderInfoCls ORenderInfo = WebEnvironments.ServerSideCreateRenderInfo();
                //ORenderInfo.SiteId = "online.onenet";
                //ORenderInfo.SiteLanguage = "vi";
                //ORenderInfo.SiteAssetLevelId = "online.onenet";
                //ORenderInfo.AssetLevelCode = "online.onenet";
                //context.Response.ContentType = "text/plain";//"application/json";
                if (context.Request.Files.Count > 1)
                {
                    IsMulti = true;
                }
                for (int iIndexFile = 0; iIndexFile < context.Request.Files.Count; iIndexFile++)
                {
                    HttpPostedFile hpf = context.Request.Files[iIndexFile] as HttpPostedFile;
                    string FileName = string.Empty;
                    if (HttpContext.Current.Request.Browser.Browser.ToUpper() == "IE")
                    {
                        string[] files = hpf.FileName.Split(new char[] { '\\' });
                        FileName = files[files.Length - 1];
                    }
                    else
                    {
                        FileName = hpf.FileName;
                    }
                    if (hpf.ContentLength == 0)
                        continue;

                    RealFile = new System.IO.FileInfo(FileName).Name;
                    Ext = new System.IO.FileInfo(FileName).Extension;
                    string SiteId = context.Request["SiteId"];

                    string SecurityCode = WebConfig.GetSecurityCode();
                    string SessionId = context.Request["SessionId"];
                    string LoginName = context.Request["LoginName"];
                    string UserId = context.Request["UserId"];
                    int filetype = Int32.Parse(context.Request["FileType"]);
                    string WebPathRootTemp = WebConfig.GetWebPathRootTemp();
                    string WebHttpRootTemp = WebConfig.GetWebHttpRootTemp();

                    string MultiUpload = context.Request["MultiUpload"];
      
                    
                    //string message;
                    if (string.IsNullOrEmpty(MultiUpload))
                    {
                        MultiUpload = "0";
                    }
                    //switch (filetype)
                    //{
                    //    case (int)eFileType.DM_DICHVU:
                    //        OUploadHandlerResult.InfoMessage = ImportDM_DICHVU(ORenderInfo, hpf.InputStream);
                    //        break;
                    //    default:
                    //        OUploadHandlerResult.InfoMessage = string.Format("Không hỗ trợ Import!");
                    //        break;
                    //}
                    if (filetype == (int)eFileType.DM_TINHTHANH){
                        OUploadHandlerResult.InfoMessage = ImportDM_TINHTHANH(ORenderInfo, hpf.InputStream);
                            }
                    ColUploadHandlerResults.Add(OUploadHandlerResult);
                }
            }
            catch (Exception ex)
            {
                if (IsMulti == false)
                {
                    OUploadHandlerResult.Error = true;
                    OUploadHandlerResult.InfoMessage = ex.Message.ToString();
                    string XmlInfo = UploadHandlerResultParser.GetXml(OUploadHandlerResult);
                    context.Response.Write(XmlInfo);
                    return;
                }
                else
                {
                    MultiUploadHandlerResultCls
                        OMultiUploadHandlerResult = new MultiUploadHandlerResultCls();
                    OMultiUploadHandlerResult.InfoMessage = ex.Message.ToString();
                    OMultiUploadHandlerResult.Error = true;
                    string XmlInfo = MultiUploadHandlerResultParser.GetXml(OMultiUploadHandlerResult);
                    context.Response.Write(XmlInfo);
                    return;
                }
            }
            if (IsMulti == false)
            {
                string XmlInfo = UploadHandlerResultParser.GetXml(OUploadHandlerResult);
                context.Response.Write(XmlInfo);
            }
            else
            {
                string XmlInfo = UploadHandlerResultParser.GetMultiXml(ColUploadHandlerResults.ToArray());
                MultiUploadHandlerResultCls
                    OMultiUploadHandlerResult = new MultiUploadHandlerResultCls();
                OMultiUploadHandlerResult.XmlData = XmlInfo;
                OMultiUploadHandlerResult.Error = false;

                string XmlData = MultiUploadHandlerResultParser.GetXml(OMultiUploadHandlerResult);
                context.Response.Write(XmlData);
            }
        }
                
        private static string ImportDM_DICHVU(RenderInfoCls ORenderInfo, System.IO.Stream stream)
        {
            Workbook workbook = new Workbook();
            workbook.LoadFromStream(stream);
            Worksheet sheet = workbook.Worksheets[0];

            int j = 0;
            foreach (var item in sheet.Rows)
            {
                if (j > 0)
                {
                    if (string.IsNullOrEmpty(item.Cells[0].Value))
                    {
                        return "Mã không được trống dòng: " + (j + 1).ToString();
                    }
                    if (string.IsNullOrEmpty(item.Cells[1].Value))
                    {
                        return "Tên không được trống dòng: " + (j + 1).ToString();
                    }
                    if (string.IsNullOrEmpty(item.Cells[5].Value))
                    {
                        return "LOAIXETNGHIEM không được trống => dòng: " + (j + 1).ToString();
                    }

                }
                j++;
            }

            //int i = 0;

            //DanhMucLoaiXetNghiemFilterCls loaixetnghiemfilter = new DanhMucLoaiXetNghiemFilterCls();
            //var loaixetnghiems = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiXetNghiemProcess().Reading(ORenderInfo, loaixetnghiemfilter);

            //foreach (var item in sheet.Rows)
            //{
            //    if (i > 0)
            //    {
            //        DanhMucDichVuCls dichvu = new DanhMucDichVuCls();
            //        dichvu.ID = System.Guid.NewGuid().ToString();
            //        dichvu.Ma = item.Cells[0].Value ?? "";
            //        dichvu.Ten = item.Cells[1].Value ?? "";
            //        dichvu.TenTat = item.Cells[2].Value ?? "";
            //        dichvu.MieuTa = item.Cells[3].Value ?? "";
            //        dichvu.STT = int.Parse(item.Cells[4].Value ?? "");
            //        dichvu.HieuLuc = true;
            //        string LoaiXetNghiemId = item.Cells[5].Value;
            //        var loaixetnghiem = loaixetnghiems.Where(o => o.Ma == LoaiXetNghiemId).FirstOrDefault();
            //        if (loaixetnghiem != null)
            //        {
            //            dichvu.LoaiXetNghiemID = loaixetnghiem.ID;
            //        }

            //        CallBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().Add(ORenderInfo, dichvu);


            //    }
            //    i++;
            //}
            return "Đã Import thành công!";
        }
        private static string ImportDM_TINHTHANH(RenderInfoCls ORenderInfo, System.IO.Stream stream)
        {
            Workbook workbook = new Workbook();
            workbook.LoadFromStream(stream);
            Worksheet sheet = workbook.Worksheets[0];

            int j = 0;
            foreach (var item in sheet.Rows)
            {
                if (j > 0)
                {
                    if (string.IsNullOrEmpty(item.Cells[2].Value))
                    {
                        return "Mã không được trống dòng: " + (j + 1).ToString();
                    }
                    if (string.IsNullOrEmpty(item.Cells[3].Value))
                    {
                        return "Tên không được trống dòng: " + (j + 1).ToString();
                    }
                    

                }
                j++;
            }

            int i = 0;
            DanhMucQuocGiaFilterCls quocgiafilter = new DanhMucQuocGiaFilterCls();
            var quocgias = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucQuocGiaProcess().Reading(ORenderInfo, quocgiafilter);

            DanhMucVungMienFilterCls vungmienfilter = new DanhMucVungMienFilterCls();
            var vungmiens = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucVungMienProcess().Reading(ORenderInfo, vungmienfilter);
           
            
            foreach (var item in sheet.Rows)
            {
                if (i > 0)
                {
                    DanhMucTinhThanhCls ck = new DanhMucTinhThanhCls();
                    ck.ID = System.Guid.NewGuid().ToString();
                    ck.Ma = item.Cells[0].Value;
                    ck.Ten = item.Cells[1].Value;

                    string tenquocgia = item.Cells[3].Value;
                    if (!string.IsNullOrEmpty(tenquocgia))
                    {
                        var quocGia = quocgias.FirstOrDefault(o => !string.IsNullOrEmpty(o.Ma) && o.Ma.Trim().ToLower().Contains(tenquocgia.Trim().ToLower())
                        || !string.IsNullOrEmpty(o.Ten) && o.Ten.Trim().ToLower().Contains(tenquocgia.Trim().ToLower()));
                        if (quocGia != null)
                        {
                            ck.QuocGiaID = quocGia.ID;
                        }
                    }

                    string tenvung = item.Cells[4].Value;
                    if (!string.IsNullOrEmpty(tenvung))
                    {
                        var vung = vungmiens.FirstOrDefault(o => !string.IsNullOrEmpty(o.Ma) && o.Ma.Trim().ToLower().Contains(tenvung.Trim().ToLower())
                        || !string.IsNullOrEmpty(o.Ten) && o.Ten.Trim().ToLower().Contains(tenvung.Trim().ToLower()));
                        if (vung != null)
                        {
                            ck.VungID = vung.ID;
                        }
                    }


                    ck.MoTa = item.Cells[5].Value ?? "";
                    //...???
                    ck.HieuLuc = int.Parse(item.Cells[6].Value);
                    if (!string.IsNullOrEmpty(item.Cells[10].Value))
                    {
                        ck.STT = int.Parse(item.Cells[10].Value);
                    }
                    else
                    {
                        ck.STT = 0;
                    }
                    //...???
                    ck.NgayHieuLuc = item.Cells[8].Value2 is DateTime ? (DateTime)item.Cells[8].Value2 : !string.IsNullOrEmpty(item.Cells[8].Value) ? DateTime.ParseExact(item.Cells[8].Value, "dd-MM-yyyy", null) : DateTime.Now;
                    ck.NgayTao = DateTime.Now;
                    //item.Cells[5].Value2 is DateTime ? (DateTime)item.Cells[5].Value2 : !string.IsNullOrEmpty(item.Cells[5].Value) ? DateTime.ParseExact(item.Cells[5].Value, "dd/MM/yyyy", null) : DateTime.Now;
                    //item.Cells[8].Value2 is DateTime ? (DateTime)item.Cells[8].Value2 : !string.IsNullOrEmpty(item.Cells[8].Value) ? DateTime.ParseExact(item.Cells[8].Value, "dd-MM-yyyy", null) : DateTime.Now;
                    ck. MaBCBYT = item.Cells[2].Value ?? "";

                    var checkma = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucTinhThanhProcess().CreateModel(ORenderInfo, item.Cells[0].Value);
                    if (checkma != null)
                    {
                        CallBussinessUtility.CreateBussinessProcess().CreateDanhMucTinhThanhProcess().Save(ORenderInfo, checkma.ID, ck);
                    }
                    else
                    {
                        CallBussinessUtility.CreateBussinessProcess().CreateDanhMucTinhThanhProcess().Add(ORenderInfo, ck);
                    }

                }
                i++;
            }

               
                return "Đã Import thành công!";
        }
        
        
        private static string ImportDM_QUANHUYEN (RenderInfoCls ORenderInfo, System.IO.Stream stream) 
        {
            Workbook workbook = new Workbook();
            workbook.LoadFromStream(stream);
            Worksheet sheet = workbook.Worksheets[0];
                int j = 0;
            foreach (var item in sheet.Rows)
            {
                if( j > 0  )
                {
                    
                    if(string.IsNullOrEmpty(item.Cells[0].Value))
                    {
                        return "Mã không được trống dòng: " + (j + 1).ToString();
                    }
                    if (string.IsNullOrEmpty(item.Cells[1].Value))
                    {
                        return "Tên không được trống dòng: " + (j + 1).ToString();
                    }
                    if (string.IsNullOrEmpty(item.Cells[2].Value))
                    {
                        return "Mã không được trống dòng: " + (j + 1).ToString();
                    }
                    if (string.IsNullOrEmpty(item.Cells[0].Value))
                    {
                        return "Tỉnh Thành không được trống dòng: " + (j + 1).ToString();
                    }
                    if (string.IsNullOrEmpty(item.Cells[5].Value))
                    {
                        return "Hiệu Lực không được trống dòng: " + (j + 1).ToString();
                    }

                }
                j++;
            }

            //int i = 0;
            //DanhMucQuocGiaFilterCls quocgiafilter = new DanhMucQuocGiaFilterCls();
            //var quocgias = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucQuocGiaProcess().Reading(ORenderInfo, quocgiafilter);
            int i = 0;
            DanhMucTinhThanhFilterCls tinhthanhfilter = new DanhMucTinhThanhFilterCls();
            var tinhthanhs = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucTinhThanhProcess().Reading(ORenderInfo, tinhthanhfilter);
            foreach(var item in sheet.Rows)
            {

                if (i > 0)
                {
                    
                    DanhMucQuanHuyenCls ck = new DanhMucQuanHuyenCls();
                    ck.ID = System.Guid.NewGuid().ToString();
                    ck.Ma = item.Cells[0].Value;
                    ck.Ten = item.Cells[1].Value;
                    ck.MaBCBYT = item.Cells[2].Value;
                    ck.TinhThanhID = item.Cells[3].Value;
                    ck.HieuLuc = int.Parse(item.Cells[5].Value);
                    
                    string tentinhthanh = item.Cells[3].Value;
                    if (!string.IsNullOrEmpty(tentinhthanh))
                    {
                        var tinhThanh = tinhthanhs.FirstOrDefault(o => !string.IsNullOrEmpty(o.Ma) && o.Ma.Trim().ToLower().Contains(tentinhthanh.Trim().ToLower())
                        || !string.IsNullOrEmpty(o.Ten) && o.Ten.Trim().ToLower().Contains(tentinhthanh.Trim().ToLower()));
                        if (tinhThanh != null)
                        {
                            ck.TinhThanhID = tinhThanh.ID;
                        }
                    }


                    var checkma = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().CreateModel(ORenderInfo, item.Cells[0].Value);
                    if (checkma != null)
                    {
                        CallBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().Save(ORenderInfo, checkma.ID, ck);
                    }
                    else
                    {
                        CallBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().Add(ORenderInfo, ck);
                    }
                }
                i++;
            }

            return "import thành công !!!";
        }


    }
}
