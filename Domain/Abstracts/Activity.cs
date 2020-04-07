using Domain.Base;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Abstracts
{
    public abstract class Activity : Entity<int>, IActivity
    {
    }
}
