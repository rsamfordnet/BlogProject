﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Enums
{
    public enum ModerationType
    {
        [Description("Political propaganda")]
        Polictical,
        [Description("Offensive language")]
        Language,
        [Description("Drug references")]
        Drugs,
        [Description("Threatening speech")]
        Threatening,
        [Description("Sexual content")]
        Sexual,
        [Description("Hate Speech")]
        HateSpeech,
        [Description("Targeted shaming ")]
        Shaming
    }
}
