using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Tip
/// </summary>
public class Tip
{   
    //variables
    private double mealAmount;
    private double tipPercent;
    //constant
    private const double TAXPERCENT = .101;
    public Tip(double amount, double tipPerc)
    {
        //
        // TODO: Add constructor logic here
        //
        mealAmount = amount;
        tipPercent = tipPerc;
    }

    public double CalculateTax()
    {
        return mealAmount * TAXPERCENT;
    }

    public double CalculateTip()
    {
        return mealAmount * tipPercent;
            }

    public double Total()

    {
        return mealAmount + CalculateTax() + CalculateTip();


    }

}