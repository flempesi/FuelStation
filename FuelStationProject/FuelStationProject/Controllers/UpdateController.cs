using FuelStationProject.Impl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationProject.Controllers {
    class UpdateController {
        public UpdateController(){
        }

        public string UpdateEntry(string primaryKey, string tableName, DataSet MasterData, DataSet MasterDataOld) {

            string sql = string.Empty;
            string sqlSet = string.Empty;

            List<string> sqlSetLines = new List<string>();
            List<string> sqlWhereLines = new List<string>();

            DataRow rowOld = MasterDataOld.Tables[0].Select(String.Format("[ID] = '{0}' ", primaryKey))[0];
            DataRow rowNew = MasterData.Tables[0].Select(String.Format("[ID] = '{0}' ", primaryKey))[0];


            foreach (DataColumn column in MasterData.Tables[0].Columns) {

                if (column.ColumnName == "ID") {
                    ComposeQueryField(sqlWhereLines, column.ColumnName, rowNew[column]);
                }
                else {

                    if (rowNew[column.ColumnName].ToString() != rowOld[column.ColumnName].ToString()) {

                        ComposeQueryField(sqlSetLines, column.ColumnName, rowNew[column]);
                    }
                }
            }

            sqlSet = string.Join(",", sqlSetLines);

            if (sqlSetLines.Count > 0) {
                sql = String.Format("UPDATE [{0}] SET {1} WHERE {2}", tableName, sqlSet, string.Join(",", sqlWhereLines));

            }
            return sql;
        }

        public void ComposeQueryField(List<string> sqlLine, string columnName, object value) {

            switch (value.GetType().Name) {

                case "String":
                case "Guid":
                    sqlLine.Add(string.Format("{0}='{1}'", columnName, value));
                    break;

                case "Int32":
                case "Int64":
                    sqlLine.Add(string.Format("{0}={1}", columnName, value));
                    break;

                case "DateTime":
                    string datePart = Convert.ToDateTime(value).ToString("yyyyMMdd");
                    sqlLine.Add(string.Format("{0}='{1}'", columnName, datePart));
                    break;

                //case "DBNull":

                //    string nothing = Convert.DBNull.ToString();
                //    sqlLine.Add(string.Format("{0}='{1}'", columnName, nothing));


                //    break;
                case "Decimal":
                    string decimalPart = Convert.ToDecimal(value).ToString().Replace(',', '.');

                    sqlLine.Add(string.Format("{0}={1}", columnName, decimalPart));
                    break;
                case "Int16":
                    sqlLine.Add(string.Format("{0}={1}", columnName, Convert.ToInt16(value)));
                    break;

                case "TransTypeEnum":
                    ItemTypeCategoryEnum enumVal = (ItemTypeCategoryEnum)value;
                    sqlLine.Add(string.Format("{0}={1}", columnName, Convert.ToInt16(enumVal)));
                    break;
            }
            
        }
    }
}
