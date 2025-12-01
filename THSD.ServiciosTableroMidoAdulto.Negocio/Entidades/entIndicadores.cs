using System.Collections.Generic;
using THSD.TableroEntidadGraficas;

public class entIndicadores
{

    public List<string> Totales { get; set; }
    public List<string> TotalValoraciones { get; set; }

    public List<entGraficasDos> GraficaDistribucionSexoEdad { get; set; }
    public entGraficas GraficaFactoresRiesgo { get; set; }
    public entGraficas GraficaObesidad { get; set; }
    public entGraficas GraficaHipertension { get; set; }
    public entGraficas GraficaDiabetes { get; set; }


    public List<string> DebugInfo { get; set; }



}