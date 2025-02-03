using Adrian_Hernandez_Bonilla_P1_Ap1.Models;
using System.Linq.Expressions;


namespace Adrian_Hernandez_Bonilla_P1_Ap1.Services
{
    public class Service
    {

        private readonly Contexto _contexto;

        public Service(Contexto contexto)
        {
            _contexto = contexto;
        }

        private async Task<bool> Existe(int Id)
        {
            return await _contexto.modelo.AnyAsync(m => m.Id == Id);

        }

                private async Task<bool> Insertar(Modelo modelo)
        {
            _contexto.modelo.Add(modelo);
            return await _contexto.SaveChangesAsync() > 0;
        }



        private async Task<bool> Modificar(Modelo modelo)
        {
            _contexto.modelo.Update(modelo);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> Guardar(Modelo modelo)
        {
            if (!await Existe(modelo.Id))
            {
                return await Insertar(modelo);
            }
            else
            {
                return await Modificar(modelo);
            }
        }

        public async Task<Modelo> Buscar(int Id)
        {
            return await _contexto.modelo.FirstOrDefaultAsync(m => m.Id == Id);
        }


        public async Task<bool> Eliminar(int Id)
        {
            var tecnico = await _contexto.modelo.FirstOrDefaultAsync(m => m.Id == Id);

            if (tecnico == null) return false;

            _contexto.modelo.Remove(tecnico);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<List<Modelo>> Listar(Expression<Func<Modelo, bool>> criterio)
        {
            return await _contexto.modelo
                .Where(criterio)
                .AsNoTracking()
                .ToListAsync();
        }

    }
}
