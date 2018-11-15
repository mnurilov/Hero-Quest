﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class MessageEventArgs : System.EventArgs
    {
        public string Message;

        public MessageEventArgs(string message)
        {
            Message = message;
        }
    }
}
