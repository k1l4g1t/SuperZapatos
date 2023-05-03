using SuperZapatos.Domain.Models;
using SuperZapatos.WF.ConsumoApi;
using SuperZapatos.WF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperZapatos.WF
{
    public partial class frmAdminStore : Form
    {
        HttpClientStores client = new HttpClientStores();
        public int? id;
        public frmAdminStore(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
                getArticle();
        }

        private async void getArticle()
        {
            
            BaseResponse<Store> result = await client.GetStoresByIdAsync("Stores", this.id!.Value);
            txtName.Text = result.Data!.Name;
            txtAddress.Text = result.Data.Address;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            Store entity = getEntity();
            if (id != null)
            {
                await client.EditStoreAsync("Stores", this.id.Value, entity);
            }
            else
            {
                await client.CreateStoreAsync("Stores", entity);
            }
            this.Close();
        }

        private Store getEntity()
        {
            Store entity = new Store();
            entity.Name = txtName.Text;
            entity.Address = txtAddress.Text;
            return entity;
        }
    }
}
