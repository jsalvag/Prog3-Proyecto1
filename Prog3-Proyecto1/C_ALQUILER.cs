using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog3_Proyecto1
{
    public class C_ALQUILER
    {
        private string
            ciA,
            placaA;

        private DateTime
            f_alquiler;

        private float
            monto;

        private int
            dias;

        public C_ALQUILER(string ci,string placa,DateTime f_alquiler,float monto,int dias)
        {
            this.ciA = ci;
            this.placaA = placa;
            this.f_alquiler = f_alquiler;
            this.monto = monto;
            this.dias = dias;
        }
    }
}
