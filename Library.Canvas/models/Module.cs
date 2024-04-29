namespace Library.Canvas.Models {


    public class Module {

        public string? Name{get; set;}

        public string? Description{get; set;}

        public int ModuleId {get; set;}


        public List<ContentItem> Content;


        public Module() {

            Content = new List<ContentItem>();

        }


         public override string ToString()
        {
           
            return $"{ModuleId} - {Name} ";

        }



    }









}