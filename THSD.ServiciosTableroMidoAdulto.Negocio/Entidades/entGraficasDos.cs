using System.Collections.Generic;

/// <summary>
/// Daots referentes a la gráfica
/// </summary>
public class entGraficasDos
{

    /// <summary>
    /// Titulo: a mostrar en la gráfica.
    /// </summary>
    /// <example>
    /// Distribución de edad.
    /// </example>
    public string titulo { get; set; }

    /// <summary>
    /// Alto: se da como el porcentaje del ancho real del gráfico. 
    /// Esto permite preservar la relación de aspecto en todos los tamaños receptivos.
    /// </summary>       
    public double alto { get; set; }

    /// <summary>
    /// Ancho: explícito para el gráfico. Se calcula a partir del ancho de desplazamiento del elemento.
    /// </summary>      
    public double ancho { get; set; }

    /// <summary>
    ///tooltipFormater: Propiedad para asignar el tooltip a la gráfica.
    /// </summary>       
    public string tooltipFormater { get; set; }
    public string toolpointFormat { get; set; }

    /// <summary>
    /// colorFondo: El color de fondo o degradado para el área externa del gráfico
    /// </summary>
    /// <example>
    /// #FFFFFF
    /// </example>
    public string colorFondo { get; set; }

    /// <summary>
    /// tituloEjeX: Texto que aparece en  el eje de la X.
    /// </summary>
    /// <example>
    /// Entidades 
    /// </example>
    public string tituloEjeX { get; set; }

    /// <summary>
    /// anguloInicial: Indica desde donde empieza el primer segmento en la gráfica de dona. 
    /// </summary>
    public double anguloInicial { get; set; }

    /// <summary>
    /// bDataLabels: Opciones para las etiquetas de datos de la serie, que aparecen junto a cada punto de datos.
    /// </summary>
    /// <example>
    /// Pintar el número de adentro de la serie.
    /// </example>
    public bool bDataLabels { get; set; }

    /// <summary>
    /// bStackLabels: Indica si se despliega una etiqueta al final de las barras apiladas.
    /// </summary>       
    public bool bStackLabels { get; set; }

    /// <summary>
    /// yAxisMax: El valor máximo del eje. Si null, el valor máximo se calcula automáticamente.
    /// </summary>   
    public double? yAxisMax { get; set; }

    /// <summary>
    /// stacking: Si se deben apilar los valores de cada serie uno encima del otro. Los valores posibles son undefined deshabilitar, "normal"apilar por valor o "percent".
    /// En el caso del percent las gráficas acumuladas llegan al 100%.
    /// </summary>
    public string stacking { get; set; }

    /// <summary>
    /// plotLines: Un conjunto de líneas que se extienden a través del área de trazado, marcando un valor específico en uno de los ejes.
    /// </summary>
    public List<entPlotLine> plotLines { get; set; }
    public entNavigator navigator { get; set; }
    /// <summary>
    /// Series: Conjunto de datos,todos los datos trazados en un gráfico provienen del objeto de la serie. 
    /// </summary>

    public List<entSerieDos> series { get; set; }

    /// <summary>
    /// categorias: Si hay categorías presentes para el xAxis, se usan nombres en lugar de números para ese eje. 
    /// </summary>
    public List<entCategoriaDos> categorias { get; set; }

    /// <summary>
    /// plotBands: Conjunto de bandas de colores que se extienden a través del área de trazado marcando un intervalo en el eje. 
    /// </summary>       
    public List<entPlotBand> plotBands { get; set; }

    /// <summary>
    /// valores: Es un arreglo de string que los puedes utilizar o no en el pintado de gráfica, regularmente sirve para los formatter. 
    /// </summary>        
    public List<string> valores { get; set; }

    /// <summary>
    /// totales: Es un arreglo de doubles que se pueden utilizar o no en pintado de gráfica de pirámide.  
    /// </summary>       
    public List<double> totales { get; set; }

    /// <summary>
    /// tamFteDona: Es el tamaño de fuente del centro de la gráfica de dona.   
    /// </summary>
    /// <example>
    ///  1.7 rem  
    /// </example>
    public double tamFteDona { get; set; }

    /// <summary>
    /// factorEjeY:Es para calcular el fondo del eje de las y en a gráfica de pirámide (solo para la gráfica de pirámide).
    /// </summary>      
    public double factorEjeY { get; set; }

    /// <summary>
    /// colorEjeY:Es el color del eje de las y en la gráfica de pirámide
    /// </summary>
    public string colorEjeY { get; set; }

    /// <summary>
    /// legendEnabled: Habilita o deshabilita la leyenda. También hay una opción específica de serie, showInLegend , que puede ocultar la serie de la leyenda. En algunos tipos de series, esto es falsepredeterminado, por lo que debe establecerse trueen para mostrar la leyenda de la serie.
    /// </summary>
    public bool legendEnabled { get; set; }

