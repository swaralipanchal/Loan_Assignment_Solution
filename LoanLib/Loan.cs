namespace LoanSys;

public abstract class Loan{
    public double Principle{get;set;}
    public int Period{get;set;}

    public abstract float getRate();

    public double getEmi(){
        return Principle *(1+getRate()*Period)/(12*Period); 
     
    }
}