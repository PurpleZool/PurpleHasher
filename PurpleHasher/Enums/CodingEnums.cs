using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleHasher.Enums
{
    public enum Codings
    {
        RAW = 0,
        ASCII = 1,
        UTF8 = 2,
        UTF16 = 3,
        NUM = 4

    }


    public enum Hashings
    {
        MD5 = 0,
        SHA256 = 1,
        SHA512 = 2
    }


    public enum ByteRep 
    {
        HEX = 0,
        NUM=1
    }

}
