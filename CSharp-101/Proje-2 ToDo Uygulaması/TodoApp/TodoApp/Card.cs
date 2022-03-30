using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    class Card
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int ResponsibleID { get; set; }
        public Size Size { get; set; }
        public CaseOf CaseOf { get; set; } = CaseOf.ToDoLine;

    }

    enum Size
    {
        XS=1,
        S,
        M,
        L,
        XL
    }

    enum CaseOf
    {
        ToDoLine=1,
        InProgressLine,
        DoneLine
    }
}
