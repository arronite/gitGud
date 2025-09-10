public class Response<T>
{
    public string Name { get; set; }
    public string FamilyName { get; set; }
    public T Message { get; set; }
}
