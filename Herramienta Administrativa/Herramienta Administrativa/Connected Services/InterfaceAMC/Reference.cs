﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Herramienta_Administrativa.InterfaceAMC {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org/BlInterfaceAMC/InterfaceAMC", ConfigurationName="InterfaceAMC.InterfaceAMCSoap")]
    public interface InterfaceAMCSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/TrabajarProtegido", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        object TrabajarProtegido(string NumTransaccion, string RutTrabajador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/TrabajarProtegido", ReplyAction="*")]
        System.Threading.Tasks.Task<object> TrabajarProtegidoAsync(string NumTransaccion, string RutTrabajador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/DetalleMedico", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        object DetalleMedico(string NumTransaccion, string folAte, string CodTipTex, string idAdm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/DetalleMedico", ReplyAction="*")]
        System.Threading.Tasks.Task<object> DetalleMedicoAsync(string NumTransaccion, string folAte, string CodTipTex, string idAdm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/ConsultaFolioNet", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        object ConsultaFolioNet(string NumTransaccion, string RutPaciente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/ConsultaFolioNet", ReplyAction="*")]
        System.Threading.Tasks.Task<object> ConsultaFolioNetAsync(string NumTransaccion, string RutPaciente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/AltaLaboral", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        object AltaLaboral(string NumTransaccion, string FolAte, string FecAlt, string FecIniLab, string RutMedAlt, string IndCauAlt, string IndCarAlt, string CondReintegro, string Condiciones, string numDias, string contTto, string Tratamiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/AltaLaboral", ReplyAction="*")]
        System.Threading.Tasks.Task<object> AltaLaboralAsync(string NumTransaccion, string FolAte, string FecAlt, string FecIniLab, string RutMedAlt, string IndCauAlt, string IndCarAlt, string CondReintegro, string Condiciones, string numDias, string contTto, string Tratamiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/AltaMedica", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        object AltaMedica(string NumTransaccion, string FolAte, string FecAlt, string FecIniLab, string RutMedAlt, string IndCauAlt, string IndCarAlt, string TipoAlta, string OtroMotivo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/AltaMedica", ReplyAction="*")]
        System.Threading.Tasks.Task<object> AltaMedicaAsync(string NumTransaccion, string FolAte, string FecAlt, string FecIniLab, string RutMedAlt, string IndCauAlt, string IndCarAlt, string TipoAlta, string OtroMotivo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/InicioTerminoAtencion", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        object InicioTerminoAtencion(string NumTransaccion, string RutPro, string RutPac, string FecRsv, string fecIniAte, string FecTerAte, string UgaOfiAte, string IndEstRsv, string FolAte, string FolOrdAte);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/InicioTerminoAtencion", ReplyAction="*")]
        System.Threading.Tasks.Task<object> InicioTerminoAtencionAsync(string NumTransaccion, string RutPro, string RutPac, string FecRsv, string fecIniAte, string FecTerAte, string UgaOfiAte, string IndEstRsv, string FolAte, string FolOrdAte);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/AnulaHoraControl", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        object AnulaHoraControl(string NumTransaccion, string RutPro, string RutPac, string FecRsv, string UgaOfiAte, string IndEstRsv, string IndCauAnuRsv, string FolAte, string FolOrdAte, string GlsAnuAte, string FolRsv, string SeqNum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/AnulaHoraControl", ReplyAction="*")]
        System.Threading.Tasks.Task<object> AnulaHoraControlAsync(string NumTransaccion, string RutPro, string RutPac, string FecRsv, string UgaOfiAte, string IndEstRsv, string IndCauAnuRsv, string FolAte, string FolOrdAte, string GlsAnuAte, string FolRsv, string SeqNum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/AsisteAControl", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        object AsisteAControl(string NumTransaccion, string RutPro, string RutPac, string FecRsv, string FecLlePac, string UgaOfiAte, string IndEstRsv, string FolAte, string FolOrdAte);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/AsisteAControl", ReplyAction="*")]
        System.Threading.Tasks.Task<object> AsisteAControlAsync(string NumTransaccion, string RutPro, string RutPac, string FecRsv, string FecLlePac, string UgaOfiAte, string IndEstRsv, string FolAte, string FolOrdAte);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/ReservaHoraControl", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        object ReservaHoraControl(string NumTransaccion, string RutPro, string RutPac, string FecRsv, string UgaOfiAte, string IndEstRsv, string FolAte, string FolOrdAte);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/ReservaHoraControl", ReplyAction="*")]
        System.Threading.Tasks.Task<object> ReservaHoraControlAsync(string NumTransaccion, string RutPro, string RutPac, string FecRsv, string UgaOfiAte, string IndEstRsv, string FolAte, string FolOrdAte);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/CalificacionAccidente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        object CalificacionAccidente(string NumTransaccion, string folAte, string IndProGra, string CauConIst, string CauConSuseso, string IndTipPac, string IndCtp, string DiasProbTto, string IndNatLes, string IndParAfe);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/CalificacionAccidente", ReplyAction="*")]
        System.Threading.Tasks.Task<object> CalificacionAccidenteAsync(string NumTransaccion, string folAte, string IndProGra, string CauConIst, string CauConSuseso, string IndTipPac, string IndCtp, string DiasProbTto, string IndNatLes, string IndParAfe);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/Diagnostico", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        object Diagnostico(string NumTransaccion, string folAte, string fecDgn, string CodDgn, string SeqJer, string IndTipDgn, string RutMedDgn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/Diagnostico", ReplyAction="*")]
        System.Threading.Tasks.Task<object> DiagnosticoAsync(string NumTransaccion, string folAte, string fecDgn, string CodDgn, string SeqJer, string IndTipDgn, string RutMedDgn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/Evolucion", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        object Evolucion(string NumTransaccion, string folAte, string fecTex, string codtiptex, string ugaofiate, string coduniser, string txtgls, string rutpro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/Evolucion", ReplyAction="*")]
        System.Threading.Tasks.Task<object> EvolucionAsync(string NumTransaccion, string folAte, string fecTex, string codtiptex, string ugaofiate, string coduniser, string txtgls, string rutpro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/ActualizaPersona", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string ActualizaPersona(
                    string NumTransaccion, 
                    string RutPer, 
                    string ApePat, 
                    string ApeMat, 
                    string NomPer, 
                    string FecNac, 
                    string FecDef, 
                    string GlsDirPer, 
                    string GlsRefDir, 
                    string UggComPer, 
                    string CodAreTel, 
                    string FonPer, 
                    string FonAlt, 
                    string CodAreFax, 
                    string FaxPer, 
                    string CodAreCel, 
                    string FonCelPer, 
                    string GlsCodPos, 
                    string GlsCasPos, 
                    string MaiPer, 
                    string GlsInsEduPer, 
                    string IndSex, 
                    string IndEstCiv, 
                    string CodAfp, 
                    string CodIsa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/ActualizaPersona", ReplyAction="*")]
        System.Threading.Tasks.Task<string> ActualizaPersonaAsync(
                    string NumTransaccion, 
                    string RutPer, 
                    string ApePat, 
                    string ApeMat, 
                    string NomPer, 
                    string FecNac, 
                    string FecDef, 
                    string GlsDirPer, 
                    string GlsRefDir, 
                    string UggComPer, 
                    string CodAreTel, 
                    string FonPer, 
                    string FonAlt, 
                    string CodAreFax, 
                    string FaxPer, 
                    string CodAreCel, 
                    string FonCelPer, 
                    string GlsCodPos, 
                    string GlsCasPos, 
                    string MaiPer, 
                    string GlsInsEduPer, 
                    string IndSex, 
                    string IndEstCiv, 
                    string CodAfp, 
                    string CodIsa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/IngresoAMC", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string IngresoAMC(
                    string NumTransaccion, 
                    string RutPer, 
                    string FecAtePac, 
                    string FecPrePac, 
                    string FecIngHos, 
                    string UgaOfiAte, 
                    string UggOfiAte, 
                    string UgaSucCar, 
                    string UggSucCar, 
                    string UgeSucCar, 
                    string IndPrvSal, 
                    string IndCnvAte, 
                    string IndCnvEmp, 
                    string IndTipAte, 
                    string IndAteAmbHos, 
                    string IndTipPac, 
                    string IndRei, 
                    string IndCnsEstSal, 
                    string GlsNomPer, 
                    string NumCam, 
                    string numConvenio, 
                    string RutProf, 
                    string NomProf, 
                    string FolioExterno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/IngresoAMC", ReplyAction="*")]
        System.Threading.Tasks.Task<string> IngresoAMCAsync(
                    string NumTransaccion, 
                    string RutPer, 
                    string FecAtePac, 
                    string FecPrePac, 
                    string FecIngHos, 
                    string UgaOfiAte, 
                    string UggOfiAte, 
                    string UgaSucCar, 
                    string UggSucCar, 
                    string UgeSucCar, 
                    string IndPrvSal, 
                    string IndCnvAte, 
                    string IndCnvEmp, 
                    string IndTipAte, 
                    string IndAteAmbHos, 
                    string IndTipPac, 
                    string IndRei, 
                    string IndCnsEstSal, 
                    string GlsNomPer, 
                    string NumCam, 
                    string numConvenio, 
                    string RutProf, 
                    string NomProf, 
                    string FolioExterno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/BitacoraErrores", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string BitacoraErrores();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/BitacoraErrores", ReplyAction="*")]
        System.Threading.Tasks.Task<string> BitacoraErroresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/BitacoraErroresFiltro", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string BitacoraErroresFiltro(string NumTransaccion, string nomWebService, string EstadoTransaccion, string FechaTransaccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/BitacoraErroresFiltro", ReplyAction="*")]
        System.Threading.Tasks.Task<string> BitacoraErroresFiltroAsync(string NumTransaccion, string nomWebService, string EstadoTransaccion, string FechaTransaccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/IngresoHospital", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string IngresoHospital(string NumTransaccion, string folAte, string UgaOfiAte, string numCam, string fecIngHos, string RutProfesional);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/IngresoHospital", ReplyAction="*")]
        System.Threading.Tasks.Task<string> IngresoHospitalAsync(string NumTransaccion, string folAte, string UgaOfiAte, string numCam, string fecIngHos, string RutProfesional);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/EgresoHospital", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string EgresoHospital(string NumTransaccion, string folAte, string UgaOfiAte, string numCam, string fecIngHos, string fecEgrHos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/EgresoHospital", ReplyAction="*")]
        System.Threading.Tasks.Task<string> EgresoHospitalAsync(string NumTransaccion, string folAte, string UgaOfiAte, string numCam, string fecIngHos, string fecEgrHos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/AnularHospitalizacion", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string AnularHospitalizacion(string NumTransaccion, string folAte, string UgaOfiAte, string numCam, string fecIngHos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/AnularHospitalizacion", ReplyAction="*")]
        System.Threading.Tasks.Task<string> AnularHospitalizacionAsync(string NumTransaccion, string folAte, string UgaOfiAte, string numCam, string fecIngHos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/DardeALTA", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string DardeALTA(string NumTransaccion, string folAte, string fecAltPac);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/DardeALTA", ReplyAction="*")]
        System.Threading.Tasks.Task<string> DardeALTAAsync(string NumTransaccion, string folAte, string fecAltPac);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/AnularALTA", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string AnularALTA(string NumTransaccion, string folAte, string fecAltPac);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/AnularALTA", ReplyAction="*")]
        System.Threading.Tasks.Task<string> AnularALTAAsync(string NumTransaccion, string folAte, string fecAltPac);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/CambioCama", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string CambioCama(string NumTransaccion, string folAte, string ugaOfiAte, string numCamaNew);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/CambioCama", ReplyAction="*")]
        System.Threading.Tasks.Task<string> CambioCamaAsync(string NumTransaccion, string folAte, string ugaOfiAte, string numCamaNew);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/ActualizaALTA", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string ActualizaALTA(string NumTransaccion, string folAte, string rutPaciente, string fecAltaPac, string RutProfesional);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BlInterfaceAMC/InterfaceAMC/ActualizaALTA", ReplyAction="*")]
        System.Threading.Tasks.Task<string> ActualizaALTAAsync(string NumTransaccion, string folAte, string rutPaciente, string fecAltaPac, string RutProfesional);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface InterfaceAMCSoapChannel : Herramienta_Administrativa.InterfaceAMC.InterfaceAMCSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InterfaceAMCSoapClient : System.ServiceModel.ClientBase<Herramienta_Administrativa.InterfaceAMC.InterfaceAMCSoap>, Herramienta_Administrativa.InterfaceAMC.InterfaceAMCSoap {
        
        public InterfaceAMCSoapClient() {
        }
        
        public InterfaceAMCSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InterfaceAMCSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InterfaceAMCSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InterfaceAMCSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public object TrabajarProtegido(string NumTransaccion, string RutTrabajador) {
            return base.Channel.TrabajarProtegido(NumTransaccion, RutTrabajador);
        }
        
        public System.Threading.Tasks.Task<object> TrabajarProtegidoAsync(string NumTransaccion, string RutTrabajador) {
            return base.Channel.TrabajarProtegidoAsync(NumTransaccion, RutTrabajador);
        }
        
        public object DetalleMedico(string NumTransaccion, string folAte, string CodTipTex, string idAdm) {
            return base.Channel.DetalleMedico(NumTransaccion, folAte, CodTipTex, idAdm);
        }
        
        public System.Threading.Tasks.Task<object> DetalleMedicoAsync(string NumTransaccion, string folAte, string CodTipTex, string idAdm) {
            return base.Channel.DetalleMedicoAsync(NumTransaccion, folAte, CodTipTex, idAdm);
        }
        
        public object ConsultaFolioNet(string NumTransaccion, string RutPaciente) {
            return base.Channel.ConsultaFolioNet(NumTransaccion, RutPaciente);
        }
        
        public System.Threading.Tasks.Task<object> ConsultaFolioNetAsync(string NumTransaccion, string RutPaciente) {
            return base.Channel.ConsultaFolioNetAsync(NumTransaccion, RutPaciente);
        }
        
        public object AltaLaboral(string NumTransaccion, string FolAte, string FecAlt, string FecIniLab, string RutMedAlt, string IndCauAlt, string IndCarAlt, string CondReintegro, string Condiciones, string numDias, string contTto, string Tratamiento) {
            return base.Channel.AltaLaboral(NumTransaccion, FolAte, FecAlt, FecIniLab, RutMedAlt, IndCauAlt, IndCarAlt, CondReintegro, Condiciones, numDias, contTto, Tratamiento);
        }
        
        public System.Threading.Tasks.Task<object> AltaLaboralAsync(string NumTransaccion, string FolAte, string FecAlt, string FecIniLab, string RutMedAlt, string IndCauAlt, string IndCarAlt, string CondReintegro, string Condiciones, string numDias, string contTto, string Tratamiento) {
            return base.Channel.AltaLaboralAsync(NumTransaccion, FolAte, FecAlt, FecIniLab, RutMedAlt, IndCauAlt, IndCarAlt, CondReintegro, Condiciones, numDias, contTto, Tratamiento);
        }
        
        public object AltaMedica(string NumTransaccion, string FolAte, string FecAlt, string FecIniLab, string RutMedAlt, string IndCauAlt, string IndCarAlt, string TipoAlta, string OtroMotivo) {
            return base.Channel.AltaMedica(NumTransaccion, FolAte, FecAlt, FecIniLab, RutMedAlt, IndCauAlt, IndCarAlt, TipoAlta, OtroMotivo);
        }
        
        public System.Threading.Tasks.Task<object> AltaMedicaAsync(string NumTransaccion, string FolAte, string FecAlt, string FecIniLab, string RutMedAlt, string IndCauAlt, string IndCarAlt, string TipoAlta, string OtroMotivo) {
            return base.Channel.AltaMedicaAsync(NumTransaccion, FolAte, FecAlt, FecIniLab, RutMedAlt, IndCauAlt, IndCarAlt, TipoAlta, OtroMotivo);
        }
        
        public object InicioTerminoAtencion(string NumTransaccion, string RutPro, string RutPac, string FecRsv, string fecIniAte, string FecTerAte, string UgaOfiAte, string IndEstRsv, string FolAte, string FolOrdAte) {
            return base.Channel.InicioTerminoAtencion(NumTransaccion, RutPro, RutPac, FecRsv, fecIniAte, FecTerAte, UgaOfiAte, IndEstRsv, FolAte, FolOrdAte);
        }
        
        public System.Threading.Tasks.Task<object> InicioTerminoAtencionAsync(string NumTransaccion, string RutPro, string RutPac, string FecRsv, string fecIniAte, string FecTerAte, string UgaOfiAte, string IndEstRsv, string FolAte, string FolOrdAte) {
            return base.Channel.InicioTerminoAtencionAsync(NumTransaccion, RutPro, RutPac, FecRsv, fecIniAte, FecTerAte, UgaOfiAte, IndEstRsv, FolAte, FolOrdAte);
        }
        
        public object AnulaHoraControl(string NumTransaccion, string RutPro, string RutPac, string FecRsv, string UgaOfiAte, string IndEstRsv, string IndCauAnuRsv, string FolAte, string FolOrdAte, string GlsAnuAte, string FolRsv, string SeqNum) {
            return base.Channel.AnulaHoraControl(NumTransaccion, RutPro, RutPac, FecRsv, UgaOfiAte, IndEstRsv, IndCauAnuRsv, FolAte, FolOrdAte, GlsAnuAte, FolRsv, SeqNum);
        }
        
        public System.Threading.Tasks.Task<object> AnulaHoraControlAsync(string NumTransaccion, string RutPro, string RutPac, string FecRsv, string UgaOfiAte, string IndEstRsv, string IndCauAnuRsv, string FolAte, string FolOrdAte, string GlsAnuAte, string FolRsv, string SeqNum) {
            return base.Channel.AnulaHoraControlAsync(NumTransaccion, RutPro, RutPac, FecRsv, UgaOfiAte, IndEstRsv, IndCauAnuRsv, FolAte, FolOrdAte, GlsAnuAte, FolRsv, SeqNum);
        }
        
        public object AsisteAControl(string NumTransaccion, string RutPro, string RutPac, string FecRsv, string FecLlePac, string UgaOfiAte, string IndEstRsv, string FolAte, string FolOrdAte) {
            return base.Channel.AsisteAControl(NumTransaccion, RutPro, RutPac, FecRsv, FecLlePac, UgaOfiAte, IndEstRsv, FolAte, FolOrdAte);
        }
        
        public System.Threading.Tasks.Task<object> AsisteAControlAsync(string NumTransaccion, string RutPro, string RutPac, string FecRsv, string FecLlePac, string UgaOfiAte, string IndEstRsv, string FolAte, string FolOrdAte) {
            return base.Channel.AsisteAControlAsync(NumTransaccion, RutPro, RutPac, FecRsv, FecLlePac, UgaOfiAte, IndEstRsv, FolAte, FolOrdAte);
        }
        
        public object ReservaHoraControl(string NumTransaccion, string RutPro, string RutPac, string FecRsv, string UgaOfiAte, string IndEstRsv, string FolAte, string FolOrdAte) {
            return base.Channel.ReservaHoraControl(NumTransaccion, RutPro, RutPac, FecRsv, UgaOfiAte, IndEstRsv, FolAte, FolOrdAte);
        }
        
        public System.Threading.Tasks.Task<object> ReservaHoraControlAsync(string NumTransaccion, string RutPro, string RutPac, string FecRsv, string UgaOfiAte, string IndEstRsv, string FolAte, string FolOrdAte) {
            return base.Channel.ReservaHoraControlAsync(NumTransaccion, RutPro, RutPac, FecRsv, UgaOfiAte, IndEstRsv, FolAte, FolOrdAte);
        }
        
        public object CalificacionAccidente(string NumTransaccion, string folAte, string IndProGra, string CauConIst, string CauConSuseso, string IndTipPac, string IndCtp, string DiasProbTto, string IndNatLes, string IndParAfe) {
            return base.Channel.CalificacionAccidente(NumTransaccion, folAte, IndProGra, CauConIst, CauConSuseso, IndTipPac, IndCtp, DiasProbTto, IndNatLes, IndParAfe);
        }
        
        public System.Threading.Tasks.Task<object> CalificacionAccidenteAsync(string NumTransaccion, string folAte, string IndProGra, string CauConIst, string CauConSuseso, string IndTipPac, string IndCtp, string DiasProbTto, string IndNatLes, string IndParAfe) {
            return base.Channel.CalificacionAccidenteAsync(NumTransaccion, folAte, IndProGra, CauConIst, CauConSuseso, IndTipPac, IndCtp, DiasProbTto, IndNatLes, IndParAfe);
        }
        
        public object Diagnostico(string NumTransaccion, string folAte, string fecDgn, string CodDgn, string SeqJer, string IndTipDgn, string RutMedDgn) {
            return base.Channel.Diagnostico(NumTransaccion, folAte, fecDgn, CodDgn, SeqJer, IndTipDgn, RutMedDgn);
        }
        
        public System.Threading.Tasks.Task<object> DiagnosticoAsync(string NumTransaccion, string folAte, string fecDgn, string CodDgn, string SeqJer, string IndTipDgn, string RutMedDgn) {
            return base.Channel.DiagnosticoAsync(NumTransaccion, folAte, fecDgn, CodDgn, SeqJer, IndTipDgn, RutMedDgn);
        }
        
        public object Evolucion(string NumTransaccion, string folAte, string fecTex, string codtiptex, string ugaofiate, string coduniser, string txtgls, string rutpro) {
            return base.Channel.Evolucion(NumTransaccion, folAte, fecTex, codtiptex, ugaofiate, coduniser, txtgls, rutpro);
        }
        
        public System.Threading.Tasks.Task<object> EvolucionAsync(string NumTransaccion, string folAte, string fecTex, string codtiptex, string ugaofiate, string coduniser, string txtgls, string rutpro) {
            return base.Channel.EvolucionAsync(NumTransaccion, folAte, fecTex, codtiptex, ugaofiate, coduniser, txtgls, rutpro);
        }
        
        public string ActualizaPersona(
                    string NumTransaccion, 
                    string RutPer, 
                    string ApePat, 
                    string ApeMat, 
                    string NomPer, 
                    string FecNac, 
                    string FecDef, 
                    string GlsDirPer, 
                    string GlsRefDir, 
                    string UggComPer, 
                    string CodAreTel, 
                    string FonPer, 
                    string FonAlt, 
                    string CodAreFax, 
                    string FaxPer, 
                    string CodAreCel, 
                    string FonCelPer, 
                    string GlsCodPos, 
                    string GlsCasPos, 
                    string MaiPer, 
                    string GlsInsEduPer, 
                    string IndSex, 
                    string IndEstCiv, 
                    string CodAfp, 
                    string CodIsa) {
            return base.Channel.ActualizaPersona(NumTransaccion, RutPer, ApePat, ApeMat, NomPer, FecNac, FecDef, GlsDirPer, GlsRefDir, UggComPer, CodAreTel, FonPer, FonAlt, CodAreFax, FaxPer, CodAreCel, FonCelPer, GlsCodPos, GlsCasPos, MaiPer, GlsInsEduPer, IndSex, IndEstCiv, CodAfp, CodIsa);
        }
        
        public System.Threading.Tasks.Task<string> ActualizaPersonaAsync(
                    string NumTransaccion, 
                    string RutPer, 
                    string ApePat, 
                    string ApeMat, 
                    string NomPer, 
                    string FecNac, 
                    string FecDef, 
                    string GlsDirPer, 
                    string GlsRefDir, 
                    string UggComPer, 
                    string CodAreTel, 
                    string FonPer, 
                    string FonAlt, 
                    string CodAreFax, 
                    string FaxPer, 
                    string CodAreCel, 
                    string FonCelPer, 
                    string GlsCodPos, 
                    string GlsCasPos, 
                    string MaiPer, 
                    string GlsInsEduPer, 
                    string IndSex, 
                    string IndEstCiv, 
                    string CodAfp, 
                    string CodIsa) {
            return base.Channel.ActualizaPersonaAsync(NumTransaccion, RutPer, ApePat, ApeMat, NomPer, FecNac, FecDef, GlsDirPer, GlsRefDir, UggComPer, CodAreTel, FonPer, FonAlt, CodAreFax, FaxPer, CodAreCel, FonCelPer, GlsCodPos, GlsCasPos, MaiPer, GlsInsEduPer, IndSex, IndEstCiv, CodAfp, CodIsa);
        }
        
        public string IngresoAMC(
                    string NumTransaccion, 
                    string RutPer, 
                    string FecAtePac, 
                    string FecPrePac, 
                    string FecIngHos, 
                    string UgaOfiAte, 
                    string UggOfiAte, 
                    string UgaSucCar, 
                    string UggSucCar, 
                    string UgeSucCar, 
                    string IndPrvSal, 
                    string IndCnvAte, 
                    string IndCnvEmp, 
                    string IndTipAte, 
                    string IndAteAmbHos, 
                    string IndTipPac, 
                    string IndRei, 
                    string IndCnsEstSal, 
                    string GlsNomPer, 
                    string NumCam, 
                    string numConvenio, 
                    string RutProf, 
                    string NomProf, 
                    string FolioExterno) {
            return base.Channel.IngresoAMC(NumTransaccion, RutPer, FecAtePac, FecPrePac, FecIngHos, UgaOfiAte, UggOfiAte, UgaSucCar, UggSucCar, UgeSucCar, IndPrvSal, IndCnvAte, IndCnvEmp, IndTipAte, IndAteAmbHos, IndTipPac, IndRei, IndCnsEstSal, GlsNomPer, NumCam, numConvenio, RutProf, NomProf, FolioExterno);
        }
        
        public System.Threading.Tasks.Task<string> IngresoAMCAsync(
                    string NumTransaccion, 
                    string RutPer, 
                    string FecAtePac, 
                    string FecPrePac, 
                    string FecIngHos, 
                    string UgaOfiAte, 
                    string UggOfiAte, 
                    string UgaSucCar, 
                    string UggSucCar, 
                    string UgeSucCar, 
                    string IndPrvSal, 
                    string IndCnvAte, 
                    string IndCnvEmp, 
                    string IndTipAte, 
                    string IndAteAmbHos, 
                    string IndTipPac, 
                    string IndRei, 
                    string IndCnsEstSal, 
                    string GlsNomPer, 
                    string NumCam, 
                    string numConvenio, 
                    string RutProf, 
                    string NomProf, 
                    string FolioExterno) {
            return base.Channel.IngresoAMCAsync(NumTransaccion, RutPer, FecAtePac, FecPrePac, FecIngHos, UgaOfiAte, UggOfiAte, UgaSucCar, UggSucCar, UgeSucCar, IndPrvSal, IndCnvAte, IndCnvEmp, IndTipAte, IndAteAmbHos, IndTipPac, IndRei, IndCnsEstSal, GlsNomPer, NumCam, numConvenio, RutProf, NomProf, FolioExterno);
        }
        
        public string BitacoraErrores() {
            return base.Channel.BitacoraErrores();
        }
        
        public System.Threading.Tasks.Task<string> BitacoraErroresAsync() {
            return base.Channel.BitacoraErroresAsync();
        }
        
        public string BitacoraErroresFiltro(string NumTransaccion, string nomWebService, string EstadoTransaccion, string FechaTransaccion) {
            return base.Channel.BitacoraErroresFiltro(NumTransaccion, nomWebService, EstadoTransaccion, FechaTransaccion);
        }
        
        public System.Threading.Tasks.Task<string> BitacoraErroresFiltroAsync(string NumTransaccion, string nomWebService, string EstadoTransaccion, string FechaTransaccion) {
            return base.Channel.BitacoraErroresFiltroAsync(NumTransaccion, nomWebService, EstadoTransaccion, FechaTransaccion);
        }
        
        public string IngresoHospital(string NumTransaccion, string folAte, string UgaOfiAte, string numCam, string fecIngHos, string RutProfesional) {
            return base.Channel.IngresoHospital(NumTransaccion, folAte, UgaOfiAte, numCam, fecIngHos, RutProfesional);
        }
        
        public System.Threading.Tasks.Task<string> IngresoHospitalAsync(string NumTransaccion, string folAte, string UgaOfiAte, string numCam, string fecIngHos, string RutProfesional) {
            return base.Channel.IngresoHospitalAsync(NumTransaccion, folAte, UgaOfiAte, numCam, fecIngHos, RutProfesional);
        }
        
        public string EgresoHospital(string NumTransaccion, string folAte, string UgaOfiAte, string numCam, string fecIngHos, string fecEgrHos) {
            return base.Channel.EgresoHospital(NumTransaccion, folAte, UgaOfiAte, numCam, fecIngHos, fecEgrHos);
        }
        
        public System.Threading.Tasks.Task<string> EgresoHospitalAsync(string NumTransaccion, string folAte, string UgaOfiAte, string numCam, string fecIngHos, string fecEgrHos) {
            return base.Channel.EgresoHospitalAsync(NumTransaccion, folAte, UgaOfiAte, numCam, fecIngHos, fecEgrHos);
        }
        
        public string AnularHospitalizacion(string NumTransaccion, string folAte, string UgaOfiAte, string numCam, string fecIngHos) {
            return base.Channel.AnularHospitalizacion(NumTransaccion, folAte, UgaOfiAte, numCam, fecIngHos);
        }
        
        public System.Threading.Tasks.Task<string> AnularHospitalizacionAsync(string NumTransaccion, string folAte, string UgaOfiAte, string numCam, string fecIngHos) {
            return base.Channel.AnularHospitalizacionAsync(NumTransaccion, folAte, UgaOfiAte, numCam, fecIngHos);
        }
        
        public string DardeALTA(string NumTransaccion, string folAte, string fecAltPac) {
            return base.Channel.DardeALTA(NumTransaccion, folAte, fecAltPac);
        }
        
        public System.Threading.Tasks.Task<string> DardeALTAAsync(string NumTransaccion, string folAte, string fecAltPac) {
            return base.Channel.DardeALTAAsync(NumTransaccion, folAte, fecAltPac);
        }
        
        public string AnularALTA(string NumTransaccion, string folAte, string fecAltPac) {
            return base.Channel.AnularALTA(NumTransaccion, folAte, fecAltPac);
        }
        
        public System.Threading.Tasks.Task<string> AnularALTAAsync(string NumTransaccion, string folAte, string fecAltPac) {
            return base.Channel.AnularALTAAsync(NumTransaccion, folAte, fecAltPac);
        }
        
        public string CambioCama(string NumTransaccion, string folAte, string ugaOfiAte, string numCamaNew) {
            return base.Channel.CambioCama(NumTransaccion, folAte, ugaOfiAte, numCamaNew);
        }
        
        public System.Threading.Tasks.Task<string> CambioCamaAsync(string NumTransaccion, string folAte, string ugaOfiAte, string numCamaNew) {
            return base.Channel.CambioCamaAsync(NumTransaccion, folAte, ugaOfiAte, numCamaNew);
        }
        
        public string ActualizaALTA(string NumTransaccion, string folAte, string rutPaciente, string fecAltaPac, string RutProfesional) {
            return base.Channel.ActualizaALTA(NumTransaccion, folAte, rutPaciente, fecAltaPac, RutProfesional);
        }
        
        public System.Threading.Tasks.Task<string> ActualizaALTAAsync(string NumTransaccion, string folAte, string rutPaciente, string fecAltaPac, string RutProfesional) {
            return base.Channel.ActualizaALTAAsync(NumTransaccion, folAte, rutPaciente, fecAltaPac, RutProfesional);
        }
    }
}
