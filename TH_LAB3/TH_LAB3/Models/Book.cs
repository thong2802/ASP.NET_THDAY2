using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace TH_LAB3.Models
{
    public class Book
    {
        private int id; 
        private string title;
        private string description;
        private string author;
        private string image_cover;

        public Book()
        {

        }
        
        public Book(int id, string title, string description, string author, string image_cover)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.author = author;
            this.image_cover = image_cover;
        }

        [Required(ErrorMessage = "id not empty")]
        public int Id
        {
            get { return id; }
            set { id = value; } 
        }
        [Required(ErrorMessage = "Title not empty")]
        [StringLength(250, ErrorMessage = "Tittle book not length 250 char!!!")]
        [Display(Name = "Title")]
        public string Title {
            get {
                return title;
            }
            set { title = value; }
        }   
        public string Description {
            get { return description; }
            set { description = value; }
        }
        public string Author { get { return author; }
            set { author = value; }
        }

        public string Image_Cover { get { return image_cover; }
            set { image_cover = value; }
        }

    }
}