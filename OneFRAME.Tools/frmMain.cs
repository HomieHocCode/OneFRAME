using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneFRAME.Tools
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            ProcessHtmlCode();
        }

        void ProcessHtmlCode()
        {
            string Html = txtCode.Text;

            string[] ItemsHtml = Html.Split(new string[] {"\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            for(int iIndex=0;iIndex<ItemsHtml.Length;iIndex++)
            {
                ItemsHtml[iIndex]=ItemsHtml[iIndex].Replace ("\"","\\\"");
            }

            Html = "Html=\r\n";
            for (int iIndex = 0; iIndex < ItemsHtml.Length; iIndex++)
            {
                if (iIndex < ItemsHtml.Length - 1)
                {
                    Html = Html + "\"" + ItemsHtml[iIndex] + "\\r\\n\"+\r\n";
                }
                else
                {
                    Html = Html + "\"" + ItemsHtml[iIndex] + "\\r\\n\";\r\n";
                }
            }
            textBoxDestCode.Text = Html;
        }

        private void cmdGen_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTableName.Text)) throw new Exception("Missing table name");
                if (string.IsNullOrEmpty(txtKey.Text)) throw new Exception("Missing Key field");
                if (string.IsNullOrEmpty(txtFields.Text)) throw new Exception("Missing fields");
                if (string.IsNullOrEmpty(txtFieldTypes.Text)) throw new Exception("Missing field type");
                string[] Fields = txtFields.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                string[] FieldTypes = txtFieldTypes.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (Fields.Length != FieldTypes.Length) throw new Exception("Field types not equals fields");

                GenModel(txtClass.Text, txtTableName.Text,txtKey.Text, Fields, FieldTypes);
                GenModelFilter(txtClass.Text, txtTableName.Text, txtKey.Text, Fields, FieldTypes);
                GenBussinessTemplate(txtClass.Text, txtTableName.Text, txtKey.Text, Fields, FieldTypes);
                GenBussinessSql(txtClass.Text, txtTableName.Text, txtKey.Text, Fields, FieldTypes);
                GenCallBussinessTemplate(txtClass.Text, txtTableName.Text, txtKey.Text, Fields, FieldTypes);
                GenCallSqlBussinessTemplate(txtClass.Text, txtTableName.Text, txtKey.Text, Fields, FieldTypes);
                GenCallWsBussinessTemplate(txtClass.Text, txtTableName.Text, txtKey.Text, Fields, FieldTypes);

                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        void GenModel(string ClassName, string TabName, string KeyName, string[] Fields, string[] FieldTypes)
        {
            string SavePath = Application.StartupPath + "\\" + TabName;

            string Html =
                "using System;\r\n" +
                "using System.Collections.Generic;\r\n" +
                "using System.Linq;\r\n" +
                "using System.Text;\r\n" +
                "using System.Data;\r\n" +
                "using OneFRAME.Model;\r\n"+
                "\r\n" +
                "namespace OneFRAME.Model\r\n" +
                "{ \r\n" +
                "    public class " + ClassName + "Cls \r\n" +
                "    { \r\n" +
                "        public string " + KeyName + "; \r\n";
            for (int iIndex = 0; iIndex < Fields.Length; iIndex++)
            {
                if (FieldTypes[iIndex].ToLower().Equals("string"))
                {
                    Html +=
                    "        public " + FieldTypes[iIndex] + " " + Fields[iIndex] + " = \"\"; \r\n";
                }
                else
                {
                    Html +=
                    "        public " + FieldTypes[iIndex] + " " + Fields[iIndex] + ";\r\n";
                }
            }
            Html +=
            "    }\r\n" +
            "}\r\n";



            Html += "\r\n" +
            "public class " + ClassName + "Parser \r\n" +
            "{ \r\n" +
            "    public static " + ClassName + "Cls CreateInstance() \r\n" +
            "    { \r\n" +
            "        " + ClassName + "Cls O" + ClassName + " = new " + ClassName + "Cls(); \r\n" +
            "        return O" + ClassName + "; \r\n" +
            "    } \r\n" +
            "\r\n" +
            "\r\n" +
            "    public static " + ClassName + "Cls ParseFromDataRow(DataRow dr) \r\n" +
            "    { \r\n" +
            "        " + ClassName + "Cls O" + ClassName + " = new " + ClassName + "Cls(); \r\n" +
            "        O" + ClassName + "." + KeyName + " = CoreXmlUtility.GetString(dr, \"" + KeyName + "\", true);\r\n";
            for (int iIndex = 0; iIndex < Fields.Length; iIndex++)
            {
                if (FieldTypes[iIndex].ToLower().Equals("string"))
                {
                    Html +=
                    "        O" + ClassName + "." + Fields[iIndex] + " = CoreXmlUtility.GetString(dr, \"" + Fields[iIndex] + "\", true);\r\n";
                }
                if (FieldTypes[iIndex].ToLower().Equals("int"))
                {
                    Html +=
                        "        O" + ClassName + "." + Fields[iIndex] + " = CoreXmlUtility.GetInt(dr, \"" + Fields[iIndex] + "\", true);\r\n";
                }
                if (FieldTypes[iIndex].ToLower().Equals("long"))
                {
                    Html +=
                        "        O" + ClassName + "." + Fields[iIndex] + " = CoreXmlUtility.GetLong(dr, \"" + Fields[iIndex] + "\", true);\r\n";
                }
                if (FieldTypes[iIndex].ToLower().Equals("decimal"))
                {
                    Html +=
                       "        O" + ClassName + "." + Fields[iIndex] + " = CoreXmlUtility.GetDecimal(dr, \"" + Fields[iIndex] + "\", true);\r\n";
                }
                if (FieldTypes[iIndex].ToLower().Equals("datetime"))
                {
                    Html +=
                      "        O" + ClassName + "." + Fields[iIndex] + " = CoreXmlUtility.GetDate(dr, \"" + Fields[iIndex] + "\", true);\r\n";
                }
            }
            Html +=
            "        return O" + ClassName + ";\r\n" +
            "    }\r\n" +
            "\r\n" +
            "    public static " + ClassName + "Cls[] ParseFromDataTable(DataTable dtTable) \r\n" +
            "    {\r\n" +
            "        " + ClassName + "Cls[] " + ClassName + "s = new " + ClassName + "Cls[dtTable.Rows.Count];\r\n" +
            "        for (int iIndex = 0; iIndex < dtTable.Rows.Count; iIndex++)\r\n" +
            "        {\r\n" +
            "            " + ClassName + "s[iIndex] = ParseFromDataRow(dtTable.Rows[iIndex]);\r\n" +
            "        }\r\n" +
            "        return " + ClassName + "s;\r\n" +
            "    }\r\n" +
            "\r\n" +
            "\r\n" +
            "    public static " + ClassName + "Cls[] ParseFromMultiXml(string XmlData, string XmlDataSchema)\r\n" +
            "    {\r\n" +
            "        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);\r\n" +
            "        " + ClassName + "Cls[] " + ClassName + "s = ParseFromDataTable(ds.Tables[0]);\r\n" +
            "        return " + ClassName + "s;\r\n" +
            "    }\r\n" +
            "\r\n" +

            "\r\n" +
            "    public static " + ClassName + "Cls ParseFromXml(string XmlData, string XmlDataSchema)\r\n" +
            "    {\r\n" +
            "        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);\r\n" +
            "        if(ds.Tables[0].Rows.Count==0)return null;\r\n"+
            "        " + ClassName + "Cls O" + ClassName + " = ParseFromDataRow(ds.Tables[0].Rows[0]);\r\n" +
            "        return O" + ClassName + ";\r\n" +
            "    }\r\n" +
            "\r\n" +

            "\r\n" +
            "    public static XmlCls GetXml(" + ClassName + "Cls[] " + ClassName + "s)\r\n" +
            "    {\r\n" +
            "        DataSet ds = new DataSet();\r\n" +
            "        ds.Tables.Add(\"info\");\r\n" +
            "        ds.Tables[\"info\"].Columns.Add(\"" + KeyName + "\");\r\n";
            for (int iIndex = 0; iIndex < Fields.Length; iIndex++)
            {
                if (FieldTypes[iIndex].ToLower().Equals("string"))
                {
                    Html +=
                        "        ds.Tables[\"info\"].Columns.Add(\"" + Fields[iIndex] + "\");\r\n";
                }
                if (FieldTypes[iIndex].ToLower().Equals("int"))
                {
                    Html +=
                        "        ds.Tables[\"info\"].Columns.Add(\"" + Fields[iIndex] + "\",typeof(int));\r\n";
                }
                if (FieldTypes[iIndex].ToLower().Equals("decimal"))
                {
                    Html +=
                        "        ds.Tables[\"info\"].Columns.Add(\"" + Fields[iIndex] + "\",typeof(decimal));\r\n";
                }
                if (FieldTypes[iIndex].ToLower().Equals("long"))
                {
                    Html +=
                        "        ds.Tables[\"info\"].Columns.Add(\"" + Fields[iIndex] + "\",typeof(long));\r\n";
                }
                if (FieldTypes[iIndex].ToLower().Equals("datetime"))
                {
                    Html +=
                        "        ds.Tables[\"info\"].Columns.Add(\"" + Fields[iIndex] + "\",typeof(DateTime));\r\n";
                }

            }
            Html +=
            "        for (int iIndex = 0; iIndex < " + ClassName + "s.Length; iIndex++)\r\n" +
            "        {\r\n" +
            "            ds.Tables[\"info\"].Rows.Add(new object[]\r\n" +
            "            {\r\n" +
            "                " + ClassName + "s[iIndex]." + KeyName + ",\r\n";
            for (int iIndex = 0; iIndex < Fields.Length; iIndex++)
            {
                Html +=
                    "                " + ClassName + "s[iIndex]." + Fields[iIndex];
                if (iIndex < Fields.Length - 1)
                {
                    Html += ",";
                }
                Html += "\r\n";
            }
            Html +=
            "            });\r\n" +
            "        }\r\n" +
            "        XmlCls OXml = new XmlCls();\r\n" +
            "        OXml.XmlData = ds.GetXml();\r\n" +
            "        OXml.XmlDataSchema = ds.GetXmlSchema();\r\n" +
            "        return OXml;\r\n" +
            "    }\r\n" +




            "\r\n" +
            "\r\n" +
            "    public static XmlCls GetXml(" + ClassName + "Cls O" + ClassName + ")\r\n" +
            "    {\r\n" +
            "        DataSet ds = new DataSet();\r\n" +
            "        ds.Tables.Add(\"info\");\r\n" +
            "        ds.Tables[\"info\"].Columns.Add(\"" + KeyName + "\");\r\n";
            for (int iIndex = 0; iIndex < Fields.Length; iIndex++)
            {
                if (FieldTypes[iIndex].ToLower().Equals("string"))
                {
                    Html +=
                        "        ds.Tables[\"info\"].Columns.Add(\"" + Fields[iIndex] + "\");\r\n";
                }
                if (FieldTypes[iIndex].ToLower().Equals("int"))
                {
                    Html +=
                        "        ds.Tables[\"info\"].Columns.Add(\"" + Fields[iIndex] + "\",typeof(int));\r\n";
                }
                if (FieldTypes[iIndex].ToLower().Equals("decimal"))
                {
                    Html +=
                        "        ds.Tables[\"info\"].Columns.Add(\"" + Fields[iIndex] + "\",typeof(decimal));\r\n";
                }
                if (FieldTypes[iIndex].ToLower().Equals("long"))
                {
                    Html +=
                        "        ds.Tables[\"info\"].Columns.Add(\"" + Fields[iIndex] + "\",typeof(long));\r\n";
                }
                if (FieldTypes[iIndex].ToLower().Equals("datetime"))
                {
                    Html +=
                        "        ds.Tables[\"info\"].Columns.Add(\"" + Fields[iIndex] + "\",typeof(DateTime));\r\n";
                }

            }
            Html +=
            "            ds.Tables[\"info\"].Rows.Add(new object[]\r\n" +
            "            {\r\n" +
            "                O" + ClassName + "." + KeyName + ",\r\n";
            for (int iIndex = 0; iIndex < Fields.Length; iIndex++)
            {
                Html +=
                    "                O" + ClassName + "." + Fields[iIndex];
                if (iIndex < Fields.Length - 1)
                {
                    Html += ",";
                }
                Html += "\r\n";
            }
            Html +=
            "            });\r\n" +
            
            "        XmlCls OXml = new XmlCls();\r\n" +
            "        OXml.XmlData = ds.GetXml();\r\n" +
            "        OXml.XmlDataSchema = ds.GetXmlSchema();\r\n" +
            "        return OXml;\r\n" +
            "    }\r\n" +
            "}\r\n";

            System.IO.Directory.CreateDirectory(SavePath);
            string SaveFile = SavePath + "\\" + ClassName + ".cs";
            try
            {
                System.IO.File.Delete(SaveFile);
            }
            catch { }
            System.IO.File.AppendAllText(SaveFile, Html);
        }



        void GenModelFilter(string ClassName, string TabName, string KeyName, string[] Fields, string[] FieldTypes)
        {
            string SavePath = Application.StartupPath + "\\" + TabName;

            string Html =
                "using System;\r\n" +
                "using System.Collections.Generic;\r\n" +
                "using System.Linq;\r\n" +
                "using System.Text;\r\n" +
                "using System.Data;\r\n" +
                "using OneFRAME.Model;\r\n" +
                "\r\n" +
                "namespace OneFRAME.Model\r\n" +
                "{ \r\n" +
                "    public class " + ClassName + "FilterCls:FilterCls \r\n" +
                "    { \r\n" +
                "    }\r\n" +
                "}\r\n";

            Html += "\r\n" +
            "public class " + ClassName + "FilterParser \r\n" +
            "{ \r\n" +
            "    public static " + ClassName + "FilterCls CreateInstance() \r\n" +
            "    { \r\n" +
            "        " + ClassName + "FilterCls O" + ClassName + "Filter = new " + ClassName + "FilterCls(); \r\n" +
            "        return O" + ClassName + "Filter; \r\n" +
            "    } \r\n" +
            "\r\n" +
            "\r\n" +
            "    public static " + ClassName + "FilterCls ParseFromDataRow(DataRow dr) \r\n" +
            "    { \r\n" +
            "        " + ClassName + "FilterCls O" + ClassName + "Filter = new " + ClassName + "FilterCls(); \r\n" +
            "        return O" + ClassName + "Filter;\r\n" +
            "    }\r\n" +
            "\r\n" +
           

            "\r\n" +
            "    public static " + ClassName + "FilterCls ParseFromXml(string XmlData, string XmlDataSchema)\r\n" +
            "    {\r\n" +
            "        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);\r\n" +
            "        if(ds.Tables[0].Rows.Count==0)return null;\r\n" +
            "        " + ClassName + "FilterCls O" + ClassName + "Filter = ParseFromDataRow(ds.Tables[0].Rows[0]);\r\n" +
            "        return O" + ClassName + "Filter;\r\n" +
            "    }\r\n" +
            "\r\n" +

            

            "\r\n" +
            "\r\n" +
            "    public static XmlCls GetXml(" + ClassName + "FilterCls O" + ClassName + "Filter)\r\n" +
            "    {\r\n" +
            "        DataSet ds = new DataSet();\r\n" +
            "        ds.Tables.Add(\"info\");\r\n" +
            "        XmlCls OXml = new XmlCls();\r\n" +
            "        OXml.XmlData = ds.GetXml();\r\n" +
            "        OXml.XmlDataSchema = ds.GetXmlSchema();\r\n" +
            "        return OXml;\r\n" +
            "    }\r\n" +
            "}\r\n";

            System.IO.Directory.CreateDirectory(SavePath);
            string SaveFile = SavePath + "\\" + ClassName + "Filter.cs";
            try
            {
                System.IO.File.Delete(SaveFile);
            }
            catch { }
            System.IO.File.AppendAllText(SaveFile, Html);
        }




        void GenBussinessTemplate(string ClassName, string TabName, string KeyName, string[] Fields, string[] FieldTypes)
        {
            string SavePath = Application.StartupPath + "\\" + TabName;

            string Html =
                "using System;\r\n" +
                "using System.Collections.Generic;\r\n" +
                "using System.Linq;\r\n" +
                "using System.Text;\r\n" +
                "using System.Data;\r\n" +
                "using OneFRAME.Model;\r\n" +
                "\r\n" +
                "namespace OneFRAME.Bussiness.Template\r\n" +
                "{\r\n" +
                "   public interface I"+ClassName+"Process\r\n" +
                "   {\r\n" +
                "       string ServiceId { get; }\r\n" +
                "       "+ClassName+"Cls[] Reading(ActionSqlParamCls ActionSqlParam, "+ClassName+"FilterCls O"+ClassName+"Filter);\r\n" +
                "       void Add(ActionSqlParamCls ActionSqlParam,  "+ClassName+"Cls O"+ClassName+");\r\n" +
                "       void Save(ActionSqlParamCls ActionSqlParam,  string Id,"+ClassName+"Cls O"+ClassName+");\r\n" +
                "       void Delete(ActionSqlParamCls ActionSqlParam,  string Id);\r\n" +
                "       "+ClassName+"Cls CreateModel(ActionSqlParamCls ActionSqlParam, string Id);\r\n" +
                "       string Duplicate(ActionSqlParamCls ActionSqlParam, string Id);\r\n" +
                "   }\r\n" +
                "   \r\n"+
                "   public class "+ClassName+"Template : I"+ClassName+"Process\r\n" +
                "   {\r\n" +
                "       public virtual string ServiceId { get { return null; } }\r\n" +
                "       public virtual "+ClassName+"Cls[] Reading(ActionSqlParamCls ActionSqlParam, "+ClassName+"FilterCls O"+ClassName+"Filter) { return null; }\r\n" +
                "       public virtual void Add(ActionSqlParamCls ActionSqlParam, "+ClassName+"Cls O"+ClassName+") { }\r\n" +
                "       public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, "+ClassName+"Cls O"+ClassName+") { }\r\n" +
                "       public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id) { }\r\n" +
                "       public virtual "+ClassName+"Cls CreateModel(ActionSqlParamCls ActionSqlParam, string Id) { return null; }\r\n" +
                "       public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id) { return null; }\r\n" +
                "   }\r\n" +
                "}\r\n";

            System.IO.Directory.CreateDirectory(SavePath);
            string SaveFile = SavePath + "\\I" + ClassName + "Template.cs";
            try
            {
                System.IO.File.Delete(SaveFile);
            }
            catch { }
            System.IO.File.AppendAllText(SaveFile, Html);
        }



        void GenBussinessSql(string ClassName, string TabName, string KeyName, string[] Fields, string[] FieldTypes)
        {
            string SavePath = Application.StartupPath + "\\" + TabName;

            string Html =
                "using System;\r\n" +
                "using System.Collections.ObjectModel;\r\n"+
                "using System.Linq;\r\n" +
                "using System.Text;\r\n" +
                "using System.Data;\r\n" +
                "using OneFRAME.Model;\r\n" +
                "using OneFRAME.Bussiness.Template;\r\n" +
                "using OneFRAME.Database.Service;\r\n" +
                "\r\n" +
                "namespace OneFRAME.Bussiness.Sql\r\n" +
                "{\r\n" +

                "public class " + ClassName + "ProcessBll : "+ClassName+"Template\r\n" +
                "{\r\n" +
                "    public override string ServiceId\r\n" +
                "    {\r\n" +
                "        get\r\n" +
                "        {\r\n" +
                "            return \"Sql" + ClassName + "ProcessBll\";\r\n" +
                "        }\r\n" +
                "    }\r\n" +


                "    public override " + ClassName + "Cls[] Reading(\r\n" +
                "        ActionSqlParamCls ActionSqlParam,\r\n" +
                "        " + ClassName + "FilterCls O" + ClassName + "Filter)\r\n" +
                "    {\r\n" +
                "        IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);\r\n" +
                "        bool HasTrans = ActionSqlParam.Trans != null;\r\n" +
                "        bool HasCommit = false;\r\n" +
                "\r\n" +
                "        if (!HasTrans)\r\n" +
                "        {\r\n" +
                "            ActionSqlParam.Trans = DBService.BeginTransaction();\r\n" +
                "        }\r\n" +
                "\r\n" +
                "        try\r\n" +
                "        {\r\n" +
                "            if (O" + ClassName + "Filter == null)\r\n" +
                "            {\r\n" +
                "                O" + ClassName + "Filter = new " + ClassName + "FilterCls();\r\n" +
                "            }\r\n" +
                "            Collection<DbParam>\r\n" +
                "                ColDbParams = new Collection<DbParam>();\r\n" +
                "            string Query = \"\";\r\n" +
                "\r\n" +
                "            Query = \" select * from " + ClassName + " where 1=1 \";\r\n" +
                "            if (!string.IsNullOrEmpty(O" + ClassName + "Filter.Keyword))\r\n" +
                "            {\r\n" +
                "                ColDbParams.Add(new DbParam(\"Keyword\", \"%\" + O" + ClassName + "Filter.Keyword + \"%\"));\r\n" +
                "                Query += \" and " + ClassName + "Name like \" + ActionSqlParam.SpecialChar + \"Keyword\";\r\n" +
                "            }\r\n" +


                "            Query += \" order by SortIndex\";\r\n" +
                "\r\n" +
                "            DataSet dsResult =\r\n" +
                "                    DBService.GetDataSet(ActionSqlParam.Trans, Query, ColDbParams.ToArray());\r\n" +
                "            " + ClassName + "Cls[] " + ClassName + "s = " + ClassName + "Parser.ParseFromDataTable(dsResult.Tables[0]);\r\n" +
                "\r\n" +
                "            dsResult.Clear();\r\n" +
                "            dsResult.Dispose();\r\n" +

                "            if (!HasTrans && !HasCommit)\r\n" +
                "            {\r\n" +
                "                ActionSqlParam.Trans.Commit();\r\n" +
                "                ActionSqlParam.Trans = null;\r\n" +
                "                HasCommit = true;\r\n" +
                "            }\r\n" +
                "            return " + ClassName + "s;\r\n" +
                "        }\r\n" +
                "        catch (Exception ex)\r\n" +
                "        {\r\n" +
                "            if (!HasTrans && !HasCommit)\r\n" +
                "            {\r\n" +
                "                ActionSqlParam.Trans.Rollback();\r\n" +
                "                ActionSqlParam.Trans = null;\r\n" +
                "            }\r\n" +
                "            throw (ex);\r\n" +
                "        }\r\n" +
                "    }\r\n" +


                "    public override void Add(ActionSqlParamCls ActionSqlParam, " + ClassName + "Cls O" + ClassName + ")\r\n" +
                "    {\r\n" +
                "        IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);\r\n" +
                "        bool HasTrans = ActionSqlParam.Trans != null;\r\n" +
                "        bool HasCommit = false;\r\n" +
                "\r\n" +
                "        if (!HasTrans)\r\n" +
                "        {\r\n" +
                "            ActionSqlParam.Trans = DBService.BeginTransaction();\r\n" +
                "        }\r\n" +
                "\r\n" +
                "        try\r\n" +
                "        {\r\n" +
                "            if (string.IsNullOrEmpty(O" + ClassName + "." + ClassName + "Id))\r\n" +
                "            {\r\n" +
                "                O" + ClassName + "." + ClassName + "Id = System.Guid.NewGuid().ToString();\r\n" +
                "            }\r\n" +

                "            string Query = \"select * from " + ClassName + " where Ma=\"+ActionSqlParam.SpecialChar+\"Ma \";\r\n" +
                "            DataTable dtCheck = DBService.GetDataTable(ActionSqlParam.Trans, Query, new DbParam[]\r\n" +
                "            {\r\n" +
                "                new DbParam(\"Ma\",O" + ClassName + ".Ma)\r\n" +
                "            });\r\n" +
                "\r\n" +
                "            if (dtCheck.Rows.Count == 0)\r\n" +
                "            {\r\n" +
                "                DBService.Insert(ActionSqlParam.Trans, \"" + ClassName + "\",\r\n" +
                "                    new DbParam[]{\r\n" +
                "                    new DbParam(\"" + ClassName + "Id\",O" + ClassName + "." + ClassName + "Id),\r\n";
            for (int iIndex = 0; iIndex < Fields.Length; iIndex++)
            {
                Html+=
                    "   new DbParam(\"" + Fields[iIndex] + "\",O" + ClassName + "." + Fields[iIndex] + ")";
                if (iIndex < Fields.Length - 1)
                {
                    Html += ",\r\n";
                }
                else
                {
                    Html += "\r\n";
                }
            }
            Html +=
                "                });\r\n" +
                "            }\r\n" +
                "            else\r\n" +
                "            {\r\n" +
                "                string " + ClassName + "Id = (string)dtCheck.Rows[0][\"" + ClassName + "Id\"];\r\n" +
                "                DBService.Update(ActionSqlParam.Trans, \"" + ClassName + "\", \"" + ClassName + "Id\", " + ClassName + "Id,\r\n" +
                "                    new DbParam[]{\r\n";
            for (int iIndex = 0; iIndex < Fields.Length; iIndex++)
            {
                Html +=
                    "   new DbParam(\"" + Fields[iIndex] + "\",O" + ClassName + "." + Fields[iIndex] + ")";
                if (iIndex < Fields.Length - 1)
                {
                    Html += ",\r\n";
                }
                else
                {
                    Html += "\r\n";
                }
            }
            Html +=
                "                });\r\n" +
                "            }\r\n" +
                "            if (!HasTrans && !HasCommit)\r\n" +
                "            {\r\n" +
                "                ActionSqlParam.Trans.Commit();\r\n" +
                "                ActionSqlParam.Trans = null;\r\n" +
                "                HasCommit = true;\r\n" +
                "            }\r\n" +
                "        }\r\n" +
                "        catch (Exception ex)\r\n" +
                "        {\r\n" +
                "            if (!HasTrans && !HasCommit)\r\n" +
                "            {\r\n" +
                "                ActionSqlParam.Trans.Rollback();\r\n" +
                "                ActionSqlParam.Trans = null;\r\n" +
                "            }\r\n" +
                "            throw (ex);\r\n" +
                "        }\r\n" +
                "    }\r\n" +

                "    public override void Save(ActionSqlParamCls ActionSqlParam, string " + ClassName + "Id, " + ClassName + "Cls O" + ClassName + ")\r\n" +
                "    {\r\n" +
                "        IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);\r\n" +
                "        bool HasTrans = ActionSqlParam.Trans != null;\r\n" +
                "        bool HasCommit = false;\r\n" +
                "\r\n" +
                "        if (!HasTrans)\r\n" +
                "        {\r\n" +
                "            ActionSqlParam.Trans = DBService.BeginTransaction();\r\n" +
                "        }\r\n" +
                "\r\n" +
                "        try\r\n" +
                "        {\r\n" +
                "            DBService.Update(ActionSqlParam.Trans, \"" + ClassName + "\", \"" + ClassName + "Id\", " + ClassName + "Id,\r\n" +
                "                new DbParam[]{\r\n";

            for (int iIndex = 0; iIndex < Fields.Length; iIndex++)
            {
                Html +=
                    "   new DbParam(\"" + Fields[iIndex] + "\",O" + ClassName + "." + Fields[iIndex] + ")";
                if (iIndex < Fields.Length - 1)
                {
                    Html += ",\r\n";
                }
                else
                {
                    Html += "\r\n";
                }
            }
            Html+=   
                "                });\r\n"+

                "            if (!HasTrans && !HasCommit)\r\n"+
                "            {\r\n"+
                "                ActionSqlParam.Trans.Commit();\r\n"+
                "                ActionSqlParam.Trans = null;\r\n"+
                "                HasCommit = true;\r\n"+
                "            }\r\n"+
                "        }\r\n"+
                "        catch (Exception ex)\r\n"+
                "        {\r\n"+
                "            if (!HasTrans && !HasCommit)\r\n"+
                "            {\r\n"+
                "                ActionSqlParam.Trans.Rollback();\r\n"+
                "                ActionSqlParam.Trans = null;\r\n"+
                "            }\r\n"+
                "            throw (ex);\r\n"+
                "        }\r\n"+
                "    }\r\n"+

                "    public override void Delete(ActionSqlParamCls ActionSqlParam, string Id)\r\n"+
                "    {\r\n"+
                "        IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);\r\n"+
                "        bool HasTrans = ActionSqlParam.Trans != null;\r\n"+
                "        bool HasCommit = false;\r\n"+

                "        if (!HasTrans)\r\n"+
                "        {\r\n"+
                "            ActionSqlParam.Trans = DBService.BeginTransaction();\r\n"+
                "        }\r\n"+
                "\r\n"+
                "        try\r\n"+
                "        {\r\n"+
                "            string DelQuery = \" Delete from "+ClassName+" where Id=\"+ActionSqlParam.SpecialChar+\"Id\";\r\n"+
                "            DBService.ExecuteNonQuery(ActionSqlParam.Trans, DelQuery, \r\n"+
                "                new DbParam[]\r\n"+
                "                {\r\n"+
                "                    new DbParam(\"Id\", Id)\r\n"+
                "                });\r\n"+

                "            if (!HasTrans && !HasCommit)\r\n"+
                "            {\r\n"+
                "                ActionSqlParam.Trans.Commit();\r\n"+
                "                ActionSqlParam.Trans = null;\r\n"+
                "                HasCommit = true;\r\n"+
                "            }\r\n"+
                "        }\r\n"+
                "        catch (Exception ex)\r\n"+
                "        {\r\n"+
                "            if (!HasTrans && !HasCommit)\r\n"+
                "            {\r\n"+
                "                ActionSqlParam.Trans.Rollback();\r\n"+
                "                ActionSqlParam.Trans = null;\r\n"+
                "            }\r\n"+
                "            throw (ex);\r\n"+
                "        }\r\n"+
                "    }\r\n"+

                "    public override "+ClassName+"Cls CreateModel(ActionSqlParamCls ActionSqlParam, string Id)\r\n"+
                "    {\r\n"+
                "        IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);\r\n"+
                "        bool HasTrans = ActionSqlParam.Trans != null;\r\n"+
                "        bool HasCommit = false;\r\n"+
                "\r\n"+
                "        if (!HasTrans)\r\n"+
                "        {\r\n"+
                "            ActionSqlParam.Trans = DBService.BeginTransaction();\r\n"+
                "        }\r\n"+
                "\r\n"+
                "        try\r\n"+
                "        {\r\n"+
                "            DataSet dsResult =\r\n"+
                "                    DBService.GetDataSet(ActionSqlParam.Trans, \"select * from "+ClassName+" where (Id=\"+ActionSqlParam.SpecialChar+\"Id or Ma=\"+ActionSqlParam.SpecialChar+\"Id)  \", new DbParam[]{\r\n"+
                "                    new DbParam(\"Id\",Id)\r\n"+
                "                });\r\n"+
                "            "+ClassName+"Cls O"+ClassName+" = null;\r\n"+
                "            if (dsResult.Tables[0].Rows.Count > 0)\r\n"+
                "            {\r\n"+
                "                O"+ClassName+" = "+ClassName+"Parser.ParseFromDataRow(dsResult.Tables[0].Rows[0]);\r\n"+
                "            }\r\n"+
                "            dsResult.Clear();\r\n"+
                "            dsResult.Dispose();\r\n"+
                "\r\n"+
                "            if (!HasTrans && !HasCommit)\r\n"+
                "            {\r\n"+
                "                ActionSqlParam.Trans.Commit();\r\n"+
                "                ActionSqlParam.Trans = null;\r\n"+
                "                HasCommit = true;\r\n"+
                "            }\r\n"+
                "            return O"+ClassName+";\r\n"+
                "        }\r\n"+
                "        catch (Exception ex)\r\n"+
                "        {\r\n"+
                "            if (!HasTrans && !HasCommit)\r\n"+
                "            {\r\n"+
                "                ActionSqlParam.Trans.Rollback();\r\n"+
                "                ActionSqlParam.Trans = null;\r\n"+
                "            }\r\n"+
                "            throw (ex);\r\n"+
                "        }\r\n"+
                "    }\r\n"+
                "\r\n"+
                "    public override string Duplicate(ActionSqlParamCls ActionSqlParam, string Id)\r\n"+
                "    {\r\n"+
                "        IDatabaseService DBService = CoreWebDatabaseService.CreateDBService(ActionSqlParam);\r\n"+
                "        bool HasTrans = ActionSqlParam.Trans != null;\r\n"+
                "        bool HasCommit = false;\r\n"+
                "\r\n"+
                "        string NewId = System.Guid.NewGuid().ToString();\r\n"+
                "        if (!HasTrans)\r\n"+
                "        {\r\n"+
                "            ActionSqlParam.Trans = DBService.BeginTransaction();\r\n"+
                "        }\r\n"+
                "\r\n"+
                "        try\r\n"+
                "        {\r\n"+
                "            "+ClassName+"Cls O"+ClassName+" = CreateModel(ActionSqlParam, Id);\r\n"+
                "            O"+ClassName+".Id = NewId;\r\n"+
                "            Add(ActionSqlParam, O"+ClassName+");\r\n"+
                "\r\n"+
                "            if (!HasTrans && !HasCommit)\r\n"+
                "            {\r\n"+
                "                ActionSqlParam.Trans.Commit();\r\n"+
                "                ActionSqlParam.Trans = null;\r\n"+
                "                HasCommit = true;\r\n"+
                "            }\r\n"+
                "            return NewId;\r\n"+
                "        }\r\n"+
                "        catch (Exception ex)\r\n"+
                "        {\r\n"+
                "            if (!HasTrans && !HasCommit)\r\n"+
                "            {\r\n"+
                "                ActionSqlParam.Trans.Rollback();\r\n"+
                "                ActionSqlParam.Trans = null;\r\n"+
                "            }\r\n"+
                "            throw (ex);\r\n"+
                "        }\r\n"+
                "    }\r\n"+
                "}\r\n"+

                "}\r\n";

            System.IO.Directory.CreateDirectory(SavePath);
            string SaveFile = SavePath + "\\" + ClassName + "ProcessBll.cs";
            try
            {
                System.IO.File.Delete(SaveFile);
            }
            catch { }
            System.IO.File.AppendAllText(SaveFile, Html);
        }



        void GenCallBussinessTemplate(string ClassName, string TabName, string KeyName, string[] Fields, string[] FieldTypes)
        {
            string SavePath = Application.StartupPath + "\\" + TabName+"\\call";

            string Html =
                "using System;\r\n" +
                "using System.Collections.Generic;\r\n" +
                "using System.Linq;\r\n" +
                "using System.Text;\r\n" +
                "using System.Data;\r\n" +
                "using OneFRAME.Model;\r\n"+
                "\r\n" +
                "namespace OneFRAME.Call.Bussiness.Template\r\n" +
                "{\r\n" +
                "   public interface I" + ClassName + "Process\r\n" +
                "   {\r\n" +
                "       string ServiceId { get; }\r\n" +
                "       " + ClassName + "Cls[] Reading(RenderInfoCls ORenderInfo, " + ClassName + "FilterCls O" + ClassName + "Filter);\r\n" +
                "       void Add(RenderInfoCls ORenderInfo,  " + ClassName + "Cls O" + ClassName + ");\r\n" +
                "       void Save(RenderInfoCls ORenderInfo,  string " + ClassName + "Id," + ClassName + "Cls O" + ClassName + ");\r\n" +
                "       void Delete(RenderInfoCls ORenderInfo,  string " + ClassName + "Id);\r\n" +
                "       " + ClassName + "Cls CreateModel(RenderInfoCls ORenderInfo, string " + ClassName + "Id);\r\n" +
                "       string Duplicate(RenderInfoCls ORenderInfo, string " + ClassName + "Id);\r\n" +
                "   }\r\n" +
                "   \r\n" +
                "   public class " + ClassName + "Template : I" + ClassName + "Process\r\n" +
                "   {\r\n" +
                "       public virtual string ServiceId { get { return null; } }\r\n" +
                "       public virtual " + ClassName + "Cls[] Reading(RenderInfoCls ORenderInfo, " + ClassName + "FilterCls O" + ClassName + "Filter) { return null; }\r\n" +
                "       public virtual void Add(RenderInfoCls ORenderInfo, " + ClassName + "Cls O" + ClassName + ") { }\r\n" +
                "       public virtual void Save(RenderInfoCls ORenderInfo, string " + ClassName + "Id, " + ClassName + "Cls O" + ClassName + ") { }\r\n" +
                "       public virtual void Delete(RenderInfoCls ORenderInfo, string " + ClassName + "Id) { }\r\n" +
                "       public virtual " + ClassName + "Cls CreateModel(RenderInfoCls ORenderInfo, string " + ClassName + "Id) { return null; }\r\n" +
                "       public virtual string Duplicate(RenderInfoCls ORenderInfo, string " + ClassName + "Id) { return null; }\r\n" +
                "   }\r\n" +
                "}\r\n";

            System.IO.Directory.CreateDirectory(SavePath);
            string SaveFile = SavePath + "\\I" + ClassName + "Template.cs";
            try
            {
                System.IO.File.Delete(SaveFile);
            }
            catch { }
            System.IO.File.AppendAllText(SaveFile, Html);
        }



        void GenCallSqlBussinessTemplate(string ClassName, string TabName, string KeyName, string[] Fields, string[] FieldTypes)
        {
            string SavePath = Application.StartupPath + "\\" + TabName + "\\call\\direct";

            string Html =
                "using System;\r\n" +
                "using System.Collections.Generic;\r\n" +
                "using System.Linq;\r\n" +
                "using System.Text;\r\n" +
                "using System.Data;\r\n" +
                "using OneFRAME.Model;\r\n" +
                "using OneFRAME.Call.Bussiness.Template;\r\n" +
                "using OneFRAME.Utility;\r\n" +
                "using OneFRAME.Bussiness.Utility;\r\n" +
                "\r\n" +
                "namespace OneFRAME.Call.Bussiness.Sql\r\n" +
                "{\r\n" +
                "public class " + ClassName + "ProcessBll : " + ClassName + "Template\r\n" +
                "{\r\n"+
                "public override string ServiceId\r\n"+
                "{\r\n"+
                "    get\r\n"+
                "    {\r\n"+
                "        return \"Sql"+ClassName+"ProcessBll\";\r\n"+
                "    }\r\n"+
                "}\r\n"+
                "\r\n"+
                "\r\n" +
                "public override "+ClassName+"Cls[] Reading(\r\n"+
                "    RenderInfoCls ORenderInfo,\r\n"+
                "    "+ClassName+"FilterCls O"+ClassName+"Filter)\r\n"+
                "{\r\n"+
                "    ActionSqlParamCls\r\n"+
                "        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);\r\n"+
                "    return OneFRAMEBussinessUtility.CreateBussinessProcess().Create"+ClassName+"Process().Reading(ActionSqlParam, O"+ClassName+"Filter);\r\n"+
                "}\r\n"+
                "\r\n" +
                "\r\n" +

                "public override void Add(RenderInfoCls ORenderInfo, "+ClassName+"Cls O"+ClassName+")\r\n"+
                "{\r\n"+
                "    ActionSqlParamCls\r\n"+
                "        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);\r\n"+
                "    OneFRAMEBussinessUtility.CreateBussinessProcess().Create"+ClassName+"Process().Add(ActionSqlParam, O"+ClassName+");\r\n"+
                "}\r\n"+
                "\r\n" +
                "\r\n" +
                "public override void Save(RenderInfoCls ORenderInfo, string Id, "+ClassName+"Cls O"+ClassName+")\r\n"+
                "{\r\n"+
                "    ActionSqlParamCls\r\n"+
                "        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);\r\n"+
                "    OneFRAMEBussinessUtility.CreateBussinessProcess().Create"+ClassName+"Process().Save(ActionSqlParam, Id, O"+ClassName+");\r\n"+
                "}\r\n"+
                "\r\n" +
                "\r\n" +
                "public override void Delete(RenderInfoCls ORenderInfo, string Id)\r\n"+
                "{\r\n"+
                "    ActionSqlParamCls\r\n"+
                "        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);\r\n"+
                "    OneFRAMEBussinessUtility.CreateBussinessProcess().Create"+ClassName+"Process().Delete(ActionSqlParam, Id);\r\n"+
                "}\r\n"+
                "\r\n" +
                "\r\n" +
                "public override "+ClassName+"Cls CreateModel(RenderInfoCls ORenderInfo, string Id)\r\n"+
                "{\r\n"+
                "    ActionSqlParamCls\r\n"+
                "        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);\r\n"+
                "    return OneFRAMEBussinessUtility.CreateBussinessProcess().Create"+ClassName+"Process().CreateModel(ActionSqlParam, Id);\r\n"+
                "}\r\n"+
                "\r\n" +
                "\r\n" +
                "public override string Duplicate(RenderInfoCls ORenderInfo, string Id)\r\n"+
                "{\r\n"+
                "    ActionSqlParamCls\r\n"+
                "        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);\r\n"+
                "    return OneFRAMEBussinessUtility.CreateBussinessProcess().Create"+ClassName+"Process().Duplicate(ActionSqlParam, Id);\r\n"+
                "}\r\n" +
                "\r\n" +
                "\r\n" +
                "}\r\n" +
                "}\r\n";

            System.IO.Directory.CreateDirectory(SavePath);
            string SaveFile = SavePath + "\\" + ClassName + "ProcessBll.cs";
            try
            {
                System.IO.File.Delete(SaveFile);
            }
            catch { }
            System.IO.File.AppendAllText(SaveFile, Html);
        }



        void GenCallWsBussinessTemplate(string ClassName, string TabName, string KeyName, string[] Fields, string[] FieldTypes)
        {
            string SavePath = Application.StartupPath + "\\" + TabName + "\\call\\ws";

            string Html =
                "using System;\r\n" +
                "using System.Collections.Generic;\r\n" +
                "using System.Linq;\r\n" +
                "using System.Text;\r\n" +
                "using System.Data;\r\n" +
                "using OneFRAME.Model;\r\n" +
                "using OneFRAME.Call.Bussiness.Template;\r\n" +
                "using OneFRAME.Utility;\r\n" +
                "using OneFRAME.Bussiness.Utility;\r\n" +
                "\r\n" +
                "namespace OneFRAME.Call.Bussiness.Ws\r\n" +
                "{\r\n" +
                "public class " + ClassName + "ProcessBll : " + ClassName + "Template\r\n" +
                "{\r\n" +
                "public override string ServiceId\r\n" +
                "{\r\n" +
                "    get\r\n" +
                "    {\r\n" +
                "        return \"Ws" + ClassName + "ProcessBll\";\r\n" +
                "    }\r\n" +
                "}\r\n" +
                "\r\n" +
                "\r\n" +
                "public override " + ClassName + "Cls[] Reading(\r\n" +
                "    RenderInfoCls ORenderInfo,\r\n" +
                "    " + ClassName + "FilterCls O" + ClassName + "Filter)\r\n" +
                "{\r\n" +
                "    ActionSqlParamCls\r\n" +
                "        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);\r\n" +
                "    return OneFRAMEBussinessUtility.CreateBussinessProcess().Create" + ClassName + "Process().Reading(ActionSqlParam, O" + ClassName + "Filter);\r\n" +
                "}\r\n" +
                "\r\n" +
                "\r\n" +

                "public override void Add(RenderInfoCls ORenderInfo, " + ClassName + "Cls O" + ClassName + ")\r\n" +
                "{\r\n" +
                "    ActionSqlParamCls\r\n" +
                "        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);\r\n" +
                "    OneFRAMEBussinessUtility.CreateBussinessProcess().Create" + ClassName + "Process().Add(ActionSqlParam, O" + ClassName + ");\r\n" +
                "}\r\n" +
                "\r\n" +
                "\r\n" +
                "public override void Save(RenderInfoCls ORenderInfo, string " + ClassName + "Id, " + ClassName + "Cls O" + ClassName + ")\r\n" +
                "{\r\n" +
                "    ActionSqlParamCls\r\n" +
                "        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);\r\n" +
                "    OneFRAMEBussinessUtility.CreateBussinessProcess().Create" + ClassName + "Process().Save(ActionSqlParam, " + ClassName + "Id, O" + ClassName + ");\r\n" +
                "}\r\n" +
                "\r\n" +
                "\r\n" +
                "public override void Delete(RenderInfoCls ORenderInfo, string " + ClassName + "Id)\r\n" +
                "{\r\n" +
                "    ActionSqlParamCls\r\n" +
                "        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);\r\n" +
                "    OneFRAMEBussinessUtility.CreateBussinessProcess().Create" + ClassName + "Process().Delete(ActionSqlParam, " + ClassName + "Id);\r\n" +
                "}\r\n" +
                "\r\n" +
                "\r\n" +
                "public override " + ClassName + "Cls CreateModel(RenderInfoCls ORenderInfo, string " + ClassName + "Id)\r\n" +
                "{\r\n" +
                "    ActionSqlParamCls\r\n" +
                "        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);\r\n" +
                "    return OneFRAMEBussinessUtility.CreateBussinessProcess().Create" + ClassName + "Process().CreateModel(ActionSqlParam, " + ClassName + "Id);\r\n" +
                "}\r\n" +
                "\r\n" +
                "\r\n" +
                "public override string Duplicate(RenderInfoCls ORenderInfo, string " + ClassName + "Id)\r\n" +
                "{\r\n" +
                "    ActionSqlParamCls\r\n" +
                "        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);\r\n" +
                "    return OneFRAMEBussinessUtility.CreateBussinessProcess().Create" + ClassName + "Process().Duplicate(ActionSqlParam, " + ClassName + "Id);\r\n" +
                "}\r\n" +
                "\r\n" +
                "\r\n" +
                "}\r\n" +
                "}\r\n";

            System.IO.Directory.CreateDirectory(SavePath);
            string SaveFile = SavePath + "\\" + ClassName + "Process.cs";
            try
            {
                System.IO.File.Delete(SaveFile);
            }
            catch { }
            System.IO.File.AppendAllText(SaveFile, Html);
        }
    }
}
