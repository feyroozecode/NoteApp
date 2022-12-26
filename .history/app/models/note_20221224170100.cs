
using Models.Category;

namespace Models.Notes{
    class Notes{
        String id{
            get; 
            set;
        }
        String content{
            get; 
            set;
        }
        Categor category{
            get; 
            set;
        } 
        DateTime timestamp{
            get; 
            set;
        }
    }
}