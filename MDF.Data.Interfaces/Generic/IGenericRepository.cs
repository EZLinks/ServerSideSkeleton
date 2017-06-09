using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MFD.Data.Interfaces.Generic
{
    /// <summary>The GenericRepository interface.</summary>
    /// <typeparam name="T">Any entoty class type.</typeparam>
    public interface IGenericRepository<T>
        where T : class
    {
        /// <summary>Gets the single entity async.</summary>
        /// <param name="expression">The expression.</param>
        /// <returns>The <see cref="T"/>.</returns>
        Task<T> GetSingleAsync(Expression<Func<T, bool>> expression);

        /// <summary>Gets list of entities async.</summary>
        /// <param name="expression">The expression.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression = null);

        /// <summary>Inserts the entity async.</summary>
        /// <param name="entity">The entity.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task InsertAsync(T entity);

        /// <summary>Deletes the entity async.</summary>
        /// <param name="expression">The expression.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task DeleteAsync(Expression<Func<T, bool>> expression);

        /// <summary>Updates entity async.</summary>
        /// <param name="entity">The entity.</param>
        /// <param name="expression">The expression.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task UpdateAsync(T entity, Expression<Func<T, bool>> expression);
    }
}