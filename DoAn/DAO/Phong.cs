using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAO
{
    public class Phong : User
    {
        string loaiphong;
        int phongtrong, giaphong;
        public Phong(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public Phong(string name, string id, string loaiphong, int phongtrong, int giaphong)
        {
            this.name = name;
            this.id = id;
            this.loaiphong = loaiphong;
            this.phongtrong = phongtrong;
            this.giaphong = giaphong;
        }
        public string Loaiphong
        {
            get { return loaiphong; }
        }
        public int Phongtrong
        {
            get { return phongtrong; }
        }
        public int Giaphong
        {
            get { return giaphong; }
        }
        public void Phongtrongset(int a)
        {
            phongtrong = a;
        }
    }
}
