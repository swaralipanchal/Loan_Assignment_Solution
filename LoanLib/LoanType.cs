namespace LoanSys;

public static class LoanType{

    public static Loan CalPersonalLoan(){
        var l=new PersonalLoan();
        return l;
    }
    public static Loan CalHomeLoan(){
        var l=new HomeLoan();
        return l;
    }
    public static double  GetTotalTax(Loan[] L , int size){
    double totalTax=0;
    for(int i=0;i<size;i++){
        if (L[i] is PersonalLoan pl)
        totalTax += pl.GetTax();
    }
    return totalTax;
 }
    public static double  GetTotalDiscount(Loan[] L , int size){
    double totalDiscount=0;
    for(int i=0;i<size;i++){
        HomeLoan HL = L[i] as HomeLoan;      
        double discount = HL?.GetDiscount() ?? 0;
        totalDiscount += discount; 
    }
    return totalDiscount;
}
}