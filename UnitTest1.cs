using CTP_laba2_zad3;
using NUnit.Framework;

namespace Angles
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1() // �������� �� ������ �������������
        {
            //����������
            Angle angle = new Angle();

            //��������
            angle.Init(44, 55, 17);

            //��������
            Assert.AreEqual(44, angle.degrees);
            Assert.AreEqual(55, angle.minutes);
            Assert.AreEqual(17, angle.seconds);
        }

        [Test]
        public void Test2() // �������� ������� ����������� �� �����
        {
            //����������
            Angle angle = new Angle();
            angle.Init(44, 55, 55);
            //��������
            angle.RoundToDegrees();
            //��������
            Assert.AreEqual(44, angle.degrees);
            Assert.AreEqual(56, angle.minutes);
            Assert.AreEqual(0, angle.seconds);
        }

        [Test]
        public void Test3() // �������� ������� �������� �����
        {
            //����������
            Angle a1 = new Angle();
            Angle a2 = new Angle();
            a1.Init(44, 55, 17);
            a2.Init(44, 55, 17);
            //��������
            Angle result = Angle.Add(a1, a2);
            //��������
            Assert.AreEqual(89, result.degrees);
            Assert.AreEqual(50, result.minutes);
            Assert.AreEqual(34, result.seconds);
        }
        [Test]
        public void Test4() // �������� �������� ������������� �����
        {
            // ����������
            Angle a1 = new Angle();
            Angle a2 = new Angle();
            a1.Init(-55, 5, 20);
            a2.Init(-80, 20, 48);

            // ��������
            Angle result = Angle.Add(a1, a2);

            // ��������
            Assert.AreEqual(-134, result.degrees);
            Assert.AreEqual(-33, result.minutes);
            Assert.AreEqual(-52, result.seconds);
        }


        [Test]
        public void Test5() // �������� ������� ������ ����
        {
            // ����������
            Angle angle = new Angle();
            angle.Init(55, 5, 20);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // ��������
                angle.Display();

                // ��������
                string expectedOutput = $"����: 55� 5' 20\"{Environment.NewLine}";
                Assert.AreEqual(expectedOutput, sw.ToString());
            }
        }


        [Test]
        public void Test6() // �������� �������� ����� � ������� ��������
        {
            // ����������
            Angle a1 = new Angle();
            Angle a2 = new Angle();
            a1.Init(0, 30, 45);
            a2.Init(0, 45, 30);

            // ��������
            Angle result = Angle.Add(a1, a2);

            // ��������
            Assert.AreEqual(1, result.degrees);
            Assert.AreEqual(16, result.minutes);
            Assert.AreEqual(15, result.seconds);
        }
        [Test]
        public void Test7() // �������� �������� �����, ��� ������ ��� �������� ��������� 60
        {
            // ����������
            Angle a1 = new Angle();
            Angle a2 = new Angle();
            a1.Init(20, 55, 30);
            a2.Init(0, 10, 45);

            // ��������
            Angle result = Angle.Add(a1, a2);

            // ��������
            Assert.AreEqual(21, result.degrees);
            Assert.AreEqual(6, result.minutes);
            Assert.AreEqual(15, result.seconds);
        }
        [Test]
        public void Test8() // �������� ������������ ���������� ����, ���� ���������� ������ ������ ��� ����� 30
        {
            // ����������
            Angle angle = new Angle();
            angle.Init(45, 59, 45);

            // ��������
            angle.RoundToDegrees();

            // ��������
            Assert.AreEqual(46, angle.degrees);
            Assert.AreEqual(0, angle.minutes);
            Assert.AreEqual(0, angle.seconds);
        }
        [Test]
        public void Test9() // �������� �������� ����� � �������������� ��������� � ��������
        {
            // ����������
            Angle a1 = new Angle();
            Angle a2 = new Angle();
            a1.Init(-15, -45, 30);
            a2.Init(-5, -30, 50);

            // ��������
            Angle result = Angle.Add(a1, a2);

            // ��������
            Assert.AreEqual(-21, result.degrees);
            Assert.AreEqual(-13, result.minutes); 
            Assert.AreEqual(-40, result.seconds);
        }

        [Test]
        public void Test10() // �������� �������� ��� ������� ��������� ����
        {
            // ����������
            Angle a1 = new Angle();
            Angle a2 = new Angle();
            a1.Init(100, 55, 55);
            a2.Init(50, 25, 30);

            // ��������
            Angle result = Angle.Add(a1, a2);

            // ��������
            Assert.AreEqual(151, result.degrees);
            Assert.AreEqual(21, result.minutes);
            Assert.AreEqual(25, result.seconds);
        }
    }
}


