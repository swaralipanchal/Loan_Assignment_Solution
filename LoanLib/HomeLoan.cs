namespace LoanSys;

 class HomeLoan:Loan , IDisposable{
    public override float getRate(){
        return Principle<=2000000?0.1f:0.11f;
      
    }
    public double GetDiscount(){
        return getEmi()*0.05;
    }

}