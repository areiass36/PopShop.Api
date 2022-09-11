namespace PopShop.Api.DataContract;

public class PageRequest<T> where T : class	 
{
	public int CurrentPage { get; set; }
	public int Size { get; set; }
	public T? Filter { get; set; } 
}
