using Adrian_Hernandez_Bonilla_P1_Ap1.Context;
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


        public async Task<bool> Guardar(Modelo modelo)
        {
            return null;
        }



        private async Task<bool> Existe(int Id)
        {
            return null;
        }


        private async Task<bool> Insertar(Modelo modelo)
        {
            return null;
        }


        private async Task<bool> Modificar(Modelo modelo)
        {
            return null;
        }



        public async Task<Modelo> Buscar(int Id)
        {
            return null;
        }


        public async Task<bool> Eliminar(int Id)
        {
            return null;

        }




    }

}