    /// <summary>
    /// xAxisLabelsRotation: Rotación de las categorías en el eje de la X.
    /// </summary>      
    public double xAxisLabelsRotation { get; set; }

    /// <summary>
    /// stackLabelsFormatter: Devolución de llamada para formatear la etiqueta.
    /// </summary>   
    public string stackLabelsFormatter { get; set; }

    /// <summary>
    /// pointWidth: Valor de píxel que especifica un ancho fijo para cada columna o barra. Cuando null, el ancho se calcula a partir de pointPaddingy
    /// </summary>
    public double pointWidth { get; set; }

    /// <summary>
    /// dataLabelsFormatter:Una cadena de formato para la etiqueta de datos. Las variables disponibles son las mismas que para formatter.
    /// </summary>
    public string dataLabelsFormatter { get; set; }

    /// <summary>
    /// yAxisMin:El valor mínimo del eje. Si null el valor mínimo se calcula automáticamente.
    /// </summary>       
    public double yAxisMin { get; set; }

    /// <summary>
    /// yGridLineWidth:El ancho de las líneas de la cuadrícula que extiende los ticks a través del área de trazado.
    /// </summary>
    /// <example>
    /// yGridLineWidth = 1 para mostrarlas 0 para ocultarlas.
    /// </example>
    public double yGridLineWidth { get; set; }

    /// <summary>
    /// tituloEjeY:Texto que aparece en el eje de las y.
    /// </summary>
    public string tituloEjeY { get; set; }

    /// <summary>
    /// bYaxisLabels:Para determinar si se pintan las etiquetas. 
    /// </summary>
    public bool bYaxisLabels { get; set; }

    /// <summary>
    /// dataLabelsAlign:La alineación de la etiqueta de datos en comparación con el punto. 
    /// Si right, el lado derecho de la etiqueta debe tocar el punto.
    ///Para los puntos con una extensión, como las columnas, las alineaciones también dictan cómo alinearlo dentro del cuadro, como se indica con la opción interior. Puede ser uno de “left”, “centro”, “right”. 
    /// </summary>         
    public string dataLabelsAlign { get; set; }
    /// <summary>
    /// bxAxisReversed:Invertir el eje para que el número más alto esté más cerca del origen. Si el gráfico se invierte, el eje x se invierte de manera predeterminada.
    /// </summary>       
    public bool bxAxisReversed { get; set; }
    /// <summary>
    /// innerSize tamaño del radio interno Dona
    /// </summary>
    public string innerSize { get; set; }
    /// <summary>
    /// mostrarTotal: se muestra defaul 45% o no se muestra  0% el texto de la grafica de pastel.
    /// </summary>
    public bool mostrarTotal { get; set; }
    /// <summary>
    /// distance: distancia que hay de los porcentajes, para sacarlos afuera o dejarlos adentro. 
    /// </summary>
    public int distance { get; set; }

    /// <summary>
    /// Constructor de entGraficas se declara para inicializar las variables.
    /// </summary>       
    public entGraficasDos()
    {
        anguloInicial = 0;
        bDataLabels = true;
        bStackLabels = true;
        yAxisMax = 110;
        stacking = "normal";
        tamFteDona = 1.7;
        colorEjeY = "#d5d5d5";
        factorEjeY = 60;
        legendEnabled = true;
        xAxisLabelsRotation = 0;
        pointWidth = 12;
        yAxisMin = 0;
        yGridLineWidth = 0;
        tituloEjeX = "";
        tituloEjeY = "";
        bYaxisLabels = true;
        dataLabelsAlign = "center";
        bxAxisReversed = false;
        navigator = new entNavigator();
        innerSize = "40%";
        mostrarTotal = true;
        distance = -35;


    }
}
public class entSerieDos
{


    /// <summary>
    /// name:El nombre de la serie como se muestra en la leyenda.
    /// </summary>     
    public string name { get; set; }

    /// <summary>
    /// data:El módulo de datos proporciona una interfaz simplificada para agregar datos a un gráfico.
    /// </summary>       
    public List<entPuntoDos> data { get; set; }

    /// <summary>
    /// color:Es un arreglo que  contiene los colores predeterminados para la serie del gráfico.      
    /// </summary> 
    public string color { get; set; }

    /// <summary>
    /// showInLegend: Mostrar esta serie particular o tipo de serie en la leyenda.
    /// Las series independientes se muestran en la leyenda de forma predeterminada, y las series vinculadas no.
    /// </summary>     
    public bool showInLegend { get; set; }

    /// <summary>
    /// type: Diferentes tipos de gráficos para que los datos se puedan mostrar de manera significativa.      
    /// </summary>       
    /// <example>
    /// Tipos de gráfico de “línea”, “spline”, “área”, columna”, “barra”, “pastel”, “dispersión”, “indicador”, “rango de área”, “rango de líneas” y ”rango de columna”.      
    /// </example>
    public string type { get; set; }

