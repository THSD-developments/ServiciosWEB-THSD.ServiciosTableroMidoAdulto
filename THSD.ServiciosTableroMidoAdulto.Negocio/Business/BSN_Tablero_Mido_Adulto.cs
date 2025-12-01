using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using THSD.ServiciosTableroMidoAdulto.Negocio.Conexion;
using THSD.ServiciosTableroMidoAdulto.Negocio.Entidades;
using THSD.TableroEntidadGraficas;

namespace THSD.ServiciosTableroMidoAdulto.Negocio.Business
{
    public class BSN_Tablero_Mido_Adulto
    {
        //Cadena de Conexión
        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["tableroMIDOweb"].ConnectionString);

        public BSN_Tablero_Mido_Adulto()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        public List<entElementoCombo> obtenerCboPeriodo(string PsCveAlcance)
        {
            List<entElementoCombo> LaoValores = new List<entElementoCombo>();
            DataTable sqlDT = new DataTable();
            try
            {

                List<SqlParameter> ParametersSQL = new List<SqlParameter>();
                ParametersSQL.Add(new SqlParameter("@PnCveAlcance", PsCveAlcance));
                sqlDT = new HelperSQL().ExecStoreProcedure("spObtenerCboPeriodoAdulto", ParametersSQL);
                if (sqlDT != null)
                {
                    foreach (DataRow dr in sqlDT.Rows)
                    {
                        entElementoCombo LoValor = new entElementoCombo();
                        LoValor.clave = dr["clave"].ToString();
                        LoValor.descripcion = dr["descripcion"].ToString();
                        LaoValores.Add(LoValor);
                    }
                }
            }
            catch (Exception ex)
            {
                new HelperLog().LogError(ex.Message, "spObtenerCboPeriodoAdulto");
            }
            return LaoValores;
        }


        public List<entElementoCombo> obtenerCboPeriodoDesdeHasta(string PsCveAlcance, string PnCvePeriodoDesde)
        {
            List<entElementoCombo> LaoValores = new List<entElementoCombo>();
            DataTable sqlDT = new DataTable();
            try
            {

                List<SqlParameter> ParametersSQL = new List<SqlParameter>();
                ParametersSQL.Add(new SqlParameter("@PnCveAlcance", PsCveAlcance));
                ParametersSQL.Add(new SqlParameter("@PnCvePeriodoDesde", PnCvePeriodoDesde));
                sqlDT = new HelperSQL().ExecStoreProcedure("spObtenerCboPeriodoDesdeHastaAdulto", ParametersSQL);
                if (sqlDT != null)
                {
                    foreach (DataRow dr in sqlDT.Rows)
                    {
                        entElementoCombo LoValor = new entElementoCombo();
                        LoValor.clave = dr["clave"].ToString();
                        LoValor.descripcion = dr["descripcion"].ToString();
                        LaoValores.Add(LoValor);
                    }
                }
            }
            catch (Exception ex)
            {
                new HelperLog().LogError(ex.Message, "spObtenerCboPeriodoDesdeHastaAdulto");
            }
            return LaoValores;
        }


        public List<entElementoCombo> obtenerCboInstitucion(string PsCvePeriodo, string PsCveAlcance, string PnCvePeriodoDesde)
        {
            List<entElementoCombo> LaoValores = new List<entElementoCombo>();
            DataTable sqlDT = new DataTable();
            try
            {
                List<SqlParameter> ParametersSQL = new List<SqlParameter>();
                ParametersSQL.Add(new SqlParameter("@PnCvePeriodo", PsCvePeriodo));
                ParametersSQL.Add(new SqlParameter("@PnCveAlcance", PsCveAlcance));
                ParametersSQL.Add(new SqlParameter("@PnCvePeriodoDesde", PnCvePeriodoDesde));
                sqlDT = new HelperSQL().ExecStoreProcedure("spObtenerCboInstitucionAdulto", ParametersSQL);
                if (sqlDT != null)
                {
                    foreach (DataRow dr in sqlDT.Rows)
                    {
                        entElementoCombo LoValor = new entElementoCombo();
                        LoValor.clave = dr["clave"].ToString();
                        LoValor.descripcion = dr["descripcion"].ToString();
                        LaoValores.Add(LoValor);
                    }
                }
            }
            catch (Exception ex)
            {
                new HelperLog().LogError(ex.Message, "spObtenerCboInstitucionAdulto");
            }
            return LaoValores;
        }

        public List<entElementoCombo> obtenerCboEntidad(string PsCvePeriodo, string PsCveInstitucion, string PsCveAlcance, string PnCvePeriodoDesde)
        {
            List<entElementoCombo> LaoValores = new List<entElementoCombo>();
            DataTable sqlDT = new DataTable();
            try
            {

                List<SqlParameter> ParametersSQL = new List<SqlParameter>();
                ParametersSQL.Add(new SqlParameter("@PnCvePeriodo", PsCvePeriodo));
                ParametersSQL.Add(new SqlParameter("@PnCveInstitucion", PsCveInstitucion));
                ParametersSQL.Add(new SqlParameter("@PnCveAlcance", PsCveAlcance));
                ParametersSQL.Add(new SqlParameter("@PnCvePeriodoDesde", PnCvePeriodoDesde));
                sqlDT = new HelperSQL().ExecStoreProcedure("spObtenerCboEntidadAdulto", ParametersSQL);
                if (sqlDT != null)
                {
                    foreach (DataRow dr in sqlDT.Rows)
                    {
                        entElementoCombo LoValor = new entElementoCombo();
                        LoValor.clave = dr["clave"].ToString();
                        LoValor.descripcion = dr["descripcion"].ToString();
                        LaoValores.Add(LoValor);
                    }
                }
            }
            catch (Exception ex)
            {
                new HelperLog().LogError(ex.Message, "spObtenerCboEntidadAdulto");
            }
            return LaoValores;
        }

