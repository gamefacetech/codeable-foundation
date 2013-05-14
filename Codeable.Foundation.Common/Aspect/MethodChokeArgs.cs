﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Codeable.Foundation.Common.Aspect
{
    public class MethodChokeArgs : EventArgs
    {
        [DebuggerNonUserCode]
        public MethodChokeArgs()
        {
        }
        [DebuggerNonUserCode]
        public MethodChokeArgs(string methodName)
        {
            this.MethodName = methodName;
        }
        [DebuggerNonUserCode]
        public MethodChokeArgs(string methodName, object result)
        {
            this.MethodName = methodName;
            this.Result = result;
        }
        [DebuggerNonUserCode]
        public MethodChokeArgs(object[] parameters, string methodName)
        {
            this.MethodName = methodName;
            this.Parameters = parameters;
        }
        [DebuggerNonUserCode]
        public MethodChokeArgs(object[] parameters, string methodName, object result)
        {
            this.MethodName = methodName;
            this.Parameters = parameters;
            this.Result = result;
        }
        public string MethodName { get; set; }
        public object[] Parameters { get; set; }
        public object Result { get; set; }
    }
}
