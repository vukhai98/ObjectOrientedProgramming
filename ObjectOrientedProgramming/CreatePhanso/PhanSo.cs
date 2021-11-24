using System;
using System.Collections.Generic;
using System.Text;

namespace CreatePhanso
{
    class PhanSo
    {


        public int tuSo { get; set; }
        public int mauSo { get; set; }
            
        public PhanSo()
        {

        }
        public PhanSo(int tu, int mau)
        {
           tuSo = tu;
            mauSo = mau;
        }
       
        public PhanSo Cong(PhanSo another)
        {
            PhanSo result = new PhanSo();
            result.tuSo = tuSo * another.mauSo + mauSo * another.tuSo;
            result.mauSo = mauSo * another.mauSo;
            return result;


        }
        public PhanSo Tru(PhanSo another)
        {
            PhanSo result = new PhanSo();
            result.tuSo = tuSo * another.mauSo - mauSo * another.tuSo;
            result.mauSo = mauSo * another.mauSo;
            return result;


        }
        public PhanSo Tich(PhanSo another)
        {
            PhanSo result = new PhanSo();
            result.tuSo = tuSo * another.tuSo;
            result.mauSo = mauSo * another.mauSo;
            return result;


        }
        public PhanSo Thuong(PhanSo another)
        {
            PhanSo result = new PhanSo();
            result.tuSo = tuSo * another.mauSo;
            result.mauSo = mauSo* another.tuSo;
            return result;


        }



        public string Display()
        {
            return string.Format("{0}/{1}", tuSo, mauSo);
        }

    }
}
