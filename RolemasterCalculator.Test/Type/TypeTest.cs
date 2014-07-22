using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RolemasterCalculator.Models.BaseTypes;

namespace RolemasterCalculator.Test.Type
{
    [TestFixture]
    public class TypeTest
    {
        TypeDetail _type;
        List<TypeDetail> _typeList;

        [SetUp]
        public void TestFixtureSetUp()
        {
            _type = new TypeDetail(1, "Missle", 1, 150);

            _typeList = new List<TypeDetail>();
            _typeList.Add(new TypeDetail(1, "Missle", 1, 150));
            _typeList.Add(new TypeDetail(2, "Sword", 1, 100));
        }

        [Test]
        public void Type_ID_Is_1()
        {
            Assert.AreEqual(1, _type.ID);
        }

        [Test]
        public void Type_Is_Missle()
        {
            Assert.AreSame("Missle", _type.Type);
        }

        [Test]
        public void Type_RollMin_Is_1()
        {
            Assert.AreEqual(1, _type.RollMin);
        }

        [Test]
        public void Type_RollMax_Is_150()
        {
            Assert.AreEqual(150, _type.RollMax);
        }

        [Test]
        public void Type_Collection_Has_2_Items()
        {
            Assert.AreEqual(2, _typeList.Count);
        }

        [Test]
        public void Type_Collection_Item_2_ID_Is_2()
        {
            Assert.AreEqual(2, _typeList[1].ID);
        }

        [Test]
        public void Type_Collection_Item_2_Type_Is_Sword()
        {
            Assert.AreSame("Sword", _typeList[1].Type);
        }
    }
}
