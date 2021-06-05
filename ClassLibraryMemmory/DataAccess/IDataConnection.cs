using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryMemory.Models;

namespace ClassLibraryMemory.DataAccess
{
    public interface IDataConnection
    {
        Chapter CreateChapter(Chapter model);
        Subject CreateSubject(Subject model);
        Unit CreateUnit(Unit model);
        Concept CreateConcept(Concept model);
        List<String> GetSubjectName();
        List<String> GetUnitName();
        List<String> GetChapterName();
        String GetSubjectID(String subjectName);
        List<String> GetChapterbySubject(String subjectName);
        String GetChapterID(String chapterName);

        //int GetUnitID();
        //int GetConceptID();
    }
}
