

using Domain.Models.Post;


namespace Infrastructure.Services;

public class PostServices
{
    List<Post> post = new List<Post>();
    public List<Post> GetPost()
    {
        return post;
    }
    public void AddPost(Post Post)
    {
        post.Add(Post);
    } 
    public void UpdatePost(Post Post)
    {
        foreach (var item in post)
        {
            if(item.Id == Post.Id)
            {
                item.Id = Post.Id;
                item.Title = Post.Title;
                item.Description = Post.Description;
                item.VoteAmount = Post.VoteAmount;
                item.CreatedAt = Post.CreatedAt;
                
            }
        }
            
    }
    public void DeletePost(int id)
    {
        foreach (var item in post)
        {
            if(item.Id == id)
            post.Remove(item);
            
        }
      
    }
}