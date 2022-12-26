
namespace Models
{
    class Category{
        String id{
            get; 
            set;
        }
        String name{
            get{
                return name;
            } 
            set{ 

                name = value;
            }
        }
        bool isFavorite = false;
    }
}