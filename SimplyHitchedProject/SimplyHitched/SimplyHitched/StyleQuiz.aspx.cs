using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimplyHitched
{
    public partial class _StyleQuiz : System.Web.UI.Page
    {
        private const int NumQuestions = 3;

        private static int questionNumber = 0;

        private static int QuestionNumber
        {
            get
            {
                return questionNumber;
            }
            set
            {
                questionNumber = value < NumQuestions ? value : 0;
            }
        }

        public void UpdateImages()
        {
            var imagePath = Path.GetDirectoryName(ImageButton1.ImageUrl);

            var originalQuestionNumber = QuestionNumber;

            QuestionNumber++;

            var newQuestionNumber = QuestionNumber;

            imagePath = imagePath.Replace("Q" + (QuestionNumber - 1).ToString(), "Q" + (QuestionNumber).ToString());

            ImageButton1.ImageUrl = Path.Combine(imagePath, Path.GetFileName(ImageButton1.ImageUrl));
            ImageButton2.ImageUrl = Path.Combine(imagePath, Path.GetFileName(ImageButton2.ImageUrl));
            ImageButton3.ImageUrl = Path.Combine(imagePath, Path.GetFileName(ImageButton3.ImageUrl));

            Label1.Text = "Original: " + originalQuestionNumber.ToString() + '\n'
                + "New: " + newQuestionNumber.ToString() + '\n'
                + "Url: " + ImageButton1.ImageUrl;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //questionNumber = 0;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            UpdateImages();
        }
    }
}