
namespace IndexerException.Library
{
    public class Calculate
    {
        public void Calc()
        {
			try
			{
                Console.WriteLine(10/int.Parse("0"));
            }
			catch (Exception ex)
			{

                throw;
            }
        }
    }
}
