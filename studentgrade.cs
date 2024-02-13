namespace StudentGrades.nunitTests
{
    public class GradeCalculatorTests
    {
        private Gradecalculator _gradecalculator { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _gradecalculator = new Gradecalculator();
        }
         
        [TestCase(91)]
        [TestCase(95)]
        [TestCase(97)]
        [TestCase(98)]


        public void GetGradeByPercentage_EqualTest(int percentage)
        {
            //Assign
            //var percentage = 99;

            //Act
            var grade = _gradecalculator.GetGradeByPercentage(percentage);

            //Assert
            Assert.That(grade, Is.EqualTo("A"));


        }
    }
}

            
        
    
    

    