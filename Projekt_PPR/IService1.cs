using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Projekt_PPR
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int ile_wierszy();
        [OperationContract]
        int wczytaj_id(int var);
        [OperationContract]
        string zwroc_imie(int var);
        [OperationContract]
        string zwroc_rase(int var);
        [OperationContract]
        int? zwroc_wiek(int var);
        [OperationContract]
        string zwroc_kontakt(int var);
        [OperationContract]
        string zwroc_zdj(int var);
        [OperationContract]
        int? zwroc_opiekuna(int var);
        [OperationContract]
        int dodaj_zwierzaka(int id, string imie, string rasa, int? wiek, string kontakt, string zdj, int? opiekun);
        [OperationContract]
        int modyfikuj_zwierzaka(int id);
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here.
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
