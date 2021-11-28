using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    internal class Field
    {
        private int group;
        private int row;
        private int column;

        public Field(int group, int row, int column)
        {
            this.group = group;
            this.row = row;
            this.column = column;
        }

        public int GetGroup()
        {
            return group;
        }

        public void SetGroup(int group)
        {
            this.group = group;
        }

        public int GetRow()
        {
            return row;
        }

        public void SetRow(int row)
        {
            this.row = row;
        }

        public int GetColumn()
        {
            return column;
        }

        public void SetColumn(int column)
        {
            this.column = column;
        }
    }
}
