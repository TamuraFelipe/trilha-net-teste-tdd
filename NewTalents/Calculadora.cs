using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> historico;
        public Calculadora()
        {
            historico = new List<string>();
        }
        public int Somar(int num1, int num2)
        {
            var result = num1 + num2;
            historico.Insert(0, $"Resultado: {result}");
            return result;
        }
        public int Subtrair(int num1, int num2)
        {
            var result = num1 - num2;
            historico.Insert(0, $"Resultado: {result}");
            return result;
        }
        public int Multiplicar(int num1, int num2)
        {
            var result = num1 * num2;
            historico.Insert(0, $"Resultado: {result}");
            return result;
        }
        public int Dividir(int num1, int num2)
        {
            var result = num1 / num2;
            historico.Insert(0, $"Resultado: {result}");
            return result;
        }
        public List<string> Historico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico; 
        }

    }
}
