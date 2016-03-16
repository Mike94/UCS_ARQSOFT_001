using System;

namespace SGI.MVCCliente.Helpers
{
    public class Constantes
    {
        #region GRILLAS PAGINACION

        public const Int32 PageIndex = 0;
        public const Int32 RowsPerPage = 10;
        public const String NoseEncontraronRegistros = "No se han encontrado registros";

        #endregion

        #region EMPLEADO

        public const String EmpleadoIndex = "~/Views/Empleado/Index.cshtml";
        public const String EmpleadoEdit = "~/Views/Empleado/EditPV.cshtml";
        public const String EmpleadoGridPV = "~/Views/Empleado/EmpleadoGridPV.cshtml";

        public const String EmpleadoUsuarioEditPV = "~/Views/Empleado/EmpleadoUsuarioEditPV.cshtml";
        #endregion

        #region TIENDA

        public const String TiendaIndex = "~/Views/Tienda/Index.cshtml";
        public const String TiendaEdit = "~/Views/Tienda/EditPV.cshtml";
        public const String TiendaGridPV = "~/Views/Tienda/TiendaGridPV.cshtml";
        public const String UbigeoPV = "~/Views/Tienda/UbigeoPV.cshtml";

        #endregion

        #region CARGO

        public const String CargoIndex = "~/Views/Cargo/Index.cshtml";
        public const String CargoEdit = "~/Views/Cargo/EditPV.cshtml";
        public const String CargoGridPV = "~/Views/Cargo/CargoGridPV.cshtml";

        #endregion

        #region GRUPO

        public const String GrupoIndex = "~/Views/Grupo/Index.cshtml";
        public const String GrupoEdit = "~/Views/Grupo/EditPV.cshtml";
        public const String GrupoGridPV = "~/Views/Grupo/GrupoGridPV.cshtml";

        #endregion

        #region USUARIO

        //public const String UsuarioIndex = "~/Views/Usuario/Index.cshtml";
        public const String UsuarioEdit = "~/Views/Usuario/EditPV.cshtml";
        //public const String UsuarioGridPV = "~/Views/Usuario/EmpleadoGridPV.cshtml";

        #endregion

        #region PRODUCTO

        public const String ProductoIndex = "~/Views/Producto/Index.cshtml";
        public const String ProductoEdit = "~/Views/Producto/EditPV.cshtml";
        public const String ProductoGridPV = "~/Views/Producto/ProductoGridPV.cshtml";

        #endregion

        #region NUMEROS

        public const Int32 UnoNegativo = -1;
        public const Int32 Cero = 0;
        public const Int32 Uno = 1;
        public const Int32 Dos = 2;
        public const Int32 Tres = 3;

        #endregion

        #region CADENAS

        public const String GuardadoExitoso = "El registro se ha guardado con exito";
        public const String GuardadoNoExitoso = "No se ha guardado el registro";
        public const String PedidoInvalidadoCantidad = "No se ha guardado el registro, la cantidad ingresada no se puede restar con la cantidad registrada anteriormente";
        public const String PedidoNoTieneRegistros = "No se ha guardado el pedido, no existen registros para este pedido";
        public const String PedidoGuardadoExitoso = "El pedido se ha guardado con exito";
        public const String PedidoNoGuardadoExitoso = "El pedido no se ha guardado con exito";

        #endregion

        #region GENERICOS

        public const Int32 Activo = 1;
        public const Int32 Inactivo = 0;

        public const String CadenaActivo = "Activo";
        public const String CadenaInactivo = "Inactivo";
        public const String CadenaTodos = "Todos";
        public const String CadenaSeleccione = "Seleccione";
        public const String CadenaVacio = "";

        public const String CadenaMasculino = "Masculino";
        public const String CadenaFemenino = "Femenino";

        public const String CadenaSoltero = "Soltero(a)";
        public const String CadenaCasado = "Casado(a)";
        public const String CadenaViudo = "Viudo(a)";
        public const String CadenaDivorciado = "Divorciado(a)";

        public const Char CaracterMasculino = 'M';
        public const Char CaracterFemenino = 'F';

        public const Char CaracterSoltero = 'S';
        public const Char CaracterCasado = 'C';
        public const Char CaracterViudo = 'V';
        public const Char CaracterDivorciado = 'D';

        public const Boolean Verdadero = true;
        public const Boolean Falso = false;

        #endregion

        #region PEDIDO

        public const String PedidoIndex = "~/Views/Pedido/Index.cshtml";
        public const String PedidoEdit = "~/Views/Pedido/EditPV.cshtml";
        public const String CabeceraGenerarPV = "~/Views/Pedido/CabeceraGenerarPV.cshtml";
        public const String PedidoGenerarPV = "~/Views/Pedido/PedidoGenerarPV.cshtml";
        public const String ProductoPedidoGridPV = "~/Views/Producto/ProductoPedidoGridPV.cshtml";
        public const String EditProductoPedidoPV = "~/Views/Pedido/EditProductoPedidoPV.cshtml";

        #endregion

        #region EMPRESA

        public const String EmpresaIndex = "~/Views/Empresa/Index.cshtml";
        public const String EmpresaEdit = "~/Views/Empresa/EditPV.cshtml";
        public const String EmpresaGridPV = "~/Views/Empresa/EmpresaGridPV.cshtml";

        #endregion

    }
}