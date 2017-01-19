﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IReportStrategy
     {
         PlainText GenerateReport(List<Student.Student> students);
     }
 
     //Strategy Context
     public interface IReportPublisher
     {
         void Publish(IReportStrategy strategy);
     }
}
