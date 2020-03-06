using Autofac;
using YogurtTheBot.Game.Core.Controllers.Abstractions;

namespace YogurtTheBot.Game.Core.Controllers.Autofac
{
    public class AutofacControllersProvider : IControllersProvider
    {
        internal const string MainControllerAutofacName = "MAIN_CONTROLLER_NAME";
        private readonly ILifetimeScope _scope;

        public AutofacControllersProvider(ILifetimeScope scope)
        {
            _scope = scope;
        }

        public IController ResolveControllerByName(string s) => _scope.ResolveNamed<IController>(s);

        public string MainControllerName => MainControllerAutofacName;
    }
}