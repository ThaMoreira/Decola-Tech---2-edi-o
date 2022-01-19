using System;
using System.Collections.Generic;
using Dio.Series.Interface;

namespace Dio.Series
{
    public class SerieRepositorio : IRepositorio<Series>
    {

        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie entidade){
            listaSerie[id] = entidade;
        }
        public void Exclui(int id, Serie entidade){
            listaSerie[id].Excluir();
        }
        public void Insere(int id, Serie entidade){
            listaSerie.Add(entidade);
        }
        public List<Serie> Lista(){
            return listaSerie;
        }
        public int ProximoId(int id, Serie entidade){
            return listaSerie.Count;
        }
        public int RetornaPorId(int id, Serie entidade){
            return listaSeri[id];
        }

    }
}