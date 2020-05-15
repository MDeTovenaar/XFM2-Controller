using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFM2_Controller
{
    public class Patch
    {
        #region Fields
        private readonly Dictionary<ParamsEnum, Parameter> _params = new Dictionary<ParamsEnum, Parameter>();
        #endregion

        #region Constructors        
        public Patch()
        {
            _params.Add(ParamsEnum.PRM_ALGO0, new Parameter("Algorithm 1", (int)ParamsEnum.PRM_ALGO0, 0, 125));
            _params.Add(ParamsEnum.PRM_ALGO1, new Parameter("Algorithm 2", (int)ParamsEnum.PRM_ALGO1, 0, 121));
            _params.Add(ParamsEnum.PRM_ALGO2, new Parameter("Algorithm 3", (int)ParamsEnum.PRM_ALGO2, 0, 119));
            _params.Add(ParamsEnum.PRM_ALGO3, new Parameter("Algorithm 4", (int)ParamsEnum.PRM_ALGO3, 0, 111));
            _params.Add(ParamsEnum.PRM_ALGO4, new Parameter("Algorithm 5", (int)ParamsEnum.PRM_ALGO4, 0, 95));
            _params.Add(ParamsEnum.PRM_ALGO5, new Parameter("Algorithm 6", (int)ParamsEnum.PRM_ALGO5, 0, 63));
            _params.Add(ParamsEnum.PRM_FEEDBACK0, new Parameter("Feedback 1", (int)ParamsEnum.PRM_FEEDBACK0, 0, 255));
            _params.Add(ParamsEnum.PRM_FEEDBACK1, new Parameter("Feedback 2", (int)ParamsEnum.PRM_FEEDBACK1, 0, 255));
            _params.Add(ParamsEnum.PRM_FEEDBACK2, new Parameter("Feedback 3", (int)ParamsEnum.PRM_FEEDBACK2, 0, 255));
            _params.Add(ParamsEnum.PRM_FEEDBACK3, new Parameter("Feedback 4", (int)ParamsEnum.PRM_FEEDBACK3, 0, 255));
            _params.Add(ParamsEnum.PRM_FEEDBACK4, new Parameter("Feedback 5", (int)ParamsEnum.PRM_FEEDBACK4, 0, 255));
            _params.Add(ParamsEnum.PRM_FEEDBACK5, new Parameter("Feedback 6", (int)ParamsEnum.PRM_FEEDBACK5, 0, 255));
            _params.Add(ParamsEnum.PRM_OSC_SYNC, new Parameter("Oscillator Sync", (int)ParamsEnum.PRM_OSC_SYNC, 0, 32));
            _params.Add(ParamsEnum.PRM_OSC_MODE, new Parameter("Oscillator Mode", (int)ParamsEnum.PRM_OSC_MODE, 0, 32));
            _params.Add(ParamsEnum.PRM_RATIO0, new Parameter("Pitch Ratio 1", (int)ParamsEnum.PRM_RATIO0, 0, 255));
            _params.Add(ParamsEnum.PRM_RATIO1, new Parameter("Pitch Ratio 2", (int)ParamsEnum.PRM_RATIO1, 0, 255));
            _params.Add(ParamsEnum.PRM_RATIO2, new Parameter("Pitch Ratio 3", (int)ParamsEnum.PRM_RATIO2, 0, 255));
            _params.Add(ParamsEnum.PRM_RATIO3, new Parameter("Pitch Ratio 4", (int)ParamsEnum.PRM_RATIO3, 0, 255));
            _params.Add(ParamsEnum.PRM_RATIO4, new Parameter("Pitch Ratio 5", (int)ParamsEnum.PRM_RATIO4, 0, 255));
            _params.Add(ParamsEnum.PRM_RATIO5, new Parameter("Pitch Ratio 6", (int)ParamsEnum.PRM_RATIO5, 0, 255));
            _params.Add(ParamsEnum.PRM_RATIO_FINE0, new Parameter("Pitch Ratio Fine 1", (int)ParamsEnum.PRM_RATIO_FINE0, 0, 255));
            _params.Add(ParamsEnum.PRM_RATIO_FINE1, new Parameter("Pitch Ratio Fine 2", (int)ParamsEnum.PRM_RATIO_FINE1, 0, 255));
            _params.Add(ParamsEnum.PRM_RATIO_FINE2, new Parameter("Pitch Ratio Fine 3", (int)ParamsEnum.PRM_RATIO_FINE2, 0, 255));
            _params.Add(ParamsEnum.PRM_RATIO_FINE3, new Parameter("Pitch Ratio Fine 4", (int)ParamsEnum.PRM_RATIO_FINE3, 0, 255));
            _params.Add(ParamsEnum.PRM_RATIO_FINE4, new Parameter("Pitch Ratio Fine 5", (int)ParamsEnum.PRM_RATIO_FINE4, 0, 255));
            _params.Add(ParamsEnum.PRM_RATIO_FINE5, new Parameter("Pitch Ratio Fine 6", (int)ParamsEnum.PRM_RATIO_FINE5, 0, 255));
            _params.Add(ParamsEnum.PRM_FINE0, new Parameter("Operator Pitch 1", (int)ParamsEnum.PRM_FINE0, 0, 255));
            _params.Add(ParamsEnum.PRM_FINE1, new Parameter("Operator Pitch 2", (int)ParamsEnum.PRM_FINE1, 0, 255));
            _params.Add(ParamsEnum.PRM_FINE2, new Parameter("Operator Pitch 3", (int)ParamsEnum.PRM_FINE2, 0, 255));
            _params.Add(ParamsEnum.PRM_FINE3, new Parameter("Operator Pitch 4", (int)ParamsEnum.PRM_FINE3, 0, 255));
            _params.Add(ParamsEnum.PRM_FINE4, new Parameter("Operator Pitch 5", (int)ParamsEnum.PRM_FINE4, 0, 255));
            _params.Add(ParamsEnum.PRM_FINE5, new Parameter("Operator Pitch 6", (int)ParamsEnum.PRM_FINE5, 0, 255));
            _params.Add(ParamsEnum.PRM_LEVEL0, new Parameter("Level 1", (int)ParamsEnum.PRM_LEVEL0, 0, 255));
            _params.Add(ParamsEnum.PRM_LEVEL1, new Parameter("Level 2", (int)ParamsEnum.PRM_LEVEL1, 0, 255));
            _params.Add(ParamsEnum.PRM_LEVEL2, new Parameter("Level 3", (int)ParamsEnum.PRM_LEVEL2, 0, 255));
            _params.Add(ParamsEnum.PRM_LEVEL3, new Parameter("Level 4", (int)ParamsEnum.PRM_LEVEL3, 0, 255));
            _params.Add(ParamsEnum.PRM_LEVEL4, new Parameter("Level 5", (int)ParamsEnum.PRM_LEVEL4, 0, 255));
            _params.Add(ParamsEnum.PRM_LEVEL5, new Parameter("Level 6", (int)ParamsEnum.PRM_LEVEL5, 0, 255));
            _params.Add(ParamsEnum.PRM_LEVEL0_L, new Parameter("Level Left 1", (int)ParamsEnum.PRM_LEVEL0_L, 0, 255));
            _params.Add(ParamsEnum.PRM_LEVEL1_L, new Parameter("Level Left 2", (int)ParamsEnum.PRM_LEVEL1_L, 0, 255));
            _params.Add(ParamsEnum.PRM_LEVEL2_L, new Parameter("Level Left 3", (int)ParamsEnum.PRM_LEVEL2_L, 0, 255));
            _params.Add(ParamsEnum.PRM_LEVEL3_L, new Parameter("Level Left 4", (int)ParamsEnum.PRM_LEVEL3_L, 0, 255));
            _params.Add(ParamsEnum.PRM_LEVEL4_L, new Parameter("Level Left 5", (int)ParamsEnum.PRM_LEVEL4_L, 0, 255));
            _params.Add(ParamsEnum.PRM_LEVEL5_L, new Parameter("Level Left 6", (int)ParamsEnum.PRM_LEVEL5_L, 0, 255));
            _params.Add(ParamsEnum.PRM_LEVEL0_R, new Parameter("Level Right 1", (int)ParamsEnum.PRM_LEVEL0_R, 0, 255));
            _params.Add(ParamsEnum.PRM_LEVEL1_R, new Parameter("Level Right 2", (int)ParamsEnum.PRM_LEVEL1_R, 0, 255));
            _params.Add(ParamsEnum.PRM_LEVEL2_R, new Parameter("Level Right 3", (int)ParamsEnum.PRM_LEVEL2_R, 0, 255));
            _params.Add(ParamsEnum.PRM_LEVEL3_R, new Parameter("Level Right 4", (int)ParamsEnum.PRM_LEVEL3_R, 0, 255));
            _params.Add(ParamsEnum.PRM_LEVEL4_R, new Parameter("Level Right 5", (int)ParamsEnum.PRM_LEVEL4_R, 0, 255));
            _params.Add(ParamsEnum.PRM_LEVEL5_R, new Parameter("Level Right 6", (int)ParamsEnum.PRM_LEVEL5_R, 0, 255));
            _params.Add(ParamsEnum.PRM_VEL_SENS0, new Parameter("Velocity Sensitivity 1", (int)ParamsEnum.PRM_VEL_SENS0, 0, 255));
            _params.Add(ParamsEnum.PRM_VEL_SENS1, new Parameter("Velocity Sensitivity 2", (int)ParamsEnum.PRM_VEL_SENS1, 0, 255));
            _params.Add(ParamsEnum.PRM_VEL_SENS2, new Parameter("Velocity Sensitivity 3", (int)ParamsEnum.PRM_VEL_SENS2, 0, 255));
            _params.Add(ParamsEnum.PRM_VEL_SENS3, new Parameter("Velocity Sensitivity 4", (int)ParamsEnum.PRM_VEL_SENS3, 0, 255));
            _params.Add(ParamsEnum.PRM_VEL_SENS4, new Parameter("Velocity Sensitivity 5", (int)ParamsEnum.PRM_VEL_SENS4, 0, 255));
            _params.Add(ParamsEnum.PRM_VEL_SENS5, new Parameter("Velocity Sensitivity 6", (int)ParamsEnum.PRM_VEL_SENS5, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_BP0, new Parameter("Keyboard Breakpoint 1", (int)ParamsEnum.PRM_KEY_BP0, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_BP1, new Parameter("Keyboard Breakpoint 2", (int)ParamsEnum.PRM_KEY_BP1, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_BP2, new Parameter("Keyboard Breakpoint 3", (int)ParamsEnum.PRM_KEY_BP2, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_BP3, new Parameter("Keyboard Breakpoint 4", (int)ParamsEnum.PRM_KEY_BP3, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_BP4, new Parameter("Keyboard Breakpoint 5", (int)ParamsEnum.PRM_KEY_BP4, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_BP5, new Parameter("Keyboard Breakpoint 6", (int)ParamsEnum.PRM_KEY_BP5, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_LDEPTH0, new Parameter("Keyboard Depth Left 1", (int)ParamsEnum.PRM_KEY_LDEPTH0, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_LDEPTH1, new Parameter("Keyboard Depth Left 2", (int)ParamsEnum.PRM_KEY_LDEPTH1, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_LDEPTH2, new Parameter("Keyboard Depth Left 3", (int)ParamsEnum.PRM_KEY_LDEPTH2, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_LDEPTH3, new Parameter("Keyboard Depth Left 4", (int)ParamsEnum.PRM_KEY_LDEPTH3, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_LDEPTH4, new Parameter("Keyboard Depth Left 5", (int)ParamsEnum.PRM_KEY_LDEPTH4, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_LDEPTH5, new Parameter("Keyboard Depth Left 6", (int)ParamsEnum.PRM_KEY_LDEPTH5, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_RDEPTH0, new Parameter("Keyboard Depth Right 1", (int)ParamsEnum.PRM_KEY_RDEPTH0, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_RDEPTH1, new Parameter("Keyboard Depth Right 2", (int)ParamsEnum.PRM_KEY_RDEPTH1, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_RDEPTH2, new Parameter("Keyboard Depth Right 3", (int)ParamsEnum.PRM_KEY_RDEPTH2, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_RDEPTH3, new Parameter("Keyboard Depth Right 4", (int)ParamsEnum.PRM_KEY_RDEPTH3, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_RDEPTH4, new Parameter("Keyboard Depth Right 5", (int)ParamsEnum.PRM_KEY_RDEPTH4, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_RDEPTH5, new Parameter("Keyboard Depth Right 6", (int)ParamsEnum.PRM_KEY_RDEPTH5, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_LCURVE0, new Parameter("Keyboard Curve Left 1", (int)ParamsEnum.PRM_KEY_LCURVE0, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_LCURVE1, new Parameter("Keyboard Curve Left 2", (int)ParamsEnum.PRM_KEY_LCURVE1, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_LCURVE2, new Parameter("Keyboard Curve Left 3", (int)ParamsEnum.PRM_KEY_LCURVE2, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_LCURVE3, new Parameter("Keyboard Curve Left 4", (int)ParamsEnum.PRM_KEY_LCURVE3, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_LCURVE4, new Parameter("Keyboard Curve Left 5", (int)ParamsEnum.PRM_KEY_LCURVE4, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_LCURVE5, new Parameter("Keyboard Curve Left 6", (int)ParamsEnum.PRM_KEY_LCURVE5, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_RCURVE0, new Parameter("Keyboard Curve Right 1", (int)ParamsEnum.PRM_KEY_RCURVE0, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_RCURVE1, new Parameter("Keyboard Curve Right 2", (int)ParamsEnum.PRM_KEY_RCURVE1, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_RCURVE2, new Parameter("Keyboard Curve Right 3", (int)ParamsEnum.PRM_KEY_RCURVE2, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_RCURVE3, new Parameter("Keyboard Curve Right 4", (int)ParamsEnum.PRM_KEY_RCURVE3, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_RCURVE4, new Parameter("Keyboard Curve Right 5", (int)ParamsEnum.PRM_KEY_RCURVE4, 0, 255));
            _params.Add(ParamsEnum.PRM_KEY_RCURVE5, new Parameter("Keyboard Curve Right 6", (int)ParamsEnum.PRM_KEY_RCURVE5, 0, 255));
            _params.Add(ParamsEnum.PRM_L0_0, new Parameter("Attack Level AM 1", (int)ParamsEnum.PRM_L0_0, 0, 255));
            _params.Add(ParamsEnum.PRM_L0_1, new Parameter("Attack Level AM 2", (int)ParamsEnum.PRM_L0_1, 0, 255));
            _params.Add(ParamsEnum.PRM_L0_2, new Parameter("Attack Level AM 3", (int)ParamsEnum.PRM_L0_2, 0, 255));
            _params.Add(ParamsEnum.PRM_L0_3, new Parameter("Attack Level AM 4", (int)ParamsEnum.PRM_L0_3, 0, 255));
            _params.Add(ParamsEnum.PRM_L0_4, new Parameter("Attack Level AM 5", (int)ParamsEnum.PRM_L0_4, 0, 255));
            _params.Add(ParamsEnum.PRM_L0_5, new Parameter("Attack Level AM 6", (int)ParamsEnum.PRM_L0_5, 0, 255));
            _params.Add(ParamsEnum.PRM_L1_0, new Parameter("Decay 1 Level AM 1", (int)ParamsEnum.PRM_L1_0, 0, 255));
            _params.Add(ParamsEnum.PRM_L1_1, new Parameter("Decay 1 Level AM 2", (int)ParamsEnum.PRM_L1_1, 0, 255));
            _params.Add(ParamsEnum.PRM_L1_2, new Parameter("Decay 1 Level AM 3", (int)ParamsEnum.PRM_L1_2, 0, 255));
            _params.Add(ParamsEnum.PRM_L1_3, new Parameter("Decay 1 Level AM 4", (int)ParamsEnum.PRM_L1_3, 0, 255));
            _params.Add(ParamsEnum.PRM_L1_4, new Parameter("Decay 1 Level AM 5", (int)ParamsEnum.PRM_L1_4, 0, 255));
            _params.Add(ParamsEnum.PRM_L1_5, new Parameter("Decay 1 Level AM 6", (int)ParamsEnum.PRM_L1_5, 0, 255));
            _params.Add(ParamsEnum.PRM_L2_0, new Parameter("Decay 2 Level AM 1", (int)ParamsEnum.PRM_L2_0, 0, 255));
            _params.Add(ParamsEnum.PRM_L2_1, new Parameter("Decay 2 Level AM 2", (int)ParamsEnum.PRM_L2_1, 0, 255));
            _params.Add(ParamsEnum.PRM_L2_2, new Parameter("Decay 2 Level AM 3", (int)ParamsEnum.PRM_L2_2, 0, 255));
            _params.Add(ParamsEnum.PRM_L2_3, new Parameter("Decay 2 Level AM 4", (int)ParamsEnum.PRM_L2_3, 0, 255));
            _params.Add(ParamsEnum.PRM_L2_4, new Parameter("Decay 2 Level AM 5", (int)ParamsEnum.PRM_L2_4, 0, 255));
            _params.Add(ParamsEnum.PRM_L2_5, new Parameter("Decay 2 Level AM 6", (int)ParamsEnum.PRM_L2_5, 0, 255));
            _params.Add(ParamsEnum.PRM_L3_0, new Parameter("Sustain Level AM 1", (int)ParamsEnum.PRM_L3_0, 0, 255));
            _params.Add(ParamsEnum.PRM_L3_1, new Parameter("Sustain Level AM 2", (int)ParamsEnum.PRM_L3_1, 0, 255));
            _params.Add(ParamsEnum.PRM_L3_2, new Parameter("Sustain Level AM 3", (int)ParamsEnum.PRM_L3_2, 0, 255));
            _params.Add(ParamsEnum.PRM_L3_3, new Parameter("Sustain Level AM 4", (int)ParamsEnum.PRM_L3_3, 0, 255));
            _params.Add(ParamsEnum.PRM_L3_4, new Parameter("Sustain Level AM 5", (int)ParamsEnum.PRM_L3_4, 0, 255));
            _params.Add(ParamsEnum.PRM_L3_5, new Parameter("Sustain Level AM 6", (int)ParamsEnum.PRM_L3_5, 0, 255));
            _params.Add(ParamsEnum.PRM_L4_0, new Parameter("Release 1 Level AM 1", (int)ParamsEnum.PRM_L4_0, 0, 255));
            _params.Add(ParamsEnum.PRM_L4_1, new Parameter("Release 1 Level AM 2", (int)ParamsEnum.PRM_L4_1, 0, 255));
            _params.Add(ParamsEnum.PRM_L4_2, new Parameter("Release 1 Level AM 3", (int)ParamsEnum.PRM_L4_2, 0, 255));
            _params.Add(ParamsEnum.PRM_L4_3, new Parameter("Release 1 Level AM 4", (int)ParamsEnum.PRM_L4_3, 0, 255));
            _params.Add(ParamsEnum.PRM_L4_4, new Parameter("Release 1 Level AM 5", (int)ParamsEnum.PRM_L4_4, 0, 255));
            _params.Add(ParamsEnum.PRM_L4_5, new Parameter("Release 1 Level AM 6", (int)ParamsEnum.PRM_L4_5, 0, 255));
            _params.Add(ParamsEnum.PRM_L5_0, new Parameter("Release 2 Level AM 1", (int)ParamsEnum.PRM_L5_0, 0, 255));
            _params.Add(ParamsEnum.PRM_L5_1, new Parameter("Release 2 Level AM 2", (int)ParamsEnum.PRM_L5_1, 0, 255));
            _params.Add(ParamsEnum.PRM_L5_2, new Parameter("Release 2 Level AM 3", (int)ParamsEnum.PRM_L5_2, 0, 255));
            _params.Add(ParamsEnum.PRM_L5_3, new Parameter("Release 2 Level AM 4", (int)ParamsEnum.PRM_L5_3, 0, 255));
            _params.Add(ParamsEnum.PRM_L5_4, new Parameter("Release 2 Level AM 5", (int)ParamsEnum.PRM_L5_4, 0, 255));
            _params.Add(ParamsEnum.PRM_L5_5, new Parameter("Release 2 Level AM 6", (int)ParamsEnum.PRM_L5_5, 0, 255));
            _params.Add(ParamsEnum.PRM_R0_0, new Parameter("Attack Time AM 1", (int)ParamsEnum.PRM_R0_0, 0, 255));
            _params.Add(ParamsEnum.PRM_R0_1, new Parameter("Attack Time AM 2", (int)ParamsEnum.PRM_R0_1, 0, 255));
            _params.Add(ParamsEnum.PRM_R0_2, new Parameter("Attack Time AM 3", (int)ParamsEnum.PRM_R0_2, 0, 255));
            _params.Add(ParamsEnum.PRM_R0_3, new Parameter("Attack Time AM 4", (int)ParamsEnum.PRM_R0_3, 0, 255));
            _params.Add(ParamsEnum.PRM_R0_4, new Parameter("Attack Time AM 5", (int)ParamsEnum.PRM_R0_4, 0, 255));
            _params.Add(ParamsEnum.PRM_R0_5, new Parameter("Attack Time AM 6", (int)ParamsEnum.PRM_R0_5, 0, 255));
            _params.Add(ParamsEnum.PRM_R1_0, new Parameter("Decay 1 Time AM 1", (int)ParamsEnum.PRM_R1_0, 0, 255));
            _params.Add(ParamsEnum.PRM_R1_1, new Parameter("Decay 1 Time AM 2", (int)ParamsEnum.PRM_R1_1, 0, 255));
            _params.Add(ParamsEnum.PRM_R1_2, new Parameter("Decay 1 Time AM 3", (int)ParamsEnum.PRM_R1_2, 0, 255));
            _params.Add(ParamsEnum.PRM_R1_3, new Parameter("Decay 1 Time AM 4", (int)ParamsEnum.PRM_R1_3, 0, 255));
            _params.Add(ParamsEnum.PRM_R1_4, new Parameter("Decay 1 Time AM 5", (int)ParamsEnum.PRM_R1_4, 0, 255));
            _params.Add(ParamsEnum.PRM_R1_5, new Parameter("Decay 1 Time AM 6", (int)ParamsEnum.PRM_R1_5, 0, 255));
            _params.Add(ParamsEnum.PRM_R2_0, new Parameter("Decay 2 Time AM 1", (int)ParamsEnum.PRM_R2_0, 0, 255));
            _params.Add(ParamsEnum.PRM_R2_1, new Parameter("Decay 2 Time AM 2", (int)ParamsEnum.PRM_R2_1, 0, 255));
            _params.Add(ParamsEnum.PRM_R2_2, new Parameter("Decay 2 Time AM 3", (int)ParamsEnum.PRM_R2_2, 0, 255));
            _params.Add(ParamsEnum.PRM_R2_3, new Parameter("Decay 2 Time AM 4", (int)ParamsEnum.PRM_R2_3, 0, 255));
            _params.Add(ParamsEnum.PRM_R2_4, new Parameter("Decay 2 Time AM 5", (int)ParamsEnum.PRM_R2_4, 0, 255));
            _params.Add(ParamsEnum.PRM_R2_5, new Parameter("Decay 2 Time AM 6", (int)ParamsEnum.PRM_R2_5, 0, 255));
            _params.Add(ParamsEnum.PRM_R3_0, new Parameter("Sustain Time AM 1", (int)ParamsEnum.PRM_R3_0, 0, 255));
            _params.Add(ParamsEnum.PRM_R3_1, new Parameter("Sustain Time AM 2", (int)ParamsEnum.PRM_R3_1, 0, 255));
            _params.Add(ParamsEnum.PRM_R3_2, new Parameter("Sustain Time AM 3", (int)ParamsEnum.PRM_R3_2, 0, 255));
            _params.Add(ParamsEnum.PRM_R3_3, new Parameter("Sustain Time AM 4", (int)ParamsEnum.PRM_R3_3, 0, 255));
            _params.Add(ParamsEnum.PRM_R3_4, new Parameter("Sustain Time AM 5", (int)ParamsEnum.PRM_R3_4, 0, 255));
            _params.Add(ParamsEnum.PRM_R3_5, new Parameter("Sustain Time AM 6", (int)ParamsEnum.PRM_R3_5, 0, 255));
            _params.Add(ParamsEnum.PRM_R4_0, new Parameter("Release 1 Time AM 1", (int)ParamsEnum.PRM_R4_0, 0, 255));
            _params.Add(ParamsEnum.PRM_R4_1, new Parameter("Release 1 Time AM 2", (int)ParamsEnum.PRM_R4_1, 0, 255));
            _params.Add(ParamsEnum.PRM_R4_2, new Parameter("Release 1 Time AM 3", (int)ParamsEnum.PRM_R4_2, 0, 255));
            _params.Add(ParamsEnum.PRM_R4_3, new Parameter("Release 1 Time AM 4", (int)ParamsEnum.PRM_R4_3, 0, 255));
            _params.Add(ParamsEnum.PRM_R4_4, new Parameter("Release 1 Time AM 5", (int)ParamsEnum.PRM_R4_4, 0, 255));
            _params.Add(ParamsEnum.PRM_R4_5, new Parameter("Release 1 Time AM 6", (int)ParamsEnum.PRM_R4_5, 0, 255));
            _params.Add(ParamsEnum.PRM_R5_0, new Parameter("Release 2 Time AM 1", (int)ParamsEnum.PRM_R5_0, 0, 255));
            _params.Add(ParamsEnum.PRM_R5_1, new Parameter("Release 2 Time AM 2", (int)ParamsEnum.PRM_R5_1, 0, 255));
            _params.Add(ParamsEnum.PRM_R5_2, new Parameter("Release 2 Time AM 3", (int)ParamsEnum.PRM_R5_2, 0, 255));
            _params.Add(ParamsEnum.PRM_R5_3, new Parameter("Release 2 Time AM 4", (int)ParamsEnum.PRM_R5_3, 0, 255));
            _params.Add(ParamsEnum.PRM_R5_4, new Parameter("Release 2 Time AM 5", (int)ParamsEnum.PRM_R5_4, 0, 255));
            _params.Add(ParamsEnum.PRM_R5_5, new Parameter("Release 2 Time AM 6", (int)ParamsEnum.PRM_R5_5, 0, 255));
            _params.Add(ParamsEnum.PRM_RATE_KEY0, new Parameter("Rate Key AM 1", (int)ParamsEnum.PRM_RATE_KEY0, 0, 255));
            _params.Add(ParamsEnum.PRM_RATE_KEY1, new Parameter("Rate Key AM 2", (int)ParamsEnum.PRM_RATE_KEY1, 0, 255));
            _params.Add(ParamsEnum.PRM_RATE_KEY2, new Parameter("Rate Key AM 3", (int)ParamsEnum.PRM_RATE_KEY2, 0, 255));
            _params.Add(ParamsEnum.PRM_RATE_KEY3, new Parameter("Rate Key AM 4", (int)ParamsEnum.PRM_RATE_KEY3, 0, 255));
            _params.Add(ParamsEnum.PRM_RATE_KEY4, new Parameter("Rate Key AM 5", (int)ParamsEnum.PRM_RATE_KEY4, 0, 255));
            _params.Add(ParamsEnum.PRM_RATE_KEY5, new Parameter("Rate Key AM 6", (int)ParamsEnum.PRM_RATE_KEY5, 0, 255));
            _params.Add(ParamsEnum.PRM_EG_LOOP, new Parameter("EG LOOP AM", (int)ParamsEnum.PRM_EG_LOOP, 0, 32));
            _params.Add(ParamsEnum.PRM_EG_LOOP_SEG, new Parameter("EG LOOP SEG AM", (int)ParamsEnum.PRM_EG_LOOP_SEG, 0, 32));
            _params.Add(ParamsEnum.PRM_LFO_AMS0, new Parameter("AMS 1", (int)ParamsEnum.PRM_LFO_AMS0, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_AMS1, new Parameter("AMS 2", (int)ParamsEnum.PRM_LFO_AMS1, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_AMS2, new Parameter("AMS 3", (int)ParamsEnum.PRM_LFO_AMS2, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_AMS3, new Parameter("AMS 4", (int)ParamsEnum.PRM_LFO_AMS3, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_AMS4, new Parameter("AMS 5", (int)ParamsEnum.PRM_LFO_AMS4, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_AMS5, new Parameter("AMS 6", (int)ParamsEnum.PRM_LFO_AMS5, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_PMS0, new Parameter("PMS 1", (int)ParamsEnum.PRM_LFO_PMS0, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_PMS1, new Parameter("PMS 2", (int)ParamsEnum.PRM_LFO_PMS1, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_PMS2, new Parameter("PMS 3", (int)ParamsEnum.PRM_LFO_PMS2, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_PMS3, new Parameter("PMS 4", (int)ParamsEnum.PRM_LFO_PMS3, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_PMS4, new Parameter("PMS 5", (int)ParamsEnum.PRM_LFO_PMS4, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_PMS5, new Parameter("PMS 6", (int)ParamsEnum.PRM_LFO_PMS5, 0, 255));
            _params.Add(ParamsEnum.PRM_L0_P, new Parameter("Attack Level Pitch", (int)ParamsEnum.PRM_L0_P, 0, 255));
            _params.Add(ParamsEnum.PRM_L1_P, new Parameter("Decay 1 Level Pitch", (int)ParamsEnum.PRM_L1_P, 0, 255));
            _params.Add(ParamsEnum.PRM_L2_P, new Parameter("Decay 2 Level Pitch", (int)ParamsEnum.PRM_L2_P, 0, 255));
            _params.Add(ParamsEnum.PRM_L3_P, new Parameter("Sustain Level Pitch", (int)ParamsEnum.PRM_L3_P, 0, 255));
            _params.Add(ParamsEnum.PRM_L4_P, new Parameter("Release 1 Level Pitch", (int)ParamsEnum.PRM_L4_P, 0, 255));
            _params.Add(ParamsEnum.PRM_L5_P, new Parameter("Release 2 Level Pitch", (int)ParamsEnum.PRM_L5_P, 0, 255));
            _params.Add(ParamsEnum.PRM_R0_P, new Parameter("Attack Time Pitch", (int)ParamsEnum.PRM_R0_P, 0, 255));
            _params.Add(ParamsEnum.PRM_R1_P, new Parameter("Decay 1 Time Pitch", (int)ParamsEnum.PRM_R1_P, 0, 255));
            _params.Add(ParamsEnum.PRM_R2_P, new Parameter("Decay 2 Time Pitch", (int)ParamsEnum.PRM_R2_P, 0, 255));
            _params.Add(ParamsEnum.PRM_R3_P, new Parameter("Sustain Time Pitch", (int)ParamsEnum.PRM_R3_P, 0, 255));
            _params.Add(ParamsEnum.PRM_R4_P, new Parameter("Release 1 Time Pitch", (int)ParamsEnum.PRM_R4_P, 0, 255));
            _params.Add(ParamsEnum.PRM_R5_P, new Parameter("Release 2 Time Pitch", (int)ParamsEnum.PRM_R5_P, 0, 255));
            _params.Add(ParamsEnum.PRM_RATE_KEYP, new Parameter("Rate Key Pitch", (int)ParamsEnum.PRM_RATE_KEYP, 0, 255));
            _params.Add(ParamsEnum.PRM_EG_PITCH_RANGE, new Parameter("Range Pitch", (int)ParamsEnum.PRM_EG_PITCH_RANGE, 0, 8));
            _params.Add(ParamsEnum.PRM_EG_PITCH_RANGE_VELO, new Parameter("Range Velocity Pitch", (int)ParamsEnum.PRM_EG_PITCH_RANGE_VELO, 0, 8));
            _params.Add(ParamsEnum.PRM_LFO_PITCH_DEPTH, new Parameter("LFO Pitch Depth", (int)ParamsEnum.PRM_LFO_PITCH_DEPTH, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_AMP_DEPTH, new Parameter("LFO AM Depth", (int)ParamsEnum.PRM_LFO_AMP_DEPTH, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_SPEED, new Parameter("LFO Speed", (int)ParamsEnum.PRM_LFO_SPEED, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_SYNC, new Parameter("LFO Sync", (int)ParamsEnum.PRM_LFO_SYNC, 0, 3));
            _params.Add(ParamsEnum.PRM_LFO_WAVE, new Parameter("LFO Wave", (int)ParamsEnum.PRM_LFO_WAVE, 0, 5));
            _params.Add(ParamsEnum.PRM_LFO_FADE, new Parameter("LFO Fade", (int)ParamsEnum.PRM_LFO_FADE, 0, 255));
            _params.Add(ParamsEnum.PRM_BEND_RANGE_UP, new Parameter("Bend Up", (int)ParamsEnum.PRM_BEND_RANGE_UP, 0, 255));
            _params.Add(ParamsEnum.PRM_BEND_RANGE_DN, new Parameter("Bend Down", (int)ParamsEnum.PRM_BEND_RANGE_DN, 0, 255));
            _params.Add(ParamsEnum.PRM_TRANSPOSE, new Parameter("Transpose", (int)ParamsEnum.PRM_TRANSPOSE, 0, 48));
            _params.Add(ParamsEnum.PRM_VOLUME, new Parameter("Volume", (int)ParamsEnum.PRM_VOLUME, 0, 255));
            _params.Add(ParamsEnum.PRM_PAN, new Parameter("Pan", (int)ParamsEnum.PRM_PAN, 0, 255));
            _params.Add(ParamsEnum.PRM_VELO_OFFSET, new Parameter("Velocity Offset", (int)ParamsEnum.PRM_VELO_OFFSET, 0, 255));
            //_params.Add(ParamsEnum.PRM_EG_RESTART, new Parameter("EG RESTART", (int)ParamsEnum.PRM_EG_RESTART, 0, 255));
            _params.Add(ParamsEnum.PRM_LEGATO, new Parameter("Legato", (int)ParamsEnum.PRM_LEGATO, 0, 1));
            _params.Add(ParamsEnum.PRM_PORTA_MODE, new Parameter("Portamento Mode", (int)ParamsEnum.PRM_PORTA_MODE, 0, 2));
            _params.Add(ParamsEnum.PRM_PORTA_TIME, new Parameter("Portamento Time", (int)ParamsEnum.PRM_PORTA_TIME, 0, 255));
            _params.Add(ParamsEnum.PRM_TUNING, new Parameter("Tuning", (int)ParamsEnum.PRM_TUNING, 0, 255));
            _params.Add(ParamsEnum.PRM_OUTPUT_LEVEL, new Parameter("Output Level", (int)ParamsEnum.PRM_OUTPUT_LEVEL, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_PITCH_DEPTH_AFTER, new Parameter("Modulation LFO Pitch After", (int)ParamsEnum.PRM_LFO_PITCH_DEPTH_AFTER, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_PITCH_DEPTH_WHEEL, new Parameter("Modulation LFO Pitch Wheel", (int)ParamsEnum.PRM_LFO_PITCH_DEPTH_WHEEL, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_PITCH_DEPTH_BREATH, new Parameter("Modulation LFO Pitch Breath", (int)ParamsEnum.PRM_LFO_PITCH_DEPTH_BREATH, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_PITCH_DEPTH_FOOT, new Parameter("Modulation LFO Pitch Foot", (int)ParamsEnum.PRM_LFO_PITCH_DEPTH_FOOT, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_AMP_DEPTH_AFTER, new Parameter("Modulation LFO AM After", (int)ParamsEnum.PRM_LFO_AMP_DEPTH_AFTER, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_AMP_DEPTH_WHEEL, new Parameter("Modulation LFOAM  Wheel", (int)ParamsEnum.PRM_LFO_AMP_DEPTH_WHEEL, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_AMP_DEPTH_BREATH, new Parameter("Modulation LFO AM Breath", (int)ParamsEnum.PRM_LFO_AMP_DEPTH_BREATH, 0, 255));
            _params.Add(ParamsEnum.PRM_LFO_AMP_DEPTH_FOOT, new Parameter("Modulation LFO AM Foot", (int)ParamsEnum.PRM_LFO_AMP_DEPTH_FOOT, 0, 255));
            _params.Add(ParamsEnum.PRM_VOLUME_DEPTH_AFTER, new Parameter("Modulation Volume After", (int)ParamsEnum.PRM_VOLUME_DEPTH_AFTER, 0, 255));
            _params.Add(ParamsEnum.PRM_VOLUME_DEPTH_WHEEL, new Parameter("Modulation Volume Wheel", (int)ParamsEnum.PRM_VOLUME_DEPTH_WHEEL, 0, 255));
            _params.Add(ParamsEnum.PRM_VOLUME_DEPTH_BREATH, new Parameter("Modulation Volume Breath", (int)ParamsEnum.PRM_VOLUME_DEPTH_BREATH, 0, 255));
            _params.Add(ParamsEnum.PRM_VOLUME_DEPTH_FOOT, new Parameter("Modulation Volume Foot", (int)ParamsEnum.PRM_VOLUME_DEPTH_FOOT, 0, 255));
            _params.Add(ParamsEnum.PRM_PITCH_DEPTH_AFTER, new Parameter("Modulation Pitch After", (int)ParamsEnum.PRM_PITCH_DEPTH_AFTER, 0, 255));
            _params.Add(ParamsEnum.PRM_PITCH_DEPTH_BREATH, new Parameter("Modulation Pitch Breath", (int)ParamsEnum.PRM_PITCH_DEPTH_BREATH, 0, 255));
            _params.Add(ParamsEnum.PRM_PITCH_DEPTH_FOOT, new Parameter("Modulation Pitch Foot", (int)ParamsEnum.PRM_PITCH_DEPTH_FOOT, 0, 255));
            _params.Add(ParamsEnum.PRM_PITCH_DEPTH_RND, new Parameter("Modulation Pitch Random", (int)ParamsEnum.PRM_PITCH_DEPTH_RND, 0, 255));
            _params.Add(ParamsEnum.PRM_ARP_MODE, new Parameter("Arpeggiator Mode", (int)ParamsEnum.PRM_ARP_MODE, 0, 5));
            _params.Add(ParamsEnum.PRM_ARP_TEMPO, new Parameter("Arpeggiator Tempo", (int)ParamsEnum.PRM_ARP_TEMPO, 50, 255));
            _params.Add(ParamsEnum.PRM_ARP_TEMPO_FINE, new Parameter("Arpeggiator Tempo Fine", (int)ParamsEnum.PRM_ARP_TEMPO_FINE, 0, 255));
            _params.Add(ParamsEnum.PRM_ARP_DIVISION, new Parameter("Arpeggiator Multiplicator", (int)ParamsEnum.PRM_ARP_DIVISION, 0, 255));
            _params.Add(ParamsEnum.PRM_ARP_OCTAVES, new Parameter("Arpeggiator Octaves", (int)ParamsEnum.PRM_ARP_OCTAVES, 0, 8));
            _params.Add(ParamsEnum.PRM_BITCRUSHER_DEPTH, new Parameter("Bitcrusher Depth", (int)ParamsEnum.PRM_BITCRUSHER_DEPTH, 1, 24));
            _params.Add(ParamsEnum.PRM_DECIMATOR_DEPTH, new Parameter("Decimator Depth", (int)ParamsEnum.PRM_DECIMATOR_DEPTH, 0, 255));
            _params.Add(ParamsEnum.PRM_FILTER_LO, new Parameter("Filter High", (int)ParamsEnum.PRM_FILTER_LO, 0, 255));
            _params.Add(ParamsEnum.PRM_FILTER_HI, new Parameter("Filter Low", (int)ParamsEnum.PRM_FILTER_HI, 0, 255));
            _params.Add(ParamsEnum.PRM_CHORUS_DRY, new Parameter("Chorus Dry", (int)ParamsEnum.PRM_CHORUS_DRY, 0, 255));
            _params.Add(ParamsEnum.PRM_CHORUS_WET, new Parameter("Chorus Wet", (int)ParamsEnum.PRM_CHORUS_WET, 0, 255));
            _params.Add(ParamsEnum.PRM_CHORUS_MODE, new Parameter("Chorus Mode", (int)ParamsEnum.PRM_CHORUS_MODE, 0, 3));
            _params.Add(ParamsEnum.PRM_CHORUS_SPEED, new Parameter("Chorus Speed", (int)ParamsEnum.PRM_CHORUS_SPEED, 0, 255));
            _params.Add(ParamsEnum.PRM_CHORUS_DEPTH, new Parameter("Chorus Depth", (int)ParamsEnum.PRM_CHORUS_DEPTH, 0, 255));
            _params.Add(ParamsEnum.PRM_CHORUS_FEEDBACK, new Parameter("Chorus Feedback", (int)ParamsEnum.PRM_CHORUS_FEEDBACK, 0, 255));
            _params.Add(ParamsEnum.PRM_CHORUS_PHASE, new Parameter("Chorus Phase", (int)ParamsEnum.PRM_CHORUS_PHASE, 0, 255));
            _params.Add(ParamsEnum.PRM_PHASER_DRY, new Parameter("Phaser Dry", (int)ParamsEnum.PRM_PHASER_DRY, 0, 255));
            _params.Add(ParamsEnum.PRM_PHASER_WET, new Parameter("Phaser Wet", (int)ParamsEnum.PRM_PHASER_WET, 0, 255));
            _params.Add(ParamsEnum.PRM_PHASER_MODE, new Parameter("Phaser Mode", (int)ParamsEnum.PRM_PHASER_MODE, 0, 2));
            _params.Add(ParamsEnum.PRM_PHASER_DEPTH, new Parameter("Phaser Depth", (int)ParamsEnum.PRM_PHASER_DEPTH, 0, 255));
            _params.Add(ParamsEnum.PRM_PHASER_SPEED, new Parameter("Phaser Speed", (int)ParamsEnum.PRM_PHASER_SPEED, 0, 255));
            _params.Add(ParamsEnum.PRM_PHASER_FEEDBACK, new Parameter("Phaser Feedback", (int)ParamsEnum.PRM_PHASER_FEEDBACK, 0, 255));
            _params.Add(ParamsEnum.PRM_PHASER_OFFSET, new Parameter("Phaser Offset", (int)ParamsEnum.PRM_PHASER_OFFSET, 0, 255));
            _params.Add(ParamsEnum.PRM_PHASER_STAGES, new Parameter("Phaser Stages", (int)ParamsEnum.PRM_PHASER_STAGES, 4, 12));
            _params.Add(ParamsEnum.PRM_PHASER_PHASE, new Parameter("Phaser Phase", (int)ParamsEnum.PRM_PHASER_PHASE, 0, 255));
            _params.Add(ParamsEnum.PRM_PHASER_WAVEFORM, new Parameter("Phaser Waveform", (int)ParamsEnum.PRM_PHASER_WAVEFORM, 0, 7));
        }
        #endregion

        #region Enum
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
            PRM_OSC_SYNC = 013,
            PRM_OSC_MODE = 014,
            PRM_RATIO0 = 015,
            PRM_RATIO1 = 016,
            PRM_RATIO2 = 017,
            PRM_RATIO3 = 018,
            PRM_RATIO4 = 019,
            PRM_RATIO5 = 020,
            PRM_RATIO_FINE0 = 021,
            PRM_RATIO_FINE1 = 022,
            PRM_RATIO_FINE2 = 023,
            PRM_RATIO_FINE3 = 024,
            PRM_RATIO_FINE4 = 025,
            PRM_RATIO_FINE5 = 026,
            PRM_FINE0 = 027,
            PRM_FINE1 = 028,
            PRM_FINE2 = 029,
            PRM_FINE3 = 030,
            PRM_FINE4 = 031,
            PRM_FINE5 = 032,
            PRM_LEVEL0 = 033,
            PRM_LEVEL1 = 034,
            PRM_LEVEL2 = 035,
            PRM_LEVEL3 = 036,
            PRM_LEVEL4 = 037,
            PRM_LEVEL5 = 038,
            PRM_VEL_SENS0 = 039,
            PRM_VEL_SENS1 = 040,
            PRM_VEL_SENS2 = 041,
            PRM_VEL_SENS3 = 042,
            PRM_VEL_SENS4 = 043,
            PRM_VEL_SENS5 = 044,
            PRM_KEY_BP0 = 045,
            PRM_KEY_BP1 = 046,
            PRM_KEY_BP2 = 047,
            PRM_KEY_BP3 = 048,
            PRM_KEY_BP4 = 049,
            PRM_KEY_BP5 = 050,
            PRM_KEY_LDEPTH0 = 051,
            PRM_KEY_LDEPTH1 = 052,
            PRM_KEY_LDEPTH2 = 053,
            PRM_KEY_LDEPTH3 = 054,
            PRM_KEY_LDEPTH4 = 055,
            PRM_KEY_LDEPTH5 = 056,
            PRM_KEY_RDEPTH0 = 057,
            PRM_KEY_RDEPTH1 = 058,
            PRM_KEY_RDEPTH2 = 059,
            PRM_KEY_RDEPTH3 = 060,
            PRM_KEY_RDEPTH4 = 061,
            PRM_KEY_RDEPTH5 = 062,
            PRM_KEY_LCURVE0 = 063,
            PRM_KEY_LCURVE1 = 064,
            PRM_KEY_LCURVE2 = 065,
            PRM_KEY_LCURVE3 = 066,
            PRM_KEY_LCURVE4 = 067,
            PRM_KEY_LCURVE5 = 068,
            PRM_KEY_RCURVE0 = 069,
            PRM_KEY_RCURVE1 = 070,
            PRM_KEY_RCURVE2 = 071,
            PRM_KEY_RCURVE3 = 072,
            PRM_KEY_RCURVE4 = 073,
            PRM_KEY_RCURVE5 = 074,
            PRM_L1_0 = 075,
            PRM_L1_1 = 076,
            PRM_L1_2 = 077,
            PRM_L1_3 = 078,
            PRM_L1_4 = 079,
            PRM_L1_5 = 080,
            PRM_L2_0 = 082,
            PRM_L2_1 = 083,
            PRM_L2_2 = 084,
            PRM_L2_3 = 085,
            PRM_L2_4 = 086,
            PRM_L2_5 = 087,
            PRM_L3_0 = 089,
            PRM_L3_1 = 090,
            PRM_L3_2 = 091,
            PRM_L3_3 = 092,
            PRM_L3_4 = 093,
            PRM_L3_5 = 094,
            PRM_L4_0 = 096,
            PRM_L4_1 = 097,
            PRM_L4_2 = 098,
            PRM_L4_3 = 099,
            PRM_L4_4 = 100,
            PRM_L4_5 = 101,
            PRM_R1_0 = 103,
            PRM_R1_1 = 104,
            PRM_R1_2 = 105,
            PRM_R1_3 = 106,
            PRM_R1_4 = 107,
            PRM_R1_5 = 108,
            PRM_R2_0 = 110,
            PRM_R2_1 = 111,
            PRM_R2_2 = 112,
            PRM_R2_3 = 113,
            PRM_R2_4 = 114,
            PRM_R2_5 = 115,
            PRM_R3_0 = 117,
            PRM_R3_1 = 118,
            PRM_R3_2 = 119,
            PRM_R3_3 = 120,
            PRM_R3_4 = 121,
            PRM_R3_5 = 122,
            PRM_R4_0 = 124,
            PRM_R4_1 = 125,
            PRM_R4_2 = 126,
            PRM_R4_3 = 127,
            PRM_R4_4 = 128,
            PRM_R4_5 = 129,
            PRM_L1_P = 130,
            PRM_L2_P = 131,
            PRM_L3_P = 132,
            PRM_L4_P = 133,
            PRM_R1_P = 134,
            PRM_R2_P = 135,
            PRM_R3_P = 136,
            PRM_R4_P = 137,
            PRM_EG_PITCH_RANGE = 138,
            PRM_EG_PITCH_RANGE_VELO = 139,
            PRM_RATE_KEY0 = 140,
            PRM_RATE_KEY1 = 141,
            PRM_RATE_KEY2 = 142,
            PRM_RATE_KEY3 = 143,
            PRM_RATE_KEY4 = 144,
            PRM_RATE_KEY5 = 145,
            PRM_RATE_KEYP = 146,
            PRM_LFO_PITCH_DEPTH = 149,
            PRM_LFO_AMP_DEPTH = 150,
            PRM_LFO_SPEED = 151,
            PRM_LFO_SYNC = 152,
            PRM_LFO_WAVE = 153,
            PRM_LFO_FADE = 154,
            PRM_LFO_PITCH_DEPTH_WHEEL = 155,
            PRM_LFO_AMP_DEPTH_WHEEL = 156,
            PRM_LFO_PITCH_DEPTH_AFTER = 157,
            PRM_LFO_AMP_DEPTH_AFTER = 158,
            PRM_LFO_AMS0 = 159,
            PRM_LFO_AMS1 = 160,
            PRM_LFO_AMS2 = 161,
            PRM_LFO_AMS3 = 162,
            PRM_LFO_AMS4 = 163,
            PRM_LFO_AMS5 = 164,
            PRM_BEND_RANGE_UP = 172,
            PRM_BEND_RANGE_DN = 173,
            PRM_TRANSPOSE = 174,
            PRM_VOLUME = 180,
            PRM_L0_0 = 181,
            PRM_L0_1 = 182,
            PRM_L0_2 = 183,
            PRM_L0_3 = 184,
            PRM_L0_4 = 185,
            PRM_L0_5 = 186,
            PRM_R0_0 = 187,
            PRM_R0_1 = 188,
            PRM_R0_2 = 189,
            PRM_R0_3 = 190,
            PRM_R0_4 = 191,
            PRM_R0_5 = 192,
            PRM_L5_0 = 193,
            PRM_L5_1 = 194,
            PRM_L5_2 = 195,
            PRM_L5_3 = 196,
            PRM_L5_4 = 197,
            PRM_L5_5 = 198,
            PRM_R5_0 = 199,
            PRM_R5_1 = 200,
            PRM_R5_2 = 201,
            PRM_R5_3 = 202,
            PRM_R5_4 = 203,
            PRM_R5_5 = 204,
            PRM_L0_P = 205,
            PRM_R0_P = 206,
            PRM_L5_P = 207,
            PRM_R5_P = 208,
            PRM_LFO_PITCH_DEPTH_BREATH = 209,
            PRM_LFO_AMP_DEPTH_BREATH = 210,
            PRM_LFO_PITCH_DEPTH_FOOT = 211,
            PRM_LFO_AMP_DEPTH_FOOT = 212,
            PRM_VOLUME_DEPTH_AFTER = 213,
            PRM_VOLUME_DEPTH_WHEEL = 214,
            PRM_VOLUME_DEPTH_BREATH = 215,
            PRM_VOLUME_DEPTH_FOOT = 216,
            PRM_PITCH_DEPTH_AFTER = 217,
            PRM_PITCH_DEPTH_BREATH = 218,
            PRM_PITCH_DEPTH_FOOT = 219,
            PRM_PITCH_DEPTH_RND = 220,
            PRM_PAN = 221,
            PRM_LFO_PMS0 = 222,
            PRM_LFO_PMS1 = 223,
            PRM_LFO_PMS2 = 224,
            PRM_LFO_PMS3 = 225,
            PRM_LFO_PMS4 = 226,
            PRM_LFO_PMS5 = 227,
            PRM_LEGATO = 228,
            PRM_PORTA_MODE = 229,
            PRM_PORTA_TIME = 230,
            PRM_WAVEFORM0 = 236,
            PRM_WAVEFORM1 = 237,
            PRM_WAVEFORM2 = 238,
            PRM_WAVEFORM3 = 239,
            PRM_WAVEFORM4 = 240,
            PRM_WAVEFORM5 = 241,
            PRM_VELO_OFFSET = 242,
            PRM_VELO_CURVE = 243,
            PRM_EG_LOOP = 244,
            PRM_EG_LOOP_SEG = 245,
            PRM_EG_RESTART = 246,
            PRM_TUNING = 251,
            PRM_LEVEL0_L = 256,
            PRM_LEVEL0_R = 257,
            PRM_LEVEL1_L = 258,
            PRM_LEVEL1_R = 259,
            PRM_LEVEL2_L = 260,
            PRM_LEVEL2_R = 261,
            PRM_LEVEL3_L = 262,
            PRM_LEVEL3_R = 263,
            PRM_LEVEL4_L = 264,
            PRM_LEVEL4_R = 265,
            PRM_LEVEL5_L = 266,
            PRM_LEVEL5_R = 267,
            PRM_WAVEFORM2_0 = 268,
            PRM_WAVEFORM2_1 = 269,
            PRM_WAVEFORM2_2 = 270,
            PRM_WAVEFORM2_3 = 271,
            PRM_WAVEFORM2_4 = 272,
            PRM_WAVEFORM2_5 = 273,
            PRM_WMODE0 = 274,
            PRM_WMODE1 = 275,
            PRM_WMODE2 = 276,
            PRM_WMODE3 = 277,
            PRM_WMODE4 = 278,
            PRM_WMODE5 = 279,
            PRM_WRATIO0 = 280,
            PRM_WRATIO1 = 281,
            PRM_WRATIO2 = 282,
            PRM_WRATIO3 = 283,
            PRM_WRATIO4 = 284,
            PRM_WRATIO5 = 285,
            PRM_OSC_PHASE0 = 286,
            PRM_OSC_PHASE1 = 287,
            PRM_OSC_PHASE2 = 288,
            PRM_OSC_PHASE3 = 289,
            PRM_OSC_PHASE4 = 290,
            PRM_OSC_PHASE5 = 291,
            PRM_SDLY_DRY = 300,
            PRM_SDLY_WET = 301,
            PRM_SDLY_MODE = 302,
            PRM_SDLY_TIME = 303,
            PRM_SDLY_FEEDBACK = 304,
            PRM_SDLY_FEEDLO = 305,
            PRM_SDLY_FEEDHI = 306,
            PRM_SDLY_TEMPO = 307,
            PRM_SDLY_NUM = 308,
            PRM_SDLY_DEN = 309,
            PRM_PHASER_DRY = 310,
            PRM_PHASER_WET = 311,
            PRM_PHASER_MODE = 312,
            PRM_PHASER_DEPTH = 313,
            PRM_PHASER_SPEED = 314,
            PRM_PHASER_FEEDBACK = 315,
            PRM_PHASER_OFFSET = 316,
            PRM_PHASER_STAGES = 317,
            PRM_PHASER_PHASE = 318,
            PRM_PHASER_WAVEFORM = 319,
            PRM_FILTER_LO = 320,
            PRM_FILTER_HI = 321,
            PRM_AM_SPEED = 330,
            PRM_AM_RANGE = 331,
            PRM_AM_DEPTH = 332,
            PRM_AM_PHASE = 333,
            PRM_FIR_IMPULSE = 340,
            PRM_WAVESHAPER_DRY = 350,
            PRM_WAVESHAPER_WET = 351,
            PRM_WAVESHAPER_GAIN_PRE = 352,
            PRM_WAVESHAPER_GAIN_POST = 353,
            PRM_WAVESHAPER_SHAPE = 354,
            PRM_CHORUS_DRY = 360,
            PRM_CHORUS_WET = 361,
            PRM_CHORUS_MODE = 362,
            PRM_CHORUS_SPEED = 363,
            PRM_CHORUS_DEPTH = 364,
            PRM_CHORUS_FEEDBACK = 365,
            PRM_CHORUS_PHASE = 366,
            PRM_DECIMATOR_DEPTH = 370,
            PRM_BITCRUSHER_DEPTH = 380,
            PRM_REVERB_DRY = 390,
            PRM_REVERB_WET = 391,
            PRM_REVERB_MODE = 392,
            PRM_REVERB_DECAY = 393,
            PRM_REVERB_DAMP = 394,
            PRM_REVERB_D0 = 395,
            PRM_REVERB_D1 = 396,
            PRM_REVERB_D2 = 397,
            PRM_FX_ROUTING = 410,
            PRM_OUTPUT_LEVEL = 411,
            PRM_CONTROL_1H = 420,
            PRM_CONTROL_1L = 421,
            PRM_CONTROL_2H = 422,
            PRM_CONTROL_2L = 423,
            PRM_CONTROL_3H = 424,
            PRM_CONTROL_3L = 425,
            PRM_CONTROL_4H = 426,
            PRM_CONTROL_4L = 427,
            PRM_ARP_MODE = 450,
            PRM_ARP_TEMPO = 451,
            PRM_ARP_TEMPO_FINE = 452,
            PRM_ARP_DIVISION = 453,
            PRM_ARP_OCTAVES = 454
        }
        #endregion

        public override string ToString() => Name;

        #region Methods
        public string Name { get; set; }
        public Guid Id { get; set; }

        public Parameter Parameter(ParamsEnum Name)
        {
            return _params[Name];
        }
        #endregion

    }
}
