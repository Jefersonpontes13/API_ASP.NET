using ASP.NET_API.Business.Entities;
using System.Collections.Generic;

namespace ASP.NET_API.Business.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICursoRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="curso"></param>
        void Adicionar(Curso curso);
        /// <summary>
        /// 
        /// </summary>
        void Commit();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigoUsuario"></param>
        /// <returns></returns>
        IList<Curso> ObterPorUsuario(int codigoUsuario);
    }
}
