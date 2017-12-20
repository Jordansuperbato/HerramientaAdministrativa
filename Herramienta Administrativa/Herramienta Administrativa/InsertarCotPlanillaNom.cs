using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Herramienta_Administrativa
{
    public partial class InsertarCotPlanillaNom : Form
    {
        public InsertarCotPlanillaNom()
        {
            InitializeComponent();
        }
        SqlConnection ley = new SqlConnection("Data Source=SRV_SALUD_VINA;Initial Catalog=INGRESOLEY;User ID=sysmk;Password=qT1OVkF7;Integrated Security=false;");
       // SqlConnection ley = new SqlConnection("Data Source=NORTE_0_73;Initial Catalog=INGRESOLEY3;User ID=sa;Password=jordan;Integrated Security=false;");
        private void BtnIngreso_Click(object sender, EventArgs e)
        {

            try
            {
                ley.Open();

                SqlCommand com = new SqlCommand("SELECT MAX(SEQ_NOMINA) as seq_nomina FROM COT_PLANILLAS_NOM with(nolock)", ley);
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {
                    label2.Text = Convert.ToString(dr["seq_nomina"]);

                }


            }
            catch (Exception w)
            {

                MessageBox.Show("asds" + w);
               
            }
            finally
            {
                ley.Close();
               
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int contador=0;
            button2.Text = "Insertando...";
            OracleConnection net = new OracleConnection("User Id = nssprod_soporte; Password=sopo753159;Data Source = 170.110.40.19/ist1;");
            try
            {

                net.Open();
                //OracleCommand cm = new OracleCommand("select ID_ADM,SEQ_NOMINA, RUT_EMPRESA,RUT_PERSONA,REGEXP_REPLACE(APE_PAT_PERSONA,'[^A-Za-z0-9ÁÉÍÓÚáéíóú ]')as APE_PAT_PERSONA,REGEXP_REPLACE(APE_MAT_PERSONA,'[^A-Za-z0-9ÁÉÍÓÚáéíóú ]')AS APE_MAT_PERSONA ,REGEXP_REPLACE(NOM_PERSONA,'[^A-Za-z0-9ÁÉÍÓÚáéíóú ]')AS NOM_PERSONA ,TO_CHAR(PER_COTIZA,'yyyy-mm-dd hh:mm:ss') as PER_COTIZA,NUM_PLANILLA,FOL_PLANILLA,VAL_RENTA_IMPONIBLE,COD_MVTO_PERSONAL,  case when FEC_INICIO_MVTO_PERSONAL is null then 'NULL' WHEN FEC_INICIO_MVTO_PERSONAL > (sysdate+17885) then   'NULL' WHEN FEC_INICIO_MVTO_PERSONAL < (sysdate-17885) then   'NULL'  else TO_CHAR(FEC_INICIO_MVTO_PERSONAL,'yyyy-mm-dd hh:mm:ss') end AS FEC_INICIO_MVTO_PERSONAL,case when FEC_FIN_MVTO_PERSONAL is null then 'NULL'WHEN FEC_FIN_MVTO_PERSONAL > (sysdate+17885) then   'NULL' WHEN FEC_FIN_MVTO_PERSONAL < (sysdate-17885) then   'NULL' else TO_CHAR(FEC_FIN_MVTO_PERSONAL,'yyyy-mm-dd hh:mm:ss')  end AS FEC_FIN_MVTO_PERSONAL,ESTADO_REG_NOMINA,ESTADO_REG,TO_CHAR(FEC_ESTADO_REG,'yyyy-mm-dd hh:mm:ss') AS FEC_ESTADO_REG ,TO_CHAR(FEC_ING_REG, 'yyyy-mm-dd hh:mm:ss') AS FEC_ING_REG,ID_USUARIO_ING_REG,TO_CHAR(FEC_ULT_MODIF_REG,'yyyy-mm-dd hh:mm:ss') AS FEC_ULT_MODIF_REG ,ID_USUARIO_ULT_MODIF_REG,ID_FUNCION_ULT_MODIF_REG,COD_ENT,NOM_ARC,SEQ_PRO,TO_CHAR(FEC_NACIMIENTO,'yyyy-mm-dd hh:mm:ss') AS FEC_NACIMIENTO,SEXO,DIAS_TRABAJADOS,TIPO_LINEA,NACIONALIDAD,COTIZACION_ACCIDENTE,SISTEMA_DE_SALUD,SISTEMA_PREVISIONAL from cot_planillas_nom  where seq_nomina='84133997'", net);
                 OracleCommand cm = new OracleCommand("select ID_ADM,SEQ_NOMINA, RUT_EMPRESA,RUT_PERSONA,REGEXP_REPLACE(APE_PAT_PERSONA,'[^A-Za-z0-9ÁÉÍÓÚáéíóú ]')as APE_PAT_PERSONA,REGEXP_REPLACE(APE_MAT_PERSONA,'[^A-Za-z0-9ÁÉÍÓÚáéíóú ]')AS APE_MAT_PERSONA ,REGEXP_REPLACE(NOM_PERSONA,'[^A-Za-z0-9ÁÉÍÓÚáéíóú ]')AS NOM_PERSONA ,TO_CHAR(PER_COTIZA,'yyyy-mm-dd hh:mm:ss') as PER_COTIZA,NUM_PLANILLA,FOL_PLANILLA,VAL_RENTA_IMPONIBLE,COD_MVTO_PERSONAL,  case when FEC_INICIO_MVTO_PERSONAL is null then 'NULL' WHEN FEC_INICIO_MVTO_PERSONAL > (sysdate+17885) then   'NULL' WHEN FEC_INICIO_MVTO_PERSONAL < (sysdate-17885) then   'NULL'  else TO_CHAR(FEC_INICIO_MVTO_PERSONAL,'yyyy-mm-dd hh:mm:ss') end AS FEC_INICIO_MVTO_PERSONAL,case when FEC_FIN_MVTO_PERSONAL is null then 'NULL'WHEN FEC_FIN_MVTO_PERSONAL > (sysdate+17885) then   'NULL' WHEN FEC_FIN_MVTO_PERSONAL < (sysdate-17885) then   'NULL' else TO_CHAR(FEC_FIN_MVTO_PERSONAL,'yyyy-mm-dd hh:mm:ss')  end AS FEC_FIN_MVTO_PERSONAL,ESTADO_REG_NOMINA,ESTADO_REG,TO_CHAR(FEC_ESTADO_REG,'yyyy-mm-dd hh:mm:ss') AS FEC_ESTADO_REG ,TO_CHAR(FEC_ING_REG, 'yyyy-mm-dd hh:mm:ss') AS FEC_ING_REG,ID_USUARIO_ING_REG,TO_CHAR(FEC_ULT_MODIF_REG,'yyyy-mm-dd hh:mm:ss') AS FEC_ULT_MODIF_REG ,ID_USUARIO_ULT_MODIF_REG,ID_FUNCION_ULT_MODIF_REG,COD_ENT,NOM_ARC,SEQ_PRO,TO_CHAR(FEC_NACIMIENTO,'yyyy-mm-dd hh:mm:ss') AS FEC_NACIMIENTO,SEXO,DIAS_TRABAJADOS,TIPO_LINEA,NACIONALIDAD,COTIZACION_ACCIDENTE,SISTEMA_DE_SALUD,SISTEMA_PREVISIONAL from cot_planillas_nom  where seq_nomina>'" + label2.Text+"'", net);

                cm.CommandType = CommandType.Text;
             
                OracleDataReader dr = cm.ExecuteReader();


              //  MessageBox.Show("" + dr);


                try
                {

                  ley.Open();
                  //  int contador = 0;
                    while (dr.Read())
                    {
                        string fec1 = Convert.ToString(dr["FEC_INICIO_MVTO_PERSONAL"]);
                        string fec2 = Convert.ToString(dr["FEC_FIN_MVTO_PERSONAL"]);
                      
                        if (fec1=="NULL")
                        {
                            fec1 = "NULL";
                        }
                        else
                        {
                            fec1 = "'"+ dr["FEC_INICIO_MVTO_PERSONAL"] + "'";
                        }
                        if (fec2 == "NULL")
                        {
                            fec2 = "NULL";
                        }
                        else
                        {
                            fec2 = "'" + dr["FEC_FIN_MVTO_PERSONAL"] + "'";
                        }
                         SqlCommand com = new SqlCommand("insert into cot_planillas_nom(ID_ADM, SEQ_NOMINA, RUT_EMPRESA, RUT_PERSONA, APE_PAT_PERSONA, APE_MAT_PERSONA, NOM_PERSONA, PER_COTIZA, NUM_PLANILLA, FOL_PLANILLA, VAL_RENTA_IMPONIBLE, COD_MVTO_PERSONAL, FEC_INICIO_MVTO_PERSONAL, FEC_FIN_MVTO_PERSONAL, ESTADO_REG_NOMINA, ESTADO_REG, FEC_ESTADO_REG, FEC_ING_REG, ID_USUARIO_ING_REG, FEC_ULT_MODIF_REG, ID_USUARIO_ULT_MODIF_REG, ID_FUNCION_ULT_MODIF_REG, COD_ENT, NOM_ARC, SEQ_PRO, FEC_NACIMIENTO, SEXO, DIAS_TRABAJADOS, TIPO_LINEA, NACIONALIDAD, COTIZACION_ACCIDENTE, SISTEMA_DE_SALUD, SISTEMA_PREVISIONAL, victima)values('" + Convert.ToString(dr["ID_ADM"]) + "', '" + Convert.ToString(dr["SEQ_NOMINA"]) + "', '" + Convert.ToString(dr["RUT_EMPRESA"]) + "', '" + Convert.ToString(dr["RUT_PERSONA"]) + "', '" + Convert.ToString(dr["APE_PAT_PERSONA"]) + "', '" + Convert.ToString(dr["APE_MAT_PERSONA"]) + "', '" + Convert.ToString(dr["NOM_PERSONA"]) + "', '" + Convert.ToString(dr["PER_COTIZA"]) + "', '" + Convert.ToString(dr["NUM_PLANILLA"]) + "', '" + Convert.ToString(dr["FOL_PLANILLA"]) + "', '" + Convert.ToString(dr["VAL_RENTA_IMPONIBLE"]) + "', '" + Convert.ToString(dr["COD_MVTO_PERSONAL"]) + "', " + fec1 + ", " + fec2 + ", '" + Convert.ToString(dr["ESTADO_REG_NOMINA"]) + "', '" + Convert.ToString(dr["ESTADO_REG"]) + "', '" + Convert.ToString(dr["FEC_ESTADO_REG"]) + "', '" + Convert.ToString(dr["FEC_ING_REG"]) + "', '" + Convert.ToString(dr["ID_USUARIO_ING_REG"]) + "', '" + Convert.ToString(dr["FEC_ULT_MODIF_REG"]) + "', '" + Convert.ToString(dr["ID_USUARIO_ULT_MODIF_REG"]) + "', '" + Convert.ToString(dr["ID_FUNCION_ULT_MODIF_REG"]) + "', '" + Convert.ToString(dr["COD_ENT"]) + "', '" + Convert.ToString(dr["NOM_ARC"]) + "', '" + Convert.ToString(dr["SEQ_PRO"]) + "', '" + Convert.ToString(dr["FEC_NACIMIENTO"]) + "', '" + Convert.ToString(dr["SEXO"]) + "', '" + Convert.ToString(dr["DIAS_TRABAJADOS"]) + "', '" + Convert.ToString(dr["TIPO_LINEA"]) + "', '" + Convert.ToString(dr["NACIONALIDAD"]) + "', '" + Convert.ToString(dr["COTIZACION_ACCIDENTE"]) + "', '" + Convert.ToString(dr["SISTEMA_DE_SALUD"]) + "', '" + Convert.ToString(dr["SISTEMA_PREVISIONAL"]) + "', '')",ley);



                        try
                        {

                            //MessageBox.Show("insert into cot_planillas_nom(ID_ADM, SEQ_NOMINA, RUT_EMPRESA, RUT_PERSONA, APE_PAT_PERSONA, APE_MAT_PERSONA, NOM_PERSONA, PER_COTIZA, NUM_PLANILLA, FOL_PLANILLA, VAL_RENTA_IMPONIBLE, COD_MVTO_PERSONAL, FEC_INICIO_MVTO_PERSONAL, FEC_FIN_MVTO_PERSONAL, ESTADO_REG_NOMINA, ESTADO_REG, FEC_ESTADO_REG, FEC_ING_REG, ID_USUARIO_ING_REG, FEC_ULT_MODIF_REG, ID_USUARIO_ULT_MODIF_REG, ID_FUNCION_ULT_MODIF_REG, COD_ENT, NOM_ARC, SEQ_PRO, FEC_NACIMIENTO, SEXO, DIAS_TRABAJADOS, TIPO_LINEA, NACIONALIDAD, COTIZACION_ACCIDENTE, SISTEMA_DE_SALUD, SISTEMA_PREVISIONAL, victima)values('" + Convert.ToString(dr["ID_ADM"]) + "', '" + Convert.ToString(dr["SEQ_NOMINA"]) + "', '" + Convert.ToString(dr["RUT_EMPRESA"]) + "', '" + Convert.ToString(dr["RUT_PERSONA"]) + "', '" + Convert.ToString(dr["APE_PAT_PERSONA"]) + "', '" + Convert.ToString(dr["APE_MAT_PERSONA"]) + "', '" + Convert.ToString(dr["NOM_PERSONA"]) + "', '" + Convert.ToString(dr["PER_COTIZA"]) + "', '" + Convert.ToString(dr["NUM_PLANILLA"]) + "', '" + Convert.ToString(dr["FOL_PLANILLA"]) + "', '" + Convert.ToString(dr["VAL_RENTA_IMPONIBLE"]) + "', '" + Convert.ToString(dr["COD_MVTO_PERSONAL"]) + "', " + fec1 + ", " + fec2+ ", '" + Convert.ToString(dr["ESTADO_REG_NOMINA"]) + "', '" + Convert.ToString(dr["ESTADO_REG"]) + "', '" + Convert.ToString(dr["FEC_ESTADO_REG"]) + "', '" + Convert.ToString(dr["FEC_ING_REG"]) + "', '" + Convert.ToString(dr["ID_USUARIO_ING_REG"]) + "', '" + Convert.ToString(dr["FEC_ULT_MODIF_REG"]) + "', '" + Convert.ToString(dr["ID_USUARIO_ULT_MODIF_REG"]) + "', '" + Convert.ToString(dr["ID_FUNCION_ULT_MODIF_REG"]) + "', '" + Convert.ToString(dr["COD_ENT"]) + "', '" + Convert.ToString(dr["NOM_ARC"]) + "', '" + Convert.ToString(dr["SEQ_PRO"]) + "', '" + Convert.ToString(dr["FEC_NACIMIENTO"]) + "', '" + Convert.ToString(dr["SEXO"]) + "', '" + Convert.ToString(dr["DIAS_TRABAJADOS"]) + "', '" + Convert.ToString(dr["TIPO_LINEA"]) + "', '" + Convert.ToString(dr["NACIONALIDAD"]) + "', '" + Convert.ToString(dr["COTIZACION_ACCIDENTE"]) + "', '" + Convert.ToString(dr["SISTEMA_DE_SALUD"]) + "', '" + Convert.ToString(dr["SISTEMA_PREVISIONAL"]) + "', ''); ");

                            com.ExecuteNonQuery();

                            contador++;

                           
                        
                    
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Error al insertar" + ex);
                            ley.Close();
                            net.Close();
                        }
                       
                        //MessageBoxTemporal.Show("Continuamos trabajando...", "Estado", 0, true);
                    }

                    MessageBox.Show("proceso finalizado");
                    button2.Text = "Insertados";
                    ley.Close();
                    button2.Enabled = true;
                    label5.Text = Convert.ToString(contador);
                }
                catch (Exception ex)
                {
                    ley.Close();
                    net.Close();
                 
                    MessageBox.Show("Error al conectar a Base de Datos net" + ex);

                }



                net.Close();
            }
            catch (Exception ex)
            {
                net.Close();
               
                MessageBox.Show("Error" + ex);
              
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Globales.gbUsuario == "18266149-K")
            {
                MenuAdmin ad = new MenuAdmin();
                ad.Show();
                this.Hide();
            }
            else
            {
                Menu a = new Menu();
                a.Show();
                this.Hide();
            }
        }
    }
}
