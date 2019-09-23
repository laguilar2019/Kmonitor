using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DBM.CLS
{
    
    public class Utilities
    {
        private static string MyApp_StringConnectionName = "KMonitor.Properties.Settings.cnxString";
        public string GetConnectionStringName() // Obtener la cadena de conexión a partir del nombre
        {
            return MyApp_StringConnectionName;
        }

        public string GetConnectionString() // Obtener la cadena de conexión a partir del nombre
        {
            try
            {
                Configuration appconfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConnectionStringSettings connStringSettings = appconfig.ConnectionStrings.ConnectionStrings[MyApp_StringConnectionName];
                return connStringSettings.ConnectionString;
            }catch(Exception e)
            {
                return e.Message;
            }
        }
        public void SaveConnectionString(string connectionString) // Actualizar la cadena de conexión a partir del nombre y la nueva cadena
        {
            Configuration MiAppConfig = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            ConnectionStringsSection miSeccion = (ConnectionStringsSection)MiAppConfig.GetSection("connectionStrings");
            MiAppConfig.ConnectionStrings.ConnectionStrings[MyApp_StringConnectionName].ConnectionString = connectionString;
            MiAppConfig.Save();
            MessageBox.Show("Se guardó la cadena de conexión. la Aplicación se reiniciará", "ConnectionSettings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();            
        }
        public void ProtectConnectionString() //Proteger la cadena de conexión
        {
            ToggleConnectionStringProtection(System.Windows.Forms.Application.ExecutablePath, true);
        }

        public void UnprotectConnectionString() //Desproteger la cadena de conexión
        {
            ToggleConnectionStringProtection(System.Windows.Forms.Application.ExecutablePath, false);
        }

        private void ToggleConnectionStringProtection
                (string pathName, bool protect)
        {
            // Define the Dpapi provider name.
            string strProvider = "DataProtectionConfigurationProvider";
            // string strProvider = "RSAProtectedConfigurationProvider";
            System.Configuration.Configuration oConfiguration = null;
            System.Configuration.ConnectionStringsSection oSection = null;

            try
            {
                // Open the configuration file and retrieve 
                // the connectionStrings section.
                // For Web!
                // oConfiguration = System.Web.Configuration.
                //                  WebConfigurationManager.OpenWebConfiguration("~");

                // For Windows!
                // Takes the executable file name without the config extension.
                oConfiguration = System.Configuration.ConfigurationManager.OpenExeConfiguration(pathName);

                if (oConfiguration != null)
                {
                    bool blnChanged = false;
                    oSection = oConfiguration.GetSection("connectionStrings") as System.Configuration.ConnectionStringsSection;
                    if (oSection != null)
                    {
                        if ((!(oSection.ElementInformation.IsLocked)) && (!(oSection.SectionInformation.IsLocked)))
                        {
                            if (protect)
                            {
                                if (!(oSection.SectionInformation.IsProtected))
                                {
                                    blnChanged = true;
                                    // Encrypt the section.
                                    oSection.SectionInformation.ProtectSection(strProvider);
                                    MessageBox.Show("Protección aplicada satisfactoriamente", "ConnectionSettings", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }
                            else
                            {
                                if (oSection.SectionInformation.IsProtected)
                                {
                                    blnChanged = true;
                                    // Remove encryption.
                                    oSection.SectionInformation.UnprotectSection();
                                    MessageBox.Show("Se ha desprotegido la cadena de conexión", "ConnectionSettings", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        if (blnChanged)
                        {
                            // Indicates whether the associated configuration section 
                            // will be saved even if it has not been modified.
                            oSection.SectionInformation.ForceSave = true;
                            // Save the current configuration.
                            oConfiguration.Save();
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw (ex);
            }
            finally
            {
            }

        }
        //Obtener la lista de conexiones disponibles
        public static List<string> GetConnectionStringNames()
        {
            List<string> cns = new List<string>();
            Configuration appconfig =ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            foreach (ConnectionStringSettings cn in appconfig.ConnectionStrings.ConnectionStrings)
            {
                cns.Add(cn.Name);
            }
            return cns;
        }

        //Obtener el nombre del servidor
        public string GetMySQL_ServerName()
        {
            try { 
            string cs = GetConnectionString();
            if (cs != null)
            {
                    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(cs);
                return builder.Server;
            }
            else
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        //Obtener el nombre del servidor
        public uint  GetMySQL_Port()
        {
            try
            {
                string cs = GetConnectionString();
                if (cs != null)
                {
                    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(cs);
                    return builder.Port;
                }
                else
                    return 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        //Obtener el nombre de la base de datos
        public string GetMySQL_DatabaseName()
        {
            try { 
            string cs = GetConnectionString();
            if (cs != null)
            {
                //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cs);
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(cs);
                return builder.Database;
            }
            else
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string GetMySQL_UserName()
        {
            try { 
            string cs = GetConnectionString();
            if (cs != null)
            {
                    //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cs);
                    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(cs);
                    return builder.UserID;
            }
            else
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string GetMySQL_Password()
        {
            try { 
            string cs = GetConnectionString();
            if (cs != null)
            {
                    //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cs);
                    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(cs);
                    return builder.Password;
            }
            else
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }


        public bool? GetMySQL_IntegratedSecurity()
        {
            try{ 
                string cs = GetConnectionString();
                if (cs != null)
                {
                    //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cs);
                    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(cs);
                    return builder.IntegratedSecurity;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        //*******************************************************************************
        //*  Setters
        //*******************************************************************************
        public string SetConnectionStringComplete(string serverName, uint port, string databaseName, string username, string password)
        {

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(GetConnectionString());
            builder.Server = serverName;
            builder.Database = databaseName;
            builder.UserID = username;
            builder.Password = password;
            builder.Port = port;
            return builder.ConnectionString;
        }
        public string SetConnectionStringServerName(string serverName)
        {

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(GetConnectionString());
            builder.Server = serverName;
            return builder.ConnectionString;
        }
        public string SetConnectionStringPort(uint port)
        {

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(GetConnectionString());
            builder.Port= port;
            return builder.ConnectionString;
        }
        public string SetConnectionStringDatabaseName(string databaseName)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(GetConnectionString());
            builder.Database = databaseName;
            return builder.ConnectionString;
        }

        public string SetConnectionStringAutenticationMySQL(string username, string password)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(GetConnectionString());
            //builder.PersistSecurityInfo = false;
            builder.UserID = username;
            builder.Password = password;
            return builder.ConnectionString;
        }


        public string SetConnectionStringAutenticationIntegrated(string connectionString)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(connectionString);
            builder.IntegratedSecurity = true;
            return builder.ConnectionString;
        }

    }
}
