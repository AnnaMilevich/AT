using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork3
{
    class Cell
    {
        char colum;
        int row;
        
        public Cell(char colum, int row)
        {

          
            // if(char.TryParse(columtest,out colum) && )
            if (row < 1 || row > 8 || (int)colum < 97 || (int)colum > 104)
            {
                throw new OutRowOrColumBoard();
            }
            this.colum = (char)colum;
            this.row = row;
          
        }
    }
}
