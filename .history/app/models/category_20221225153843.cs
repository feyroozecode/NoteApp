
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

                if(value == null)
                    name = value;
                    
            }
        }
        bool isFavorite = false;
    }
}