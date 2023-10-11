using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint2.Task6.V14.Lib;

namespace Tyuiu.SavenkovaME.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Понедельник", ds.FindDayName(1,1));
            Assert.AreEqual("Вторник", ds.FindDayName(2,1));
            Assert.AreEqual("Среда", ds.FindDayName(3,1));
            Assert.AreEqual("Четверг", ds.FindDayName(4,1));
            Assert.AreEqual("Пятница", ds.FindDayName(5,1));
            Assert.AreEqual("Суббота", ds.FindDayName(6,1));
            Assert.AreEqual("Воскресенье", ds.FindDayName(7,1));
        }
        [TestMethod]
        public void ValidFindDayName2()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Понедельник", ds.FindDayName(7, 2));
            Assert.AreEqual("Вторник", ds.FindDayName(1, 2));
            Assert.AreEqual("Среда", ds.FindDayName(2, 2));
            Assert.AreEqual("Четверг", ds.FindDayName(3, 2));
            Assert.AreEqual("Пятница", ds.FindDayName(4, 2));
            Assert.AreEqual("Суббота", ds.FindDayName(5, 2));
            Assert.AreEqual("Воскресенье", ds.FindDayName(6, 2));
        }
        [TestMethod]
        public void ValidFindDayName3()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Понедельник", ds.FindDayName(6,3));
            Assert.AreEqual("Вторник", ds.FindDayName(7,3));
            Assert.AreEqual("Среда", ds.FindDayName(1,3));
            Assert.AreEqual("Четверг", ds.FindDayName(2,3));
            Assert.AreEqual("Пятница", ds.FindDayName(3,3));
            Assert.AreEqual("Суббота", ds.FindDayName(4,3));
            Assert.AreEqual("Воскресенье", ds.FindDayName(5,3));

        }
        [TestMethod]
        public void ValidFindDayName4()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Понедельник", ds.FindDayName(5,4));
            Assert.AreEqual("Вторник", ds.FindDayName(6,4));
            Assert.AreEqual("Среда", ds.FindDayName(7,4));
            Assert.AreEqual("Четверг", ds.FindDayName(1,4));
            Assert.AreEqual("Пятница", ds.FindDayName(2,4));
            Assert.AreEqual("Суббота", ds.FindDayName(3,4));
            Assert.AreEqual("Воскресенье", ds.FindDayName(4,4));

        }
        [TestMethod]
        public void ValidFindDayName5()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Понедельник", ds.FindDayName(4,5));
            Assert.AreEqual("Вторник", ds.FindDayName(5,5));
            Assert.AreEqual("Среда", ds.FindDayName(6,5));
            Assert.AreEqual("Четверг", ds.FindDayName(7,5));
            Assert.AreEqual("Пятница", ds.FindDayName(1,5));
            Assert.AreEqual("Суббота", ds.FindDayName(2,5));
            Assert.AreEqual("Воскресенье", ds.FindDayName(3,5));

        }
        [TestMethod]
        public void ValidFindDayName6()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Понедельник", ds.FindDayName(3,6));
            Assert.AreEqual("Вторник", ds.FindDayName(4,6));
            Assert.AreEqual("Среда", ds.FindDayName(5,6));
            Assert.AreEqual("Четверг", ds.FindDayName(6,6));
            Assert.AreEqual("Пятница", ds.FindDayName(7,6));
            Assert.AreEqual("Суббота", ds.FindDayName(1,6));
            Assert.AreEqual("Воскресенье", ds.FindDayName(2,6));

        }
        [TestMethod]
        public void ValidFindDayName7()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Понедельник", ds.FindDayName(2,7));
            Assert.AreEqual("Вторник", ds.FindDayName(3,7));
            Assert.AreEqual("Среда", ds.FindDayName(4,7));
            Assert.AreEqual("Четверг", ds.FindDayName(5,7));
            Assert.AreEqual("Пятница", ds.FindDayName(6,7));
            Assert.AreEqual("Суббота", ds.FindDayName(7,7));
            Assert.AreEqual("Воскресенье", ds.FindDayName(1,7));

        }
    }
}
