using OnionCrafter.Entity.Base;
using OnionCrafter.Util.Object.Auditable;

namespace OnionCrafter.Entity.Auditable.Base
{
    /// <summary>
    /// Represents an auditable entity with a specific key type.
    /// </summary>
    /// <typeparam name="TKey">The type of the entity's key.</typeparam>
    public interface IAccessAuditableEntity<TKey> :
        IEntity<TKey>,
        IAccessAuditable
        where TKey : notnull, IEquatable<TKey>, IComparable<TKey>
    {
    }

    /// <summary>
    /// Represents an auditable entity with a default key type of <see cref="string"/>.
    /// </summary>
    public interface IAccessAuditableEntity :
        IEntity,
        IAccessAuditableEntity<string>
    {
    }
}