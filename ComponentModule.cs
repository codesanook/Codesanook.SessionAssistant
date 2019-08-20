using System;
using System.Globalization;
using System.Reflection;
using Autofac;

namespace Codesanook.SessionAssistant {
    public class ComponentModule : Autofac.Module {
        protected override void Load(ContainerBuilder builder) {
            RedirectAssembly("Microsoft.Owin.Security", new Version("4.0.0.0"), "31bf3856ad364e35");
        }

        private static void RedirectAssembly(string shortName, Version targetVersion, string publicKeyToken) {
            ResolveEventHandler handler = null;
            handler = (sender, args) => {

                // Use latest strong name & version when trying to load SDK assemblies
                var requestedAssembly = new AssemblyName(args.Name);
                if (requestedAssembly.Name != shortName)
                    return null;

                requestedAssembly.Version = targetVersion;
                requestedAssembly.CultureInfo = CultureInfo.InvariantCulture;
                //For security reasons public key token should match;
                requestedAssembly.SetPublicKeyToken(new AssemblyName("x, PublicKeyToken=" + publicKeyToken).GetPublicKeyToken());
                AppDomain.CurrentDomain.AssemblyResolve -= handler;

                return Assembly.Load(requestedAssembly);
            };

            AppDomain.CurrentDomain.AssemblyResolve += handler;
        }
    }
}