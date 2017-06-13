using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "communityAssistService" in code, svc and config file together.
public class communityAssistService : IcommunityAssistService
{
    Community_AssistEntities db = new Community_AssistEntities();

    public List<GrantRequest> GetGrantRequest(int PersonKey)
    {
        var grant = from g in db.GrantRequests
                    select g;
                     
        List<GrantRequest> grants = new List<GrantRequest>();
        foreach (GrantRequest gr in grant )
        {
            GrantRequest grant1 = new GrantRequest();
            grant1.GrantRequestDate = gr.GrantRequestDate;
            grant1.PersonKey = gr.PersonKey;
            grant1.GrantTypeKey = gr.GrantTypeKey;
            grant1.GrantRequestExplanation = gr.GrantRequestExplanation;
            grant1.GrantRequestAmount = gr.GrantRequestAmount;
            
            
               
            
            grants.Add(grant1);
        }
        return grants;
    }





    public List<GrantRequest> GetGrantReview(int personKey)
    {
        var grnts = from g in db.GrantRequests
                    from p in g.GrantReviews
                    where g.PersonKey == personKey
                    select g;
    
        List<GrantRequest> grantRequests = new List<GrantRequest>();

        foreach (var gt in grnts)
        {
            GrantRequest gr = new GrantRequest();
            gr.GrantRequestDate = gt.GrantRequestDate;
            gr.GrantTypeKey = gt.GrantTypeKey;
            gr.GrantRequestExplanation = gt.GrantRequestExplanation;
            gr.GrantRequestAmount = gt.GrantRequestAmount;
            gr.PersonKey = gt.PersonKey;
        }
        return grantRequests;
    }

    public List<GrantReview> GetGrantReviews(int GrantRequestKey)
    {
        throw new NotImplementedException();
    }

    public int Login(string user, string password)
    {
        int key = 0;
        int  result = db.usp_Login(user, password);
        if (result != -1)
        {
            var userKey = (from k in db.People
                           where k.PersonKey.Equals(user)
                           select k.PersonKey).FirstOrDefault();
            key = (int)userKey;
        }
        return key;

    }

    public bool RegisterPerson(PersonLite p)
    {
        bool result = true;
        int per = db.usp_Register(p.lastname,
            p.firstname, p.email, p.password,
            p.ApartmentNumber, p.street, p.city, p.state, p.zipcode, p.homePhone, p.workPhone);

            return result;
    }
}
