using System.Collections.Generic;
using THSD.TableroEntidadGraficas;

public class entGraficas
{
    public string titulo;
    public double alto;
    public double ancho;
    public string tooltipFormater;
    public string colorFondo;
    public string tituloEjeX;
    public double total;
    public double total2;
    public double anguloInicial = 0; //indica desde donde empieza el primer segmento de la gráfica 
    public bool bDataLabels = true;
    public bool stackLabels = true; //Indica si se despliega una etiqueta al final de las barras apiladas
    public double yAxis_max = 110;
    public string stacking = "normal"; //indica como apilar las series en la grafica
    public List<entSerie> series;
    public List<entCategoria> categorias;
    public List<entPlotBands> plotBands;
    public List<string> valores;
    public List<double> totales;


    public entGraficas()
    {
        anguloInicial = 0;
        plotBands = new List<entPlotBands>();
        plotBands.Add(new entPlotBands() { color = "#F4BBB1", from = 0, to = 60 });
        plotBands.Add(new entPlotBands() { color = "#FAE4BB", from = 60, to = 80 });
        plotBands.Add(new entPlotBands() { color = "#C5DDC0", from = 80, to = 100 });
    }
}