
namespace Models
{
    class Category{
        String id{
            get; 
            set;
        }
        String name{
            get{
                
                return value;
            } 
            set{ 

                name = value;
            }
        }
        bool isFavorite = false;
    }
}