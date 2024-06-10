namespace Shared
{
    public static class Constantes
    {

        //MENSAJES PARA LOS MESSAGEBOX
        public static readonly string TITULO_AVISO_GENERICO = "Aviso";
        public static readonly string TITULO_ERROR_GENERICO = "Error";
        public static readonly string TITULO_EXITO_GENERICO = "Operación correcta";
        public static readonly string MENSAJE_ERROR_GENERICO = "Se ha producido un error en la aplicación.Contacte con su administrador.";
        public static readonly string MENSAJE_EXITO_GENERICO = "Operacion realizada correctamente";
        public static readonly string MENSAJE_CONFIRMACION_GENERICO = "Esta operación no se puede deshacer. ¿Desea continuar?";
        public static readonly string MENSAJE_CONFIRMACION_ELIMINAR_PLANTILLA = "Se borrará la Plantilla y toda la relación de campos vinculados a ella. Esta operación no se puede deshacer. ¿Desea continuar?";                
        public static readonly string MENSAJE_ERROR_CAMPO_OBLIGATORIO_LOGIN = "Debe introducir usuario y contraseña";
        public static readonly string MENSAJE_ERROR_CAMPO_OBLIGATORIO_NOMBRE = "Debe introducir un nombre.";
        public static readonly string MENSAJE_ERROR_CAMPO_OBLIGATORIO_USUARIO = "Debe introducir un usuario.";
        public static readonly string MENSAJE_ERROR_CAMPO_OBLIGATORIO_PLANTILLA = "Debe introducir un id de Plantilla.";
        public static readonly string MENSAJE_ERROR_USUARIO_EXISTENTE = "El usuario introducido ya existe.";
        public static readonly string MENSAJE_ERROR_EMAIL_INCORRECTO = "Debe introducir email válido.";
        public static readonly string MENSAJE_ERROR_LOGIN = "Usuario y/o contraseña incorrecto/s.";
        public static readonly string MENSAJE_ERROR_NO_FILA_SELECCIONADA = "Debe seleccionar al menos una fila.";
        public static readonly string MENSAJE_ERROR_NO_CAMPOS_PLANTILLA = "Debe indicar alguna fila completa de campos para esta plantilla.";
        public static readonly string MENSAJE_ERROR_NO_NOMBRE_PLANTILLA = "Debe indicar algún Nombre para esta plantilla.";
        public static readonly string MENSAJE_ERROR_NO_PLANTILLA = "Debe seleccionar algún fichero de Word para esta plantilla.";
        public static readonly string MENSAJE_ERROR_CONTACTE_INFORMATICA = "Si tiene problemas para iniciar sesión en esta aplicación contacte con el Servicio de Desarrollo Tecnológico en soporte.desarrollo@ayto-caceres.es.";
        public static readonly string MENSAJE_ERROR_AUTENTICACION = "El nombre de usuario y/o contraseña no son correcto/s.";
        public static readonly string MENSAJE_ERROR_AUTORIZACION = "El usuario no tiene permisos para acceder a esta aplicación.";
        public static readonly string MENSAJE_ERROR_AUTORIZACION_IMPRIMIR_PLANTILLA = "El usuario no tiene permisos para imprimir esta plantilla.";
        public static readonly string MENSAJE_ERROR_AUTORIZACION_EDITAR_PLANTILLA = "El usuario no tiene permisos para editar esta plantilla.";
        public static readonly string MENSAJE_ERROR_NO_EXPEDIENTE_URBANISMO = "No existe ningún expediente con la clave proporcionada.";
        public static readonly string MENSAJE_ERROR_NO_EXPEDIENTE_ASESORIA = "No existe ningún expediente de Asesoría Jurídica con el número proporcionado.";
        public static readonly string MENSAJE_ERROR_NO_EXPEDIENTE_MYTAO_URBANISMO = "No existe ningún expediente de MyTAO relacionado con este expediente de Urbanismo.";
        public static readonly string MENSAJE_ERROR_NO_EXPEDIENTE_MYTAO_ASESORIA = "No existe ningún expediente de MyTAO relacionado con este expediente de Asesoría Jurídica.";
        public static readonly string MENSAJE_ERROR_NO_EXPEDIENTE_MYTAO = "No existe ningún expediente de MyTAO con el número proporcionado.";
        public static readonly string MENSAJE_ERROR_NO_EXPEDIENTE_MYTAO_RELACIONADO = "No existe ningún expediente de MyTAO relacionado.";
        public static readonly string MENSAJE_SOLICITAR_PLANTILLA = "Para solicitar la configuración de una nueva plantilla envíe un email a soporte.desarrollo@ayto-caceres.es y nos pondremos en contacto con usted.";
        public static readonly string MENSAJE_CAMPOS_OBLIGATORIOS = "Todos los campos son obligatorios";
        public static readonly string MENSAJE_ERROR_NO_EXISTE_PLANTILLA = "No existe ninguna plantilla para el id proporcionado.";
        public static readonly string MENSAJE_ERROR_PLANTILLA_NO_PREPARADA = "Solo puede imprimir plantillas en estado 'Preparada'.";


        //VALORES PARA EL SERVICIO WEB DE LA SEGURIDAD
        public static readonly int CODIGO_OPERACION_USUARIO_AUTENTICADO = 1;
        public static readonly int CODIGO_OPERACION_USUARIO_AUTORIZADO = 2;
        public static readonly int ID_APLICACION_GPLAN = 19;
        public static readonly string DOMINIO_AYTO = "AYTO-CACERES";

        //VALORES DE LOS PERFILES DE LA APLICACION
        public static readonly int PERFIL_ADMINISTRADOR = 30;
        public static readonly int PERFIL_URBANISMO = 31;
        public static readonly int PERFIL_LICENCIAS = 32;
        public static readonly int PERFIL_DISPLICINA_URBANISTICA = 36;
        public static readonly int PERFIL_SANCIONES = 37;

        //COMBO TIPOS DE CAMPOS DE PLANTILLAS
        public static readonly string TIPO_CAMPO_BBDD = "Base de datos";
        public static readonly string TIPO_CAMPO_MYTAO = "MyTao";

        //TIPOS
        public static readonly int TIPO_DEPARTAMENTOS = 1;
        public static readonly int TIPO_ESTADOS = 3;
        public static readonly int TIPO_SEGURIDAD = 2;
        public static readonly int TIPO_TIPOS_CAMPO = 4;

        //VALORES
        //VALORES DE LOS TIPOS DE SEGURIDAD DE LAS PLANTILLAS
        public static readonly int VALOR_SEGURIDAD_PLANTILLA_PUBLICA = 2;
        public static readonly int VALOR_SEGURIDAD_PLANTILLA_PRIVADA = 3;

        //VALORES DE LOS TIPOS DE ESTADO DE LAS PLANTILLAS
        public static readonly int VALOR_ESTADO_PENDIENTE_CONFIGURAR = 6;
        public static readonly int VALOR_ESTADO_PREPARADA = 7;

        //VALORES DE LOS TIPOS DE DEPARTAMENTOS
        public static readonly int VALOR_DEPARTAMENTO_URBANISMO = 1;
        public static readonly int VALOR_DEPARTAMENTO_SANCIONES = 14;
        public static readonly int VALOR_DEPARTAMENTO_LICENCIAS = 17;

        //VALORES DE LOS TIPOS DE CAMPO EN LAS PLANTILLAS
        public static readonly int VALOR_TIPO_CAMPO_BBDD = 9;
        public static readonly int VALOR_TIPO_CAMPO_MYTAO = 10;
    }
}
