#region Librerías
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos;
using System.Data;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using Negocio.Lógica;
#endregion

#region Manejo de datos
namespace Negocio.Manejo_de_datos
{
    #region Class
    public class CRUD_Usuario
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        SqlCommand Comando;
        AccionesSistema As = new AccionesSistema();
        #endregion

        #region Propiedades
        public long id_usuario { get; set; }
        public string primer_nombre { get; set; }
		public string segundo_nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        public char genero { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string tipo_documento { get; set; }
        public string numero_documento { get; set; }
        public string departamento_residencia { get; set; }
        public string ciudad_residencia { get; set; }
        public string localidad_residencia { get; set; }
        public string direccion_residencia { get; set; }
        public string telefono_celular { get; set; }
        public string telefono_fijo { get; set; }
        public string facebook { get; set; }
        public string twiter { get; set; }
        public string instagram { get; set; }
        public string gmail { get; set; }
        public string diseño_entorno { get; set; }
        public bool sonido { get; set; }
        public string nombre_usuario { get; set; }
        public string contrasena { get; set; }
        public string correo { get; set; }
        public string pregunta_seguridad { get; set; }
        public string respuesta_pregunta_seguridad { get; set; }
        public string pin { get; set; }
        public Image foto_perfil { get; set; }
        public DateTime fecha_actualizacion { get; set; }
        public DateTime fecha_registro { get; set; }
        public bool estado { get; set; }
        #endregion

        #region Constructores
        public CRUD_Usuario()
        {
        }
        public CRUD_Usuario(long p_id_usuario,
            string p_primer_nombre,string p_segundo_nombre,
            string p_primer_apellido,string p_segundo_apellido,
            char p_genero, DateTime p_fecha_nacimiento,
            string p_tipo_documento,string p_numero_documento,
            string p_departamento_residencia,string p_ciudad_residencia,
            string p_localidad_residencia,string p_direccion_residencia,
            string p_telefono_celular,string p_telefono_fijo,
            string p_facebook,string p_twiter,
            string p_instagram,string p_gmail,
            string p_diseño_entorno,bool p_sonido,
            string p_nombre_usuario,string p_contrasena,
            string p_correo, string p_pregunta_seguridad,
            string p_respuesta_pregunta_seguridad,string p_pin,
            Image p_foto_perfil,DateTime p_fecha_actualizacion,
            DateTime p_fecha_registro,bool p_estado)
        {
            id_usuario = p_id_usuario;
            primer_nombre = p_primer_nombre;
            segundo_nombre = p_segundo_nombre;
            primer_apellido = p_primer_apellido;
            segundo_apellido = p_segundo_apellido;
            genero = p_genero;
            fecha_nacimiento = p_fecha_nacimiento;
            tipo_documento = p_tipo_documento;
            numero_documento = p_numero_documento;
            departamento_residencia = p_departamento_residencia;
            ciudad_residencia = p_ciudad_residencia;
            localidad_residencia = p_localidad_residencia;
            direccion_residencia = p_direccion_residencia;
            telefono_celular = p_telefono_celular;
            telefono_fijo = p_telefono_fijo;
            facebook = p_facebook;
            twiter = p_twiter;
            instagram = p_instagram;
            gmail = p_gmail;
            diseño_entorno = p_diseño_entorno;
            sonido = p_sonido;
            nombre_usuario = p_nombre_usuario;
            contrasena = p_contrasena;
            correo = p_correo;
            pregunta_seguridad = p_pregunta_seguridad;
            respuesta_pregunta_seguridad = p_respuesta_pregunta_seguridad;
            pin = p_pin;
            foto_perfil = p_foto_perfil;
            fecha_actualizacion = p_fecha_actualizacion;
            fecha_registro = p_fecha_registro;
            estado = p_estado;
        }
        public CRUD_Usuario(string p_primer_nombre, string p_segundo_nombre,
            string p_primer_apellido, string p_segundo_apellido,
            char p_genero, DateTime p_fecha_nacimiento,
            string p_tipo_documento, string p_numero_documento,
            string p_departamento_residencia, string p_ciudad_residencia,
            string p_localidad_residencia, string p_direccion_residencia,
            string p_telefono_celular, string p_telefono_fijo,
            string p_facebook, string p_twiter,
            string p_instagram, string p_gmail,
            string p_diseño_entorno, bool p_sonido,
            string p_nombre_usuario, string p_contrasena,
            string p_correo, string p_pregunta_seguridad,
            string p_respuesta_pregunta_seguridad, string p_pin,
            Image p_foto_perfil, DateTime p_fecha_actualizacion,
            DateTime p_fecha_registro, bool p_estado)
        {
            primer_nombre = p_primer_nombre;
            segundo_nombre = p_segundo_nombre;
            primer_apellido = p_primer_apellido;
            segundo_apellido = p_segundo_apellido;
            genero = p_genero;
            fecha_nacimiento = p_fecha_nacimiento;
            tipo_documento = p_tipo_documento;
            numero_documento = p_numero_documento;
            departamento_residencia = p_departamento_residencia;
            ciudad_residencia = p_ciudad_residencia;
            localidad_residencia = p_localidad_residencia;
            direccion_residencia = p_direccion_residencia;
            telefono_celular = p_telefono_celular;
            telefono_fijo = p_telefono_fijo;
            facebook = p_facebook;
            twiter = p_twiter;
            instagram = p_instagram;
            gmail = p_gmail;
            diseño_entorno = p_diseño_entorno;
            sonido = p_sonido;
            nombre_usuario = p_nombre_usuario;
            contrasena = p_contrasena;
            correo = p_correo;
            pregunta_seguridad = p_pregunta_seguridad;
            respuesta_pregunta_seguridad = p_respuesta_pregunta_seguridad;
            pin = p_pin;
            foto_perfil = p_foto_perfil;
            fecha_actualizacion = p_fecha_actualizacion;
            fecha_registro = p_fecha_registro;
            estado = p_estado;
        }
        public CRUD_Usuario(string p_primer_nombre, string p_segundo_nombre,
            string p_primer_apellido, string p_segundo_apellido,
            char p_genero, DateTime p_fecha_nacimiento,
            string p_tipo_documento, string p_numero_documento,
            string p_departamento_residencia, string p_ciudad_residencia,
            string p_localidad_residencia, string p_direccion_residencia,
            string p_telefono_celular, string p_telefono_fijo,
            string p_diseño_entorno,
            string p_nombre_usuario, string p_contrasena,
            string p_correo, string p_pregunta_seguridad,
            string p_respuesta_pregunta_seguridad, string p_pin,
            Image p_foto_perfil)
        {
            primer_nombre = p_primer_nombre;
            segundo_nombre = p_segundo_nombre;
            primer_apellido = p_primer_apellido;
            segundo_apellido = p_segundo_apellido;
            genero = p_genero;
            fecha_nacimiento = p_fecha_nacimiento;
            tipo_documento = p_tipo_documento;
            numero_documento = p_numero_documento;
            departamento_residencia = p_departamento_residencia;
            ciudad_residencia = p_ciudad_residencia;
            localidad_residencia = p_localidad_residencia;
            direccion_residencia = p_direccion_residencia;
            telefono_celular = p_telefono_celular;
            telefono_fijo = p_telefono_fijo;
            diseño_entorno = p_diseño_entorno;
            nombre_usuario = p_nombre_usuario;
            contrasena = p_contrasena;
            correo = p_correo;
            pregunta_seguridad = p_pregunta_seguridad;
            pregunta_seguridad = p_pregunta_seguridad;
            respuesta_pregunta_seguridad = p_respuesta_pregunta_seguridad;
            pin = p_pin;
            foto_perfil = p_foto_perfil;
        }
        public CRUD_Usuario(string value)
        {
            primer_nombre = 
            segundo_nombre = 
            primer_apellido = 
            segundo_apellido = 
            tipo_documento = 
            numero_documento = 
            departamento_residencia = 
            ciudad_residencia = 
            localidad_residencia = 
            direccion_residencia = 
            telefono_celular = 
            telefono_fijo = 
            facebook = 
            twiter = 
            instagram = 
            gmail = 
            diseño_entorno = 
            nombre_usuario = 
            contrasena = 
            correo = 
            pregunta_seguridad = 
            respuesta_pregunta_seguridad = 
            pin = value;
        }
        public CRUD_Usuario(long value)
        {
           id_usuario = value;
        }
        #endregion

        #region Métodos
        
        public long Insert()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "insert_usuario_complete";

            SqlParameter primer_nombre = new SqlParameter();
            primer_nombre.ParameterName = "@primer_nombre";
            primer_nombre.Value = this.primer_nombre;
            primer_nombre.Direction = ParameterDirection.Input;
            primer_nombre.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(primer_nombre);

            SqlParameter segundo_nombre = new SqlParameter();
            segundo_nombre.ParameterName = "@segundo_nombre";
            segundo_nombre.Value = this.segundo_nombre;
            segundo_nombre.Direction = ParameterDirection.Input;
            segundo_nombre.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(segundo_nombre);

            SqlParameter primer_apellido = new SqlParameter();
            primer_apellido.ParameterName = "@primer_apellido";
            primer_apellido.Value = this.primer_apellido;
            primer_apellido.Direction = ParameterDirection.Input;
            primer_apellido.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(primer_apellido);

            SqlParameter segundo_apellido = new SqlParameter();
            segundo_apellido.ParameterName = "@segundo_apellido";
            segundo_apellido.Value = this.segundo_apellido;
            segundo_apellido.Direction = ParameterDirection.Input;
            segundo_apellido.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(segundo_apellido);

            SqlParameter genero = new SqlParameter();
            genero.ParameterName = "@genero";
            genero.Value = this.genero;
            genero.Direction = ParameterDirection.Input;
            genero.SqlDbType = SqlDbType.Char;
            Comando.Parameters.Add(genero);

            SqlParameter fecha_nacimiento = new SqlParameter();
            fecha_nacimiento.ParameterName = "@fecha_nacimiento";
            fecha_nacimiento.Value = this.fecha_nacimiento;
            fecha_nacimiento.Direction = ParameterDirection.Input;
            fecha_nacimiento.SqlDbType = SqlDbType.Date;
            Comando.Parameters.Add(fecha_nacimiento);

            SqlParameter tipo_documento = new SqlParameter();
            tipo_documento.ParameterName = "@tipo_documento";
            tipo_documento.Value = this.tipo_documento;
            tipo_documento.Direction = ParameterDirection.Input;
            tipo_documento.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(tipo_documento);

            SqlParameter numero_documento = new SqlParameter();
            numero_documento.ParameterName = "@numero_documento";
            numero_documento.Value = this.numero_documento;
            numero_documento.Direction = ParameterDirection.Input;
            numero_documento.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(numero_documento);

            SqlParameter departamento_residencia = new SqlParameter();
            departamento_residencia.ParameterName = "@departamento_residencia";
            departamento_residencia.Value = this.departamento_residencia;
            departamento_residencia.Direction = ParameterDirection.Input;
            departamento_residencia.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(departamento_residencia);

            SqlParameter ciudad_residencia = new SqlParameter();
            ciudad_residencia.ParameterName = "@ciudad_residencia";
            ciudad_residencia.Value = this.ciudad_residencia;
            ciudad_residencia.Direction = ParameterDirection.Input;
            ciudad_residencia.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(ciudad_residencia);

            SqlParameter localidad_residencia = new SqlParameter();
            localidad_residencia.ParameterName = "@localidad_residencia";
            localidad_residencia.Value = this.localidad_residencia;
            localidad_residencia.Direction = ParameterDirection.Input;
            localidad_residencia.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(localidad_residencia);

            SqlParameter direccion_residencia = new SqlParameter();
            direccion_residencia.ParameterName = "@direccion_residencia";
            direccion_residencia.Value = this.direccion_residencia;
            direccion_residencia.Direction = ParameterDirection.Input;
            direccion_residencia.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(direccion_residencia);

            SqlParameter telefono_celular = new SqlParameter();
            telefono_celular.ParameterName = "@telefono_celular";
            telefono_celular.Value = this.telefono_celular;
            telefono_celular.Direction = ParameterDirection.Input;
            telefono_celular.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(telefono_celular);

            SqlParameter telefono_fijo = new SqlParameter();
            telefono_fijo.ParameterName = "@telefono_fijo";
            telefono_fijo.Value = this.telefono_fijo;
            telefono_fijo.Direction = ParameterDirection.Input;
            telefono_fijo.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(telefono_fijo);

            SqlParameter diseño_entorno = new SqlParameter();
            diseño_entorno.ParameterName = "@diseño_entorno";
            diseño_entorno.Value = this.diseño_entorno;
            diseño_entorno.Direction = ParameterDirection.Input;
            diseño_entorno.SqlDbType = SqlDbType.Char;
            Comando.Parameters.Add(diseño_entorno);

            SqlParameter nombre_usuario = new SqlParameter();
            nombre_usuario.ParameterName = "@nombre_usuario";
            nombre_usuario.Value = this.nombre_usuario;
            nombre_usuario.Direction = ParameterDirection.Input;
            nombre_usuario.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(nombre_usuario);

            SqlParameter contrasena = new SqlParameter();
            contrasena.ParameterName = "@contrasena";
            contrasena.Value = this.contrasena;
            contrasena.Direction = ParameterDirection.Input;
            contrasena.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(contrasena);

            SqlParameter correo = new SqlParameter();
            correo.ParameterName = "@correo";
            correo.Value = this.correo;
            correo.Direction = ParameterDirection.Input;
            correo.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(correo);

            SqlParameter pregunta_seguridad = new SqlParameter();
            pregunta_seguridad.ParameterName = "@pregunta_seguridad";
            pregunta_seguridad.Value = this.pregunta_seguridad;
            pregunta_seguridad.Direction = ParameterDirection.Input;
            pregunta_seguridad.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(pregunta_seguridad);

            SqlParameter respuesta_pregunta_seguridad = new SqlParameter();
            respuesta_pregunta_seguridad.ParameterName = "@respuesta_pregunta_seguridad";
            respuesta_pregunta_seguridad.Value = this.respuesta_pregunta_seguridad;
            respuesta_pregunta_seguridad.Direction = ParameterDirection.Input;
            respuesta_pregunta_seguridad.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(respuesta_pregunta_seguridad);

            SqlParameter pin = new SqlParameter();
            pin.ParameterName = "@pin";
            pin.Value = this.pin;
            pin.Direction = ParameterDirection.Input;
            pin.SqlDbType = SqlDbType.Char;
            Comando.Parameters.Add(pin);

            SqlParameter foto_perfil = new SqlParameter();
            foto_perfil.ParameterName = "@foto_perfil";
            if (this.foto_perfil is null)
            {
                foto_perfil.Value = DBNull.Value;
            }
            else
                foto_perfil.Value = As.ConvertirImagen(this.foto_perfil);
            foto_perfil.Direction = ParameterDirection.Input;
            foto_perfil.SqlDbType = SqlDbType.Image;
            Comando.Parameters.Add(foto_perfil);

            return ED.ProcedureExecuteNonQuery(Comando);
        }

