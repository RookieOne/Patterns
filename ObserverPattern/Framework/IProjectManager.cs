using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.Framework
{
    public interface IProjectManager : ISullyObserver
    {
        string Name { get; }
    }
}
