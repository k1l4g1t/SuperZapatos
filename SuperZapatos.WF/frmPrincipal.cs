using SuperZapatos.WF.ConsumoApi;
using System.Drawing.Text;

namespace SuperZapatos.WF
{
    public partial class frmPrincipal : Form
    {
        HttpClientArticles clientArticles;
        HttpClientStores clientStore;

        #region constructor
        public frmPrincipal()
        {
            InitializeComponent();
            clientArticles = new HttpClientArticles();
            clientStore = new HttpClientStores();
        }
        #endregion

        #region StoresMethods
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private async void refresh()
        {
            var resultArticles = await clientArticles.GetArticlesAsync("Articles");
            if (resultArticles != null && resultArticles.Data!.Count() > 0)
                this.gv_Articulos.DataSource = resultArticles.Data!.ToList();

            var resultStores = await clientStore.GetStoresAsync("Stores");
            if (resultStores != null && resultStores.Data!.Count() > 0)
                this.gv_Tiendas.DataSource = resultStores.Data!.ToList();
        }
        private async void cargaComboTiendas(frmAdminArticles _frmAdminArticles)
        {
            var result = await clientArticles.GetStoresAsync("Stores");
            if (result != null && result.Data!.Count() > 0)
            {
                _frmAdminArticles.cmbTienda.DataSource = result.Data!.ToList();
                _frmAdminArticles.cmbTienda.ValueMember = "id";
                _frmAdminArticles.cmbTienda.DisplayMember = "name";
            }
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            showFormArticles();
        }

        private void showFormArticles(int? id = null)
        {
            frmAdminArticles _frmAdminArticles = new frmAdminArticles(id);
            cargaComboTiendas(_frmAdminArticles);
            _frmAdminArticles.ShowDialog();
            refresh();
        }

        private void btnEditArticle_Click(object sender, EventArgs e)
        {
            int? id = getIdArticle();
            if (id != null)
            {
                showFormArticles(id);
            }

        }

        private int getIdArticle()
        {
            return int.Parse(gv_Articulos.Rows[gv_Articulos.CurrentRow.Index].Cells[0].Value.ToString()!);
        }

        private async void btnRemoveArticle_Click(object sender, EventArgs e)
        {
            int? id = getIdArticle();
            if (id != null)
            {
                var confirmResult = MessageBox.Show("Estas seguro de eliminar el elemento seleccionado ??",
                                     "Confirmar Eliminación!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    await clientArticles.DeleteArticleAsync("Articles", id.Value);
                    refresh();
                }
            }
        }
        #endregion

        #region StoresMethods
        private void btnAddStore_Click(object sender, EventArgs e)
        {
            showFormStores();
        }

        private void btnEditStore_Click(object sender, EventArgs e)
        {
            int? id = getIdStore();
            if (id != null)
            {
                showFormStores(id);
            }
        }

        private async void btnRemoveStore_Click(object sender, EventArgs e)
        {
            int? id = getIdStore();
            if (id != null)
            {
                var confirmResult = MessageBox.Show("Estas seguro de eliminar el elemento seleccionado ??",
                                     "Confirmar Eliminación!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    await clientStore.DeleteStoreAsync("Stores", id.Value);
                    refresh();
                }
            }
        }

        private void showFormStores(int? id = null)
        {
            frmAdminStore _frmAdminStore = new frmAdminStore(id);
            _frmAdminStore.ShowDialog();
            refresh();
        }

        private int getIdStore()
        {
            return int.Parse(gv_Tiendas.Rows[gv_Tiendas.CurrentRow.Index].Cells[0].Value.ToString()!);
        }
        #endregion
    }
}