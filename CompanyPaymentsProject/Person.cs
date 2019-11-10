using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyPaymentsProject
{
    class Person
    {
        private int _personID;
        private string _name;
        private string _surname;
        private int _payments;
        Post post = new Post();
        
        public int PersonID
        {
            get
            {
                return _personID;
            }
            set
            {
                _personID = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        public int Payments
        {
            get
            {
                return _payments;
            }
            set
            {
                _payments = value;
            }
        }
        //public string Post
        //{
        //    get
        //    {
        //        return post;
        //    }
        //    set
        //    {
        //        post = value;
        //    }
        //}
    }
}
