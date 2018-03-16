﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExamTotalTech.Models
{
    public class Response<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
