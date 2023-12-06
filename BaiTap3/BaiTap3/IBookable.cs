using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    public interface IBookable
    {
        bool BookRoom(DateTime date);
        void ReleaseRoom(DateTime date);
    }
}
