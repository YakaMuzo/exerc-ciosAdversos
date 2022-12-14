using System;

namespace Name {
    class Retangulo {
        public double A;
        public double B;


        public double Area() {
            return A * B;
        }

        public double Perimetro() {
            return 2 * (A + B);
        }

        public double Diagonal() {
            return Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
        }
    }
}
