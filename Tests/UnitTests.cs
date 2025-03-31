namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}

	[TestMethod]
	public void TestPower_Mousa()
	{
		Assert.AreEqual(8.0, Program.Power("2", "3"));
		Assert.AreEqual(1.0, Program.Power("5", "0"));
		Assert.AreEqual(0.0, Program.Power("0", "5"));
	}
	[TestMethod]
	public void TestSubtract_Mousa()
        {
            // Assuming you have implemented a Subtract method:
            // 3 - 2 should equal 1
            double expected = 1.0;
            double actual = Program.Subtract("3", "2");
            Assert.AreEqual(expected, actual);

            // 5 - 5 should equal 0
            expected = 0.0;
            actual = Program.Subtract("5", "5");
            Assert.AreEqual(expected, actual);

            // 3 - 5 should equal -2
            expected = -2.0;
            actual = Program.Subtract("3", "5");
            Assert.AreEqual(expected, actual);
        }
		[TestMethod]
        public void TestDivide_Mousa()
        {
            // 6 / 3 should equal 2
            double expected = 2.0;
            double actual = Program.Divide("6", "3");
            Assert.AreEqual(expected, actual);

            // 10 / 2 should equal 5
            expected = 5.0;
            actual = Program.Divide("10", "2");
            Assert.AreEqual(expected, actual);
        }
	public void TestMultiply_Mousa()
        {
            // 2 * 3 should equal 6
            double expected = 6.0;
            double actual = Program.Multiply("2", "3");
            Assert.AreEqual(expected, actual);

            // 0 * 5 should equal 0
            expected = 0.0;
            actual = Program.Multiply("0", "5");
            Assert.AreEqual(expected, actual);
        }


}
