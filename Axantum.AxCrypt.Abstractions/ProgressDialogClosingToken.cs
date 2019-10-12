﻿using Axantum.AxCrypt.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axantum.AxCrypt.Abstractions
{
    public class ProgressDialogClosingToken : Releaser
    {
        public void CloseDialog()
        {
            Dispose();
        }
    }
}