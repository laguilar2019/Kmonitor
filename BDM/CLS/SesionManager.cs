using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBM.CLS
{
    public class Sesion
    {
        private static volatile Sesion instancia;
        private static Object syncRoot = new Object();
        String _idUsuario;
        String _Usuario;
        String _Credencial;
        String _Perfil;

        public String Credencial
        {
            get { return _Credencial; }
            set { _Credencial = value; }
        }
        public String idUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        public String Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        public String Perfil
        {
            get { return _Perfil; }
            set { _Perfil = value; }
        }
        private Sesion()
        {
            _idUsuario = "";
            _Usuario = "";
            _Credencial = "";
            _Perfil = "";
        }
        public static Sesion Instancia
        {
            get
            {
                if (instancia == null)
                {
                    lock (syncRoot)
                    {
                        if (instancia == null)
                        {
                            instancia = new Sesion();
                            instancia._idUsuario = "";
                            instancia._Usuario = "";
                            instancia._Credencial = "";
                            instancia._Perfil = "";
                        }
                    }
                }
                return instancia;
            }
        }
    }
}
