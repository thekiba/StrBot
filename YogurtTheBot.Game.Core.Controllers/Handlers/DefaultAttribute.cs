using System;

namespace YogurtTheBot.Game.Core.Controllers.Handlers
{
    [AttributeUsage(AttributeTargets.Method)]
    public class DefaultAttribute : Attribute, IHandlerAttribute
    {
        
    }
}