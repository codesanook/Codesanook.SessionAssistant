using System.Collections.Generic;
using Orchard.Environment.Extensions.Models;
using Orchard.Security.Permissions;

namespace Codesanook.SessionAssistant {
    public class Permissions : IPermissionProvider {
        public static readonly Permission PushMessage = new Permission {
            Description = "Push message to client",
            Name = nameof(PushMessage)
        };

        public virtual Feature Feature { get; set; }

        public IEnumerable<Permission> GetPermissions() {
            return new[] {
                PushMessage,
            };
        }

        public IEnumerable<PermissionStereotype> GetDefaultStereotypes() {
            return new[] {
                new PermissionStereotype {
                    Name = "Administrator",
                    Permissions = new[] {PushMessage}
                },
            };
        }
    }
}