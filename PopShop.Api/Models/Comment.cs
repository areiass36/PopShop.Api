namespace PopShop.Api.Models;

public class Comment
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid UserId { get; set; }
    public Guid ParentId { get; set; }
    public string Text { get; set; } = string.Empty;
    public DateTime CreationDate { get; set; }
    public IEnumerable<CommentLike> Likes { get; set; } = Enumerable.Empty<CommentLike>();
}

public class CommentLike
{
    public Guid CommentId { get; set; }
    public Guid UserId { get; set; }
}