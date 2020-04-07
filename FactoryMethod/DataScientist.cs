namespace FactoryMethod
{
    public class DataScientist : IDeveloper
    {
        public IProgram CreateProgram()
        {
            return new LearningModel();
        }
    }
}