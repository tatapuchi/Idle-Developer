﻿using Idle.Resources;
using Idle.Resources.Images;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Views.ValueConverters
{
    public class GradeStringToImageSourceConverter : StringToImageSourceConverterBase
    {
        protected override ImagesProviderBase ImagesProvider => new GradeImagesProvider();

    }
}
