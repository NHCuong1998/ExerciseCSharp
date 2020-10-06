using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class Class
    {
        public string IDClass { get; set; }
        public string NameClass { get; set; }

        public object Student { get; set; }

        public Class() {}

        public Class(string iDClass, string nameClass, object student)
        {
            IDClass = iDClass;
            NameClass = nameClass;
            Student = student;
        }

        public override string ToString() => $"idClass = {IDClass}, NameClass = {NameClass}, Student= {Student}";
    }
}
