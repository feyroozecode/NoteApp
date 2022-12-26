
using Models;

namespace Models{
    class Notes{

        public static 
        String id{
            get; 
            set;
        }
        String content{
            get; 
            set;
        }
        Category category{
            get; 
            set;
        } 
        DateTime timestamp{
            get; 
            set;
        }
    }
}