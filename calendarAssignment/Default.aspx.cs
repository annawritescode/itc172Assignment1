using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] importantDates = new string[6, 2];
    protected void Page_Load(object sender, EventArgs e)
    {
        importantDates[0,0]= "Easter";
        importantDates[0,1]= "4/16/2017";
        importantDates[1,0]= "Tax Day";
        importantDates[1,1]= "4/18/2017";
        importantDates[2,0]= "Mothers Day";
        importantDates[2,1]= "5/14/2017";
        importantDates[3,0]= "Otis Birthday";
        importantDates[3,1]= "5/16/2017";
        importantDates[4,0]= "Fourth of July";
        importantDates[4,1]= "7/04/2017";
        importantDates[5,0]= "Castners Birthday";
        importantDates[5,1]= "7/12/2017";

        
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        EventLabel.Text = "";
        string date = Calendar1.SelectedDate.ToShortDateString();
        for (int i = 0;i<6;i++)
        {
            if (importantDates[i,1].Equals(date)) 
            {
                EventLabel.Text += importantDates[i,0];
            }
        }
        
    if(EventLabel.Text==""){
            EventLabel.Text = Calendar1.SelectedDate.ToShortDateString();
        }
    }
}