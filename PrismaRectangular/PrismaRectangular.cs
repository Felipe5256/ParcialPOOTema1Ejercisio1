using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismaRectangularRecto
{
    public class PrismaRectangular
    {
        public int _altura { get; set; }
        public int _ancho { get; set; }
        public int _largo { get; set; }

        public PrismaRectangular(int altura, int ancho ,int largo)
        {
            _largo = largo;
            _altura = altura;   
            _ancho = ancho;
        }

        public int AreaBase => _largo * _ancho;

        public int AreaAltura => _altura*_ancho;

        public int AreaAncho => _altura * _largo;

        public double GetArea => 2 * (AreaBase+AreaAltura+AreaAncho);

        public double GetVolumen => _largo * _ancho * _altura;

        public double GetDiagrama => Math.Sqrt(Math.Pow(_largo,2)+Math.Pow(_ancho,2)+Math.Pow(_altura,2));

        public string MostrarDatos()
        {
            StringBuilder sr = new StringBuilder();
            sr.AppendLine("PrismaRectangularRecto");
            sr.AppendLine($"Area Base:{AreaBase}");
            sr.AppendLine($"Area Altura:{AreaAltura}");
            sr.AppendLine($"Area Ancho:{AreaAncho}");
            sr.AppendLine($"Area:{GetArea}");
            sr.AppendLine($"Volumen:{GetVolumen}");
            sr.AppendLine($"Diagrama:{GetDiagrama}");
            return sr.ToString();
        }




    }
}
