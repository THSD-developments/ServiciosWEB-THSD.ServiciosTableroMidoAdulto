using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using THSD.ServiciosTableroMidoAdulto.Negocio.Business;
using THSD.ServiciosTableroMidoAdulto.Negocio.Entidades;
using THSD.TableroEntidadGraficas;
using System.CodeDom;
using System.IO;
using System.Data;
using System.Net.Http.Headers;

/*
Esta hoja alimenta los servicios de el TableroMidoAdulto
URL del tablero  
https://tableromidoadultoproduccion.azurewebsites.net/Mido/0?midoGlobal=99&entidad=-1&jurisdiccion=-1&unidadsalud=-1 --produccion

https://tableromidoadultopruebas.azurewebsites.net/Mido/0?midoGlobal=99&entidad=-1&jurisdiccion=-1&unidadsalud=-1 --pruebas

servicios

https://serviciostableromidoadulto-c6h0bucsa7gnejf8.southcentralus-01.azurewebsites.net/ --produccion
https://serviciostableromidoadultopruebas-akcxhpcse2dde0fk.southcentralus-01.azurewebsites.net/ --pruebas
*/


namespace THSD.ServiciosTableroMidoAdulto.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("THSD.TableroMidoAdulto")]
    public class TableroMidoAdultoController : ApiController
    {
        // GET: api/Tablero
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        [HttpPost]
        [AllowAnonymous]
        [Route("wmCboPeriodo")]
        public IHttpActionResult wmCboPeriodo(entFiltros PoFiltros)
        {
            BSN_Tablero_Mido_Adulto LoMidoAdulto = new BSN_Tablero_Mido_Adulto();
            List<entElementoCombo> LaoValores = new List<entElementoCombo>();
            LaoValores = LoMidoAdulto.obtenerCboPeriodo(PoFiltros.cveAlcance);

            return Ok(LaoValores);
        }


        [HttpPost]
        [AllowAnonymous]
        [Route("wmCboPeriodoDesdeHasta")]
        public IHttpActionResult wmCboPeriodoDesdeHasta(entFiltros PoFiltros)
        {
            BSN_Tablero_Mido_Adulto LoMidoAdulto = new BSN_Tablero_Mido_Adulto();
            List<entElementoCombo> LaoValores = new List<entElementoCombo>();
            LaoValores = LoMidoAdulto.obtenerCboPeriodoDesdeHasta(PoFiltros.cveAlcance, PoFiltros.cvePeriodoDesde);

            return Ok(LaoValores);
        }


        [HttpPost]
        [AllowAnonymous]
        [Route("wmCboInstitucion")]
        public IHttpActionResult wmCboInstitucion(entFiltros PoFiltros)
        {
            BSN_Tablero_Mido_Adulto LoMidoAdulto = new BSN_Tablero_Mido_Adulto();
            List<entElementoCombo> LaoValores = new List<entElementoCombo>();
            LaoValores = LoMidoAdulto.obtenerCboInstitucion(PoFiltros.cvePeriodo, PoFiltros.cveAlcance, PoFiltros.cvePeriodoDesde, PoFiltros.cveOrigen);   //Se agrega CboOrigenAdulto - DMZ - 2026-Marzo-11
            return Ok(LaoValores);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("wmCboEntidad")]
        public IHttpActionResult wmCboEntidad(entFiltros PoFiltros)
        {
            BSN_Tablero_Mido_Adulto LoMidoAdulto = new BSN_Tablero_Mido_Adulto();
            List<entElementoCombo> LaoValores = new List<entElementoCombo>();
            LaoValores = LoMidoAdulto.obtenerCboEntidad(PoFiltros.cvePeriodo, PoFiltros.cveInstitucion, PoFiltros.cveAlcance, PoFiltros.cvePeriodoDesde, PoFiltros.cveOrigen);   //Se agrega CboOrigenAdulto - DMZ - 2026-Marzo-11
            return Ok(LaoValores);
        }


        [HttpPost]
        [AllowAnonymous]
        [Route("wmCboJurisdiccion")]
        public IHttpActionResult wmCboJurisdiccion(entFiltros PoFiltros)
        {
            BSN_Tablero_Mido_Adulto LoMidoAdulto = new BSN_Tablero_Mido_Adulto();
            List<entElementoCombo> LaoValores = new List<entElementoCombo>();
            LaoValores = LoMidoAdulto.obtenerCboJurisdiccion(PoFiltros.cvePeriodo, PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cvePeriodoDesde, PoFiltros.cveOrigen);   //Se agrega CboOrigenAdulto - DMZ - 2026-Marzo-11
            return Ok(LaoValores);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("wmCboUnidadSalud")]
        public IHttpActionResult wmCboUnidadSalud(entFiltros PoFiltros)
        {
            BSN_Tablero_Mido_Adulto LoMidoAdulto = new BSN_Tablero_Mido_Adulto();
            List<entElementoCombo> LaoValores = new List<entElementoCombo>();
            LaoValores = LoMidoAdulto.obtenerCboUnidadSalud(PoFiltros.cvePeriodo, PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cvePeriodoDesde, PoFiltros.cveOrigen);   //Se agrega CboOrigenAdulto - DMZ - 2026-Marzo-11
            return Ok(LaoValores);
        }


        [HttpPost]
        [AllowAnonymous]
        [Route("wmCboDescripcion")]
        public IHttpActionResult wmCboDescripcion(entFiltros PoFiltros)
        {
            BSN_Tablero_Mido_Adulto LoMidoAdulto = new BSN_Tablero_Mido_Adulto();
            List<entElementoCombo> LaoValores = new List<entElementoCombo>();
            LaoValores = LoMidoAdulto.obtenerDescripcionCbo(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveUnidadSalud);
            return Ok(LaoValores);
        }

        //Se agrega CboOrigenAdulto - DMZ - 2026-Marzo-11
        [HttpPost]
        [AllowAnonymous]
        [Route("wmCboOrigenAdulto")]
        public IHttpActionResult wmCboOrigenAdulto(entFiltros PoFiltros)
        {
            BSN_Tablero_Mido_Adulto LoMidoAdulto = new BSN_Tablero_Mido_Adulto();
            List<entElementoCombo> LaoValores = new List<entElementoCombo>();
            LaoValores = LoMidoAdulto.obtenerCboOrigenAdulto();
            return Ok(LaoValores);
        }


        [HttpPost]
        [AllowAnonymous]
        [Route("wmIndicadores")]
        public IHttpActionResult wmIndicadores(entFiltros PoFiltros)
        {
            BSN_Tablero_Mido_Adulto LoMidoAdulto = new BSN_Tablero_Mido_Adulto();
            entIndicadores indicadores = LoMidoAdulto.ObtenerIndicadoresAdulto(PoFiltros.cvePeriodo,
            PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion,
            PoFiltros.cveUnidadSalud, PoFiltros.cveAlcance, 
            PoFiltros.cvePeriodoDesde, PoFiltros.cveOrigen);
            return Ok(indicadores);
        }


  

    }
}
