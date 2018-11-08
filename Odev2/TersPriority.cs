using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class TersPriority : IQueue
    {        
        public object[] Queue;
        private int front = -1;
        private int size = 0;
        private int count = 0;

        public TersPriority(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(object o)
        {
            if (count == size)
            {
                throw new Exception("Queue is full");
            }

            if (IsEmpty())
            {
                front++;
                Queue[front] = o;
                count++;
            }
            else
            {
                int i;
                for (i = count - 1; i >= 0; i--)
                {
                    if (((Musteri)o).Islem_SuresiTers > ((Musteri)Queue[i]).Islem_SuresiTers)
                        Queue[i + 1] = Queue[i];
                    else
                        break;
                }
                Queue[i + 1] = o;
                front++;
                count++;
            }
        }

         public bool IsEmpty()
        {
            return (count == 0);
        }

        public string DisplayTers()
        {
            string temp = "";

            for (int i = 0; i < 20; i++)
            {
                temp += i + 1 + " Numaralı Müşterinin " + Environment.NewLine + "Müşteri no : " + ((Musteri)Queue[i]).Musteri_No.ToString() + Environment.NewLine +
                    "İşlem süresi :" + ((Musteri)Queue[i]).Islem_SuresiTers.ToString() + Environment.NewLine + "Toplam İşlem Süresi:" + IslemTamamlama_suresiTers(((Musteri)Queue[i]).Islem_SuresiTers).ToString() +
                    Environment.NewLine + Environment.NewLine;
            }

            return temp;
        }

        public int IslemSuresiTers = 0;
        public int IslemTamamlama_suresiTers(int sure)
        {
            IslemSuresiTers += sure;
            return IslemSuresiTers;
        }


        public object Remove()
        {
            throw new NotImplementedException();
        }

        public object Peek()
        {
            throw new NotImplementedException();
        }
    }
}
