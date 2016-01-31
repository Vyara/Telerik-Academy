namespace Todos
{
    using System;
    using System.Linq;
    using System.Web.UI.WebControls;
    using Todos.Data;
    using Todos.Data.Models;

    public partial class Default : System.Web.UI.Page
    {
        private TodosDbContext db;

        public IQueryable<Category> CategoriesListView_GetData()
        {
            return this.db.Categories;
        }

        public void CategoriesListView_UpdateItem(int? id)
        {
            var category = this.db.Categories.Find(id);
            if (category == null)
            {
                ModelState.AddModelError(string.Empty, string.Format("An instructor with ID {0} could not be found.", id));
                return;
            }

            this.TryUpdateModel(category);
            if (ModelState.IsValid)
            {
                this.db.SaveChanges();
            }
        }

        public void CategoriesListView_DeleteItem(int? id)
        {
            var category = this.db.Categories.Find(id);
            if (category == null)
            {
                return;
            }

            var todosAsList = category.Todos.ToList();

            foreach (var todo in todosAsList)
            {
                this.db.Todos.Remove(todo);
            }

            this.db.SaveChanges();
            this.db.Categories.Remove(category);
            this.db.SaveChanges();
        }

        public IQueryable<Todo> TodosListView_GetData()
        {
            return this.db.Todos;
        }

        public void TodosListView_UpdateItem(int? id)
        {
            var todo = this.db.Todos.Find(id);
            if (todo == null)
            {
                ModelState.AddModelError(string.Empty, string.Format("An instructor with ID {0} could not be found.", id));
                return;
            }

            this.TryUpdateModel(todo);
            if (ModelState.IsValid)
            {
                todo.Changed = DateTime.Now;
                this.db.SaveChanges();
            }
        }

        public void TodosListView_DeleteItem(int? id)
        {
            var todo = this.db.Todos.Find(id);
            if (todo == null)
            {
                return;
            }

            this.db.Todos.Remove(todo);
            this.db.SaveChanges();
        }

        protected void InsertTodoButton_Click(object sender, EventArgs e)
        {
            this.db.Todos.Add(new Todo()
            {
                Title = string.IsNullOrEmpty(this.InsertTodoNameTextBox.Text) ? "Unnamed" : this.InsertTodoNameTextBox.Text,
                Body = string.IsNullOrEmpty(this.InsertTodoBodyTextBox.Text) ? "Unnamed" : this.InsertTodoBodyTextBox.Text,
                CategoryId = this.InsertTodoCategory.SelectedValue == string.Empty ? 1 : int.Parse(this.InsertTodoCategory.SelectedValue),
                Changed = DateTime.Now
            });

            this.db.SaveChanges();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.db = new TodosDbContext();
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.DataBind();
        }

        protected void InsertCategoryButton_Click(object sender, EventArgs e)
        {
            this.db.Categories.Add(new Category()
            {
                Name = string.IsNullOrEmpty(this.InsertCategoryNameTextBox.Text) ? "Unnamed" : this.InsertCategoryNameTextBox.Text
            });

            this.db.SaveChanges();
        }
    }
}