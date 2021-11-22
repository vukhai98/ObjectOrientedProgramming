using System;
using System.Collections.Generic;
using System.Text;

namespace CreatClassPhanSo
{
    class PhanSo
    {

        public float tuSo { set; get; }
        public float mauSo { set; get; }


        public PhanSo()
        {


        }
        public PhanSo(float _tuSo, float _mauSo)
        {
            tuSo = _tuSo;
            mauSo = _mauSo;
        }
        public float CreatePhanSo()
        {
            return tuSo / mauSo;
        }



    }

    public interface Test
    {
        float CreatePhanSo();
    }

    public interface Test2 : Test
    {
        float CreatePhanSo2();
    }

    public class Test3 : Test
    {
        public float CreatePhanSo()
        {
            throw new NotImplementedException();
        }
    }
}
