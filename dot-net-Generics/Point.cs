using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_Generics
{
    public class Point<T,V>
    {
        public T X { set; get; }
        public V Y { set; get; }
    }
    //public class SetNo<R,W,K>
    //{
    //    public R X { set; get; }
    //    public W Y { set; get; }
    //    public K z { set; get; }
    //}
    public class SuperClass<A,B>:Point<A,B>
    {
        
    }
    public class SuperSubClass<A,B,C>:Point<A,B>
    {
        public C Z { set; get; }
    }
    public class Person:Iuser
    {
        public string Name { set; get; }
        public string UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Person(string name) 
        { 
            Name = name;
        }
    }
}
