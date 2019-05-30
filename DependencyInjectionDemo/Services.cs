namespace DependencyInjectionDemo
{
	public interface ICustomService
	{
		string GetMessage();
	}

	public class CustomServiceA : ICustomService
	{
		public string GetMessage()
		{
			return "Message from " + GetType().FullName;
		}
	}

	public class CustomServiceB : ICustomService
	{
		public string GetMessage()
		{
			return "Message from " + GetType().FullName;
		}
	}
}