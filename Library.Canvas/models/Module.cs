namespace Library.Canvas.Models {


    public class Module {

        public string? Name{get; set;}

        public string? Description{get; set;}


        public List<ContentItem> Content;


        public Module() {

            Content = new List<ContentItem>();

        }


    }









}