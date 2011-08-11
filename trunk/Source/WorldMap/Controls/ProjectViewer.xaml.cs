using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System;
using NCRVisual.web.DataModel;
using System.Windows.Data;

namespace WorldMap
{
    public partial class ProjectViewer : UserControl
    {
        public event EventHandler PostCommentBegin;
        public EventHandler SaveFavoriteProject_Click;
        public ProjectViewer()
        {
            InitializeComponent();            
        }        

        public void PopulateProjectData(tbl_projects project)
        {
            //Populate Overview part
            LoadProjectOverview(project);
            LoadImages(project.related_image);
            LoadVideo(project.related_video);            
        }

        /// <summary>
        /// Action after login in
        /// </summary>
        public void InitializeAfterLogin()
        {
            this.postComment.Visibility = System.Windows.Visibility.Visible;
            this.SaveProject.Visibility = System.Windows.Visibility.Visible;
        }

        /// <summary>
        /// Action after login out
        /// </summary>
        public void InitializeAfterLogout()
        {
            this.postComment.Visibility = System.Windows.Visibility.Collapsed;
            this.SaveProject.Visibility = System.Windows.Visibility.Collapsed;
        }

        public void PopulateComments(List<tbl_comments> comments)
        {
            //Populate Comments
            //CommentControl.ItemsSource = comments;

            PagedCollectionView pcv = new PagedCollectionView(comments);
            pcv.PageSize = 6;
            DataContext = pcv; 
        }

        private void LoadProjectOverview(tbl_projects project)
        {
            this.IdTxtBlck.Text = project.project_wb_id;
            this.NameTxtBlck.Text = project.project_name;
            this.LinkButton.NavigateUri = new Uri(project.project_link);
            this.StatusTxtBlck.Text = project.project_status;
            this.CostTxtBlck.Text = project.project_cost;
            this.ADateTxtBlck.Text = project.project_approval_date;
            this.CDateTxtBlck.Text = project.project_close_date;
            this.RegionTxtBlck.Text = project.project_region;
            this.BorrowerTxtBlck.Text = project.project_borrower;
            this.ImplementAgencyTxtBlck.Text = project.project_implement_agency;
            this.MajorSectorTxtBlck.Text = project.project_major_sector.Replace("\t", "").Replace("\n", " ").Replace("/n", "\n");
            this.ProjectThemesTxtBlck.Text = project.project_themes.Replace("\t", "").Replace("\n", " ").Replace("/n", "\n");
            this.OutComeTxtBlck.Text = project.project_outcome.Replace("\t", "").Replace("\n", " ").Replace("/n", "\n");            
        }

        private void LoadImages(string projectLinks)
        {
            if (projectLinks != null)
            {
                this.ErrorBorder.Visibility = System.Windows.Visibility.Collapsed;
                List<Picture> coll = new List<Picture>();
                string[] links = projectLinks.Split('|');
                foreach (string link in links)
                {
                    coll.Add(AddPicture(link));
                }
                lbImage.ItemsSource = coll;
            }
            else
            {
                this.ErrorBorder.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void LoadVideo(string videoLinks)
        {
            if (videoLinks != null)
            {
                this.ErrorVideoBorder.Visibility = System.Windows.Visibility.Collapsed;
                List<string> links = new List<string>(videoLinks.Split('|'));
                VideosListbox.ItemsSource = links;
            }
            else
            {
                this.htmlHost.SourceHtml = "";
                this.ErrorVideoBorder.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private Picture AddPicture(string path)
        {
            return new Picture
            {
                Href = new BitmapImage(
                new Uri(
                    path,
                    UriKind.Absolute))
            };
        }

        private void lbImage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbImage.SelectedItem != null)
            {
                Preview.Source = ((Picture)lbImage.SelectedItem).Href;
            }
        }

        private void Image_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.Visibility = System.Windows.Visibility.Collapsed;
            htmlHost.SourceHtml = "";
        }

        private void PostComment_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (PostCommentBegin != null)
            {
                PostCommentBegin(sender, null);
            }
        }

        public void SaveProject_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            SaveFavoriteProject_Click(sender, e);
        }

        private void VideosListbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (VideosListbox.SelectedItem != null)
            {
                htmlHost.Visibility = System.Windows.Visibility.Visible;
                string html = "<iframe title=\"YouTube video player\" width=\"320\" height=\"195\" src=\"" + VideosListbox.SelectedItem.ToString().Replace("watch?v=", "embed/") + "\" frameborder=\"0\" allowfullscreen></iframe>";
                this.htmlHost.SourceHtml = html;
            }
        }
    }

    public class Picture
    {
        public ImageSource Href { get; set; }
    }
}