    /// <summary>
    /// marker: Opciones para los marcadores de puntos de series tipo línea.      
    /// </summary>      
    public entMarker marker { get; set; }
    /// <summary>
    /// lineWidth: Ancho de la  línea.      
    /// </summary> 
    public double lineWidth { get; set; }

    public entNavigator navigator { get; set; }
    public bool showInNavigator { get; set; }
    public double? min { get; set; }
    public double? max { get; set; }
    public double? yGridLineWidth { get; set; }
    public string tituloEjeX { get; set; }

}

public class entNavigator
{
    public entSeries series { get; set; }
    public class entSeries
    {
        public string stacking { get; set; }
        public string type { get; set; }
        public string name { get; set; }
    }

}
public class entMarker
{
    /// <summary>
    /// lineWidth: Ancho de píxeles de la línea del gráfico.     
    /// </summary> 
    public double lineWidth { get; set; }

    /// <summary>
    /// lineColor:El color principal de la serie.
    /// En las series de tipo de línea, se aplica a la línea y a los marcadores de puntos a menos que se especifique lo contrario.    
    /// </summary>       

    public string lineColor { get; set; }

    /// <summary>
    /// radius: El radio del marcador de punto.       
    /// </summary>      
    public double radius { get; set; }
    public string fillColor { get; set; }

    /// <summary>
    /// zIndex: El índice z de la línea de trazado dentro del gráfico.       
    /// </summary>
    public double zIndex { get; set; }

}
public class entPuntoDos
{
    /// <summary>
    /// y: El valor del punto.       
    /// </summary> 
    public double y { get; set; }

    /// <summary>
    /// name: Nombre del punto.       
    /// </summary> 
    public string name { get; set; }

    /// <summary>
    /// color: contiene los colores  para la serie del gráfico.       
    /// </summary> 
    public string color { get; set; }

    /// <summary>
    /// valorY: Los valores que se mandan a llamar para la serie del  gráfico.       
    /// </summary> 
    public double valorY { get; set; }

    /// <summary>
    /// id: Se usa para traer el nombre de una región.      
    /// </summary>
    public string id { get; set; }

    /// <summary>
    /// high: Es el valor donde termina la barra en la gráfica de pirámide.         
    /// </summary>
    public double high { get; set; }

    /// <summary>
    /// low: Es el valor donde inicia la barra en la gráfica de pirámide.      
    /// </summary>
    public double low { get; set; }

    /// <summary>
    ///  sliced: Se muestra un corte de corte desde el centro.       
    /// </summary>
    public bool sliced { get; set; }
}
public class entCategoriaDos
{
    /// <summary>
    ///  nombre: Nombre de las categorías.       
    /// </summary>
    public string nombre { get; set; }
}
public class entPlotBand
{
    /// <summary>
    /// color: Color del borde para la banda de trama.       
    /// </summary>
    public string color;

    /// <summary>
    /// from: Ancho de borde para la banda de trazado.       
    /// </summary>
    public double from;

    /// <summary>
    /// to: La posición final de la banda de trazado en unidades de eje.       
    /// </summary>
    public double to;



}

public class entPlotLine
{
    /// <summary>
    /// color: El color de la línea.       
    /// </summary>
    public string color;

    /// <summary>
    /// width: El ancho o grosor de la línea de trazado.       
    /// </summary>
    public double width;

    /// <summary>
    /// value: La posición de la línea en unidades de eje.       
    /// </summary>
    public double value;

    /// <summary>
    /// zIndex: El índice z de la línea de trazado dentro del gráfico.       
    /// </summary>
    public double zIndex;
}


public class entMapas
{
    /// <summary>
    /// tooltipFormater:Propiedad para asignar el tooltip a la gráfica.       
    /// </summary>
    public string tooltipFormater { get; set; }
    /// <summary>
    /// Series: Conjunto de datos,todos los datos trazados en un gráfico provienen del objeto de la serie.        
    /// </summary>
    public List<entSerieMapa> series { get; set; }
}
public class entSerieMapa
{
    /// <summary>
    /// name: Nombre de la serie.        
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// color: color de la serie.        
    /// </summary>
    public string color { get; set; }

    /// <summary>
    /// data: Proporciona una interfaz simplificada para agregar datos a un gráfico.        
    /// </summary>
    public List<entPuntoMapa> data { get; set; }
    /// <summary>
    ///bDataLabels: Es para los nombres de los estados.
    /// </summary>

    public bool bDataLabels { get; set; }

    public entSerieMapa()
    {
        bDataLabels = true;
    }
}
public class entPuntoMapa
{
    /// <summary>
    /// hc_key: Nombre de las entidades del gráfico.        
    /// </summary>
    public string hc_key { get; set; }

    /// <summary>
    /// color: Color de los puntos  del gráfico.        
    /// </summary>
    public string color { get; set; }

    /// <summary>
    /// value: La posición del punto  en unidades del eje.        
    /// </summary>
    public double value { get; set; }
    public string name { get; set; }
}