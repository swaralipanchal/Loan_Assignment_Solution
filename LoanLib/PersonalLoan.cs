namespace LoanSys;

 public class PersonalLoan:Loan ,ITaxable{
    
    public override float getRate(){
        return Principle<=500000?0.15f:0.16f;
        
    }
    public double GetTax(){
        return getEmi()*0.1;
    }
    
}
