using System;
using System.Collections.Generic;
using System.Text;

namespace ATGM_DomainServices.Repositories
{
    public interface IGenericRepository<Tentity> where Tentity : class
    {
        /// <summary>
        /// Return all entities
        /// </summary>
        /// <returns>IENumerable containing all entities</returns>
        IEnumerable<Tentity> Index();

        /// <summary>
        /// Get certain entity by ID
        /// </summary>
        /// <param name="ID">ID of said entity</param>
        /// <returns>Entities found</returns>
        Tentity GetByID(int ID);

        /// <summary>
        /// Adds entity to database; immediatly save afterwards
        /// </summary>
        /// <param name="entity">Entity to add to database</param>
        /// <returns>Entity that was added</returns>
        Tentity Add(Tentity entity);

        /// <summary>
        /// Marks entity to add to database, does not immediatly add
        /// Use this function when adding multiple entites, to save the round-trip
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Tentity MarkForAdd(Tentity entity);

        /// <summary>
        /// Updates an entity and saves changes
        /// </summary>
        /// <param name="entity">Entity to update</param>
        /// <returns>Updated entity</returns>
        Tentity Update(Tentity entity);

        /// <summary>
        /// Marks entity for update; does not immediatly update
        /// Use this function when updating multiple entiies; to save round-trip
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Tentity MarkForUpdate(Tentity entity);

        /// <summary>
        /// Delete given entity
        /// </summary>
        /// <param name="entity">entity to delete</param>
        /// <returns>delted entity</returns>
        Tentity Delete(Tentity entity);

        /// <summary>
        /// Marks entity for deletion; does not immediatly remove
        /// Use this function when removing multiple entities.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Tentity MarkForDelete(Tentity entity);

        /// <summary>
        /// Generic SaveChange function;
        /// </summary>
        /// <returns>True if succeeded; false if it hasn't</returns>
        bool SaveChanges();
    }
}
