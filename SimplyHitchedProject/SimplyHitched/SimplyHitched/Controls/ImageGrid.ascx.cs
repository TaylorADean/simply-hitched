using System;
using System.Collections.Generic;
using System.IO;
using System.Web.UI.WebControls;

namespace SimplyHitched.Controls
{
    public partial class ImageGrid : System.Web.UI.UserControl
    {
        private string virtualPath;
        private string physicalPath;

        /// <summary>
        /// Relative path to the Images Folder
        /// </summary>
        public string ImageFolderPath { get; set; }

        /// <summary>
        /// Title to be displayed on top of Images
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Page load operations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            //Update the path
            UpdatePath();
        }

        /// <summary>
        /// Pre render operations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_PreRender(object sender, EventArgs e)
        {
            //Binds the Data Before Rendering
            BindData();
        }


        /// <summary>
        /// Updates the path variables
        /// </summary>
        private void UpdatePath()
        {
            //use a default path
            virtualPath = "~/Images";
            physicalPath = Server.MapPath(virtualPath);

            //If ImageFolderPath is specified then use that path
            if (!string.IsNullOrEmpty(ImageFolderPath))
            {
                physicalPath = Server.MapPath(ImageFolderPath);
                virtualPath = ImageFolderPath;
            }

        }

        /// <summary>
        /// Binds the ImageListView to current DataSource
        /// </summary>
        private void BindData()
        {
            ImageListView.DataSource = GetListOfImages();
            ImageListView.DataBind();

        }

        /// <summary>
        /// Gets list of images
        /// </summary>
        /// <returns></returns>
        private List<string> GetListOfImages()
        {
            var images = new List<string>();

            try
            {
                var imagesFolder = new DirectoryInfo(physicalPath);
                foreach (var item in imagesFolder.EnumerateFiles())
                {
                    if (item is FileInfo)
                    {
                        //add virtual path of the image to the images list
                        images.Add(string.Format("{0}/{1}", virtualPath, item.Name));
                    }
                }
            }
            catch (Exception ex)
            {
                //log exception
                //Logger.Log(ex.Message);
            }

            return images;
        }

        /// <summary>
        /// Sets Title
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void titleLabel_Load(object sender, EventArgs e)
        {
            var titleLabel = sender as Label;
            if (titleLabel == null) return;

            titleLabel.Text = Title;
        }

        /// <summary>
        /// Redirects to the full image when the image is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void itemImageButton_Command(object sender, CommandEventArgs e)
        {
            var currentPath = physicalPath;
            var index = (int)physicalPath[ImageFolderPath.Length - 1];
            physicalPath = physicalPath.Replace(index.ToString(), index.ToString() + 1);
            UpdatePath();
            BindData();
            //Response.Redirect(e.CommandArgument as string);
        }
    }
}