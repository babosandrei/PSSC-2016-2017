using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class SubjectsFactory
    {
         public static readonly SubjectsFactory Instance = new SubjectsFactory();
 
         private SubjectsFactory()
         {
 
         }
 
         public Subject.Subject CreateSubjects(SubjectInformation subjectInfo)
         {
             var subject = new Subject.Subject(subjectInfo);
 
             return subject;
         }
    }
}
