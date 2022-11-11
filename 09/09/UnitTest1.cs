using System.ComponentModel;
using System.Data;

namespace _09
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Circle c = new Circle(new Point(3, 3), 3);
            Point p = new Point(5, 3);
            Assert.True(c.Intersect(p));
        }
        [Fact]
        public void Test2()
        {
            Circle c = new Circle(new Point(3, 3), 3);
            Point p = new Point(7, 3);
            Assert.False(c.Intersect(p));
        }
        [Fact]
        public void Test3()
        {
            Circle c = new Circle(new Point(3, 3), 3);
            Point p = new Point(6, 3);
            Assert.True(c.Intersect(p));
        }
        [Fact]
        public void Test4()
        {
            Circle c1 = new Circle(new Point(3, 3), 3);
            Circle c2 = new Circle(new Point(8, 3), 5);
            Assert.True(c1.Intersect(c2));
        }
        [Fact]
        public void Test5()
        {
            Circle c1 = new Circle(new Point(3, 3), 3);
            Assert.False(c1.Intersect(c1));
        }
        [Fact]
        public void Test6()
        {
            Circle c1 = new Circle(new Point(3, 3), 9);
            Circle c2 = new Circle(new Point(6, 3), 2);
            Assert.False(c1.Intersect(c2));
        }
    }
    public class UnitTest2
    {
        [Fact]
        public void Test1()
        {
            BadList BL = new();
            BL.Add(2);
            Assert.Equal(1, BL.Length);
        }
        
    }
    public class UnitTest3
    {
        [Fact]
        public void Test1()
        {
            Vector v1 = new Vector(1, 1);
            Vector v2 = new Vector(2, 2);
            Assert.Equal(3, v1.Add(v2).x);
        }
        [Fact]
        public void Test2()
        {
            Vector v1 = new Vector(1, 2);
            Vector v2 = new Vector(2, 2);
            Assert.Equal(4, v1.Add(v2).y);
        }
        [Fact]
        public void Test3()
        {
            Vector v1 = new Vector(1, 1);
            Vector v2 = new Vector(2, 2);
            Assert.Equal(-1, v1.Sub(v2).x);
        }
        [Fact]
        public void Test4()
        {
            Vector v1 = new Vector(1, 3);
            Vector v2 = new Vector(2, 2);
            Assert.Equal(1, v1.Sub(v2).y);
        }
    }
    public class UnitTest4
    {
        [Fact]
        public void Test1()
        {
            Vector v1 = new Vector(1, 1);
            Vector v2 = new Vector(2, 2);
            var actual = v1.Add(v2).x;
            Assert.Equal(3, actual);
        }
        
    }
}

class StringGood
{
    char[] chars;
    public int Length { get { return chars.Length; } }
    public StringGood(char[] chars)
    {
        this.chars = chars;
    }
    public char CharAt (int i)
    {
        return i < Length ? chars[i] : throw(new IndexOutOfRangeException());
    }


}