        public DataTable autentificar_nombre_usuario()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "autentificar_nombre_usuario";

            SqlParameter nombre_usuario = new SqlParameter();
            nombre_usuario.ParameterName = "@nombre_usuario";
            nombre_usuario.Value = this.nombre_usuario;
            nombre_usuario.Direction = ParameterDirection.Input;
            nombre_usuario.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(nombre_usuario);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable Autentificar(string user, string password)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "autentificar";

            SqlParameter nombre_usuario = new SqlParameter();
            nombre_usuario.ParameterName = "@nombre_usuario";
            nombre_usuario.Value = user;
            nombre_usuario.Direction = ParameterDirection.Input;
            nombre_usuario.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(nombre_usuario);

            SqlParameter contrasena = new SqlParameter();
            contrasena.ParameterName = "@contrasena";
            contrasena.Value = password;
            contrasena.Direction = ParameterDirection.Input;
            contrasena.SqlDbType = SqlDbType.VarChar;
            Comando.Parameters.Add(contrasena);

            return ED.ProcedureExecuteReader(Comando);
        }
        public DataTable Search()
        {
            Comando = new SqlCommand();
            Comando.CommandText = "select_usuario_nombre";

            return ED.ProcedureExecuteReader(Comando);
        }
        #endregion
    }
    #endregion
}
#endregion
