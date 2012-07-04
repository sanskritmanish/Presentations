﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using FluentValidation.Attributes;
using TodoMVC.Models.Validators;

namespace TodoMVC.Models
{
    /// <remarks>
    ///  Yes, this is a very anemic model. :(
    /// </remarks>
    [DebuggerDisplay("{Name}")]
    [Validator(typeof(TaskValidator))]
    public class Task
    {
        public virtual int? Id { get; set; }
        public virtual string Name { get; set; }

        //public virtual bool IsCompleted { get; set; }

        public virtual TaskPriority Priority { get; set; }
        public virtual TaskStatus Status { get; set; }
    }
}