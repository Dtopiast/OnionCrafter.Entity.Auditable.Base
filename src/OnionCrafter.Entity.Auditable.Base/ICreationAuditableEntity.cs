using OnionCrafter.Entity.Base;
using OnionCrafter.Util.Object.Auditable;

namespace OnionCrafter.Entity.Auditable.Base
{
    /// <summary>
    /// Represents an auditable entity with a specific key type that includes creation audit information.
    /// </summary>
    /// <typeparam name="TKey">The type of the entity's key.</typeparam>
    public interface ICreationAuditableEntity<TKey> :
        IEntity<TKey>,
        ICreationAuditable
        where TKey : notnull, IEquatable<TKey>, IComparable<TKey>
    {
    }

    /// <summary>
    /// Represents an auditable entity with a default key type of <see cref="string"/> that includes creation audit information.
    /// </summary>
    public interface ICreationAuditableEntity :
        IEntity,
        ICreationAuditableEntity<string>
    {
    }
}