        public List<entElementoCombo> obtenerCboJurisdiccion(string PsCvePeriodo, string PsCveInstitucion, string PsCveEntidad, string PnCvePeriodoDesde)
        {
            List<entElementoCombo> LaoValores = new List<entElementoCombo>();
            DataTable sqlDT = new DataTable();
            try
            {

                List<SqlParameter> ParametersSQL = new List<SqlParameter>();
                ParametersSQL.Add(new SqlParameter("@PnCvePeriodo", PsCvePeriodo));
                ParametersSQL.Add(new SqlParameter("@PnCveInstitucion", PsCveInstitucion));
                ParametersSQL.Add(new SqlParameter("@PnCveEntidad", PsCveEntidad));
                ParametersSQL.Add(new SqlParameter("@PnCvePeriodoDesde", PnCvePeriodoDesde));
                sqlDT = new HelperSQL().ExecStoreProcedure("spObtenerCboJurisdiccionAdulto", ParametersSQL);
                if (sqlDT != null)
                {
                    foreach (DataRow dr in sqlDT.Rows)
                    {
                        entElementoCombo LoValor = new entElementoCombo();
                        LoValor.clave = dr["clave"].ToString();
                        LoValor.descripcion = dr["descripcion"].ToString();
                        LaoValores.Add(LoValor);
                    }
                }
            }
            catch (Exception ex)
            {
                new HelperLog().LogError(ex.Message, "spObtenerCboJurisdiccionAdulto");
            }
            return LaoValores;
        }


        public List<entElementoCombo> obtenerCboUnidadSalud(string PsCvePeriodo, string PsCveInstitucion, string PsCveEntidad, string PnCveJurisdiccion, string PnCvePeriodoDesde)
        {
            List<entElementoCombo> LaoValores = new List<entElementoCombo>();
            DataTable sqlDT = new DataTable();
            try
            {

                List<SqlParameter> ParametersSQL = new List<SqlParameter>();
                ParametersSQL.Add(new SqlParameter("@PnCvePeriodo", PsCvePeriodo));
                ParametersSQL.Add(new SqlParameter("@PnCveInstitucion", PsCveInstitucion));
                ParametersSQL.Add(new SqlParameter("@PnCveEntidad", PsCveEntidad));
                ParametersSQL.Add(new SqlParameter("@PnCveJurisdiccion", PnCveJurisdiccion));
                ParametersSQL.Add(new SqlParameter("@PnCvePeriodoDesde", PnCvePeriodoDesde));
                sqlDT = new HelperSQL().ExecStoreProcedure("spObtenerCboUnidadSaludAdulto", ParametersSQL);
                if (sqlDT != null)
                {
                    foreach (DataRow dr in sqlDT.Rows)
                    {
                        entElementoCombo LoValor = new entElementoCombo();
                        LoValor.clave = dr["clave"].ToString();
                        LoValor.descripcion = dr["descripcion"].ToString();
                        LaoValores.Add(LoValor);
                    }
                }
            }
            catch (Exception ex)
            {
                new HelperLog().LogError(ex.Message, "spObtenerCboUnidadSaludAdulto");
            }
            return LaoValores;
        }

        public List<entElementoCombo> obtenerDescripcionCbo(string PsCveInstitucion, string PsCveEntidad, string PnCveJurisdiccion, string CLUES)
        {
            List<entElementoCombo> LaoValores = new List<entElementoCombo>();
            DataTable sqlDT = new DataTable();
            try
            {

                List<SqlParameter> ParametersSQL = new List<SqlParameter>();
                ParametersSQL.Add(new SqlParameter("@PnCveInstitucion", PsCveInstitucion));
                ParametersSQL.Add(new SqlParameter("@PnCveEntidad", PsCveEntidad));
                ParametersSQL.Add(new SqlParameter("@PnCveJurisdiccion", PnCveJurisdiccion));
                ParametersSQL.Add(new SqlParameter("@PnCLUES", CLUES));
                sqlDT = new HelperSQL().ExecStoreProcedure("spObtenerDescripcionCombo", ParametersSQL);
                if (sqlDT != null)
                {
                    foreach (DataRow dr in sqlDT.Rows)
                    {
                        entElementoCombo LoValor = new entElementoCombo();
                        LoValor.clave = dr["clave"].ToString();
                        LoValor.descripcion = dr["descripcion"].ToString();
                        LaoValores.Add(LoValor);
                    }
                }
            }
            catch (Exception ex)
            {
                new HelperLog().LogError(ex.Message, "spObtenerDescripcionCombo");
            }
            return LaoValores;
        }


        // ⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞⁞  Obtener todos los indicadores adulto
        private DataSet ConsultaIndicadores(string PsCvePeriodo, string PnCveInstitucion, string PnCveEntidad, string PnCveJurisdiccion, string PnCveUS, string PsCveAlcance,  string PnCvePeriodoDesde, string PnCveOrigen)
        {
            SqlCommand sqlCmd = new SqlCommand();
            DataSet ds = new DataSet();
            try
            {
                string comando = string.Format(" exec spObtenerIndicadoresMAdulto {0}, {1}, {2}, {3}, '{4}', {5}, {6}, {7}", PsCvePeriodo, PnCveInstitucion, PnCveEntidad, PnCveJurisdiccion, PnCveUS, PsCveAlcance, PnCvePeriodoDesde, PnCveOrigen);
                SqlDataAdapter adapter = new SqlDataAdapter(comando, ConfigurationManager.ConnectionStrings["tableroMIDOweb"].ConnectionString);
                adapter.SelectCommand.CommandTimeout = 260;
                adapter.Fill(ds);
                sqlCon.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                closeQuietly();
            }
            return ds;
        }

