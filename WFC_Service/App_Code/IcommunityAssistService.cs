using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IcommunityAssistService" in both code and config file together.
[ServiceContract]
public interface IcommunityAssistService
{
    [OperationContract]
    int Login(string user, string password);

    [OperationContract]
    bool RegisterPerson(PersonLite p);

    [OperationContract]
    List<GrantRequest> GetGrantRequest(int PersonKey);

    [OperationContract]

    List<GrantReview> GetGrantReviews(int GrantRequestKey);
}


[DataContract]

public class PersonLite
{
    //add stored procedures for usp register
    [DataMember]
    public string lastname { get; set; }
    [DataMember]
    public string firstname { get; set; }
    [DataMember]
    public string email { get; set; }
    [DataMember]
    public string password { get; set; }

    [DataMember]
    public string ApartmentNumber { get; set; }
    [DataMember]
    public string street { get; set; }
    [DataMember]
    public string city { get; set; }
    [DataMember]
    public string state { get; set; }
    [DataMember]
    public string zipcode { get; set; }
    [DataMember]
    public string homePhone { get; set; }
    [DataMember]
    public string workPhone { get; set; }
}
    
