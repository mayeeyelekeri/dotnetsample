using static Newtonsoft.Json.JsonConvert;

namespace library;
public class Class1
{
	public class Thing 
	{
		public int Get(int left, int right) =>
			DeserializeObject<int>($"{left + right}"); 
	}
}
