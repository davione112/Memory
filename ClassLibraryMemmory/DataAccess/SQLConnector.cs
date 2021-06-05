using ClassLibraryMemory.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace ClassLibraryMemory.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        public Chapter CreateChapter(Chapter model)
        {
            // using method: dont leave the connection open
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Memmory")))
            {
                var p = new DynamicParameters();
                p.Add("@ChapterName", model.ChapterName);
                p.Add("@SubjectID", model.SubjectID);
                p.Add("@id", 1, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spChapters_Insert", p, commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>("@id");

                return model;
            }
            // connection break after this curly symbol.
        }
        public Subject CreateSubject(Subject model)
        {
            // using method: dont leave the connection open
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Memmory")))
            {
                var p = new DynamicParameters();
                p.Add("@SubjectName", model.SubjectName);
                p.Add("@id", 1, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spSubjects_Insert", p, commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>("@id");

                return model;
            }
            // connection break after this curly symbol.
        }
        public Unit CreateUnit(Unit model)
        {
            // using method: dont leave the connection open
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Memmory")))
            {
                var p = new DynamicParameters();
                p.Add("@UnitName", model.UnitName);
                p.Add("@ChapterID", model.ChapterID);
                p.Add("@id", 1, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spUnits_Insert", p, commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>("@id");

                return model;
            }
            // connection break after this curly symbol.
        }
        public Concept CreateConcept(Concept model)
        {
            // using method: dont leave the connection open
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Memmory")))
            {
                var p = new DynamicParameters();
                p.Add("@ConceptName", model.ConceptName);
                p.Add("@Author", model.Author);
                p.Add("@P_Year", model.Year);
                p.Add("@Content", model.Content);
                p.Add("@id", 1, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spConcepts_Insert", p, commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>("@id");

                return model;
            }
            // connection break after this curly symbol.
        }
        public List<String> GetSubjectName()
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Memmory")))
            {
                var ouput = connection.Query<String>("dbo.spSubjects_Get").ToList();
                return ouput;
            }
        }
        public List<String> GetUnitName()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Memmory")))
            {
                var ouput = connection.Query<String>("dbo.spUnits_Get").ToList();
                return ouput;
            }
        }
        public List<String> GetChapterName()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Memmory")))
            {
                var ouput = connection.Query<String>("dbo.spChapters_Get").ToList();
                return ouput;
            }
        }
        public String GetSubjectID(String subjectName)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Memmory")))
            {
                var output = connection.Query<String>("dbo.spSubjects_GetIDbyName @SubjectName", new { SubjectName = subjectName }).ToList();

                return output[0];
            }
        }
        public List<String> GetChapterbySubject(String subjectName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Memmory")))
            {
                var output = connection.Query<String>("dbo.spChapters_GetChapterbySubject @SubjectName", new { SubjectName = subjectName }).ToList();

                return output;
            }
        }
        public String GetChapterID(String chapterName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Memmory")))
            {
                var output = connection.Query<String>("dbo.spChapters_GetIDbyName @ChapterName", new { ChapterName = chapterName }).ToList();

                return output[0];
            }
        }
    }
}
