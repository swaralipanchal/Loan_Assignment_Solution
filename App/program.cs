using LoanSys;

Loan loan1 =LoanType.CalPersonalLoan();
loan1.Principle=1000000;
loan1.Period=1;

Loan loan2 =LoanType.CalHomeLoan();
loan2.Principle=15600000;
loan2.Period=5;

Loan[] L = new Loan[4];
L[0] = LoanType.CalPersonalLoan();
L[1] = LoanType.CalHomeLoan();
L[2] = LoanType.CalPersonalLoan();
L[3] = LoanType.CalHomeLoan();
L[0].Principle=100;
L[0].Period=1;
L[1].Principle=100;
L[1].Period=1;
L[2].Principle=100;
L[2].Period=1;
L[3].Principle=100;
L[3].Period=1;
foreach(Loan arr in L){
Console.WriteLine ("The array emi = {0:0.00}",arr.getEmi());
}



// Console.WriteLine ("The Personal Loan EMI= {0:0.00}",loan1.getEmi());
// Console.WriteLine ("The Home Loan EMI= {0:0.00}",loan2.getEmi());
Console.WriteLine("total tax = {0:0.00}",LoanType.GetTotalTax(L,4));
Console.WriteLine("total discount = {0:0.00}",LoanType.GetTotalDiscount(L,4));