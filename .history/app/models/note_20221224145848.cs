
namespace Models{
    class Notes{
        String id{get; set;}
        String content{get; set;};
        Category category; 
        DateTime timestamp;
    }
}