        private void closeQuietly()
        {
            if (sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }


        public entIndicadores ObtenerIndicadoresAdulto(string PsCvePeriodo, string PnCveInstitucion, string PnCveEntidad, string PnCveJurisdiccion, string PnCveUS, string PsCveAlcance, string PnCvePeriodoDesde, string PnCveOrigen)
        {
            var indicadores = new entIndicadores();
            try
            {
                var ds = ConsultaIndicadores(PsCvePeriodo, PnCveInstitucion, PnCveEntidad, PnCveJurisdiccion, PnCveUS, PsCveAlcance,  PnCvePeriodoDesde, PnCveOrigen);
                // Validación para evitar nulls silenciosos
                if (ds == null || ds.Tables.Count < 2 || ds.Tables[1].Rows.Count == 0)
                {
                    indicadores.DebugInfo = new List<string> { " La tabla 1 no tiene datos o el SP no devolvió suficientes tablas" };
                    return indicadores;
                }
                indicadores.Totales = obtenerTotalesIntro(ds.Tables[0]);
                indicadores.TotalValoraciones = obtenerTotalValoraciones(ds.Tables[1]);
                indicadores.GraficaDistribucionSexoEdad = obtenerDistribucionSexoEdad(ds.Tables[2]);
                indicadores.GraficaFactoresRiesgo = obtenerFactores(ds.Tables[3]);
                indicadores.GraficaObesidad = obtenerGraficaObesidad(ds.Tables[4]);
                indicadores.GraficaHipertension = obtenerGraficaHipertension(ds.Tables[5]);
                indicadores.GraficaDiabetes = obtenerGraficaDiabetes(ds.Tables[6]);

            }
            catch (Exception ex)
            {
                indicadores = new entIndicadores
                {
                    DebugInfo = new List<string> { "❌ Error interno: " + ex.Message }
                };
            }


            return indicadores;
        }



        private List<string> obtenerTotalesIntro(DataTable LdtIntro)
        {
            List<string> LaoValores = new List<string>();

            if (LdtIntro != null)
            {
                LaoValores.Add(LdtIntro.Rows[0]["numEnt"].ToString());
                LaoValores.Add(LdtIntro.Rows[0]["numUS"].ToString());
                LaoValores.Add(LdtIntro.Rows[0]["meta"].ToString());
                LaoValores.Add(LdtIntro.Rows[0]["numPersonas"].ToString());
                LaoValores.Add(LdtIntro.Rows[0]["porcPersonas"].ToString());
                LaoValores.Add(LdtIntro.Rows[0]["totalHist"].ToString());
                LaoValores.Add(LdtIntro.Rows[0]["mido4"].ToString());
                LaoValores.Add(LdtIntro.Rows[0]["fecProceso"].ToString());
            }

            return LaoValores;
        }

        private List<string> obtenerTotalValoraciones(DataTable LdtIntro)
        {
            List<string> LaoValores = new List<string>();


            if (LdtIntro != null)
            {
                LaoValores.Add(LdtIntro.Rows[0]["NumeroValoraciones"].ToString());
                LaoValores.Add(LdtIntro.Rows[0]["NumeroPersonas"].ToString());
                LaoValores.Add(LdtIntro.Rows[0]["Promedio"].ToString());
            }

            return LaoValores;
        }


        private List<entGraficasDos> obtenerDistribucionSexoEdad(DataTable LdtIntro)
        {

            List<entGraficasDos> distribucionSexoEdad = new List<entGraficasDos>();
            if (LdtIntro != null)
            {
                entGraficasDos distribucionMujeres = obtenerDistribucionMujeres(LdtIntro);
                entGraficasDos distribucionHombres = obtenerDistribucionHombres(LdtIntro);
                distribucionSexoEdad.Add(distribucionMujeres);
                distribucionSexoEdad.Add(distribucionHombres);
            }

            return distribucionSexoEdad;

        }

        public entGraficasDos obtenerDistribucionMujeres(DataTable LdtIntro)
        {
            entGraficasDos LoGraficas = new entGraficasDos();
            try
            {


                if (LdtIntro != null)
                {
                    LoGraficas.titulo = "";
                    //LoGraficas.tituloEjeX = "Edad";
                    List<entSerieDos> LaoSeries = new List<entSerieDos>();
                    List<entCategoriaDos> LasCategorias = new List<entCategoriaDos>();
                    List<double> LanTotales = new List<double>();
                    double LnBaseH;
                    double LnBaseM;
                    double LnMaximo;
                    string LsTooltip;

                    LnMaximo = Convert.ToDouble(LdtIntro.Rows[0]["max"].ToString());

                    LoGraficas.valores = new List<string>();
                    double LnTotalM = 0;

                    entSerieDos LoSerieM = new entSerieDos();
                    LoSerieM.name = "Mujeres";
                    LoSerieM.data = new List<entPuntoDos>();
                    LoSerieM.color = "#F3B741";
                    LoSerieM.showInLegend = false;

                    LnBaseM = Math.Ceiling(LnMaximo / 11) * -1;


                    foreach (DataRow dr in LdtIntro.Rows)
                    {
                        entCategoriaDos LoCategoria = new entCategoriaDos();
                        LoCategoria.nombre = dr["etiqueta"].ToString();
                        LasCategorias.Add(LoCategoria);
                        entPuntoDos LoPuntoM = new entPuntoDos();

                        //LoPuntoM.low = Convert.ToDouble(LnBaseM);
                        LoPuntoM.y = Convert.ToDouble(dr["numMujeres"].ToString());
                        LoPuntoM.color = "#F3B741";

                        LnTotalM += Convert.ToDouble(dr["numMujeres"].ToString());


                        LoSerieM.data.Add(LoPuntoM);

                        LanTotales.Add(Convert.ToDouble(dr["numHombres"].ToString()) + Convert.ToDouble(dr["numMujeres"].ToString()));
                    }
                    LaoSeries.Add(LoSerieM);

                    LsTooltip = "";
                    LsTooltip = LsTooltip + "if ( PoPuntos.totales[this.point.index] == 0) {";
                    LsTooltip = LsTooltip + "'<b>' + this.series.name + ', edad ' + this.point.category + ': ' ";
                    LsTooltip = LsTooltip + "+ Highcharts.numberFormat(Math.abs(numberWithCommas(this.point.y)), 0) + '(0%)'";
                    LsTooltip = LsTooltip + "} else {";
                    LsTooltip = LsTooltip + "'<b>' + this.series.name + ', edad ' + this.point.category + ': ' ";
                    LsTooltip = LsTooltip + "+ Highcharts.numberFormat(Math.abs(numberWithCommas(this.point.y)), 0) ";
                    LsTooltip = LsTooltip + "+ '(' + Highcharts.numberFormat(Math.abs(numberWithCommas(this.point.y)) / PoPuntos.totales[this.point.index] * 100, 1) + '%)'};";
                    // LsTooltip = "this.point.index";
                    LoGraficas.tooltipFormater = LsTooltip;
                    //LoGraficas.tooltipFormater = "'<b>' + this.series.name + ', edad ' + this.point.category + ': ' + Highcharts.numberFormat(Math.abs(this.point.high - this.point.low), 0) + '(' + Highcharts.numberFormat(Math.abs(this.point.high - this.point.low) / PoPuntos.totales[this.point.index] * 100, 1) + '%)';
                    //LoGraficas.tooltipFormater = "this.x + ': ' + numberWithCommas(PoPuntos.series[0].data[this.point.index].valorY);";
                    //LoGraficas.tooltipFormater = "console.log(this);console.log(this.point);";
                    LoGraficas.series = LaoSeries;
                    LoGraficas.categorias = LasCategorias;
                    LoGraficas.totales = LanTotales;
                    LoGraficas.valores.Add(LnTotalM.ToString());
                    LoGraficas.valores.Add((LnMaximo).ToString());


                    LoGraficas.bStackLabels = true;
                    LoGraficas.yAxisMax = null;
                    LoGraficas.pointWidth = 20;
                    //LoGraficas.dataLabelsFormatter = "numberWithCommas(this.y) ";
                    LoGraficas.stackLabelsFormatter = "numberWithCommas(this.total)	 ";
                    LoGraficas.yGridLineWidth = 0;
                    LoGraficas.bxAxisReversed = true;
                    LoGraficas.dataLabelsAlign = "left";
                    LoGraficas.colorEjeY = "#d5d5d5";
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            return LoGraficas;

        }
        public entGraficasDos obtenerDistribucionHombres(DataTable LdtIntro)
        {
            entGraficasDos LoGraficas = new entGraficasDos();

            try
            {

                if (LdtIntro != null)
                {
                    LoGraficas.titulo = "";
                    //LoGraficas.tituloEjeX = "Edad";
                    List<entSerieDos> LaoSeries = new List<entSerieDos>();
                    List<entCategoriaDos> LasCategorias = new List<entCategoriaDos>();
                    List<double> LanTotales = new List<double>();
                    double LnBaseH;
                    double LnBaseM;
                    double LnMaximo;
                    string LsTooltip;

                    LnMaximo = Convert.ToDouble(LdtIntro.Rows[0]["max"].ToString());

                    LoGraficas.valores = new List<string>();
                    //int LnSerie = 0;
                    //int Lni = 0;
                    //double LnTotalPorSerie = 0;
                    double LnTotalH = 0;

                    entSerieDos LoSerieH = new entSerieDos();
                    LoSerieH.name = "Hombres";
                    LoSerieH.data = new List<entPuntoDos>();
                    LoSerieH.color = "#459EE6";
                    LoSerieH.showInLegend = false;

                    LnBaseH = Math.Ceiling(LnMaximo / 11);

                    foreach (DataRow dr in LdtIntro.Rows)
                    {
                        entCategoriaDos LoCategoria = new entCategoriaDos();
                        LoCategoria.nombre = dr["etiqueta"].ToString();
                        LasCategorias.Add(LoCategoria);

                        entPuntoDos LoPuntoH = new entPuntoDos();

                        //LoPuntoH.low = Convert.ToDouble(LnBaseH);
                        LoPuntoH.y = Convert.ToDouble(dr["numHombres"].ToString());
                        LoPuntoH.color = "#459EE6";
                        LnTotalH += Convert.ToDouble(dr["numHombres"].ToString());

                        LoSerieH.data.Add(LoPuntoH);

                        LanTotales.Add(Convert.ToDouble(dr["numHombres"].ToString()) + Convert.ToDouble(dr["numMujeres"].ToString()));
                    }
                    LaoSeries.Add(LoSerieH);

                    LsTooltip = "";
                    LsTooltip = LsTooltip + "if ( PoPuntos.totales[this.point.index] == 0) {";
                    LsTooltip = LsTooltip + "'<b>' + this.series.name + ', edad ' + this.point.category + ': ' ";
                    LsTooltip = LsTooltip + "+ Highcharts.numberFormat(Math.abs(numberWithCommas(this.point.y)), 0) + '(0%)'";
                    LsTooltip = LsTooltip + "} else {";
                    LsTooltip = LsTooltip + "'<b>' + this.series.name + ', edad ' + this.point.category + ': ' ";
                    LsTooltip = LsTooltip + "+ Highcharts.numberFormat(Math.abs(numberWithCommas(this.point.y)), 0) ";
                    LsTooltip = LsTooltip + "+ '(' + Highcharts.numberFormat(Math.abs(numberWithCommas(this.point.y)) / PoPuntos.totales[this.point.index] * 100, 1) + '%)'};";
                    LoGraficas.tooltipFormater = LsTooltip;
                    //LoGraficas.tooltipFormater = "'<b>' + this.series.name + ', edad ' + this.point.category + ': ' + Highcharts.numberFormat(Math.abs(this.point.high - this.point.low), 0) + '(' + Highcharts.numberFormat(Math.abs(this.point.high - this.point.low) / PoPuntos.totales[this.point.index] * 100, 1) + '%)';
                    //LoGraficas.tooltipFormater = "this.x + ': ' + numberWithCommas(PoPuntos.series[0].data[this.point.index].valorY);";
                    //LoGraficas.tooltipFormater = "console.log(this);console.log(this.point);";
                    LoGraficas.series = LaoSeries;
                    LoGraficas.categorias = LasCategorias;
                    LoGraficas.totales = LanTotales;
                    LoGraficas.valores.Add(LnTotalH.ToString());
                    LoGraficas.valores.Add((LnMaximo).ToString());

                    LoGraficas.bStackLabels = true;
                    LoGraficas.yAxisMax = null;
                    LoGraficas.pointWidth = 20;
                    //LoGraficas.dataLabelsFormatter = "numberWithCommas(this.y) ";
                    LoGraficas.stackLabelsFormatter = "	numberWithCommas(this.total) ";
                    LoGraficas.yGridLineWidth = 0;
                    LoGraficas.bxAxisReversed = true;
                    LoGraficas.dataLabelsAlign = "right";
                    LoGraficas.colorEjeY = "#d5d5d5";
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            return LoGraficas;

        }


        private entGraficas obtenerFactores(DataTable LdtIntro)
        {
            entGraficas LoGraficas = new entGraficas();

            LoGraficas.titulo = "";
            LoGraficas.valores = new List<string>();

            List<entSerie> LaoSeries = new List<entSerie>();
            entSerie LoSerie = new entSerie();

            List<entCategoria> LasCategorias = new List<entCategoria>();

            if (LdtIntro.Rows.Count > 0)
            {
                LoSerie.name = "factores";
                LoSerie.data = new List<entPunto>();
                LaoSeries.Add(LoSerie);

                LoGraficas.valores.Add(LdtIntro.Rows[0]["numReg"].ToString());

                entCategoria LoCategoria5 = new entCategoria();
                LoCategoria5.nombre = "Infarto o embolia";
                LasCategorias.Add(LoCategoria5);

                entCategoria LoCategoria4 = new entCategoria();
                LoCategoria4.nombre = "Diagnóstico previo de HTA";
                LasCategorias.Add(LoCategoria4);

                entCategoria LoCategoria3 = new entCategoria();
                LoCategoria3.nombre = "Diagnóstico previo de DM2";
                LasCategorias.Add(LoCategoria3);

                entCategoria LoCategoria2 = new entCategoria();
                LoCategoria2.nombre = "Fumador";
                LasCategorias.Add(LoCategoria2);

                entCategoria LoCategoria = new entCategoria();
                LoCategoria.nombre = "Hx Fam de DM2, HTA y ERC";
                LasCategorias.Add(LoCategoria);

                entPunto LoPunto5 = new entPunto();
                if (Convert.ToDouble(LdtIntro.Rows[0]["numReg"].ToString()) == 0)
                    LoPunto5.y = 0;
                else
                    LoPunto5.y = Convert.ToDouble(LdtIntro.Rows[0]["infarto"].ToString()) / Convert.ToDouble(LdtIntro.Rows[0]["numReg"].ToString()) * 100;

                LoPunto5.valorY = Convert.ToDouble(LdtIntro.Rows[0]["infarto"].ToString());
                LoPunto5.color = "#4f81bd";
                LaoSeries[0].data.Add(LoPunto5);

                entPunto LoPunto4 = new entPunto();
                if (Convert.ToDouble(LdtIntro.Rows[0]["numReg"].ToString()) == 0)
                    LoPunto4.y = 0;
                else
                    LoPunto4.y = Convert.ToDouble(LdtIntro.Rows[0]["hta"].ToString()) / Convert.ToDouble(LdtIntro.Rows[0]["numReg"].ToString()) * 100;


                LoPunto4.valorY = Convert.ToDouble(LdtIntro.Rows[0]["hta"].ToString());
                LoPunto4.color = "#c04d50";
                LaoSeries[0].data.Add(LoPunto4);

                entPunto LoPunto3 = new entPunto();
                if (Convert.ToDouble(LdtIntro.Rows[0]["numReg"].ToString()) == 0)
                    LoPunto3.y = 0;
                else
                    LoPunto3.y = Convert.ToDouble(LdtIntro.Rows[0]["dm2"].ToString()) / Convert.ToDouble(LdtIntro.Rows[0]["numReg"].ToString()) * 100;


                LoPunto3.valorY = Convert.ToDouble(LdtIntro.Rows[0]["dm2"].ToString());
                LoPunto3.color = "#9bbb59";
                LaoSeries[0].data.Add(LoPunto3);

                entPunto LoPunto2 = new entPunto();
                if (Convert.ToDouble(LdtIntro.Rows[0]["numReg"].ToString()) == 0)
                    LoPunto2.y = 0;
                else
                    LoPunto2.y = Convert.ToDouble(LdtIntro.Rows[0]["fuma"].ToString()) / Convert.ToDouble(LdtIntro.Rows[0]["numReg"].ToString()) * 100;

                LoPunto2.valorY = Convert.ToDouble(LdtIntro.Rows[0]["fuma"].ToString());
                LoPunto2.color = "#8064a2";
                LaoSeries[0].data.Add(LoPunto2);

                entPunto LoPunto = new entPunto();
                LoPunto.y = Convert.ToDouble(LdtIntro.Rows[0]["antecedentes"].ToString()) / Convert.ToDouble(LdtIntro.Rows[0]["numReg"].ToString()) * 100;
                if (Convert.ToDouble(LdtIntro.Rows[0]["numReg"].ToString()) == 0)
                    LoPunto.y = 0;
                else
                    LoPunto.y = Convert.ToDouble(LdtIntro.Rows[0]["antecedentes"].ToString()) / Convert.ToDouble(LdtIntro.Rows[0]["numReg"].ToString()) * 100;

                LoPunto.valorY = Convert.ToDouble(LdtIntro.Rows[0]["antecedentes"].ToString());
                LoPunto.color = "#4bacc6";
                LaoSeries[0].data.Add(LoPunto);

                LoGraficas.tooltipFormater = "this.x + ': ' + numberWithCommas(PoPuntos.series[0].data[this.point.index].valorY);";
                //LoGraficas.tooltipFormater = "console.log(this);console.log(this.point);";
                LoGraficas.series = LaoSeries;
                LoGraficas.categorias = LasCategorias;
            }
            return LoGraficas;
        }


        private entGraficas obtenerGraficaObesidad(DataTable LdtIntro)
        {
            entGraficas LoGraficas = new entGraficas();
            double LnVal = 0, t1, t2, t3, ConTotMedidasObe, totalHist, SinTotMedidasObe, ConObePorc, SinObePorc,
            SinobesidadPorc;

            if (LdtIntro != null)
            {
                LoGraficas.titulo = "";

                List<entSerie> LaoSeries = new List<entSerie>();
                entSerie LoSerie = new entSerie();
                LoGraficas.valores = new List<string>();
                LoSerie.name = "mediciones";
                LoSerie.data = new List<entPunto>();
                LaoSeries.Add(LoSerie);
                double LnTotal = 0;
                double LnTotPersonas = 0;
                double Sinobesidad = 0;

                List<entCategoria> LasCategorias = new List<entCategoria>();

                t1 = Convert.ToDouble(LdtIntro.Rows[0]["y"].ToString());
                t2 = Convert.ToDouble(LdtIntro.Rows[1]["y"].ToString());
                t3 = Convert.ToDouble(LdtIntro.Rows[2]["y"].ToString());
                totalHist = Convert.ToDouble(LdtIntro.Rows[0]["total"].ToString());

                ConTotMedidasObe = t1 + t2 + t3;
                SinTotMedidasObe = (totalHist - ConTotMedidasObe);

                if (totalHist > 0)
                {
                    ConObePorc = (ConTotMedidasObe / totalHist) * 100;
                    SinObePorc = (SinTotMedidasObe / totalHist) * 100;
                }
                else
                {
                    SinObePorc = 0;
                    ConObePorc = 0;
                }

                Sinobesidad = ConTotMedidasObe;
                if (ConTotMedidasObe > 0)
                    SinobesidadPorc = (Sinobesidad / ConTotMedidasObe) * 100;
                else
                    SinobesidadPorc = 0;


                if (ConObePorc > 100)
                {
                    ConObePorc = 100.0;
                }

                LoGraficas.valores.Add(ConTotMedidasObe.ToString("###,##0")); // lblTotMedidasObe
                LoGraficas.valores.Add(SinTotMedidasObe.ToString("###,##0")); //  lblSinTotMedidasObe
                LoGraficas.valores.Add(ConObePorc.ToString("(##0.0") + "%)"); // lblConObeP
                LoGraficas.valores.Add(SinObePorc.ToString("(##0.0") + "%)"); // lblSinObeP
                LoGraficas.valores.Add(totalHist.ToString("###,##0"));  // totalHist
                LoGraficas.valores.Add(Sinobesidad.ToString("###,##0"));  // lblSinobesidad
                LoGraficas.valores.Add(SinobesidadPorc.ToString("##0.0") + "%"); // lblSinobesidadPorc


                List<double> LanTotales = new List<double>();

                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entPunto LoPunto = new entPunto();
                    LoPunto.y = Convert.ToDouble(dr["y"].ToString());
                    LnTotal += LoPunto.y;
                    LoPunto.name = dr["etiquetaX"].ToString();
                    //LoPunto.valorY = Convert.ToDouble(dr["valorY"].ToString());
                    LoPunto.color = dr["color"].ToString();
                    if (dr["orden"].ToString() == "3")
                    {
                        LoPunto.sliced = true;
                        LnVal = LoPunto.y;
                    }
                    LaoSeries[0].data.Add(LoPunto);
                    LnTotPersonas = Convert.ToDouble(dr["total"].ToString());
                }
                if (LnTotal == 0)
                {
                    LoGraficas.anguloInicial = 0;
                }
                else
                {
                    LoGraficas.anguloInicial = (180 - (LnVal / LnTotal * 100 * 3.6)) / 2;
                    if (LoGraficas.anguloInicial < 0) LoGraficas.anguloInicial = 0;
                }
                LoGraficas.tooltipFormater = "this.key + ': ' + numberWithCommas(this.y) + ' (' + redondeaN(this.percentage, 1) + '%)';";
                LoGraficas.total = Sinobesidad;
                LoGraficas.series = LaoSeries;
                LanTotales.Add(LnTotPersonas);
                LoGraficas.totales = LanTotales;
            }

            return LoGraficas;
        }

        public entGraficas obtenerGraficaHipertension(DataTable LdtIntro)
        {
            entGraficas LoGraficas = new entGraficas();
            SqlCommand sqlCmd = new SqlCommand();
            double LnVal = 0, TotalHistorico, t1, t2, t3, t4, t5, TotMedidashipertension, ConhipertensionPorc, SinTotMedidashipertension, SinhipertensionPorc,
                 ConhipertensionPorc1, SinhipertensionPorc1;
            if (LdtIntro != null)
            {
                LoGraficas.titulo = "";

                List<entSerie> LaoSeries = new List<entSerie>();

                entSerie LoSerie = new entSerie();
                LoGraficas.valores = new List<string>();
                LoSerie.name = "mediciones";
                LoSerie.data = new List<entPunto>();
                LaoSeries.Add(LoSerie);
                double LnTotal = 0;
                double LnTotPersonas = 0;
                double Conhipertension = 0;
                double Sinhipertension = 0;

                List<entCategoria> LasCategorias = new List<entCategoria>();

                t1 = Convert.ToDouble(LdtIntro.Rows[0]["y"].ToString());
                t2 = Convert.ToDouble(LdtIntro.Rows[1]["y"].ToString());
                t3 = Convert.ToDouble(LdtIntro.Rows[2]["y"].ToString());
                t4 = Convert.ToDouble(LdtIntro.Rows[3]["y"].ToString());
                t5 = Convert.ToDouble(LdtIntro.Rows[4]["y"].ToString());
                TotalHistorico = Convert.ToDouble(LdtIntro.Rows[0]["total"].ToString());

                TotMedidashipertension = t1 + t2 + t3 + t4 + t5;
                TotalHistorico = Convert.ToDouble(LdtIntro.Rows[0]["total"].ToString());
                SinTotMedidashipertension = (TotalHistorico - TotMedidashipertension);
                if (TotalHistorico > 0)
                {
                    ConhipertensionPorc = (TotMedidashipertension / TotalHistorico) * 100;
                    SinhipertensionPorc = (SinTotMedidashipertension / TotalHistorico) * 100;
                }
                else
                {
                    ConhipertensionPorc = 0;
                    SinhipertensionPorc = 0;
                }

                Conhipertension = t2 + t3;
                Sinhipertension = t1 + t4 + t5;
                if (TotMedidashipertension > 0)
                {
                    ConhipertensionPorc1 = (Conhipertension / TotMedidashipertension) * 100;
                    SinhipertensionPorc1 = (Sinhipertension / TotMedidashipertension) * 100;
                }
                else
                {
                    ConhipertensionPorc1 = 0;
                    SinhipertensionPorc1 = 0;
                }

                if (ConhipertensionPorc > 100)
                {
                    ConhipertensionPorc = 100.0;
                }


                LoGraficas.valores.Add(TotMedidashipertension.ToString("###,##0")); //  lblTotMedidashipertension
                LoGraficas.valores.Add(SinTotMedidashipertension.ToString("###,##0")); // lblSinTotMedidashipertension  
                LoGraficas.valores.Add(ConhipertensionPorc.ToString("(##0.0") + "%)"); // lblConhipertensionP
                LoGraficas.valores.Add(SinhipertensionPorc.ToString("(##0.0") + "%)"); // lblSinhipertensionP
                LoGraficas.valores.Add(TotalHistorico.ToString("###,##0")); //LblTotalHistorico
                LoGraficas.valores.Add(Conhipertension.ToString("###,##0")); //lblConhipertension
                LoGraficas.valores.Add(ConhipertensionPorc1.ToString("##0.0") + "%"); //lblConhipertensionPorc 
                LoGraficas.valores.Add(Sinhipertension.ToString("###,##0")); //lblSinhipertension
                LoGraficas.valores.Add(SinhipertensionPorc1.ToString("##0.0") + "%"); // lblSinhipertensionPorc


                List<double> LanTotales = new List<double>();


                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entPunto LoPunto = new entPunto();
                    LoPunto.y = Convert.ToDouble(dr["y"].ToString());
                    LnTotal += LoPunto.y;
                    LoPunto.name = dr["etiquetaX"].ToString();
                    LoPunto.color = dr["color"].ToString();
                    if (dr["orden"].ToString() == "5")
                    {
                        LoPunto.sliced = true;
                        LnVal = LoPunto.y;
                    }
                    LaoSeries[0].data.Add(LoPunto);
                    LnTotPersonas = Convert.ToDouble(dr["total"].ToString());
                }
                if (LnTotal == 0)
                {
                    LoGraficas.anguloInicial = 0;
                }
                else
                {
                    LoGraficas.anguloInicial = (180 - (LnVal / LnTotal * 100 * 3.6)) / 2;
                    if (LoGraficas.anguloInicial < 0) LoGraficas.anguloInicial = 0;
                }
                LoGraficas.tooltipFormater = "this.key + ': ' + numberWithCommas(this.y) + ' (' + redondeaN(this.percentage, 1) + '%)';";
                LoGraficas.total = Conhipertension;
                LoGraficas.total2 = Sinhipertension;
                LoGraficas.series = LaoSeries;
                LanTotales.Add(LnTotPersonas);
                LoGraficas.totales = LanTotales;
            }

            return LoGraficas;
        }

        public entGraficas obtenerGraficaDiabetes(DataTable LdtIntro)
        {
            entGraficas LoGraficas = new entGraficas();
            double LnVal = 0, TotMedidasDM, ConDMPorc, t1, t2, t3, t4, t5, totalHistorico, SinTotMedidasDM, SinDMPorc, ConDM2Porc, SinDM2Porc;
            if (LdtIntro != null)
            {
                LoGraficas.titulo = "";

                List<entSerie> LaoSeries = new List<entSerie>();

                entSerie LoSerie = new entSerie();
                LoGraficas.valores = new List<string>();
                LoSerie.name = "mediciones";
                LoSerie.data = new List<entPunto>();
                LaoSeries.Add(LoSerie);
                double LnTotal = 0;
                double LnTotPersonas = 0;
                double ConDM2 = 0;
                double SinDM2 = 0;

                List<entCategoria> LasCategorias = new List<entCategoria>();

                t1 = Convert.ToDouble(LdtIntro.Rows[0]["y"].ToString());
                t2 = Convert.ToDouble(LdtIntro.Rows[1]["y"].ToString());
                t3 = Convert.ToDouble(LdtIntro.Rows[2]["y"].ToString());
                t4 = Convert.ToDouble(LdtIntro.Rows[3]["y"].ToString());
                t5 = Convert.ToDouble(LdtIntro.Rows[4]["y"].ToString());
                totalHistorico = Convert.ToDouble(LdtIntro.Rows[0]["total"].ToString());

                TotMedidasDM = t1 + t2 + t3 + t4 + t5;
                SinTotMedidasDM = (totalHistorico - TotMedidasDM);
                if (totalHistorico > 0)
                {
                    ConDMPorc = (TotMedidasDM / totalHistorico) * 100;
                    SinDMPorc = (SinTotMedidasDM / totalHistorico) * 100;
                }
                else
                {
                    ConDMPorc = 0;
                    SinDMPorc = 0;
                }

                ConDM2 = t2 + t3;
                SinDM2 = t1 + t4 + t5;

                if (TotMedidasDM > 0)
                {
                    ConDM2Porc = (ConDM2 / TotMedidasDM) * 100;
                    SinDM2Porc = (SinDM2 / TotMedidasDM) * 100;
                }
                else
                {
                    ConDM2Porc = 0;
                    SinDM2Porc = 0;
                }



                LoGraficas.valores.Add(TotMedidasDM.ToString("###,##0")); // lblTotMedidasDM
                LoGraficas.valores.Add(SinTotMedidasDM.ToString("###,##0")); // lblSinTotMedidasDM
                LoGraficas.valores.Add(ConDMPorc.ToString("(##0.0") + "%)"); // lblConDMP
                LoGraficas.valores.Add(SinDMPorc.ToString("(##0.0") + "%)"); // lblSinDMP
                LoGraficas.valores.Add(totalHistorico.ToString("###,##0")); // totalHistorico
                LoGraficas.valores.Add(ConDM2.ToString("###,##0")); // lblConDM2
                LoGraficas.valores.Add(ConDM2Porc.ToString("##0.0") + "%"); // lblConDM2Porc
                LoGraficas.valores.Add(SinDM2.ToString("###,##0")); // lblSinDM2
                LoGraficas.valores.Add(SinDM2Porc.ToString("##0.0") + "%"); // lblSinDM2Porc

                List<double> LanTotales = new List<double>();

                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entPunto LoPunto = new entPunto();
                    LoPunto.y = Convert.ToDouble(dr["y"].ToString());
                    LnTotal += LoPunto.y;
                    LoPunto.name = dr["etiquetaX"].ToString();
                    //LoPunto.valorY = Convert.ToDouble(dr["valorY"].ToString());
                    LoPunto.color = dr["color"].ToString();
                    if (dr["orden"].ToString() == "5")
                    {
                        LoPunto.sliced = true;
                        LnVal = LoPunto.y;
                    }
                    LaoSeries[0].data.Add(LoPunto);
                    LnTotPersonas = Convert.ToDouble(dr["total"].ToString());
                }
                if (LnTotal == 0)
                {
                    LoGraficas.anguloInicial = 0;
                }
                else
                {
                    LoGraficas.anguloInicial = (180 - (LnVal / LnTotal * 100 * 3.6)) / 2;
                    if (LoGraficas.anguloInicial < 0) LoGraficas.anguloInicial = 0;
                }
                LoGraficas.tooltipFormater = "this.key + ': ' + numberWithCommas(this.y) + ' (' + redondeaN(this.percentage, 1) + '%)';";
                LoGraficas.total = SinDM2;
                LoGraficas.total2 = ConDM2;
                LoGraficas.series = LaoSeries;
                LanTotales.Add(LnTotPersonas);
                LoGraficas.totales = LanTotales;
            }
            return LoGraficas;
        }

    }
}
