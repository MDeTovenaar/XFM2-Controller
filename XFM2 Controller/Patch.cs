using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFM2_Controller
{
    public class Patch
    {
        public enum ParamsEnum : int
        {
            PRM_ALGO0 = 001,
            PRM_ALGO1 = 002,
            PRM_ALGO2 = 003,
            PRM_ALGO3 = 004,
            PRM_ALGO4 = 005,
            PRM_ALGO5 = 006,
            PRM_FEEDBACK0 = 007,
            PRM_FEEDBACK1 = 008,
            PRM_FEEDBACK2 = 009,
            PRM_FEEDBACK3 = 010,
            PRM_FEEDBACK4 = 011,
            PRM_FEEDBACK5 = 012,
        }

        public string Name { get; set; }
        public Guid Id { get; set; }

        public Parameter Parameter(ParamsEnum Name)
        {
            return new Parameter("test", 1, 0, 255);
        }
    }
}
