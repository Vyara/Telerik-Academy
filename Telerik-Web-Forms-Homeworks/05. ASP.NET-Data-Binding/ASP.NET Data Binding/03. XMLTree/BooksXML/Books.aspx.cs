namespace BooksXML
{
    using System;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class Books : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TreeView newTree = new TreeView();
            newTree.ID = "BookTreeView";
            newTree.DataSourceID = "BooksXmlDataSource";

            TreeNodeBinding rootBinding = new TreeNodeBinding();
            rootBinding.DataMember = "catalog";
            rootBinding.Depth = 1;
            rootBinding.TextField = "#innerText";

            TreeNodeBinding authorBinding = new TreeNodeBinding();
            authorBinding.DataMember = "author";
            authorBinding.Depth = 2;
            authorBinding.TextField = "#innerText";
            authorBinding.FormatString = "author: {0}";

            TreeNodeBinding titleBinding = new TreeNodeBinding();
            titleBinding.DataMember = "title";
            titleBinding.Depth = 2;
            titleBinding.TextField = "#innerText";
            titleBinding.FormatString = "title: {0}";

            TreeNodeBinding genreBinding = new TreeNodeBinding();
            genreBinding.DataMember = "genre";
            genreBinding.Depth = 2;
            genreBinding.TextField = "#innerText";
            genreBinding.FormatString = "genre: {0}";

            TreeNodeBinding priceBinding = new TreeNodeBinding();
            priceBinding.DataMember = "price";
            priceBinding.Depth = 2;
            priceBinding.TextField = "#innerText";
            priceBinding.FormatString = "price: {0} USD";

            TreeNodeBinding publishDateBinding = new TreeNodeBinding();
            publishDateBinding.DataMember = "publish_date";
            publishDateBinding.Depth = 2;
            publishDateBinding.TextField = "#innerText";
            publishDateBinding.FormatString = "publish date: {0}";

            TreeNodeBinding descriptionBinding = new TreeNodeBinding();
            descriptionBinding.DataMember = "description";
            descriptionBinding.Depth = 2;
            descriptionBinding.TextField = "#innerText";
            descriptionBinding.FormatString = "description: {0}";

            newTree.DataBindings.Add(rootBinding);
            newTree.DataBindings.Add(authorBinding);
            newTree.DataBindings.Add(titleBinding);
            newTree.DataBindings.Add(genreBinding);
            newTree.DataBindings.Add(priceBinding);
            newTree.DataBindings.Add(publishDateBinding);
            newTree.DataBindings.Add(descriptionBinding);

            ControlPlaceHolder.Controls.Add(newTree);
        }
    }
}