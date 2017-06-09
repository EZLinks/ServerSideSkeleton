using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MFD.Data.Interfaces.Generic;
using ServiceStack.OrmLite;

namespace MFD.Data.Generic
{
    /// <summary>The OrmLiteGenericRepository interface.</summary>
    /// <typeparam name="T">Any reference type.</typeparam>
    public interface IOrmLiteGenericRepository<T> : IGenericRepository<T>
        where T : class
    {
        /// <summary>Gets the query so it could be run later.</summary>
        /// <returns>The <see cref="SqlExpression"/>.</returns>
        SqlExpression<T> GetQuery();
    }

    /// <summary>The orm lite generic repository.</summary>
    /// <typeparam name="T">Any reference entity type.</typeparam>
    public class OrmLiteGenericRepository<T> : IOrmLiteGenericRepository<T>
        where T : class
    {
        /// <summary>The data parameters.</summary>
        private readonly IDataParameters _parameters;

        /// <summary>Initializes a new instance of the <see cref="OrmLiteGenericRepository{T}"/> class.</summary>
        /// <param name="parameters">The parameters.</param>
        public OrmLiteGenericRepository(IDataParameters parameters)
        {
            _parameters = parameters;
        }

        #region IOrmLiteGenericRepository
         
        public SqlExpression<T> GetQuery()
        {
            var factory = this.CreateFactory();
            using (var db = factory.Open())
            {
                return db.From<T>();
            }
        }

        #endregion

        #region IGenericRepository
         
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression)
        {
            var factory = this.CreateFactory();
            using (var db = factory.Open())
            {
                var query = db.From<T>().Where(expression);
                return await db.SingleAsync<T>(query);
            }
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression = null)
        {
            var factory = this.CreateFactory();
            using (var db = factory.Open())
            {
                var query = db.From<T>();

                if (expression != null)
                {
                    query = query.Where(expression);
                }

                return await db.ColumnAsync<T>(query);
            }
        }

        public async Task InsertAsync(T entity)
        {
            var factory = this.CreateFactory();
            using (var db = factory.Open())
            {
                await db.InsertAsync(entity);
            }
        }

        public async Task DeleteAsync(Expression<Func<T, bool>> expression)
        {
            var factory = this.CreateFactory();
            using (var db = factory.Open())
            {
                await db.DeleteAsync(expression);
            }
        }

        public async Task UpdateAsync(T entity, Expression<Func<T, bool>> expression)
        {
            var factory = this.CreateFactory();
            using (var db = factory.Open())
            {
                await db.UpdateAsync(entity, expression);
            }
        }

        #endregion

        #region Protected Methods

        protected OrmLiteConnectionFactory CreateFactory()
        {
            return new OrmLiteConnectionFactory(
                _parameters.ConnectionString,
                SqlServerDialect.Provider);
        }

        #endregion
    }
}