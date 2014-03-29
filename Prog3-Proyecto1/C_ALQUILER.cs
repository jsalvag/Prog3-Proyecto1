using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog3_Proyecto1
{
    class C_ALQUILER
    {
        private string
            ci,
            placa;

        private DateTime
            f_alquiler;

        private float
            monto;

        private int
            dias;

        public C_ALQUILER(string ci,string placa,DateTime f_alquiler,float monto,int dias)
        {
            this.ci = ci;
            this.placa = placa;
            this.f_alquiler = f_alquiler;
            this.monto = monto;
            this.dias = dias;
        }
    }
}
