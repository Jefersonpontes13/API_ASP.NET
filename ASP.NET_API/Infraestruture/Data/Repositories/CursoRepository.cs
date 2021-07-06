using ASP.NET_API.Business.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ASP.NET_API.Business.Repositories;
using ASP.NET_API.Infraestruture.Data;

namespace ASP.NET_API.Infraestruture.Data.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class CursoRepository : ICursoRepository
    {
        private readonly CursoDbContext _contexto;
        
        /// <summary>
        /// 
        /// </summary>
        public CursoRepository(CursoDbContext contexto)
        {
            _contexto = contexto;
        }
        /// <summary>
        /// 
        /// </summary>
        public void Adicionar(Curso curso)
        {
            _contexto.Curso.Add(curso);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Commit()
        {
            _contexto.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        public IList<Curso> ObterPorUsuario(int codigoUsuario)
        {
            return _contexto.Curso.Include(i => i.Usuario).Where(w => w.CodigoUsuario == codigoUsuario).ToList();
        }
    }
}
