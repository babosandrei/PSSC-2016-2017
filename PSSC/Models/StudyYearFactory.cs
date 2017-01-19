using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class StudyYearFactory
    {
         public static readonly StudyYearFactory Instance = new StudyYearFactory();
 
         private StudyYearFactory()
         {
         }
 
         public StudyYear createStudyYear(StudyYear studyYear)
         {
             return studyYear;
         }
    }
}
