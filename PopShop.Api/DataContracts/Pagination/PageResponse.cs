namespace PopShop.Api.DataContract;

public class PageResult<T> where T : class	 
{
	public int CurrentPage { get; set; }
	public int MaxPage { get; set; }
	public bool HasNextPage { get; set; }
	public IEnumerable<T> Result { get; set; } = Enumerable.Empty<T>();
}
