using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class PieceWorker : Employee
    {
        public double Wage { get; set; }

        public int Pieces { get; set; }

        public PieceWorker(string first, string last, string ssn, double wagePerPiece, int piecesProduced) : base(first, last, ssn)
        {
            Wage = wagePerPiece;
            Pieces = piecesProduced;
        }

        public override double earnings()
        {
            return Pieces * Wage;
        }

        public override string ToString()
        {
            return "Piece Worker: " + base.ToString() + $"\nWage Per Piece: {Wage:C2}, Pieces Produced: {Pieces}";
        }
    }
}
