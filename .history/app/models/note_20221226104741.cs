
using Models;

namespace Models{
    class Notes{

        public static Notes(String s){
            
        }
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