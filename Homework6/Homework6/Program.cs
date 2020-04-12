using System;

namespace Homework6Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //        // Task 1

            //        // Create a class "PhotoAlbum" with a private attribute "numberOfPages".
            //        // It should also have a public method "GetNumberOfPages", which will return the number of pages. 
            //        // The default constructor will create an album with 16 pages.
            //        // There will be an additional constructor, with which we can specify the number of pages we want in the album.
            //        // Create a class "BigPhotoAlbum" whose constructor will create an album with 64 pages.
            //        // In main method create a "PhotoAlbum" instance with its default constructor and one with 24 pages. 
            //        // Also create "BigPhotoAlbum" and show the number of pages that the three albums have.

            PhotoAlbum myAlbum1 = new PhotoAlbum();
            Console.WriteLine(myAlbum1.GetNumberOfPages());

            PhotoAlbum myAlbum2 = new PhotoAlbum(24);
            Console.WriteLine(myAlbum2.GetNumberOfPages());

            BigPhotoAlbum myBigPhotoAlbum1 = new BigPhotoAlbum();
            Console.WriteLine(myBigPhotoAlbum1.GetNumberOfPages());

            Console.ReadLine();
        }
    }
    class PhotoAlbum
    {
        protected int numberOfPages;

        public PhotoAlbum()
        {
            numberOfPages = 16;
        }

        public PhotoAlbum(int numberOfPages)
        {
            this.numberOfPages = numberOfPages;
        }

        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }

    class BigPhotoAlbum : PhotoAlbum
    {
        public BigPhotoAlbum()
        {
            numberOfPages = 64;
        }
    }
}


