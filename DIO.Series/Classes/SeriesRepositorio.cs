using DIO.Series.Serviços;
using DIO.Series.Classes;
using System.Collections.Generic;
using System;

namespace DIO.Series.Classes
{
    public class SeriesRepositorio : Registro<Serie>
    {
        private List<Serie> list = new List<Serie>();

        public void Inserir(Serie objeto){
            list.Add(objeto);
        }

       public void Atualizar(int id, Serie objeto){
           list[id] = objeto;
       }

      public Serie Retornar(int id){
          return list[id];
      }

      public int ProximoId(){
          return list.Count;
      }

      public List<Serie> listar(){
          return list;
      }
      
    }
}