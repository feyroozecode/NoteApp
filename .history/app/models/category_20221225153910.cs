
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

                if(value == null )
                    return value;

            }
        }
        bool isFavorite = false;
    }
}