using System;

namespace Chapter5.Library
{
    public class Class
    {
        public enum Status : byte
        {
            None = 0b_00_00,
            SUCCESS = 0b_00_01,
            PENDING = 0b_00_10,
            ERROR = 0b_01_00
        }
        internal string member1;

        public const Status initStatus = Status.SUCCESS;
    }
}