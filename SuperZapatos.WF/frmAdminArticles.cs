using SuperZapatos.Domain.Models;
using SuperZapatos.WF.ConsumoApi;
using SuperZapatos.WF.Models;

namespace SuperZapatos.WF
{
    public partial class frmAdminArticles : Form
    {
        HttpClientArticles client = new HttpClientArticles();
        public int? id;
        public frmAdminArticles(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
                getArticle();
        }

        private async void getArticle()
        {
            BaseResponse<Articles> result = await client.GetArticlesByIdAsync("Articles", this.id!.Value);
            txtName.Text = result.Data!.Name;
            txtDescripcion.Text = result.Data.Description;
            txtPrecio.Text = result.Data.Price.ToString();
            txtTotalEstante.Text = result.Data.Total_in_shelf.ToString();
            txtTotalBodega.Text = result.Data.Total_in_vault.ToString();
            cmbTienda.SelectedValue = result.Data.Store_id;
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            Articles entity = getEntity();
            if (id != null)
            {
                await client.EditArticleAsync("Articles", this.id.Value, entity);
            }
            else
            {
                await client.CreateArticleAsync("Articles", entity);
            }
            this.Close();
        }
        private Articles getEntity()
        {
            Articles entity = new Articles();
            entity.Name = txtName.Text;
            entity.Description = txtDescripcion.Text;
            entity.Price = float.Parse(txtPrecio.Text);
            entity.Total_in_shelf = int.Parse(txtTotalEstante.Text);
            entity.Total_in_vault = int.Parse(txtTotalBodega.Text);
            entity.Store_id = int.Parse(cmbTienda.SelectedValue.ToString()!);
            return entity;
        }
    }
}
