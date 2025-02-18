using Adrian_Hernandez_Bonilla_P1_Ap1.Context;
using Adrian_Hernandez_Bonilla_P1_Ap1.Models;
using System.Linq.Expressions;


namespace Adrian_Hernandez_Bonilla_P1_Ap1.Services
{
    public class AportesService
    {

        private readonly Contexto _contexto;

        public AportesService(Contexto contexto)
        {
            _contexto = contexto;
        }



        public async Task<bool> Guardar(Aportes aportes)
        {

            if (!await Existe(aportes.AporteId))


            {

                return await Insertar(aportes);


            }


            else
            {
                return await Modificar(aportes);

            }

        }



        public async Task<bool> Existe(int AporteId)
        {

            return await _contexto.aportes.AnyAsync(a => a.AporteId == AporteId);    

        }



        public async Task<bool> Insertar(Aportes aportes)
        {

            _contexto.aportes.Add(aportes);
            return await _contexto.SaveChangesAsync() > 0;  

        }



        public async Task<bool> Modificar(Aportes aportes)

        {

            _contexto.aportes.Update(aportes);
            return await _contexto.SaveChangesAsync() > 0;

        }

        public async Task<Aportes> Buscar(int AporteId)
        {
            return await _contexto.aportes.FirstOrDefaultAsync(a => a.AporteId == AporteId);
        }



        public async Task<bool> Eliminar(int AporteId)
        {


            var aportes = await _contexto.aportes.FirstOrDefaultAsync(a => a.AporteId == AporteId);
            if (aportes == null) return await Insertar(aportes);


            _contexto.Remove(aportes);
            return await _contexto.SaveChangesAsync() > 0;


        }




        public async Task<List<Aportes>> Listar(Expression<Func<Aportes, bool>> criterio)
        {


            return await _contexto.aportes
              .Where(criterio)
               .AsNoTracking()
               .ToListAsync();

        }


    }



}
